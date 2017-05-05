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
        public ShowAddTestDialog()
        {
            InitializeComponent();
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
