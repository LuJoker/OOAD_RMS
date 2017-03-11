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
    public partial class Index : Form
    {
        BindingList<Project> _projectList = new BindingList<Project>();
        public Index()
        {
            InitializeComponent();
            BindingSource projectSource = new BindingSource(_projectList, null);
            _projectGridView.DataSource = projectSource;
        }

        private void ClickAddBtn(object sender, EventArgs e)
        {
            ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog();
            if (showAddProjectDialog.ShowDialog() == DialogResult.OK) {
                Project project = showAddProjectDialog.GetProject();
                Console.WriteLine("projectName: " + project.ProjectName);
                Console.WriteLine("projectDescription: " + project.ProjectDescription);
                _projectList.Add(project);
            }
        }
    }
}
