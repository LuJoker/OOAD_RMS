﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class ShowAddTestDialog : Form
    {
        Model _model;
        Test _test;
        public ShowAddTestDialog(Model model)
        {
            _model = model;
            _test = new Test();
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";
        }

        private void _editRequirementList_Click(object sender, EventArgs e)
        {
            RequirementCheckList requirementCheckList = new RequirementCheckList(_model);

            if (requirementCheckList.ShowDialog() == DialogResult.OK)
            {
                _test.requirements = requirementCheckList.getRequirements();
                BindingSource testSource = new BindingSource(requirementCheckList.getRequirements(), null);
                _testRequirementComboBox.DataSource = testSource;
            }
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            _test.testName = _testNameTxt.Text;
            _test.testDescription = _testDescriptionTxt.Text;
            _model.addTest(_test);
        }
    }
}
