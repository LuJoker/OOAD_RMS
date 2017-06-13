using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OOAD_RMS
{
    public class DBManager
    {
        private User _currentUser;
        private Project _currentProject;

        #region Init、SetCurrentUser、SetCurrentProject
        public DBManager()
        {

        }

        public void SetCurrentUser(User user)
        {
            _currentUser = user;
        }

        public void SetCurrentProject(Project project)
        {
            _currentProject = project;
        }
        #endregion

        #region Get Method
        public DataTable GetUsers()
        {
            DataTable userTable = SqlHelper.GetDataTableText("SELECT Account,Password,Title FROM Users GROUP BY Account,Password,Title", new SqlParameter[] {});
            return userTable;
        }

        public DataTable GetUsersIsRegister(string account)
        {
            DataTable userTable = SqlHelper.GetDataTableText("SELECT IIF(not EXISTS(SELECT* from Users WHERE Account = @account), 'TRUE', 'FALSE' ) as Result", new SqlParameter[] {
                new SqlParameter("@account", account)
            });
            return userTable;
        }

        public DataTable GetProjectByUserAccount(string account)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Users INNER JOIN Project ON Users.ProjectId=Project.Id WHERE Users.Account=@account", new SqlParameter[] {
                new SqlParameter("@account", account)
            });
            return projectTable;
        }

        public DataTable GetRequirementByProjectId(int projectId)
        {
            DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE ProjectId=@projectId", new SqlParameter[] {
                new SqlParameter("@projectId", projectId)
            });
            return requirementTable;
        }

        public DataTable GetTestByProjectId(int projectId)
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE ProjectId=@projectId", new SqlParameter[] {
                new SqlParameter("@projectId", projectId)
            });
            return testTable;
        }

        public DataTable GetTestMapRequirementByTestId(int testId)
        {
            DataTable testMapRequirementTable = SqlHelper.GetDataTableText("SELECT * FROM TestMapRequirement INNER JOIN Requirement ON TestMapRequirement.RequirementId = Requirement.Id WHERE TestMapRequirement.TestId=@testId", new SqlParameter[] {
                new SqlParameter("@testId", testId)
            });
            return testMapRequirementTable;
        }

        #endregion

        #region Add Method
        public void AddUser(string account, string password, string identity)
        {
            SqlHelper.ExecuteNonQueryText("INSERT INTO Users (Account,Password,Title) VALUES (@account,@password,@title)", new SqlParameter[] {
                new SqlParameter("@account", account),
                new SqlParameter("@password", password),
                new SqlParameter("@title",identity)
            });
        }

        public void AddProject(string projectName, string projectDescription)
        {
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
                new SqlParameter("@title", _currentUser.UserIdentity),
                new SqlParameter("@projectId", projectTable.Rows[0]["Id"].ToString())
            });
        }

        public void AddRequirement(string requirementName, string requirementDescription)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName",  _currentProject.ProjectName),
                new SqlParameter("@ProjectDescription", _currentProject.ProjectDescription)
            });
            SqlHelper.ExecuteNonQueryText("INSERT INTO Requirement VALUES (@RequirementName,@RequirementDescription,@projectId)", new SqlParameter[] {
                new SqlParameter("@RequirementName", requirementName),
                new SqlParameter("@RequirementDescription", requirementDescription),
                new SqlParameter("@projectId", (int)projectTable.Rows[0]["Id"])
            });
        }

        public void AddTest(string testName, string testDescription, List<Requirement> requirements)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName",  _currentProject.ProjectName),
                new SqlParameter("@projectDescription", _currentProject.ProjectDescription)
            });
            SqlHelper.ExecuteNonQueryText("INSERT INTO Test VALUES (@testName,@testDescription,@projectId)", new SqlParameter[] {
                new SqlParameter("@testName", testName),
                new SqlParameter("@testDescription", testDescription),
                new SqlParameter("@projectId", (int)projectTable.Rows[0]["Id"])
            });
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE TestName = @testName and TestDescription = @testDescription", new SqlParameter[] {
                new SqlParameter("@testName",  testName),
                new SqlParameter("@testDescription", testDescription)
            });
            foreach (Requirement req in requirements)
            {
                DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE RequirementName = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
                    new SqlParameter("@requirementName", req.RequirementName),
                    new SqlParameter("@requirementDescription", req.RequirementDescription)
                });
                SqlHelper.ExecuteNonQueryText("INSERT INTO TestMapRequirement VALUES (@requirementId,@testId,@isCompleted)", new SqlParameter[] {
                    new SqlParameter("@requirementId", (int)requirementTable.Rows[0]["Id"]),
                    new SqlParameter("@testId", (int)testTable.Rows[0]["Id"]),
                    new SqlParameter("@isCompleted", "0")
                });
            }
        }
        #endregion

        #region Edit Method
        public void EditProject(string projectNameOrigin, string projectDescriptionOrigin, string projectNameEdit, string projectDescriptionEdit)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Project SET ProjectName = @ProjectName , ProjectDescription = @projectDescription WHERE ProjectName = @preProjectName and ProjectDescription = @preProjectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectNameEdit),
                new SqlParameter("@ProjectDescription", projectDescriptionEdit),
                new SqlParameter("@preProjectName", projectNameOrigin),
                new SqlParameter("@preProjectDescription", projectDescriptionOrigin)
            });
        }

        public void EditRequirement(string requirementNameOrigin, string requirementDescriptionOrigin, string requirementNameEdit, string requirementDescriptionEdit)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Requirement SET RequirementName = @requirementName , RequirementDescription = @requirementDescription WHERE RequirementName = @preRequirementName and RequirementDescription = @preRequirementDescription", new SqlParameter[] {
                new SqlParameter("@requirementName", requirementNameEdit),
                new SqlParameter("@requirementDescription", requirementDescriptionEdit),
                new SqlParameter("@preRequirementName", requirementNameOrigin),
                new SqlParameter("@preRequirementDescription", requirementDescriptionOrigin)
            });
        }

        public void EditTest(string testNameOrigin, string testDescriptionOrigin, string testNameEdit, string testDescriptionEdit, List<Requirement> requirementsEdit)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Test SET TestName = @testName , TestDescription = @testDescription WHERE TestName = @preTestName and TestDescription = @preTestDescription", new SqlParameter[] {
                new SqlParameter("@testName", testNameEdit),
                new SqlParameter("@testDescription", testDescriptionEdit),
                new SqlParameter("@preTestName", testNameOrigin),
                new SqlParameter("@preTestDescription", testDescriptionOrigin)
            });
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE TestName = @testName and TestDescription = @testDescription", new SqlParameter[] {
                new SqlParameter("@testName",  testNameEdit),
                new SqlParameter("@testDescription", testDescriptionEdit)
            });
            SqlHelper.GetDataTableText("DELETE FROM TestMapRequirement WHERE TestId = @testId", new SqlParameter[] {
                new SqlParameter("@testId", testTable.Rows[0]["Id"])
            });
            foreach (Requirement req in requirementsEdit)
            {
                DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE RequirementName = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
                    new SqlParameter("@requirementName", req.RequirementName),
                    new SqlParameter("@requirementDescription", req.RequirementDescription)
                });
                SqlHelper.ExecuteNonQueryText("INSERT INTO TestMapRequirement VALUES (@requirementId,@testId,@isCompleted)", new SqlParameter[] {
                    new SqlParameter("@requirementId", (int)requirementTable.Rows[0]["Id"]),
                    new SqlParameter("@testId", (int)testTable.Rows[0]["Id"]),
                    new SqlParameter("@isCompleted", "0")
                });
            }
        }

        public void EditTestIsComplete(Test test)
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE TestName = @testName and TestDescription = @testDescription", new SqlParameter[] {
                new SqlParameter("@testName",  test.testName),
                new SqlParameter("@testDescription", test.testDescription)
            });
            foreach (Requirement req in test.requirementisComplete.Keys)
            {
                DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE RequirementName = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
                    new SqlParameter("@requirementName", req.RequirementName),
                    new SqlParameter("@requirementDescription", req.RequirementDescription)
                });
                SqlHelper.ExecuteNonQueryText("UPDATE TestMapRequirement SET IsCompleted=@isCompleted WHERE requirementId=@requirementId AND testId=@testId", new SqlParameter[] {
                    new SqlParameter("@requirementId", (int)requirementTable.Rows[0]["Id"]),
                    new SqlParameter("@testId", (int)testTable.Rows[0]["Id"]),
                    new SqlParameter("@isCompleted", test.requirementisComplete[req] ? "1" : "0")
                });
            }
        }
        #endregion

        #region Delete Method
        public void DeleteProject(string projectName, string projectDescription)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@ProjectDescription", projectDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM Users WHERE ProjectId = @ProjectId", new SqlParameter[] {
                new SqlParameter("@ProjectId", projectTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Project WHERE ProjectName = @ProjectName and ProjectDescription = @ProjectDescription", new SqlParameter[] {
                new SqlParameter("@ProjectName", projectTable.Rows[0]["ProjectName"].ToString()),
                new SqlParameter("@ProjectDescription", projectTable.Rows[0]["ProjectDescription"].ToString())
            });
        }

        public void DeleteRequirement(string requirementName, string requirementDescription)
        {
            DataTable RequirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE Requirementname = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
                new SqlParameter("@requirementName", requirementName),
                new SqlParameter("@requirementDescription", requirementDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM TestMapRequirement WHERE RequirementId = @requirementId", new SqlParameter[] {
                new SqlParameter("@requirementId", RequirementTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Requirement WHERE Id = @requirementId", new SqlParameter[] {
                new SqlParameter("@requirementId", RequirementTable.Rows[0]["Id"])
            });
        }

        public void DeleteTest(string testName, string testDescription)
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE TestName = @testName and TestDescription = @testDescription", new SqlParameter[] {
                new SqlParameter("@testName",  testName),
                new SqlParameter("@testDescription", testDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM TestMapRequirement WHERE TestId = @testId", new SqlParameter[] {
                new SqlParameter("@testId", testTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Test WHERE Id = @testId", new SqlParameter[] {
                new SqlParameter("@testId", testTable.Rows[0]["Id"])
            });
        }
        #endregion
    }
}
