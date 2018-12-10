using Microsoft.VisualStudio.TestTools.UnitTesting;
using HL7LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HL7LIB.Tests
{
    [TestClass()]
    public class primitiveTypeTests
    {
        [TestMethod()]
        public void primitiveTypeTest()
        {
            primitiveType obj = new primitiveType("ID");
            Assert.AreEqual("ID", obj.Name);
            obj.Value = "ABC123456";
            Assert.AreEqual("ABC123456", obj.Value);
        }

        [TestMethod()]
        public void ParseTest()
        {
            primitiveType obj = new primitiveType("TS");
            String ts = DateTime.Now.ToString("yyyyMMddhhmmss.fff");
            obj.Parse(ts);
            Assert.AreEqual(ts, obj.Value);
            DateTime dt = DateTime.Now;
            obj.Parse(dt.ToString("yyyy年MM月dd日hh时mm分"));

            Assert.AreEqual(dt.ToString("yyyy年MM月dd日hh时mm分"), obj.Value);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            primitiveType obj = new primitiveType("ID");
            obj.Value = "MAYUE";
            Assert.AreEqual("MAYUE", obj.ToString());
        }
    }
}