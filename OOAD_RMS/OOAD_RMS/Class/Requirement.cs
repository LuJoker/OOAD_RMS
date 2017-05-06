using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_RMS
{
    public class Requirement
    {
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
    }
}