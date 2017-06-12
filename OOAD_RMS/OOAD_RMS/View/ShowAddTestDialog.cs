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
        List<Requirement> _requirement;
        public ShowAddTestDialog(Model model)
        {
            _model = model;
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";
            _requirement = new List<Requirement>();
        }

        public ShowAddTestDialog(Test test, Model model)
        {
            _model = model;
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";

            _testNameTxt.Text = test.testName;
            _testDescriptionTxt.Text = test.testDescription;
            _requirement = test.requirements;
            BindingSource requirementSource = new BindingSource(test.requirements, null);
            _testRequirementComboBox.DataSource = requirementSource;
        }

        private void ClickEditRequirementList(object sender, EventArgs e)
        {
            RequirementCheckList requirementCheckList = new RequirementCheckList(_requirement, _model);

            if (requirementCheckList.ShowDialog() == DialogResult.OK)
            {
                _requirement = requirementCheckList.getRequirements();
                BindingSource testSource = new BindingSource(requirementCheckList.getRequirements(), null);
                _testRequirementComboBox.DataSource = testSource;
            }
        }

        public List<Requirement> GetRequirements()
        {
            return _requirement;
        }

        public string GetTestName()
        {
            return _testNameTxt.Text;
        }

        public string GetTestDescription()
        {
            return _testDescriptionTxt.Text;
        }
    }
}
