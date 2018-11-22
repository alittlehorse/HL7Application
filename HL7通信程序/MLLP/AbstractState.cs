using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLLP
{
    public abstract class AbstractState
    {
        public abstract void Handle(Context ctx, byte input);

    }


    /// <summary>
    /// 输入状态
    /// </summary>
    public class DataState : AbstractState
    {
        public override void Handle(Context ctx, byte input)
        {
            switch (input)
            {
                case (byte)enumEvent.SB:
                    ctx.InitBuff();
                    break;
                case (byte)enumEvent.EB://转入END模式
                    ctx.ChangeState(enumState.END);
                    break;
                default://其余状态BufferIn
                    ctx.BufferIn(input);
                    break;
            }
        }
    }


    /// <summary>
    /// 结束输入,触发HL7接收事件
    /// </summary>
    public class EndState : AbstractState
    {
        public override void Handle(Context ctx, byte input)
        {
            switch (input)
            {
                case (byte)enumEvent.CR:
                    ctx.ChangeState(enumState.WAIT);
                    ctx.MsgProc();//触发HL7接收事件
                    break;
                case (byte)enumEvent.SB:
                    ctx.InitBuff();
                    break;
                default:
                    ctx.ChangeState(enumState.WAIT);
                    break;
            }
        }
    }


    /// <summary>
    /// 等待进入输入状态
    /// </summary>
    public class WaitState : AbstractState
    {
        public override void Handle(Context ctx, byte input)
        {
            switch (input)
            {
                case (byte)enumEvent.SB:
                    ctx.InitBuff();
                    ctx.ChangeState(enumState.DATA);
                    break;
                default:
                    break;
            }
        }
    }
}

