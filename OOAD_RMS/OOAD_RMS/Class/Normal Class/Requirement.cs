using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class Requirement
    {
        private Project _project;
        private string _requirementName;
        private string _requirementDescription;

        public string RequirementName
        {
            get
            {
                return _requirementName;
            }
            set
            {
                _requirementName = value;
            }
        }

        public string RequirementDescription
        {
            get
            {
                return _requirementDescription;
            }
            set
            {
                _requirementDescription = value;
            }
        }

        public Project Project
        {
            get
            {
                return _project;
            }
            set
            {
                _project = value;
            }
        }
    }
}