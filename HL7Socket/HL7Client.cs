using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows;
using System.IO;


namespace HL7Socket
{/// <summary>
/// HL7通讯程序的socket层
/// 通过事件连接MLLP
/// </summary>
    public class HL7Client
    {
        private TcpClient client { set; get; }
        private BinaryReader br { set; get; }
        private BinaryWriter bw { set; get; }
        private String remoteHost { set; get; }
        private int remotePort { set; get; }
        /// <summary>
        /// 事件,采用事件机制连接socket层和MLLP,
        /// 将mllp对象的Input方法作为接收事件的处理程序
        /// </summary>
        public event EventHandler<msgEventArgs_Bytes> evtReceived;
        public event EventHandler<msgSend> evtSendMessage;

        public HL7Client( String remoteHost, int remotePort)
        {            
            this.remoteHost = remoteHost;
            this.remotePort = remotePort;
            msgSend msg = null;
            try
            {
                //这个事件的触发在构造函数里面,所以无法触发,想想别的办法,不过不影响
                //看服务端就可以知道是否连接上
                client = new TcpClient(remoteHost, remotePort);
                string m = String.Format("Connect Success: the Client is connect with{0}:{1}", remoteHost, remotePort);
                msg = new msgSend(m);
                OnevtSendMessage(msg);
            }
            catch
            {
                msg = new msgSend("Connect failed,please input a right port");
                OnevtSendMessage(msg);
                return;
            }
            //**********************************************
            NetworkStream networkStream = client.GetStream();
            br = new BinaryReader(networkStream);
            bw = new BinaryWriter(networkStream);
            //**************************************************
            //事件的处理函数,将socket层和MLLP层连接起来


            Task.Run(() => ReceiveData());
        }
        private void ReceiveData()
        {
            while (true)
            {
                byte[] buff;
                buff = new byte[1024];
                msgEventArgs_Bytes args=null;
                try
                {
                    br.Read(buff, 0, 1024);
                    args = new msgEventArgs_Bytes(buff);                   
                    
                }
                catch
                {                   
                    break;
                }
                if (args != null)
                {
                    OnevtReceived(args);
                }
                
            }
        }
        public void SendMessage(String message)
        {
            msgSend msg = null;
            try
            {
                String str = '\x0b' + message + '\x1c' + '\x0d';
                bw.Write(str);
                bw.Flush();
                msg = new msgSend("send success\n");
                OnevtSendMessage(msg);
            }
            catch
            {
                msg = new msgSend("send failed");
                OnevtSendMessage(msg);
            }
        }


        /// <summary>
        /// 触发socket层的事件,将socket层和MLLP层连接起来
        /// </summary>
        /// <param name="e"></param>
        protected  void OnevtReceived(msgEventArgs_Bytes e)
        {
            evtReceived(this, e);
        }
        protected  void OnevtSendMessage(msgSend e)
        {           
            if (evtSendMessage != null)
            {
                evtSendMessage(this, e);
            }
        }
    }
    /// <summary>
    /// MLLP层evtReceived事件专用事件消息
    /// </summary>
    public class msgEventArgs_Bytes : EventArgs
    { 
        public byte[] msg;    
        public msgEventArgs_Bytes(byte[] msg)
        {
            this.msg = msg;
        }
    }
    /// <summary>
    /// 错误事件消息
    /// </summary>
    public class msgSend : EventArgs
    {
        public String msg;
        public msgSend(string msg)
        {
            this.msg = msg;
        }
    }
}

