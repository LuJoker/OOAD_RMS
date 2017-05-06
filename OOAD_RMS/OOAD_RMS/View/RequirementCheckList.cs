using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class RequirementCheckList : Form
    {
        Model _model;
        List<Requirement> _checkedRequirements = new List<Requirement>();
        public RequirementCheckList(List<Requirement> requirements, Model model)
        {
            _model = model;
            InitializeComponent();

            BindingSource bs = new BindingSource(_model.GetRequirement(), null);
            ((ListBox)_requirementCheckedListBox).DataSource = bs;
            ((ListBox)_requirementCheckedListBox).DisplayMember = "RequirementName";
            Height = 90 + _model.GetRequirement().Count * 20;

            for (int i = 0; i < _requirementCheckedListBox.Items.Count; i++)
            {
                foreach (Requirement requirement in requirements)
                {
                    if (_requirementCheckedListBox.Items[i].Equals(requirement))
                    {
                        _requirementCheckedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void ClickSelectReOkClick(object sender, EventArgs e)
        {
            for (int i = 0; i < _requirementCheckedListBox.Items.Count; i++)
            {
                if (_requirementCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    _checkedRequirements.Add((Requirement)_requirementCheckedListBox.Items[i]);
                }
            }
        }

        public List<Requirement> getRequirements()
        {
            foreach (Requirement re in _checkedRequirements)
                Console.WriteLine("RequirementName: " + re.RequirementName);
            return _checkedRequirements;
        }
    }
}
