using Microsoft.VisualStudio.TestTools.UnitTesting;
using HL7LIB.ConcretcompositeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7LIB.ConcretcompositeType.Tests
{
    [TestClass()]
    public class ACKTests
    {
        [TestMethod()]
        public void ACKTest()
        {
            ACK ack = new ACK(null, "ACK01");
            String str = @"MSH|^~\&|RIS||HIS||200405201205||ACK|RIS0001|P|2.4"+"\r"+"MSA|AE|MSG0001|type error|||102" + "\r";
       
            //str += "\x0d\x1c";
            ack.Value = str ;
            Assert.AreEqual(str, ack.Value);
        }
    }
}