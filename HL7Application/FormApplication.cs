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
            hL7Client = new HL7Client(remoteHost,remotePort);
            hL7Client.evtReceived += mllpcontext.Input;
            hL7Client.evtSendMessage += this.Update_rtx_ReceiveMessag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hL7Client.SendMessage(txMessage.Text);
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
                rtx_ReceiveMessage.AppendText(args.message);
            });
        }


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
            //txtMessage.Text = msg.ToString(); 
            txMessage.Text = msg.msa.MessageControlID.Value;
            txMessage.Text = msg.msa.TextMessage.Value;

        }
    }
}


