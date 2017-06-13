using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace OOAD_RMS
{
    public partial class ShowAddProjectDialog : Form
    {
        Model _model;
        public ShowAddProjectDialog(Model model)
        {
            _model = model;
            InitializeComponent();
        }

        public void EditProjectName(String projectName) {
            _projectNameTxt.Text = projectName;
        }
        public void EditProjectDescription(String projectDescription) {
            _projectDescriptionTxt.Text = projectDescription;
        }

        public string GetProjectName()
        {
            return _projectNameTxt.Text;
        }

        public string GetProjectDescription()
        {
            return _projectDescriptionTxt.Text;
        }

        private void ClickSelectUserBtn(object sender, EventArgs e)
        {
            UserCheckList _userCheckList = new UserCheckList(_model);
            _userCheckList.ShowDialog();
        }
    }
}
