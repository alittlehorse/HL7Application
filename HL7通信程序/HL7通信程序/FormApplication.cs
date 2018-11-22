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
using System.IO;
using HL7Socket;
using MLLP;
using System.Net;


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
            rtx_ReceiveMessage.Text += args.msg;
        }

        private void Update_rtx_ReceiveMessag(object sender, msgSend args)
        {
            rtx_ReceiveMessage.Text += args.msg;
        }
        /// <summary>
        /// 由user的接收事件触发的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void ShowMessageFromUser(object sender,msgEventArgsInServer args)
        {
            this.richTextBox1.Text += args.message;
        }
    }
}


