﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OOAD_RMS
{
    public abstract class DBManager
    {
        private static User _currentUser;
        private static Project _currentProject;

        #region Init、SetCurrentUser、SetCurrentProject

        public static User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }

        public static Project CurrentProject
        {
            get
            {
                return _currentProject;
            }
            set
            {
                _currentProject = value;
            }
        }
        #endregion

        #region Get Method
        public static DataTable GetUsers()
        {
            DataTable userTable = SqlHelper.GetDataTableText("SELECT Account,Password,Title FROM Users", new SqlParameter[] {});
            return userTable;
        }

        public static DataTable GetUsersIsRegister(string account)
        {
            DataTable userTable = SqlHelper.GetDataTableText("SELECT IIF(not EXISTS(SELECT* from Users WHERE Account = @account), 'TRUE', 'FALSE' ) as Result", new SqlParameter[] {
                new SqlParameter("@account", account)
            });
            return userTable;
        }

        public static DataTable GetProjects()
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project", new SqlParameter[] {
            });
            return projectTable;
        }

        public static DataTable GetProjectByUserAccount(string account)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT ProjectName,ProjectDescription,Project.Id FROM Users INNER JOIN UserMapProject ON Users.Id=UserMapProject.UserId INNER JOIN Project ON Project.Id=UserMapProject.ProjectId WHERE Users.Account=@account", new SqlParameter[] {
                new SqlParameter("@account", account)
            });
            return projectTable;
        }

        public static DataTable GetRequirements()
        {
            DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement", new SqlParameter[] {
            });
            return requirementTable;
        }

        public static DataTable GetRequirementByProjectId(int projectId)
        {
            DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE ProjectId=@projectId", new SqlParameter[] {
                new SqlParameter("@projectId", projectId)
            });
            return requirementTable;
        }

        public static DataTable GetTests()
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test", new SqlParameter[] {
            });
            return testTable;
        }

        public static DataTable GetTestByProjectId(int projectId)
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE ProjectId=@projectId", new SqlParameter[] {
                new SqlParameter("@projectId", projectId)
            });
            return testTable;
        }

        public static DataTable GetTestMapRequirementByTestId(int testId)
        {
            DataTable testMapRequirementTable = SqlHelper.GetDataTableText("SELECT * FROM TestMapRequirement INNER JOIN Requirement ON TestMapRequirement.RequirementId = Requirement.Id WHERE TestMapRequirement.TestId=@testId", new SqlParameter[] {
                new SqlParameter("@testId", testId)
            });
            return testMapRequirementTable;
        }

        #endregion

        #region Add Method
        public static void AddUser(string account, string password, string identity)
        {
            SqlHelper.ExecuteNonQueryText("INSERT INTO Users (Account,Password,Title) VALUES (@account,@password,@title)", new SqlParameter[] {
                new SqlParameter("@account", account),
                new SqlParameter("@password", password),
                new SqlParameter("@title",identity)
            });
        }

        public static void AddProject(string projectName, string projectDescription,List<User>selectedUserList)
        {
            SqlHelper.ExecuteNonQueryText("INSERT INTO Project VALUES (@projectName,@projectDescription)", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@projectDescription", projectDescription)
            });
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@ProjectDescription", projectDescription)
            });
            
            foreach (User u in selectedUserList)
            {
                DataTable userTable = SqlHelper.GetDataTableText("SELECT * FROM Users WHERE Account = @account and Password = @password and Title=@title", new SqlParameter[] {
                new SqlParameter("@account", u.UserAccount),
                new SqlParameter("@password", u.UserPassword),
                new SqlParameter("@title", u.UserIdentity)
                });

                SqlHelper.ExecuteNonQueryText("INSERT INTO UserMapProject VALUES (@projectId,@userId)", new SqlParameter[] {
                new SqlParameter("@projectId", projectTable.Rows[0]["Id"].ToString()),
                new SqlParameter("@userId", userTable.Rows[0]["Id"].ToString())
                });
            }
            
        }

        public static void AddRequirement(string requirementName, string requirementDescription)
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

        public static void AddTest(string testName, string testDescription, List<Requirement> requirements)
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
        public static void EditProject(string projectNameOrigin, string projectDescriptionOrigin, string projectNameEdit, string projectDescriptionEdit,List<User>selectedUserList)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName AND ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectNameOrigin),
                new SqlParameter("@ProjectDescription", projectDescriptionOrigin)
            });

            SqlHelper.ExecuteNonQueryText("DELETE FROM UserMapProject WHERE ProjectId = @projectId", new SqlParameter[] {
                new SqlParameter("@projectId", projectTable.Rows[0]["Id"].ToString())
            });

            foreach (User u in selectedUserList)
            {
                DataTable userTable = SqlHelper.GetDataTableText("SELECT * FROM Users WHERE Account = @account and Password = @password and Title=@title", new SqlParameter[] {
                new SqlParameter("@account", u.UserAccount),
                new SqlParameter("@password", u.UserPassword),
                new SqlParameter("@title", u.UserIdentity)
                });

                SqlHelper.ExecuteNonQueryText("INSERT INTO UserMapProject VALUES (@projectId,@userId)", new SqlParameter[] {
                new SqlParameter("@projectId", projectTable.Rows[0]["Id"].ToString()),
                new SqlParameter("@userId", userTable.Rows[0]["Id"].ToString())
                });
            }

            SqlHelper.ExecuteNonQueryText("UPDATE Project SET ProjectName = @ProjectName , ProjectDescription = @projectDescription WHERE ProjectName = @preProjectName and ProjectDescription = @preProjectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectNameEdit),
                new SqlParameter("@ProjectDescription", projectDescriptionEdit),
                new SqlParameter("@preProjectName", projectNameOrigin),
                new SqlParameter("@preProjectDescription", projectDescriptionOrigin)
            });
        }

        public static void EditRequirement(string requirementNameOrigin, string requirementDescriptionOrigin, string requirementNameEdit, string requirementDescriptionEdit)
        {
            SqlHelper.ExecuteNonQueryText("UPDATE Requirement SET RequirementName = @requirementName , RequirementDescription = @requirementDescription WHERE RequirementName = @preRequirementName and RequirementDescription = @preRequirementDescription", new SqlParameter[] {
                new SqlParameter("@requirementName", requirementNameEdit),
                new SqlParameter("@requirementDescription", requirementDescriptionEdit),
                new SqlParameter("@preRequirementName", requirementNameOrigin),
                new SqlParameter("@preRequirementDescription", requirementDescriptionOrigin)
            });
        }

        public static void EditTest(string testNameOrigin, string testDescriptionOrigin, string testNameEdit, string testDescriptionEdit, List<Requirement> requirementsEdit)
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

        public static void EditTestIsComplete(Test test)
        {
            DataTable testTable = SqlHelper.GetDataTableText("SELECT * FROM Test WHERE TestName = @testName and TestDescription = @testDescription", new SqlParameter[] {
                new SqlParameter("@testName",  test.TestName),
                new SqlParameter("@testDescription", test.TestDescription)
            });
            //foreach (Requirement req in test.requirementisComplete.Keys)
            //{
            //    DataTable requirementTable = SqlHelper.GetDataTableText("SELECT * FROM Requirement WHERE RequirementName = @requirementName and RequirementDescription = @requirementDescription", new SqlParameter[] {
            //        new SqlParameter("@requirementName", req.RequirementName),
            //        new SqlParameter("@requirementDescription", req.RequirementDescription)
            //    });
            //    SqlHelper.ExecuteNonQueryText("UPDATE TestMapRequirement SET IsCompleted=@isCompleted WHERE requirementId=@requirementId AND testId=@testId", new SqlParameter[] {
            //        new SqlParameter("@requirementId", (int)requirementTable.Rows[0]["Id"]),
            //        new SqlParameter("@testId", (int)testTable.Rows[0]["Id"]),
            //        new SqlParameter("@isCompleted", test.requirementisComplete[req] ? "1" : "0")
            //    });
            //}
        }
        #endregion

        #region Delete Method
        public static void DeleteProject(string projectName, string projectDescription)
        {
            DataTable projectTable = SqlHelper.GetDataTableText("SELECT * FROM Project WHERE ProjectName = @projectName and ProjectDescription = @projectDescription", new SqlParameter[] {
                new SqlParameter("@projectName", projectName),
                new SqlParameter("@ProjectDescription", projectDescription)
            });
            SqlHelper.GetDataTableText("DELETE FROM UserMapProject WHERE ProjectId = @ProjectId", new SqlParameter[] {
                new SqlParameter("@ProjectId", projectTable.Rows[0]["Id"])
            });
            SqlHelper.GetDataTableText("DELETE FROM Project WHERE ProjectName = @ProjectName and ProjectDescription = @ProjectDescription", new SqlParameter[] {
                new SqlParameter("@ProjectName", projectTable.Rows[0]["ProjectName"].ToString()),
                new SqlParameter("@ProjectDescription", projectTable.Rows[0]["ProjectDescription"].ToString())
            });
        }

        public static void DeleteRequirement(string requirementName, string requirementDescription)
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

        public static void DeleteTest(string testName, string testDescription)
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
