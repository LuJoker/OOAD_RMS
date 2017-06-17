using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class ProjectManage
    {
        List<UserMapProject> _projects;
        public ProjectManage()
        {
            _projects = new List<UserMapProject>();
        }

        public void addProject(User user, Project project)
        {
            _projects.Add(new UserMapProject(user, project));
        }

        public void addProject(Project project, List<User> users)
        {
            foreach (User user in users)
            {
                _projects.Add(new UserMapProject(user, project));
            }
        }

        public void editProject(Project project, List<User> users)
        {
            _projects.RemoveAll(c => c.Project == project);
            foreach (User user in users)
            {
                _projects.Add(new UserMapProject(user, project));
            }
        }

        public void deleteProject(Project project)
        {
            _projects.RemoveAll(c => c.Project == project);
        }

        public List<User> GetProjectMapUsers(Project project)
        {
            return _projects.FindAll(c => c.Project == project).Select(s => s.User).ToList();
        }

        public List<Project> GetProjects(User user)
        {
            return _projects.OrderBy(y => y.Project.ProjectName).ToList().FindAll(c => c.User == user).Select(t => t.Project).ToList();
        }
    }
}
