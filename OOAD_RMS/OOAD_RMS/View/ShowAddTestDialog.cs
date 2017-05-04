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
        private Test _test;
        public ShowAddTestDialog()
        {
            InitializeComponent();
            _test = new Test();
        }

        private void ClickOkBtn(object sender, EventArgs e)
        {
            _test.testName = _testNameTxt.Text;
            _test.testDescription = _testDescriptionTxt.Text;
        }

        public Test GetTest()
        {
            return _test;
        }
    }
}
