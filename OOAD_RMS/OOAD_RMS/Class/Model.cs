using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace OOAD_RMS
{
    public class Model
    {
        BindingList<Project> _projectList;
        BindingList<Requirement> _requirementList;
        BindingList<Test> _testList;
        List<User> _userList;
        DBManager _dbManager;
        public Model()
        {
            _dbManager = new DBManager();
            _userList = new List<User>();

            DataTable userTable = _dbManager.GetUsers();

            foreach (DataRow userDataRow in userTable.Rows)
            {
                User user = new User();
                user.UserAccount = userDataRow["Account"].ToString();
                user.UserPassword = userDataRow["Password"].ToString();
                user.UserIdentity = userDataRow["Title"].ToString();

                DataTable projectTable = _dbManager.GetProjectByUserAccount(user.UserAccount);

                foreach (DataRow datarow in projectTable.Rows)
                {
                    Project project = new Project();
                    project.ProjectName = datarow["ProjectName"].ToString();
                    project.ProjectDescription = datarow["ProjectDescription"].ToString();

                    DataTable requirementTable = _dbManager.GetRequirementByProjectId((int)datarow["Id"]);
                    foreach (DataRow reqRow in requirementTable.Rows)
                    {
                        Requirement requirement = new Requirement();
                        requirement.RequirementName = reqRow["RequirementName"].ToString();
                        requirement.RequirementDescription = reqRow["RequirementDescription"].ToString();
                        project.AddRequirement(requirement);
                    }

                    DataTable testTable = _dbManager.GetTestByProjectId((int)datarow["Id"]);
                    foreach (DataRow testRow in testTable.Rows)
                    {
                        Test test = new Test();
                        test.testName = testRow["TestName"].ToString();
                        test.testDescription = testRow["TestDescription"].ToString();

                        DataTable testMapRequirementTable = _dbManager.GetTestMapRequirementByTestId((int)testRow["Id"]);
                        foreach (DataRow testMapReq in testMapRequirementTable.Rows)
                        {
                            Requirement requirement = project.GetRequirements().Find(r => r.RequirementName == testMapReq["RequirementName"].ToString());
                            test.AddRequirement(requirement, (testMapReq["IsCompleted"].ToString() == "True")? true:false);
                        }
                        project.AddTest(test);
                    }

                    user.addProject(project);
                }
                _userList.Add(user);
            }
        }


        public void addProject(string projectName, string projectDescription)
        {
            Project project = new Project();
            project.ProjectName = projectName;
            project.ProjectDescription = projectDescription;
            _dbManager.AddProject(projectName, projectDescription);
            _projectList.Add(project);
        }

        public void editProject(string projectName, string projectDescription, int index)
        {
            _dbManager.EditProject(_projectList[index].ProjectName, _projectList[index].ProjectDescription, projectName, projectDescription);
            _projectList[index].ProjectName = projectName;
            _projectList[index].ProjectDescription = projectDescription;
            _projectList.ResetBindings();
        }

        public void deleteProject(int index)
        {
            _dbManager.DeleteProject(_projectList[index].ProjectName, _projectList[index].ProjectDescription);
            _projectList.RemoveAt(index);
        }

        public BindingList<Requirement> getRequirementFromSelectProject(int projectIndex)
        {
            if (projectIndex > -1)
            {
                _dbManager.SetCurrentProject(_projectList[projectIndex]);
                _requirementList = new BindingList<Requirement>(_projectList[projectIndex].GetRequirements());
            }     
            return _requirementList;
        }

        public BindingList<Test> getTestFromSelectProject(int projectIndex)
        {
            if (projectIndex > -1)
                _testList = new BindingList<Test>(_projectList[projectIndex].GetTests());
            return _testList;
        }

        public void getTraceAbilityMatrixFromSelectProject(DataGridView grid)
        {
            TraceabilityMatrix tm = new TraceabilityMatrix(_requirementList.ToList(), _testList.ToList());
            tm.SetTraceAbilityMatrix(grid);
        }

        public void addRequirement(string requirementName, string requirementDescription)
        {
            Requirement requirement = new Requirement();
            requirement.RequirementName = requirementName;
            requirement.RequirementDescription = requirementDescription;
            _dbManager.AddRequirement(requirementName, requirementDescription);
            _requirementList.Add(requirement);
        }

        public void editRequirement(string requirementName, string requirementDescription, int index)
        {
            _dbManager.EditRequirement(_requirementList[index].RequirementName, _requirementList[index].RequirementDescription, requirementName, requirementDescription);
            _requirementList[index].RequirementName = requirementName;
            _requirementList[index].RequirementDescription = requirementDescription;
            _requirementList.ResetBindings();
        }

        public void deleteRequirement(int index)
        {
            _dbManager.DeleteRequirement(_requirementList[index].RequirementName, _requirementList[index].RequirementDescription);
            foreach (Test test in _testList)
                test.requirements.Remove(_requirementList[index]);
            _requirementList.RemoveAt(index);
        }

        public void addTest(string testName, string testDescription, List<Requirement> requirements)
        {
            Test test = new Test();
            test.testName = testName;
            test.testDescription = testDescription;
            test.requirements = requirements;
            _dbManager.AddTest(testName, testDescription, requirements);
            _testList.Add(test);
        }

        public void editTest(string testName, string testDescription, List<Requirement> requirements, int index)
        {
            _dbManager.EditTest(_testList[index].testName, _testList[index].testDescription, testName, testDescription, requirements);
            _testList[index].testName = testName;
            _testList[index].testDescription = testDescription;
            _testList[index].requirements = requirements;
            _testList.ResetBindings();
        }

        public void deleteTest(int index)
        {
            _dbManager.DeleteTest(_testList[index].testName, _testList[index].testDescription);
            _testList.RemoveAt(index);
        }

        public void updateTestIsComplete(Test test)
        {
            _dbManager.EditTestIsComplete(test);
        }

        public bool LoginCheck(string account, string password)
        {
            List<User> user = _userList.FindAll(x => (x.UserAccount == account) && (x.UserPassword == password));
            if (user.Count == 1)
            {
                _dbManager.SetCurrentUser(user[0]);
                setProject(user[0]);
                return true;
            }
            else
                return false;
        }


        public void registerAccount(string account, string password, string Identity)
        {
            DataTable userTable = _dbManager.GetUsersIsRegister(account);
            String NotExist = userTable.Rows[0]["Result"].ToString();
            if (NotExist == "TRUE")
            {
                _dbManager.AddUser(account, password, Identity);
                MessageBox.Show(account + " 註冊成功\n回到登入畫面", "註冊成功");
            }
            else
                MessageBox.Show(account + " 已被註冊", "註冊失敗");
        }

        public void setProject(User user)
        {
            _projectList = new BindingList<Project>(user.GetInProjects());
        }

        public BindingList<Project> GetProjects()
        {
            return _projectList;
        }

        public BindingList<Requirement> GetRequirement()
        {
            return _requirementList;
        }

        public List<User> GetAllUser()
        {
            return _userList;
        }
    }
}