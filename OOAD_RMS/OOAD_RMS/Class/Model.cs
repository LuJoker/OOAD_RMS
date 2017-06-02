using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
namespace OOAD_RMS
{
    public class Model
    {
        BindingList<Project> _projectList;
        BindingList<Requirement> _requirementList;
        BindingList<Test> _testList;
        List<User> _userList;
        public Model()
        {
            _userList = new List<User>();

            DataTable userTable = SqlHelper.GetDataTableText("SELECT Account,Password,Title FROM Users GROUP BY Account,Password,Title", new SqlParameter[] { });

            foreach (DataRow userDataRow in userTable.Rows)
            {
                User user = new User();
                user.UserAccount = userDataRow["Account"].ToString();
                user.UserPassword = userDataRow["Password"].ToString();
                user.UserIdentity = userDataRow["Title"].ToString();

                DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Users INNER JOIN Project ON Users.ProjectId=Project.Id WHERE Users.Account=@account", new SqlParameter[] { new SqlParameter("@account", user.UserAccount) });

                foreach (DataRow datarow in projectTable.Rows)
                {
                    Project project = new Project();
                    project.ProjectName = datarow["ProjectName"].ToString();
                    project.ProjectDescription = datarow["ProjectDescription"].ToString();
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
            _projectList.Add(project);
        }

        public void editProject(string projectName, string projectDesciption,int index)
        {
            _projectList[index].ProjectName = projectName;
            _projectList[index].ProjectDescription = projectDesciption;
            _projectList.ResetBindings();
        }

        public void deleteProject(int index)
        {
            _projectList.RemoveAt(index);
        }

        public BindingList<Requirement> getRequirementFromSelectProject(int projectIndex)
        {
            if (projectIndex > -1) 
                _requirementList = new BindingList<Requirement>(_projectList[projectIndex].GetRequirements());
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
            grid.Rows.Clear();
            grid.Columns.Clear();

            DataGridViewTextBoxColumn firstRequirementColumn = new DataGridViewTextBoxColumn();
            firstRequirementColumn.HeaderText = "";
            grid.Columns.Add(firstRequirementColumn);
            foreach (Requirement re in _requirementList)
            {
                DataGridViewTextBoxColumn requirementColumn = new DataGridViewTextBoxColumn();
                grid.Columns.Add(requirementColumn);
                requirementColumn.HeaderText = re.RequirementName;
            }

            foreach (Test te in _testList)
            {
                grid.Rows.Add(te.testName);
            }

            for (int i = 0; i < _testList.Count; i++)
            {
                for (int j = 0; j < _requirementList.Count; j++)
                {
                    List<Requirement> requirementInTest = _testList[i].requirements;
                    if (requirementInTest.Contains(_requirementList[j]))
                        grid.Rows[i].Cells[j + 1].Value = "O";
                }
            }
        }

        public void addRequirement(string requirementName, string requirementDescription)
        {
            Requirement requirement = new Requirement();
            requirement.RequirementName = requirementName;
            requirement.RequirementDescription = requirementDescription;
            _requirementList.Add(requirement);
        }

        public void editRequirement(string requirementName, string requirementDescription, int index)
        {
            _requirementList[index].RequirementName = requirementName;
            _requirementList[index].RequirementDescription = requirementDescription;
            _requirementList.ResetBindings();
        }

        public void deleteRequirement(int index)
        {
            foreach (Test test in _testList)
                test.requirements.Remove(_requirementList[index]);
            _requirementList.RemoveAt(index);
        }

        public void addTest(Test test)
        {
            _testList.Add(test);
        }

        public void editTest()
        {
            _testList.ResetBindings();
        }

        public void deleteTest(int index)
        {
            _testList.RemoveAt(index);
        }
        public bool LoginCheck(string account, string password)
        {
            List<User> user = _userList.FindAll(x => (x.UserAccount == account) && (x.UserPassword == password));
            if (user.Count == 1)
            {
                setProject(user[0]);
                return true;
            }
            else
                return false;
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
    }
}