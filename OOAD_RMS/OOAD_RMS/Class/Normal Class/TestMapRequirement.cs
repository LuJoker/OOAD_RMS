using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class TestMapRequirement
    {
        Test _test;
        Requirement _requirement;
        bool _isComplete;

        public TestMapRequirement(Test test, Requirement req, bool isComplete)
        {
            _test = test;
            _requirement = req;
            _isComplete = isComplete;
        }

        public Test Test
        {
            get {
                return _test;
            }
            set {
                _test = value;
            }
        }

        public Requirement Requirement
        {
            get {
                return _requirement;
            }
            set {
                _requirement = value;
            }
        }

        public bool IsComplete
        {
            get {
                return _isComplete;
            }
            set {
                _isComplete = value;
            }
        }
    }
}
