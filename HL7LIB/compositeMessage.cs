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
    /// 段
    /// </summary>
    public class compositeSegment : compositeType
    {
        public compositeSegment(compositeType parent, string name) : base(parent, name)
        {
            
        }
        public override bool Parse(String text)
        {
            //对MSH做特殊处理，其MSH1只为一个|，MSH2才是分割后的数据
            if (text.Split(delimiter[0])[0] == "MSH")
            {
                string[] subs = text.Split(delimiter[0]);
                data[0].Parse("|");
                for (int i = 1; i < subs.Length; i++)
                {
                    if (subs[i] == null || subs[i].Length == 0) continue;
                    data[i].Parse(subs[i]);
                }
                value = text;
                return true;
            }
            else {
                string[] subs = text.Split(delimiter[0]);
                //跳过第一个，就是去除段首
                for (int i = 1; i < subs.Length; i++)
                {
                    if (subs[i] == null || subs[i].Length == 0) continue;
                    data[i-1].Parse(subs[i]);
                }
                value = text;
                return true;
            }
        }
        public override string ToString()
        {
            if (this.GetType() == typeof(ConcretcompositeType.MSH))
            {
                return "MSH" + base.ToString() ;
            }
            else {
                if (base.ToString() == null) return "";
                return this.GetType().ToString().Split('.').Last() + delimiter+ base.ToString();
            }
                
        }
    }
}