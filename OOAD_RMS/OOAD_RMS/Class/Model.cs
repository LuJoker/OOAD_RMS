using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            requirement2.RequirementName = "Re3";
            requirement2.RequirementDescription = "Re3 123";
            project3.AddRequirement(requirement2);
            Requirement requirement3 = new Requirement();
            requirement3.RequirementName = "Re4";
            requirement3.RequirementDescription = "Re4 456";
            project3.AddRequirement(requirement3);
            Requirement requirement4 = new Requirement();
            requirement4.RequirementName = "Re5";
            requirement4.RequirementDescription = "Re5 789";
            project3.AddRequirement(requirement4);
            Requirement requirement5 = new Requirement();
            requirement5.RequirementName = "Re6";
            requirement5.RequirementDescription = "Re6 012";
            project3.AddRequirement(requirement5);
            Test test3 = new Test();
            test3.testName = "Te3";
            test3.testDescription = "Te3 123";
            test3.AddRequirement(requirement3);
            test3.AddRequirement(requirement5);
            project3.AddTest(test3);
            Test test4 = new Test();
            test4.testName = "Te4";
            test4.testDescription = "Te4 456";
            test4.AddRequirement(requirement4);
            test4.AddRequirement(requirement5);
            project3.AddTest(test4);

            User user1 = new User();
            user1.UserAccount = "admin";
            user1.UserPassword = "admin";
            user1.UserIdentity = "Manager";
            user1.addProject(project1);
            user1.addProject(project2);
            user1.addProject(project3);

            _userList.Add(user1);
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