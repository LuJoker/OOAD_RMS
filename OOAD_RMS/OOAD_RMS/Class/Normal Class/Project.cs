using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public class Project
    {
        private string _projectName;
        private string _projectDescription;

        public string ProjectName {
            get {
                return _projectName;
            }
            set {
                _projectName = value;
            }    
        }

        public string ProjectDescription
        {
            get
            {
                return _projectDescription;
            }
            set
            {
                _projectDescription = value;
            }
        }
    }
}