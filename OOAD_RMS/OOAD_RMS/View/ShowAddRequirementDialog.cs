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
        private Requirement _requirement;
        public ShowAddRequirementDialog()
        {
            InitializeComponent();
            _requirement = new Requirement();
        }

        private void ClickOkBtn(object sender, EventArgs e)
        {
            _requirement.RequirementName = _requirementNameTxt.Text;
            _requirement.RequirementDescription = _requirementDescriptionTxt.Text;
        }

        public Requirement GetRequirement()
        {
            return _requirement;
        }
    }
}
