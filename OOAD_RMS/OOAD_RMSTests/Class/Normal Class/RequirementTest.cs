using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOAD_RMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOAD_RMS.Tests
{
    [TestClass()]
    public class RequirementTest
    {
        Requirement _requirement;
        [TestInitialize()]
        public void RequirementInit()
        {
            _requirement = new Requirement();
        }

        [TestMethod()]
        public void RequirementName()
        {
            _requirement.RequirementName = "test";
            Assert.AreEqual("test", _requirement.RequirementName);
        }

        [TestMethod()]
        public void RequirementDescription()
        {
            _requirement.RequirementDescription = "test123";
            Assert.AreEqual("test123", _requirement.RequirementDescription);
        }

    }
}
