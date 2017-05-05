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

        public void EditRequirementName(string requirementName)
        {
            _requirementNameTxt.Text = requirementName;
        }

        public void EditRequirementDescription(string requirementDescription)
        {
            _requirementDescriptionTxt.Text = requirementDescription;
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
