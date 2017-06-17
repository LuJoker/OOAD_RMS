using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class UserMapProject
    {
        Tuple<User, Project> _userMapProject;

        public UserMapProject(User user, Project project)
        {
            _userMapProject = new Tuple<User, Project>(user, project);
        }

        public User User
        {
            get
            {
                return _userMapProject.Item1;
            }
        }

        public Project Project
        {
            get
            {
                return _userMapProject.Item2;
            }
        }
    }
}
