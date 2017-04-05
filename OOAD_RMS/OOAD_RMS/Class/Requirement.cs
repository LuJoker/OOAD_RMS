using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class Requirement
    {
        private string _requirementName;
        private string _requirementDescription;
        private List<Test> _tests = new List<Test>();

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
