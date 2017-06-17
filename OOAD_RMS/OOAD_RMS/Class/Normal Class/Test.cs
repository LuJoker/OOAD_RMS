using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;

namespace OOAD_RMS
{
    public class Test
    {
        private Project _project;
        private string _testName;
        private string _testDescription;

        public string TestName
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

        public string TestDescription
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