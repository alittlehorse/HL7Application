using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7LIB
{
    public abstract class abstractType
    {
        protected string name;
        protected string value;

        public abstractType(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
        }

        public string Value
        {
            get => value.ToString();
            set
            {
                Parse(value);
            }
        }
        /// <summary>
        /// 访问common.version
        /// </summary>
        public string Version
        {
            get => common.version;
        }
        /// <summary>
        /// 写入函数
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public abstract bool Parse(string text);

        public abstract override string ToString();
    }


    public class primitiveType : abstractType
    {
        public primitiveType(string name) : base(name) {
            
        }
        public override bool Parse(string text)
        {
            value = text;
            return true;
        }
        public override string ToString()
        {
            return value;
        }
    }
    /// <summary>
    /// 为基类构造函数提供参数，
    /// 并通过上层容器构件parent.delimiter字段的值确定本容器构件的分隔符
    /// </summary>
    public class compositeType : abstractType
    {
        public compositeType(compositeType parent, string name) : base(name)
        {
            //根据上层节点的分隔符选择当前节点的分隔符
            if (parent == null)//本层是段的集合
                delimiter = common.segmentDelimiter;
            //本层是字段的集合
            else if (parent.delimiter == common.segmentDelimiter)
                delimiter = common.fieldDelimiter;
            //本层是组件的集合
            else if (parent.delimiter == common.fieldDelimiter)
                delimiter = common.componentDelimiter;
            //本层是子组件的集合
            else if (parent.delimiter == common.componentDelimiter)
                delimiter = common.subComponentDelimiter;

        }
        /// <summary>
        /// 所容纳子组件的数组
        /// </summary>
        protected abstractType[] data;
        /// <summary>
        /// 存放本层分隔符
        /// </summary>
        public string delimiter;

        //*******************************************//

        /// <summary>
        /// 将文本切割分向下层,直到无法再分
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public override bool Parse(string text)
        {
            string[] subs = text.Split(delimiter[0]);
            for (int i = 0; i < subs.Length; i++)
            {
                if (subs[i] == null || subs[i].Length == 0) continue;
                data[i].Parse(subs[i]);
            }
            value = text;
            return true;
        }
        /// <summary>
        /// 组合模式的向下拼接
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String str = "";
            bool isEmpty = true;
            for(int i = data.Length-1;i>=0;i--)
            {
                if (data[i] == null) continue;
                if (isEmpty)
                {
                    str = data[i].ToString();
                    if (str != null && str.Length > 0)
                    {
                        isEmpty = false;
                    }
                    else
                        str = data[i].ToString() + delimiter + str;
                }
            }
            value = str;
            return str;
        }

    }
}
