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
    public partial class TestDetailInfo : Form
    {
        private ManagerCollecter _manages;
        private Test _test;
        public TestDetailInfo(ManagerCollecter manages, Test test, Project project)
        {
            _manages = manages;
            _test = test;
            InitializeComponent();
            _testNameLabel.Text = "測試名稱: " + _test.TestName;
            _testDescriptionLabel.Text = "測試描述: " + _test.TestDescription;
            List<Requirement> requirement = _manages.TestManage.GetTestMapRequirements(test, project);
            ((ListBox)_testReqInfo).DataSource = requirement;
            ((ListBox)_testReqInfo).DisplayMember = "RequirementName";
            Height = 210 + _manages.TestManage.GetTestMapRequirements(test, project).Count * 20;

            if (requirement.Count == 0)
            {
                Height = 150;
                _testReqLabel.Visible = false;
                _testReqInfo.Visible = false;
            }
            
            for (int i = 0; i < _testReqInfo.Items.Count; i++)
            {
                _testReqInfo.SetItemChecked(i, _manages.TestManage.getTestMapRequirementIsComplete(test, (Requirement)_testReqInfo.Items[i]));
            }
        }

        private void FormatTestReqInfo(object sender, ListControlConvertEventArgs e)
        {
            string requirementName = ((Requirement)e.ListItem).RequirementName;
            string requirementDescription = ((Requirement)e.ListItem).RequirementDescription;

            e.Value = "需求名稱: " + requirementName;
        }

        private void ClickOkButton(object sender, EventArgs e)
        {
            for (int i = 0; i < _testReqInfo.Items.Count; i++)
            {
                Requirement requirement = (Requirement)_testReqInfo.Items[i];
                bool isComplete = (_testReqInfo.GetItemCheckState(i) == CheckState.Checked) ? true : false;
                _manages.TestManage.updateTestMapRequirementIsComplete(_test, requirement, isComplete);
            }
        }
    }
}
