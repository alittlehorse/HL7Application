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
    public class MSHTests
    {
        [TestMethod()]
        public void MSHTest()
        {
            MSH msh = new MSH(new ACK(null, "ack"), "msh");
            String str = @"MSH|^~\&|NES|NINTENDO|TESTSYSTEM|TESTFACILITY|20010101000000||ADT^A04|Q123456789T123456789X123456|P|2.3";
            msh.Value = str;
            Assert.AreEqual(msh.Value, str);
        }
    }
}