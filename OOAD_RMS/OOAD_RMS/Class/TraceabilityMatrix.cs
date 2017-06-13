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
        private List<Test> _tests;

        public TraceabilityMatrix(List<Requirement> requirements, List<Test> tests)
        {
            _requirements = requirements;
            _tests = tests;
        }

        public void SetTraceAbilityMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            DataGridViewTextBoxColumn firstRequirementColumn = new DataGridViewTextBoxColumn();
            firstRequirementColumn.HeaderText = "";
            grid.Columns.Add(firstRequirementColumn);
            foreach (Requirement re in _requirements)
            {
                DataGridViewTextBoxColumn requirementColumn = new DataGridViewTextBoxColumn();
                if (_tests.All(c => c.requirementIsComplete(re) == true))
                    requirementColumn.DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow;
                grid.Columns.Add(requirementColumn);
                requirementColumn.HeaderText = re.RequirementName;
            }

            foreach (Test te in _tests)
            {
                grid.Rows.Add(te.testName);
            }

            for (int i = 0; i < _tests.Count; i++)
            {
                for (int j = 0; j < _requirements.Count; j++)
                {
                    List<Requirement> requirementInTest = _tests[i].requirements;
                    if (requirementInTest.Contains(_requirements[j]))
                    {
                        if (_tests[i].requirementisComplete[_requirements[j]])
                            grid.Rows[i].Cells[j + 1].Value = "✓";
                        else
                            grid.Rows[i].Cells[j + 1].Value = "O";
                    }
                }
            }
        }
    }
}