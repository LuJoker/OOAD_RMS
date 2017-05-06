using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OOAD_RMS
{
   public class Test
    {
        private string _testName;
        private string _testDescription;
        private BindingList<Requirement> _requirements = new BindingList<Requirement>();

        public string testName
        {
            get
            {
                return _testName;
            }
            set
            {
                _testName = value;
            }
        }

        public string testDescription
        {
            get
            {
                return _testDescription;
            }
            set
            {
                _testDescription = value;
            }
        }

        public void AddRequirement(Requirement requirement)
        {
            _requirements.Add(requirement);
        }

        public BindingList<Requirement> requirements
        {
            get
            {
                return _requirements;
            }
            set
            {
                _requirements = value;
            }
        }
    }
}