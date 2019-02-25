using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using HL7Socket;
using MLLP;
using HL7LIB.ConcretcompositeType;
using HL7LIB;


namespace HL7Application
{
    public partial class FormApplication : Form
    {
        private TcpListener myListener;
        HL7Client hL7Client;
        Context mllpcontext;


        public FormApplication()
        {
            InitializeComponent();
            mllpcontext = new Context();
            mllpcontext.eventUpperMsgReceived += this.MsgProc;
        }

        /// <summary>
        /// 服务端开始接收连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btStart_ClickAsync(object sender, EventArgs e)
        {
            try {
                CC.port = int.Parse(txPort.Text);
                myListener = new TcpListener(CC.localIP,CC.port);
                myListener.Start();
                labelShowingListening.Text += string.Format("开始在{0}:{1}监听客户连接", CC.localIP, CC.port);
                richTextBox1.Text = string.Format("开始在{0}:{1}监听客户连接\n", CC.localIP, CC.port);


                while (true)
                {
                    try
                    {
                        TcpClient newClient = await myListener.AcceptTcpClientAsync();
                        User user = new User(newClient);
                        CC.userlist.Add(user);

                        //将user的evtReceivedFromUser事件和ShowMessageFromUser建立关联
                        user.evtReceivedFromUser += this.ShowMessageFromUser;                   
                    }
                    catch
                    {
                        break;//错误直接跳出循环,取消任务
                    }
                }
            }
            catch { MessageBox.Show("请输入正确的端口号"); }
            
            
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            myListener.Stop();
            labelShowingListening.Text = "";
            richTextBox1.Text += "\n监听已结束";
        }

        private void btnConnectionStart_Click(object sender, EventArgs e)
        {
            String remoteHost = "127.0.0.1";
            int remotePort = int.Parse(textBox2.Text);
            try
            {
                hL7Client = new HL7Client(remoteHost, remotePort);
                rtx_ReceiveMessage.Text = "连接成功";
                hL7Client.evtReceived += mllpcontext.Input;
                hL7Client.evtSendMessage += this.Update_rtx_ReceiveMessag;
            }
            catch
            {
                rtx_ReceiveMessage.Text = "连接失败";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MSH = "MSH|^~\\&|NES|NINTENDO|TESTSYSTEM|TESTFACILITY|20010101000000||ADT^A04|Q123456789T123456789X123456|P|2.3.1";
            string EVN = "EVN|A04|20010101000000|||^KOOPA^BOWSER^^^^^^^CURRENT";
            string PID = "PID|1||583070^^^ADT1|0123456789^AA^^JP|BLACK^CHARLES||19780214|M||WH|16 ARUNDEL PL^^ST. LOUIS^MO^63105|1234|(555)555-0123^HOME^JP:1234567|||S|MSH|12345678|||||||0|||||N";
            string NK11 = "NK1|1|PEACH^PRINCESS^^^^|SO|ANOTHER CASTLE^^TOADSTOOL KINGDOM^NES^^JP|(123)555-1234|(123)555-2345|NOK|||||||||||||";
            string NK12 = "NK1|2|TOADSTOOL^PRINCESS^^^^|SO|YET ANOTHER CASTLE^^TOADSTOOL KINGDOM^NES^^JP|(123)555-3456|(123)555-4567|EMC|||||||||||||";
            string PV1 = "PV1|1|E|ABCD^EFGH^|||^^||5101^NELL^FREDERICK^P^^DR||CRD||||||||AO|0123456789|1|||||||||||||||||||MSH||A|||20010101000000";
            string IN11 = "IN1|1|PAR^PARENT||||LUIGI";
            string IN12 = "IN1|2|FRI^FRIEND||||PRINCESS";
            string msg = MSH + "\x0d" + EVN + "\x0d" + PID + "\x0d" + NK11 + "\x0d" + NK12 + "\x0d" + PV1 + "\x0d" + IN11 + "\x0d" + IN12 + "\x0d";
            hL7Client.SendMessage(msg);
        }

        private void btnConnectionStop_Click(object sender, EventArgs e)
        {
            hL7Client = null;
            rtx_ReceiveMessage.Text += "connection close";
        }

        //由MLLP的接收完成事件触发的函数
        private void MsgProc(object sender,msgEventArgs args)
        {
            Action b = () => rtx_ReceiveMessage.AppendText(args.msg);
            rtx_ReceiveMessage.Invoke(b);
        }

        private void Update_rtx_ReceiveMessag(object sender, msgSend args)
        {
            rtx_ReceiveMessage.Invoke((Action)delegate ()
            {
                rtx_ReceiveMessage.AppendText(args.msg);
            });
        }
        /// <summary>
        /// 由user的接收事件触发的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ShowMessageFromUser(object sender,msgEventArgsInServer args)
        {
            richTextBox1.Invoke((Action)delegate ()
            {
                richTextBox1.AppendText(args.message);
            });
        }

//测试实例
        private void btnSample_Click(object sender, EventArgs e)
        {
            messageFactory factory = new messageFactory();
            ACK msg = factory.Create(null, enumMessage.ACK, "ACK") as ACK;
            msg.msh.FieldSeparator.Value = "|";
            msg.msh.EncodingCharacters.Value = "^~\\&";
            msg.msh.DateOrTimeOfMessage.Value = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            msg.msh.MessageType.messagecode.Value = "ACK";
            msg.msh.MessageType.triggerevent.Value = "A01";
            msg.msh.MessageType.messagestructure.Value = "ACK_A01";
            //msg.msh.MessageType.Value = "ACK^A01^ACK_A01";
            msg.msh.MessageControlID.Value = "A00002";
            msg.msh.ProcessingID.processingID.Value = "P";
            msg.msh.VersionID.versionID.Value = "2.4";
            msg.msa.AcknowledgmentCode.Value = "AA";
            msg.msa.MessageControlID.Value = "MSG00001";
            msg.msa.TextMessage.Value = "Success";

            txMessage.Text = msg.ToString()+"\n";
            ORM orm = factory.Create(null, enumMessage.ORM, "ORM") as ORM;
            orm.msh.FieldSeparator.Value = "|";
            orm.msh.EncodingCharacters.Value = "^~\\&";
            orm.msh.DateOrTimeOfMessage.Value = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            orm.msh.MessageType.messagecode.Value = "ORM";
            orm.msh.MessageType.triggerevent.Value = "001";
            orm.msh.MessageType.messagestructure.Value = "ORM_001";
            orm.pid.PatientName.Value="Wangzifu";
            txMessage.Text += orm.ToString();
        }

        private void FormApplication_Load(object sender, EventArgs e)
        {
            messageFactory factory = new messageFactory();
            ACK msg = factory.Create(null, enumMessage.ACK, "ACK")as ACK;

            msg.Parse("MSH|^~\\&|HIS|00001|LIS|1234|2004112754000||ACK^A01^ACK_A01|0200002|P|2.4\rMSA|AE|0200001|type error|||102\r");
            txMessage.Text = msg.ToString(); 


        }
    }
}


