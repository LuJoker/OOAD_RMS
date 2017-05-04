using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OOAD_RMS
{
    public class Model
    {
        BindingList<Project> _projectList;
        BindingList<Requirement> _requirementList;
        BindingList<Test> _testList;

        public void addProject(string projectName, string projectDescription)
        {
            Project project = new Project();
            project.ProjectName = projectName;
            project.ProjectDescription = projectDescription;
            Console.WriteLine(project.ProjectName);
            Console.WriteLine(project.ProjectDescription);
            Console.WriteLine(_projectList.Count);
            _projectList.Add(project);
            Console.WriteLine(_projectList.Count);
        }

        public void setProject(User user)
        {
            _projectList = new BindingList<Project>(user.GetInProjects());
        }

        public BindingList<Project> GetProjects()
        {
            return _projectList;
        }
    }
}
