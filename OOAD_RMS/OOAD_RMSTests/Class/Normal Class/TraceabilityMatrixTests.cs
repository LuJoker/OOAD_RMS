using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOAD_RMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_RMS.Tests
{
    [TestClass()]
    public class TraceabilityMatrixTests
    {
        DataGridView _grid;
        Requirement _rq1,_rq2,_rq3;
        List<TestMapRequirement> _tmp;
        List<Requirement> _rq;
        //TestMapRequirement _tmp1,_tmp2,_tmp3;
        TraceabilityMatrix _tm;
        Test _test1ForRQ1, _test2ForRQ1, _test1ForRQ2, _test2ForRQ2, _test3ForRQ2, _test1ForRQ3;
        Project _pro1;

        [TestInitialize()]
        public void TraceabilityMatrixTestsInit()
        {
            _pro1 = new Project();
            _pro1.ProjectName = "pn";
            _pro1.ProjectDescription = "pd";

            _rq1 = new Requirement();
            _rq1.RequirementDescription = "rd1";
            _rq1.RequirementName = "rn1";
            _rq1.Project = _pro1;

            _rq2 = new Requirement();
            _rq2.RequirementDescription = "rd2";
            _rq2.RequirementName = "rn2";
            _rq2.Project = _pro1;

            _rq3 = new Requirement();
            _rq3.RequirementDescription = "rd3";
            _rq3.RequirementName = "rn3";
            _rq3.Project = _pro1;

            _rq = new List<Requirement>();
            _rq.Add(_rq1);
            _rq.Add(_rq2);
            _rq.Add(_rq3);

            _test1ForRQ1 = new Test();
            _test1ForRQ1.TestName = "t1RQ1tn";
            _test1ForRQ1.TestDescription = "t1RQ1td";
            _test1ForRQ1.Project = _pro1;

            _test2ForRQ1 = new Test();
            _test2ForRQ1.TestName = "t2RQ1tn";
            _test2ForRQ1.TestDescription = "t2RQ1td";
            _test2ForRQ1.Project = _pro1;

            _test1ForRQ2 = new Test();
            _test1ForRQ2.TestName = "t1RQ2tn";
            _test1ForRQ2.TestDescription = "t1RQ2td";
            _test1ForRQ2.Project = _pro1;

            _test2ForRQ2 = new Test();
            _test2ForRQ2.TestName = "t2RQ2tn";
            _test2ForRQ2.TestDescription = "t2RQ2td";
            _test2ForRQ2.Project = _pro1;

            _test3ForRQ2 = new Test();
            _test3ForRQ2.TestName = "t3RQ2tn";
            _test3ForRQ2.TestDescription = "t3RQ2td";
            _test3ForRQ2.Project = _pro1;

            _test1ForRQ3 = new Test();
            _test1ForRQ3.TestName = "t1RQ3tn";
            _test1ForRQ3.TestDescription = "t1RQ3td";
            _test1ForRQ3.Project = _pro1;

            _tmp = new List<TestMapRequirement>();
            _tmp.Add(new TestMapRequirement(_test1ForRQ1,_rq1,false));
            _tmp.Add(new TestMapRequirement(_test2ForRQ1, _rq1, false));
            _tmp.Add(new TestMapRequirement(_test1ForRQ2, _rq2, false));
            _tmp.Add(new TestMapRequirement(_test2ForRQ2, _rq2, false));
            _tmp.Add(new TestMapRequirement(_test3ForRQ2, _rq2, false));
            _tmp.Add(new TestMapRequirement(_test1ForRQ3, _rq3, false));

            _tm = new TraceabilityMatrix(_rq, _tmp);

            _grid = new DataGridView();
        }

        [TestMethod()]
        public void SetTraceAbilityMatrixTest()
        {
            _tmp[0].IsComplete = true;
            _tm.SetTraceAbilityMatrix(_grid);       
            Console.WriteLine(_grid.Rows[0].Cells[1].Value);
            Assert.AreEqual("✓", _grid.Rows[0].Cells[1].Value);
            Assert.AreEqual("O", _grid.Rows[1].Cells[2].Value);
            Assert.AreEqual("O", _grid.Rows[2].Cells[3].Value);
            Assert.AreEqual("O", _grid.Rows[3].Cells[1].Value);
            Assert.AreEqual("O", _grid.Rows[4].Cells[2].Value);
            Assert.AreEqual("O", _grid.Rows[5].Cells[2].Value);
        }

    }
}