using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_RMS
{
   public class Test
    {
        private string _testName;
        private string _testDescription;
        private List<Requirement> _requirement = new List<Requirement>();

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


    }
}
