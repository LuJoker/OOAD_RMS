using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class UserMapProject
    {
        User _user;
        Project _project;

        public UserMapProject(User user, Project project)
        {
            _user = user;
            _project = project;
        }

        public User User
        {
            get {
                return _user;
            }
            set {
                _user = value;
            }
        }

        public Project Project
        {
            get {
                return _project;
            }
            set {
                _project = value;
            }
        }
    }
}
