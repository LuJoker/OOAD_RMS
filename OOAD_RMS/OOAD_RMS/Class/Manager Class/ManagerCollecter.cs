using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class ManagerCollecter
    {
        UserManage _userManage;
        ProjectManage _projectManage;
        RequirementManage _requirementManage;
        TestManage _testManage;

        public ManagerCollecter()
        {
            _userManage = new UserManage();
            _projectManage = new ProjectManage();
            _requirementManage = new RequirementManage();
            _testManage = new TestManage();

            DataTable projectTable = DBManager.GetProjects();
            List<Project> projects = new List<Project>();
            foreach (DataRow projectRow in projectTable.Rows)
            {
                Project project = new Project();
                project.ProjectName = projectRow["ProjectName"].ToString();
                project.ProjectDescription = projectRow["ProjectDescription"].ToString();
                projects.Add(project);

                DataTable requirementTable = DBManager.GetRequirementByProjectId((int)projectRow["Id"]);
                foreach (DataRow reqRow in requirementTable.Rows)
                {
                    Requirement requirement = new Requirement();
                    requirement.RequirementName = reqRow["RequirementName"].ToString();
                    requirement.RequirementDescription = reqRow["RequirementDescription"].ToString();
                    requirement.Project = project;
                    _requirementManage.addRequirement(requirement);
                }

                DataTable testTable = DBManager.GetTestByProjectId((int)projectRow["Id"]);
                foreach (DataRow testRow in testTable.Rows)
                {
                    Test test = new Test();
                    test.TestName = testRow["TestName"].ToString();
                    test.TestDescription = testRow["TestDescription"].ToString();
                    test.Project = project;

                    List<Requirement> requirementsMap = new List<Requirement>();
                    DataTable testMapRequirementTable = DBManager.GetTestMapRequirementByTestId((int)testRow["Id"]);
                    foreach (DataRow testMapReq in testMapRequirementTable.Rows)
                    {
                        Requirement reqRelateTest = _requirementManage.GetRequirements(project).Find(c => (c.RequirementName == testMapReq["RequirementName"].ToString()));
                        requirementsMap.Add(reqRelateTest);
                        TestMapRequirement testMapRequirement = new TestMapRequirement(test, reqRelateTest, (testMapReq["IsCompleted"].ToString() == "True") ? true : false);
                        _testManage.addTest(testMapRequirement);
                    }
                }
            }

            DataTable userTable = DBManager.GetUsers();

            foreach (DataRow userDataRow in userTable.Rows)
            {
                User user = new User();
                user.UserAccount = userDataRow["Account"].ToString();
                user.UserPassword = userDataRow["Password"].ToString();
                user.UserIdentity = userDataRow["Title"].ToString();
                DataTable userInProjectTable = DBManager.GetProjectByUserAccount(user.UserAccount);

                foreach (DataRow projectRow in userInProjectTable.Rows)
                {
                    Project project = projects.Find(c => (c.ProjectName == projectRow["ProjectName"].ToString() && c.ProjectDescription == projectRow["ProjectDescription"].ToString()));
                    _projectManage.addProject(user, project);
                }
                _userManage.addUser(user);
            }
        }

        public UserManage UserManage
        {
            get {
                return _userManage;
            }
        }

        public ProjectManage ProjectManage
        {
            get
            {
                return _projectManage;
            }
        }

        public RequirementManage RequirementManage
        {
            get
            {
                return _requirementManage;
            }
        }

        public TestManage TestManage
        {
            get
            {
                return _testManage;
            }
        }
    }
}
