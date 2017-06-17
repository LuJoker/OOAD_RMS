using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public class TraceabilityMatrix
    {
        private List<Requirement> _requirements;
        private List<TestMapRequirement> _testMapRequirement;

        public TraceabilityMatrix(List<Requirement> requirements,List<TestMapRequirement> testMapRequirement)
        {
            _requirements = requirements;
            _testMapRequirement = testMapRequirement;
        }

        public void SetTraceAbilityMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            
            //x軸 (需求)
            DataGridViewTextBoxColumn firstRequirementColumn = new DataGridViewTextBoxColumn();
            firstRequirementColumn.HeaderText = "";
            grid.Columns.Add(firstRequirementColumn);
            foreach (Requirement re in _requirements)
            {
                DataGridViewTextBoxColumn requirementColumn = new DataGridViewTextBoxColumn();
                if (_testMapRequirement.FindAll(f => f.Requirement == re).All(c => c.IsComplete == true))
                    requirementColumn.DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
                grid.Columns.Add(requirementColumn);
                requirementColumn.HeaderText = re.RequirementName;
            }

            //y軸 (測試)
            List<Test> tests = _testMapRequirement.Select(t => t.Test).GroupBy(g => g).Select(s => s.Key).ToList().OrderBy(y => y.TestName).ToList();
            foreach (Test te in tests)
            {
                grid.Rows.Add(te.TestName);
            }

            //掃每個格子
            for (int i = 0; i < tests.Count; i++)
            {
                for (int j = 0; j < _requirements.Count; j++)
                {
                    List<Requirement> requirementInTest = _testMapRequirement.FindAll(f => f.Test == tests[i]).Select(s => s.Requirement).ToList();
                    if (requirementInTest.Contains(_requirements[j]))
                    {
                        if (_testMapRequirement.Find(f => f.Requirement == _requirements[j] && f.Test == tests[i]).IsComplete)
                            grid.Rows[i].Cells[j + 1].Value = "✓";
                        else
                            grid.Rows[i].Cells[j + 1].Value = "O";
                    }
                }
            }
        }
    }
}