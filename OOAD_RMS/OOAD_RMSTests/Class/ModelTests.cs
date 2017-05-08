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
    public class ModelTests
    {
        Model _model;
        [TestInitialize()]
        public void ModelInitialize()
        {
            _model = new Model();

            Project project1 = new Project();
            project1.ProjectName = "Project1";
            project1.ProjectDescription = "Project1 123";

            Requirement requirement1 = new Requirement();
            requirement1.RequirementName = "Re1";
            requirement1.RequirementDescription = "Re1 123";
            project1.AddRequirement(requirement1);
            Test test1 = new Test();
            test1.testName = "Te1";
            test1.testDescription = "Te1 123";
            project1.AddTest(test1);
            Test test2 = new Test();
            test2.testName = "Te2";
            test2.testDescription = "Te2 123";
            project1.AddTest(test2);

            Project project2 = new Project();
            project2.ProjectName = "Project2";
            project2.ProjectDescription = "Project2 456";

            Project project3 = new Project();
            project3.ProjectName = "Project3";
            project3.ProjectDescription = "Project3 789";
            Requirement requirement2 = new Requirement();
            requirement2.RequirementName = "Re1";
            requirement2.RequirementDescription = "Re1 123";
            project3.AddRequirement(requirement2);
            Requirement requirement3 = new Requirement();
            requirement3.RequirementName = "Re2";
            requirement3.RequirementDescription = "Re2 456";
            project3.AddRequirement(requirement3);
            Test test3 = new Test();
            test3.testName = "Te3";
            test3.testDescription = "Te3 123";
            test3.AddRequirement(requirement3);
            project3.AddTest(test3);

            User user1 = new User();
            user1.UserAccount = "admin";
            user1.UserPassword = "admin";
            user1.UserIdentity = "Manager";
            user1.addProject(project1);
            user1.addProject(project2);
            user1.addProject(project3);

            _model.setProject(user1);

        }
        [TestMethod()]
        public void addProjectTest()
        {
            _model.addProject("test_projectName", "test_projectDescription");
            Assert.AreEqual("test_projectName",_model.GetProjects()[3].ProjectName);
        }

        [TestMethod()]
        public void editProjectTest()
        {
            _model.editProject("test_projectName1", "test_projectDescription1",2);
            Assert.AreEqual("test_projectName1", _model.GetProjects()[2].ProjectName);
            Assert.AreEqual("test_projectDescription1", _model.GetProjects()[2].ProjectDescription);
        }

        [TestMethod()]
        public void deleteProjectTest()
        {
            _model.deleteProject(1);
            Assert.AreEqual("Project3", _model.GetProjects()[1].ProjectName);
        }

        [TestMethod()]
        public void getRequirementFromSelectProjectTest()
        {
            Assert.AreEqual("Re1", _model.getRequirementFromSelectProject(0)[0].RequirementName);
        }

        [TestMethod()]
        public void getTestFromSelectProjectTest()
        {
            Assert.AreEqual("Te1", _model.getTestFromSelectProject(0)[0].testName);
        }

        [TestMethod()]
        public void addRequirementTest()
        {
            _model.getRequirementFromSelectProject(0);
            _model.addRequirement("test_reName", "test_reDescription");
            Assert.AreEqual("test_reName", _model.GetRequirement()[1].RequirementName);
            Assert.AreEqual("test_reDescription", _model.GetRequirement()[1].RequirementDescription);
        }

        [TestMethod()]
        public void editRequirementTest()
        {
            _model.getRequirementFromSelectProject(0);
            _model.editRequirement("test_reName", "test_reDescription", 0);
            Assert.AreEqual("test_reName", _model.GetRequirement()[0].RequirementName);
            Assert.AreEqual("test_reDescription", _model.GetRequirement()[0].RequirementDescription);
        }

        [TestMethod()]
        public void deleteRequirementTest()
        {
            _model.getRequirementFromSelectProject(0);
            _model.getTestFromSelectProject(0);
            _model.deleteRequirement(0);
            Assert.AreEqual(0, _model.GetRequirement().Count);
        }

        [TestMethod()]
        public void addTestTest()
        {
            Test test1 = new Test();
            test1.testName = "t_name";
            test1.testDescription = "t_description";
            _model.getTestFromSelectProject(0);
            _model.addTest(test1);
            Assert.AreEqual("t_name", _model.getTestFromSelectProject(0)[2].testName);
            Assert.AreEqual("t_description", _model.getTestFromSelectProject(0)[2].testDescription);
        }

        [TestMethod()]
        public void LoginCheckTest()
        {
            Assert.IsTrue(_model.LoginCheck("admin", "admin"));
        }

        [TestMethod()]
        public void GetProjectsTest()
        {
            Assert.AreEqual(3, _model.GetProjects().Count);
        }

        [TestMethod()]
        public void GetRequirementTest()
        {
            _model.getRequirementFromSelectProject(0);
            Assert.AreEqual(1, _model.GetRequirement().Count);
        }
    }
}