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
    public class RequirementManageTests
    {
        RequirementManager _rm;
        Project _project;
        Requirement _requirement;
        [TestInitialize()]
        public void RequirementManageTestsInit()
        {
            _rm = new RequirementManager();

            _project = new Project();
            _project.ProjectName = "pn";
            _project.ProjectDescription = "pd";

            _requirement = new Requirement();
            _requirement.RequirementDescription = "rd";
            _requirement.RequirementName = "rn";
            _requirement.Project = _project;
        }

        [TestMethod()]
        public void addRequirementTest()
        {
            List<Requirement> requirementList;
            _rm.addRequirement(_requirement);
            requirementList = _rm.GetRequirements(_project);
            Assert.AreEqual("rn", requirementList.Find(x => x.RequirementName == "rn").RequirementName);
        }

        [TestMethod()]
        public void editRequirementTest()
        {
            List<Requirement> requirementList;
            _requirement.RequirementName = "editrn";
            _requirement.RequirementDescription = "editrd";
            _rm.editRequirement(_requirement);
            _rm.addRequirement(_requirement);
            requirementList = _rm.GetRequirements(_project);
            Assert.AreEqual("editrn", requirementList.Find(x => x.RequirementName == "editrn").RequirementName);
            Assert.AreEqual("editrd", requirementList.Find(x => x.RequirementName == "editrn").RequirementDescription);
        }

        [TestMethod()]
        public void deleteRequirementTest()
        {
            List<Requirement> requirementList;
            _rm.deleteRequirement(_requirement);
            requirementList = _rm.GetRequirements(_project);
            Assert.AreEqual(0, requirementList.Count);
        }

        [TestMethod()]
        public void GetRequirementsTest()
        {
            List<Requirement> requirementList;
            _rm.addRequirement(_requirement);
            requirementList = _rm.GetRequirements(_project);
            Assert.AreEqual("rn", requirementList.Find(x => x.RequirementName == "rn").RequirementName);
        }
    }
}