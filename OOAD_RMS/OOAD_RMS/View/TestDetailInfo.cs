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
        private Model _model;
        private Test _test;
        public TestDetailInfo(Model model, Test test)
        {
            _model = model;
            _test = test;
            InitializeComponent();
            _testNameLabel.Text = "測試名稱: " + _test.testName;
            _testDescriptionLabel.Text = "測試描述: " + _test.testDescription;
            ((ListBox)_testReqInfo).DataSource = _test.requirements;
            ((ListBox)_testReqInfo).DisplayMember = "RequirementName";
            Height = 210 + _test.requirements.Count * 20;

            if (_test.requirements.Count == 0)
            {
                Height = 150;
                _testReqLabel.Visible = false;
                _testReqInfo.Visible = false;
            }
            
            for (int i = 0; i < _testReqInfo.Items.Count; i++)
            {
                _testReqInfo.SetItemChecked(i, test.requirementisComplete.Values.ToList()[i]);
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
            Dictionary<Requirement, bool> _requirementsIsComplete = new Dictionary<Requirement, bool>();
            for (int i = 0; i < _testReqInfo.Items.Count; i++)
            {
                _requirementsIsComplete.Add((Requirement)_testReqInfo.Items[i], (_testReqInfo.GetItemCheckState(i) == CheckState.Checked) ? true : false);
            }
            _test.requirementisComplete = _requirementsIsComplete;
            _model.updateTestIsComplete(_test);
        }
    }
}
