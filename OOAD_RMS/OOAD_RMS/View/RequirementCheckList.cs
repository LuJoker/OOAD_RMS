﻿using System;
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
        BindingList<Requirement> _checkedRequirements = new BindingList<Requirement>();
        public RequirementCheckList(Model model)
        {
            _model = model;
            InitializeComponent();

            BindingSource bs = new BindingSource(_model.GetRequirement(), null);
            ((ListBox)_requirementCheckedListBox).DataSource = bs;
            ((ListBox)_requirementCheckedListBox).DisplayMember = "RequirementName";

        }

        private void _selectReOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _requirementCheckedListBox.Items.Count; i++)
            {
                if (_requirementCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    _checkedRequirements.Add((Requirement)_requirementCheckedListBox.Items[i]);
                }
            }
        }

        public BindingList<Requirement> getRequirements()
        {
            foreach (Requirement re in _checkedRequirements)
                Console.WriteLine("RequirementName: " + re.RequirementName);
            return _checkedRequirements;
        }
    }
}
