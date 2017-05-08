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
    public class TestTests
    {
        List<Requirement> _requirements;
        Test _test;

        [TestInitialize()]
        public void TestInit()
        {
            _test = new Test();
            _requirements = new List<Requirement>();
        }

        [TestMethod()]
        public void AddRequirementTest()
        {
            Requirement re1 = new Requirement();
            re1.RequirementName = "re1_name";
            re1.RequirementDescription = "re_description";
            _test.AddRequirement(re1);
            Assert.AreEqual("re1_name", _test.requirements[0].RequirementName);
            Assert.AreEqual("re_description", _test.requirements[0].RequirementDescription);

        }

        
    }
}