using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace HL7Socket
{
    /// <summary>
    /// 处理所有客户的连接,发送消息的功能
    /// </summary>
    public  static class CC
    {
        public static List<User> userlist { get; set; }
        public static IPAddress localIP { set; get; }
        public static int port { set; get; }

        static CC()
        {
            userlist = new List<User>();
            //获取本机所有的IP地址
            //Dns.GetHostAddresses(Dns.GetHostName())
            IPAddress[] ips = { IPAddress.Parse("127.0.0.1") };
            foreach (var v in ips)
            {
                if (v.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = v;
                    break;
                }
            }
        }
        public static void RemoveUser(User user)
        {
            userlist.Remove(user);
        }
    }
}
