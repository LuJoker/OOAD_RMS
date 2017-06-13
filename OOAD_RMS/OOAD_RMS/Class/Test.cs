using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace OOAD_RMS
{
    public class Test
    {
        private string _testName;
        private string _testDescription;
        //List<Requirement> _requirements = new List<Requirement>();
        Dictionary<Requirement, bool> _requirements = new Dictionary<Requirement, bool>();

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

        public void AddRequirement(Requirement requirement, bool isComplete)
        {
            _requirements.Add(requirement, isComplete);
        }

        public Dictionary<Requirement, bool> requirementisComplete
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

        public List<Requirement> requirements
        {
            get
            {
                return _requirements.Keys.ToList();
            }
            set
            {
                _requirements.Clear();
                foreach (Requirement req in value)
                    _requirements.Add(req, false);
            }
        }
    }
}