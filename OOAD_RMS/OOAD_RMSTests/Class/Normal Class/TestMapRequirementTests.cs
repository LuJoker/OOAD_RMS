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
    public class TestMapRequirementTests
    {
        TestMapRequirement _tmr;
        Test _test;
        Requirement _requirement;
        bool _isComplete;
        [TestInitialize()]
        public void TestMapRequirement()
        {
            _test = new Test();
            _requirement = new Requirement();
            _isComplete = false;
            _tmr = new TestMapRequirement(_test, _requirement, _isComplete);
        }

        [TestMethod()]
        public void TestMapRequirement_TestName()
        {
            _tmr.Test.TestName = "test";
            Assert.AreEqual("test", _tmr.Test.TestName);
        }
        [TestMethod()]
        public void TestMapRequirement_TestDescription()
        {
            _tmr.Test.TestDescription = "test";
            Assert.AreEqual("test", _tmr.Test.TestDescription);
        }

        [TestMethod()]
        public void TestMapRequirement_RequirementDescription()
        {
            _tmr.Requirement.RequirementDescription = "test";
            Assert.AreEqual("test", _tmr.Requirement.RequirementDescription);
        }

        [TestMethod()]
        public void TestMapRequirement_RequirementName()
        {
            _tmr.Requirement.RequirementName = "test";
            Assert.AreEqual("test", _tmr.Requirement.RequirementName);
        }

        [TestMethod()]
        public void IsComplete()
        {
            _tmr.IsComplete = true;
            Assert.AreEqual(true, _tmr.IsComplete);
        }
    }
}