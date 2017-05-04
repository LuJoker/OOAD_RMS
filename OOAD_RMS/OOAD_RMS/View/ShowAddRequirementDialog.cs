using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class ShowAddRequirementDialog : Form
    {
        public ShowAddRequirementDialog()
        {
            InitializeComponent();
        }
        

        public string GetRequirementName()
        {
            return _requirementNameTxt.Text;
        }

        public string GetRequirementDescription()
        {
            return _requirementDescriptionTxt.Text;
        }
    }
}
