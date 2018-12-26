using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7LIB.ConcretcompositeType;

namespace HL7LIB
{
    public abstract class abstractFactory
    {
        public abstract abstractType Create(compositeType parent, Enum product, string name);

    }
    public class messageFactory:abstractFactory
    {/// <summary>
    /// 消息工厂创建messageType，生成ADT，ACK等消息
    /// </summary>
    /// <param name="parent"></param>
    /// <param name="product"></param>
    /// <param name="name"></param>
    /// <returns></returns>
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            abstractType tmp = null;
            switch (product)
            {
                case enumMessage.ACK:
                    tmp = new ACK(parent, name);
                    break;
                default:
                    throw new NotSupportedException();
            }
            return tmp;
        }
    }
    public class segmentFactory:abstractFactory
    {/// <summary>
     /// 段工厂创建消息工厂创建segmentType，生成MSH|MSA|EVN|PID等
     /// </summary>
     /// <param name="parent"></param>
     /// <param name="product"></param>
     /// <param name="name"></param>
     /// <returns></returns>
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            abstractType tmp = null;
            switch (product)
            {
                case enumSegment.PID:tmp = new PID(parent, name);break;
                case enumSegment.MSH: tmp = new MSH(parent, name); break;
                case enumSegment.MSA: tmp = new MSA(parent, name); break;
                case enumSegment.ERR: tmp = new ERR(parent, name); break;
                default: throw new NotSupportedException();
            }
            return tmp;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class primitiveFactory:abstractFactory
    {
        /// <summary>
        /// 简单类型工厂创建primitiveType，如ID等
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="product"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            abstractType tmp = null;
            switch (product)
            {
                case enumPrimitive.DR:tmp = new DR(name);break;
                case enumPrimitive.DT:tmp = new DT(name);break;
                case enumPrimitive.FT:tmp = new FT(name);break;
                case enumPrimitive.ID: tmp = new ID(name); break;
                case enumPrimitive.IS: tmp = new IS(name); break;
                case enumPrimitive.NM: tmp = new NM(name); break;
                case enumPrimitive.SAD: tmp = new SAD(name); break;
                case enumPrimitive.SI: tmp = new SI(name); break;
                case enumPrimitive.ST: tmp = new ST(name); break;
                case enumPrimitive.TM: tmp = new TM(name); break;
                case enumPrimitive.TN: tmp = new TN(name); break;
                case enumPrimitive.TS: tmp = new TS(name); break;
                case enumPrimitive.TX: tmp = new TX(name); break;
                default:
                    throw new NotSupportedException();
            }
            return tmp;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public  class fieldFactory:abstractFactory
    {
        /// <summary>
        /// 创建fieldtype，如CE，XCN等
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="product"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public override abstractType Create(compositeType parent, Enum product, string name)
        {
            abstractType tmp = null;
            switch (product)
            {
                case enumField.CE: tmp = new CE(parent, name); break;
                case enumField.CM: tmp = new CM(parent, name); break;
                case enumField.CWE: tmp = new CWE(parent, name); break;
                case enumField.CX: tmp = new CX(parent, name); break;
                case enumField.DLN: tmp = new DLN(parent, name); break;
                case enumField.EI: tmp = new EI(parent, name); break;
                case enumField.ELD: tmp = new ELD(parent, name); break;
                case enumField.FN: tmp = new FN(parent, name); break;
                case enumField.HD: tmp = new HD(parent, name); break;
                case enumField.MSG: tmp = new MSG(parent, name); break;
                case enumField.PT: tmp = new PT(parent, name); break;
                case enumField.VID: tmp = new VID(parent, name); break;
                case enumField.XAD: tmp = new XAD(parent, name); break;
                case enumField.XCN: tmp = new XCN(parent, name); break;
                case enumField.XPN: tmp = new XPN(parent, name); break;
                case enumField.XTN: tmp = new XTN(parent, name); break;
                case enumField.ERL: tmp = new ERL(parent, name); break;
                default: throw new NotSupportedException();
            }
            return tmp;
        }
    }
}

public enum enumMessage
{
        ACK,
        ADT
 };
public  enum enumField
{
        CE, FN, CX, XCN, HD, MSG, PT, VID, ELD, CM, EI, XPN, XAD, XTN, DLN, CWE ,ERL       
};
public enum enumPrimitive
{
        ID, IS, FT, TN, TX, TS, TM, DT, SI, ST, NM, SAD, DR
};
public enum enumSegment
{
        MSH,
        MSA,
        ERR,
        PID
};
    
