using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace HL7Socket
{
    /// <summary>
    /// 服务端接收到的客户端对象
    /// </summary>
    public class User
    {
        /// <summary>
        /// 处理与某个可会通信的信息;
        /// </summary>
        public BinaryReader br { get; private set; }
        public BinaryWriter bw { get; private set; }
        private TcpClient client;
        
        public event EventHandler<msgEventArgsInServer> evtReceivedFromUser;
        /// <summary>
        /// 需要改变前端界面
        /// </summary>
        /// <param name="form1"></param>
        /// <param name="client"></param>
        /// <param name="isTask"></param>
        public User(TcpClient client)
        {
            this.client = client;
            NetworkStream networkStream = client.GetStream();
            br = new BinaryReader(networkStream);
            bw = new BinaryWriter(networkStream);
            Task.Run(() => ReciveFromClient());
        }

        /// <summary>
        /// 接受从客户端传来的消息
        /// </summary>
        public void ReciveFromClient()
        {
            while (true)
            {
                String receiveString = null;
                try
                {
                    receiveString = br.ReadString();
                    onevtReceived(receiveString);
                }
                catch
                {

                    CC.RemoveUser(this);
                    return;//结束了这个进程
                }

            }
        }
        /// <summary>
        /// 触发事件的函数,向Application层传消息
        /// </summary>
        /// <param name="message"></param>
        public void onevtReceived(String message)
        {
            msgEventArgsInServer args = new msgEventArgsInServer(message);
            evtReceivedFromUser(this,args);
        }

    }

    /// <summary>
    /// User专用事件消息类型
    /// </summary>
    public class msgEventArgsInServer:EventArgs
    {
        public String message { get; set; }
        public msgEventArgsInServer(String message)
        {
            this.message = message;
        }
    }
        
}
