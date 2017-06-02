using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace OOAD_RMS
{
    public class Model
    {
        BindingList<Project> _projectList;
        BindingList<Requirement> _requirementList;
        BindingList<Test> _testList;
        List<User> _userList;
        User _currentUser;
        Project _currentProject;
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

                    DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE ProjectId=@projectId", new SqlParameter[] { new SqlParameter("@projectId", (int)datarow["Id"]) });
                    foreach (DataRow reqRow in requirementTable.Rows)
                    {
                        Requirement requirement = new Requirement();
                        requirement.RequirementName = reqRow["RequirementName"].ToString();
                        requirement.RequirementDescription = reqRow["RequirementDescription"].ToString();
                        project.AddRequirement(requirement);
                    }

                    DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE ProjectId=@projectId", new SqlParameter[] { new SqlParameter("@projectId", (int)datarow["Id"]) });
                    foreach (DataRow testRow in testTable.Rows)
                    {
                        Test test = new Test();
                        test.testName = testRow["TestName"].ToString();
                        test.testDescription = testRow["TestDescription"].ToString();

                        DataTable testMapRequirementTable = SqlHelper.GetDataTableText("SELECT * FROM TestMapRequirement INNER JOIN Requirement ON TestMapRequirement.RequirementId = Requirement.Id WHERE TestMapRequirement.TestId=@testId", new SqlParameter[] { new SqlParameter("@testId", (int)testRow["Id"]) });
                        foreach (DataRow testMapReq in testMapRequirementTable.Rows)
                        {
                            Requirement requirement = project.GetRequirements().Find(r => r.RequirementName == testMapReq["RequirementName"].ToString());
                            test.AddRequirement(requirement);
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
            SqlHelper.ExecuteNonQueryText("INSERT INTO Project VALUES (@projectName,@projectDescription)", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@projectDescription", projectDescription)
            });
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@ProjectDescription", projectDescription)
            });
            SqlHelper.ExecuteNonQueryText("INSERT INTO Users (Account,Password,Title,ProjectId) VALUES (@account,@password,@title,@projectId)", new SqlParameter[] {
                new SqlParameter("@account", _currentUser.UserAccount),
                new SqlParameter("@password", _currentUser.UserPassword),
                new SqlParameter("@title",_currentUser.UserIdentity),
                new SqlParameter("@projectId",projectTable.Rows[0]["Id"].ToString())
            });

            _projectList.Add(project);
        }

        public void editProject(string projectName, string projectDescription, int index)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Project SET ProjectName = @ProjectName , ProjectDescription = @projectDescription WHERE ProjectName = @preProjectName and ProjectDescription = @preProjectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@ProjectDescription", projectDescription),
                new SqlParameter("@preProjectName", _projectList[index].ProjectName),
                new SqlParameter("@preProjectDescription", _projectList[index].ProjectDescription)
            });

            _projectList[index].ProjectName = projectName;
            _projectList[index].ProjectDescription = projectDescription;
            _projectList.ResetBindings();
        }

        public void deleteProject(int index)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName",  _projectList[index].ProjectName),
                new SqlParameter("@ProjectDescription", _projectList[index].ProjectDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM Users WHERE ProjectId = @ProjectId", new SqlParameter[] {
                new SqlParameter("@ProjectId",  projectTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Project WHERE ProjectName = @ProjectName and ProjectDescription = @ProjectDescription", new SqlParameter[] {
                new SqlParameter("@ProjectName",  projectTable.Rows[0]["ProjectName"].ToString()),
                new SqlParameter("@ProjectDescription",  projectTable.Rows[0]["ProjectDescription"].ToString())
            });
            _projectList.RemoveAt(index);
        }

        public BindingList<Requirement> getRequirementFromSelectProject(int projectIndex)
        {
            if (projectIndex > -1)
            {
                _currentProject = _projectList[projectIndex];
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
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName",  _currentProject.ProjectName),
                new SqlParameter("@ProjectDescription", _currentProject.ProjectDescription)
            });
            Requirement requirement = new Requirement();
            requirement.RequirementName = requirementName;
            requirement.RequirementDescription = requirementDescription;
            SqlHelper.ExecuteNonQueryText("INSERT INTO Requirement VALUES (@RequirementName,@RequirementDescription,@projectId)", new SqlParameter[] {
                new SqlParameter("@RequirementName", requirementName),
                new SqlParameter("@RequirementDescription", requirementDescription),
                new SqlParameter("@projectId", (int)projectTable.Rows[0]["Id"])
            });
            _requirementList.Add(requirement);
        }

        public void editRequirement(string requirementName, string requirementDescription, int index)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Requirement SET RequirementName = @requirementName , RequirementDescription = @requirementDescription WHERE RequirementName = @preRequirementName and RequirementDescription = @preRequirementDescription", new SqlParameter[] {
                new SqlParameter("@requirementName", requirementName),
                new SqlParameter("@requirementDescription", requirementDescription),
                new SqlParameter("@preRequirementName", _requirementList[index].RequirementName),
                new SqlParameter("@preRequirementDescription", _requirementList[index].RequirementDescription)
            });
            _requirementList[index].RequirementName = requirementName;
            _requirementList[index].RequirementDescription = requirementDescription;
            _requirementList.ResetBindings();
        }

        public void deleteRequirement(int index)
        {
            DataTable RequirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE Requirementname = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
                new SqlParameter("@requirementName",  _requirementList[index].RequirementName),
                new SqlParameter("@requirementDescription",_requirementList[index].RequirementDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM TestMapRequirement WHERE RequirementId = @requirementId", new SqlParameter[] {
                new SqlParameter("@requirementId",  RequirementTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Requirement WHERE Id = @requirementId", new SqlParameter[] {
                new SqlParameter("@requirementId",  RequirementTable.Rows[0]["Id"])
            });
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
                _currentUser = user[0];
                setProject(user[0]);
                return true;
            }
            else
                return false;
        }


        public void registerAccount(string account, string password, string Identity)
        {
            DataTable userTable = SqlHelper.GetDataTableText("SELECT IIF(not EXISTS(SELECT* from Users WHERE Account = @account), 'TRUE', 'FALSE' ) as Result", new SqlParameter[] { new SqlParameter("@account", account) });

            String NotExist=userTable.Rows[0]["Result"].ToString();

            if (NotExist == "TRUE")
            {
                SqlHelper.ExecuteNonQueryText("INSERT INTO Users (Account,Password,Title) VALUES (@account,@password,@title)", new SqlParameter[] {
                new SqlParameter("@account", account),
                new SqlParameter("@password", password),
                new SqlParameter("@title",Identity)
            });
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
    }
}