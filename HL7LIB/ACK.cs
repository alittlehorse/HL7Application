using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7LIB;

namespace HL7LIB.ConcretcompositeType
{
    public class ACK:compositeMessage
    {
        public ACK(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[3];
            data[0] = new MSH(this,"ACK");
            data[1] = new MSA(this, "ACK");
            data[2] = new ERR(this, "ACK");
        }
        public MSH msh { get { return data[0] as MSH; } set { data[0] = value; } }
        public MSA msa { get { return data[1] as MSA; } set { data[1] = value; } }
        public ERR err { get { return data[2] as ERR; } set { data[2] = value; } } 
    }
    /// <summary>
    /// 医嘱
    /// </summary>
    /// <seealso cref="HL7LIB.compositeMessage" />
    public class ORM : compositeMessage
    {
        public ORM(compositeType parent, string name) : base(parent, name)
        {
            data = new abstractType[19];
            
            data[0] = new MSH(this, "MSH");
            data[1] = new NTE(this, "NTE");
            //Patient
            data[2] = new PID(this, "PID");
            data[3] = new PD1(this, "PD1");
            //Patient_VISIT
            data[4] = new PV1(this, "PV1");
            data[5] = new PV2(this, "PV2");
            //INsurance
            data[6] = new IN1(this, "IN1");
            data[7] = new IN2(this, "IN2");
            data[8] = new IN3(this, "IN3");
            
            data[9] = new GT1(this, "GT1");
            data[10] = new AL1(this, "AL1");
            //Order
            data[11] = new ORC(this, "ORC");
            //Order_Detail
            data[12] = new OBR(this, "OBR");
            data[13] = new NTE(this, "NTE");
            data[14] = new DG1(this, "DG1");
            //Observation
            data[15] = new OBX(this, "OBX");
            data[16] = new NTE(this, "NTE");
            data[17] = new CTI(this, "CTI");
            data[18] = new BLG(this, "BLG");
        }
        public MSH msh { get { return data[0] as MSH; } set { data[0] = value; } }
        public NTE nte1 { get { return data[1] as NTE; } set { data[1] = value; } }
        public PID pid { get { return data[2] as PID; } set { data[2] = value; } }
        public PD1 err { get { return data[3] as PD1; } set { data[3] = value; } }
        public PV1 pv1 { get { return data[4] as PV1; } set { data[4] = value; } }
        public PV2 pv2 { get { return data[5] as PV2; } set { data[5] = value; } }
        public IN1 in1 { get { return data[6] as IN1; } set { data[6] = value; } }
        public IN2 in2 { get { return data[7] as IN2; } set { data[7] = value; } }
        public IN3 iN3 { get { return data[8] as IN3; } set { data[8] = value; } }
        public GT1 gt1 { get { return data[9] as GT1; } set { data[9] = value; } }
        public AL1 al1 { get { return data[10] as AL1; } set { data[10] = value; } }
        public ORC orc { get { return data[11] as ORC; } set { data[11] = value; } }
        public OBR obr { get { return data[12] as OBR; } set { data[12] = value; } }
        public NTE nte2 { get { return data[13] as NTE; } set { data[13] = value; } }
        public DG1 dg1 { get { return data[14] as DG1; } set { data[14] = value; } }
        public OBX obx { get { return data[15] as OBX; } set { data[15] = value; } }
        public NTE nte3 { get { return data[16] as NTE; } set { data[16] = value; } }
        public CTI cti { get { return data[17] as CTI; } set { data[17] = value; } }
        public BLG blg { get { return data[18] as BLG; } set { data[18] = value; } }

    }
}
