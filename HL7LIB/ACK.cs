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
}
