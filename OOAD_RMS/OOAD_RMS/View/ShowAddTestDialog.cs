using System;
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

        public ShowAddTestDialog(Test test, Model model)
        {
            _model = model;
            _test = test;
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";

            _testNameTxt.Text = _test.testName;
            _testDescriptionTxt.Text = _test.testDescription;
            BindingSource testSource = new BindingSource(_test.requirements, null);
            _testRequirementComboBox.DataSource = testSource;
        }

        private void ClickEditRequirementList(object sender, EventArgs e)
        {
            RequirementCheckList requirementCheckList = new RequirementCheckList(_test.requirements, _model);

            if (requirementCheckList.ShowDialog() == DialogResult.OK)
            {
                _test.requirements = requirementCheckList.getRequirements();
                BindingSource testSource = new BindingSource(requirementCheckList.getRequirements(), null);
                _testRequirementComboBox.DataSource = testSource;
            }
        }

        private void ClickOkBtn(object sender, EventArgs e)
        {
            _test.testName = _testNameTxt.Text;
            _test.testDescription = _testDescriptionTxt.Text;
            _model.editTest();
        }

        public Test GetTest()
        {
            return _test;
        }
    }
}
