using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace OOAD_RMS
{
    public partial class ShowAddTestDialog : Form
    {
        ManagerCollecter _manages;
        List<Requirement> _requirement;
        Project _project;
        public ShowAddTestDialog(Project project, ManagerCollecter manages)
        {
            _manages = manages;
            _project = project;
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";
            _requirement = new List<Requirement>();
        }

        public ShowAddTestDialog(Project project, Test test, ManagerCollecter manages)
        {
            _manages = manages;
            _project = project;
            InitializeComponent();
            _testRequirementComboBox.DisplayMember = "RequirementName";

            _testNameTxt.Text = test.TestName;
            _testDescriptionTxt.Text = test.TestDescription;
            _requirement = manages.TestManage.GetTestMapRequirement().FindAll(c => c.Test == test).Select(t => t.Requirement).ToList();
            BindingSource requirementSource = new BindingSource(_requirement, null);
            _testRequirementComboBox.DataSource = requirementSource;
        }

        private void ClickEditRequirementList(object sender, EventArgs e)
        {
            RequirementCheckList requirementCheckList = new RequirementCheckList(_project, _requirement, _manages);

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
