using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HL7LIB
{
    /// <summary>
    /// 消息
    /// </summary>
    public class compositeMessage : compositeType
    {
        public compositeMessage(compositeType parent, string name) : base(parent,name)
        {
          
        }
    }
    /// <summary>
    /// 段
    /// </summary>
    public class compositeField : compositeType
    {
        public compositeField(compositeType parent, string name) : base(parent, name)
        {

        }
    }
    /// <summary>
    /// 段里的结构
    /// </summary>
    public class compositeSegment : compositeType
    {
        public compositeSegment(compositeType parent, string name) : base(parent, name)
        {
            
        }
        public override bool Parse(String text)
        {
            if (text.Split(delimiter[0])[0] == "MSH")
            {

            }
            else {
                base.Parse(text);
            }
        }
    }
}