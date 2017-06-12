﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class TestDetailInfo : Form
    {
        Test _test;
        public TestDetailInfo(Test test)
        {
            _test = test;
            InitializeComponent();
            _testNameLabel.Text = "測試名稱: " + _test.testName;
            _testDescriptionLabel.Text = "測試描述: " + _test.testDescription;
            ((ListBox)_testReqInfo).DataSource = _test.requirements;
            ((ListBox)_testReqInfo).DisplayMember = "RequirementName";
            Height = 170 + _test.requirements.Count * 20;

            if (_test.requirements.Count == 0)
            {
                Height = 150;
                _testReqLabel.Visible = false;
                _testReqInfo.Visible = false;
            }
        }

        private void FormatTestReqInfo(object sender, ListControlConvertEventArgs e)
        {
            string requirementName = ((Requirement)e.ListItem).RequirementName;
            string requirementDescription = ((Requirement)e.ListItem).RequirementDescription;

            e.Value = "需求名稱: " + requirementName;
        }
    }
}
