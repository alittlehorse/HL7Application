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
    public class PIDTests
    {
        [TestMethod()]
        public void PIDTest()
        {
            PID pid = new PID(new ACK(null,"ack"),"pid");
            String str = @"PID|1||123456789|0123456789^AA^^JP|BROS^MARIO||19850101000000|M|||123 FAKE STREET^MARIO \T\ LUIGI BROS PLACE^TOADSTOOL KINGDOM^NES^A1B2C3^JP^HOME^^1234|1234|(555)555-0123^HOME^JP:1234567|||S|MSH|12345678|||||||0|||||N";
            pid.Value = str;
            Assert.AreEqual(pid.Value, str);
        }
    }
}