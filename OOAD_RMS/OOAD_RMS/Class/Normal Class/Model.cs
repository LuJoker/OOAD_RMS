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
        //BindingList<Project> _projectList; //某個User所屬的Project

        //BindingList<Requirement> _currentRequirementList; //目前UI上呈現的Requirement列表
        //BindingList<Test> _currentTestList; //目前UI上呈現的Test列表

        //List<User> _userList; //所有已註冊的使用者
        //public Model()
        //{
        //    _userList = new List<User>();

        //    DataTable userTable = DBManager.GetUsers();

        //    foreach (DataRow userDataRow in userTable.Rows)
        //    {
        //        User user = new User();
        //        user.UserAccount = userDataRow["Account"].ToString();
        //        user.UserPassword = userDataRow["Password"].ToString();
        //        user.UserIdentity = userDataRow["Title"].ToString();

        //        DataTable projectTable = DBManager.GetProjectByUserAccount(user.UserAccount);

        //        foreach (DataRow datarow in projectTable.Rows)
        //        {
        //            Project project = new Project();
        //            project.ProjectName = datarow["ProjectName"].ToString();
        //            project.ProjectDescription = datarow["ProjectDescription"].ToString();

        //            DataTable requirementTable = DBManager.GetRequirementByProjectId((int)datarow["Id"]);
        //            foreach (DataRow reqRow in requirementTable.Rows)
        //            {
        //                Requirement requirement = new Requirement();
        //                requirement.RequirementName = reqRow["RequirementName"].ToString();
        //                requirement.RequirementDescription = reqRow["RequirementDescription"].ToString();
        //                //project.AddRequirement(requirement);
        //            }

        //            DataTable testTable = DBManager.GetTestByProjectId((int)datarow["Id"]);
        //            foreach (DataRow testRow in testTable.Rows)
        //            {
        //                Test test = new Test();
        //                test.TestName = testRow["TestName"].ToString();
        //                test.TestDescription = testRow["TestDescription"].ToString();

        //                DataTable testMapRequirementTable = DBManager.GetTestMapRequirementByTestId((int)testRow["Id"]);
        //                foreach (DataRow testMapReq in testMapRequirementTable.Rows)
        //                {
        //                    //Requirement requirement = project.GetRequirements().Find(r => r.RequirementName == testMapReq["RequirementName"].ToString());
        //                    //test.AddRequirement(requirement, (testMapReq["IsCompleted"].ToString() == "True")? true:false);
        //                }
        //                //project.AddTest(test);
        //            }

        //            user.addProject(project);
        //        }
        //        _userList.Add(user);
        //    }
        //}


        //public void addProject(string projectName, string projectDescription,List<User>selectedUserList)
        //{
        //    Project project = new Project();
        //    project.ProjectName = projectName;
        //    project.ProjectDescription = projectDescription;
        //    DBManager.AddProject(projectName, projectDescription, selectedUserList);
        //    _projectList.Add(project);
        //}

        //public void editProject(string projectName, string projectDescription,List<User>selectedUserList, int index)
        //{
        //    DBManager.EditProject(_projectList[index].ProjectName, _projectList[index].ProjectDescription, projectName, projectDescription,selectedUserList);
        //    _projectList[index].ProjectName = projectName;
        //    _projectList[index].ProjectDescription = projectDescription;
        //    _projectList.ResetBindings();
        //}

        //public void deleteProject(int index)
        //{
        //    DBManager.DeleteProject(_projectList[index].ProjectName, _projectList[index].ProjectDescription);
        //    _projectList.RemoveAt(index);
        //}

        //public BindingList<Requirement> getRequirementFromSelectProject(int projectIndex)
        //{
        //    if (projectIndex > -1)
        //    {
        //        DBManager.CurrentProject = _projectList[projectIndex];
        //        _currentRequirementList = new BindingList<Requirement>(_projectList[projectIndex].GetRequirements());
        //    }     
        //    return _currentRequirementList;
        //}

        //public BindingList<Test> getTestFromSelectProject(int projectIndex)
        //{
        //    if (projectIndex > -1)
        //    {
        //        DBManager.CurrentProject = _projectList[projectIndex];
        //        _currentTestList = new BindingList<Test>(_projectList[projectIndex].GetTests());
        //    }
        //    return _currentTestList;
        //}

        //public void getTraceAbilityMatrixFromSelectProject(DataGridView grid)
        //{
        //    TraceabilityMatrix tm = new TraceabilityMatrix(_currentRequirementList.ToList(), _currentTestList.ToList());
        //    tm.SetTraceAbilityMatrix(grid);
        //}

        //public void addRequirement(string requirementName, string requirementDescription)
        //{
        //    Requirement requirement = new Requirement();
        //    requirement.RequirementName = requirementName;
        //    requirement.RequirementDescription = requirementDescription;
        //    DBManager.AddRequirement(requirementName, requirementDescription);
        //    _currentRequirementList.Add(requirement);
        //}

        //public void editRequirement(string requirementName, string requirementDescription, int index)
        //{
        //    DBManager.EditRequirement(_currentRequirementList[index].RequirementName, _currentRequirementList[index].RequirementDescription, requirementName, requirementDescription);
        //    _currentRequirementList[index].RequirementName = requirementName;
        //    _currentRequirementList[index].RequirementDescription = requirementDescription;
        //    _currentRequirementList.ResetBindings();
        //}

        //public void deleteRequirement(int index)
        //{
        //    DBManager.DeleteRequirement(_currentRequirementList[index].RequirementName, _currentRequirementList[index].RequirementDescription);
        //    foreach (Test test in _currentTestList)
        //        //test.requirements.Remove(_currentRequirementList[index]);
        //    _currentRequirementList.RemoveAt(index);
        //}

        //public void addTest(string testName, string testDescription, List<Requirement> requirements)
        //{
        //    Test test = new Test();
        //    test.TestName = testName;
        //    test.TestDescription = testDescription;
        //    //test.requirements = requirements;
        //    DBManager.AddTest(testName, testDescription, requirements);
        //    _currentTestList.Add(test);
        //}

        //public void editTest(string testName, string testDescription, List<Requirement> requirements, int index)
        //{
        //    DBManager.EditTest(_currentTestList[index].TestName, _currentTestList[index].TestDescription, testName, testDescription, requirements);
        //    _currentTestList[index].TestName = testName;
        //    _currentTestList[index].TestDescription = testDescription;
        //    //_currentTestList[index].requirements = requirements;
        //    _currentTestList.ResetBindings();
        //}

        //public void deleteTest(int index)
        //{
        //    DBManager.DeleteTest(_currentTestList[index].TestName, _currentTestList[index].TestDescription);
        //    _currentTestList.RemoveAt(index);
        //}

        //public void updateTestIsComplete(Test test)
        //{
        //    DBManager.EditTestIsComplete(test);
        //}

        //public bool LoginCheck(string account, string password)
        //{
        //    List<User> user = _userList.FindAll(x => (x.UserAccount == account) && (x.UserPassword == password));
        //    if (user.Count == 1)
        //    {
        //        DBManager.CurrentUser = user[0];
        //        setProject(user[0]);
        //        return true;
        //    }
        //    else
        //        return false;
        //}


        //public void registerAccount(string account, string password, string Identity)
        //{
        //    DataTable userTable = DBManager.GetUsersIsRegister(account);
        //    String NotExist = userTable.Rows[0]["Result"].ToString();
        //    if (NotExist == "TRUE")
        //    {
        //        DBManager.AddUser(account, password, Identity);
        //        MessageBox.Show(account + " 註冊成功\n回到登入畫面", "註冊成功");
        //    }
        //    else
        //        MessageBox.Show(account + " 已被註冊", "註冊失敗");
        //}

        //public void setProject(User user)
        //{
        //    _projectList = new BindingList<Project>(user.GetInProjects());
        //}

        //public BindingList<Project> GetProjects()
        //{
        //    return _projectList;
        //}

        //public BindingList<Requirement> GetRequirement()
        //{
        //    return _currentRequirementList;
        //}

        //public List<User> GetAllUser()
        //{
        //    return _userList;
        //}
    }
}