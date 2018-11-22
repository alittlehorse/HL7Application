using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7Socket;


namespace MLLP
{
    public class Context
    {
        byte[] buff;   //消息缓冲区
        int idx;      //消息缓冲区指针
        AbstractState state;
        public Context()
        {
            buff = new byte[4096];
            idx = 0;
            ChangeState(enumState.WAIT);
        }
        /// <summary>
        /// HL7消息接收事件
        /// </summary>
        public event EventHandler<msgEventArgs> eventUpperMsgReceived;//
        /// <summary>
        /// 消息缓冲区
        /// </summary>
        /// 
        /// <summary>
        /// 状态迁移
        ///   可以和享元模式结合起来,减少实例化次数
        /// </summary>
        /// <param name="newState"></param>
        public void ChangeState(enumState newState)
        {
            switch (newState)
            {
                case enumState.WAIT:
                    state = new WaitState();
                    break;
                case enumState.DATA:
                    state = new DataState();
                    break;
                case enumState.END:
                    state = new EndState();
                    break;
            }
        }
        /// <summary>
        /// 初始化消息缓存区
        /// </summary>
        public void InitBuff()
        {
            idx = 0;
        }
        /// <summary>
        /// 消息接收完成，即Input函数处理结束
        /// 触发HL7消息接收事件
        /// </summary>
        public void MsgProc()
        {
            msgEventArgs evt = new msgEventArgs(System.Text.Encoding.Default.GetString(buff));
            eventUpperMsgReceived(this, evt);
        }


        /// <summary>
        /// 把input保存到消息缓存区
        /// </summary>
        /// <param name="input">byte</param>
        public void BufferIn(byte input)
        {

            buff[idx++] = input;
        }

        /// <summary>
        ///   由socket层接收事件触发的函数
        /// </summary>
        /// <param name="data"></param>
        public void Input(object sender, msgEventArgs_Bytes args)
        {
            byte[] data = args.msg;
            int i = 0;
            while (i < data.Length)
            {
                state.Handle(this, data[i]);
                i++;
            }
        }
    }

    public enum enumState { WAIT, DATA, END }      //状态枚举声明
    public enum enumEvent { SB = 0x0b, EB = 0x1c, CR = 0x0d } //事件枚举
    public class msgEventArgs : EventArgs
    {  //HL7消息事件参数类
        public string msg;    //HL7消息
        public msgEventArgs(string msg)
        {
            this.msg = msg;
        }

    }

}
