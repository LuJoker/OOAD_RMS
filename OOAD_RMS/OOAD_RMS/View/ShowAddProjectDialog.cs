using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class ShowAddProjectDialog : Form
    {
        private Project _project;
        public ShowAddProjectDialog()
        {
            InitializeComponent();
            _project = new Project();
        }

        private void ClickOkBtn(object sender, EventArgs e)
        {
            _project.ProjectName = _projectNameTxt.Text;
            _project.ProjectDescription = _projectDescriptionTxt.Text;
        }

        public Project GetProject()
        {
            return _project;
        }
    }
}
