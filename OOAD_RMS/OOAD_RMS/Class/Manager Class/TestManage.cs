using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class TestManage
    {
        List<TestMapRequirement> _tests;

        public TestManage()
        {
            _tests = new List<TestMapRequirement>();
        }

        public void addTest(TestMapRequirement test)
        {
            _tests.Add(test);
        }

        public void addTest(Test test, List<Requirement> requirements)
        {
            foreach (Requirement req in requirements)
            {
                _tests.Add(new TestMapRequirement(test, req, false));
            }
        }

        public void editTest(Test test, List<Requirement> requirements)
        {
            _tests.RemoveAll(c => c.Test == test);
            foreach (Requirement req in requirements)
            {
                _tests.Add(new TestMapRequirement(test, req, false));
            }
        }

        public void deleteTest(Test test)
        {
            _tests.RemoveAll(c => c.Test == test);
        }

        public bool getTestMapRequirementIsComplete(Test test, Requirement req)
        {
            return _tests.Find(c => c.Test == test && c.Requirement == req).IsComplete;
        }

        public void updateTestMapRequirementIsComplete(Test test, Requirement req, bool isComplete)
        {
            _tests.Find(c => c.Test == test && c.Requirement == req).IsComplete = isComplete;
        }

        public List<Requirement> GetTestMapRequirements(Test test, Project project)
        {
            return _tests.FindAll(c => c.Requirement.Project == project && c.Test.Project == project && c.Test == test).Select(s => s.Requirement).ToList();
        }

        public List<Test> GetTests(Project project)
        {
            return _tests.Select(s => s.Test).GroupBy(g => g).Select(s => s.Key).OrderBy(y => y.TestName).ToList().FindAll(c => c.Project == project);
        }

        //這個暫時不用測
        public List<TestMapRequirement> GetTestMapRequirement()
        {
            return _tests;
        }
    }
}
