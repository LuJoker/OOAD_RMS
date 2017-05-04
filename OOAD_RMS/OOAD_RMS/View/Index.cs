using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class Index : Form
    {
        Model _model;
        public Index(Model model)
        {
            InitializeComponent();
            _model = model;
            BindingSource projectSource = new BindingSource(_model.GetProjects(), null);
            _projectGridView.DataSource = projectSource;
            _projectComboBox.DataSource = projectSource;
            _projectComboBox.DisplayMember = "ProjectName";

            //_requirementList = new BindingList<Requirement>();
            //BindingSource requirementSource = new BindingSource(_requirementList, null);
            //_requirementGridView.DataSource = requirementSource;

            //_testList = new BindingList<Test>();
            //BindingSource testSource = new BindingSource(_testList, null);
            //_testGridView.DataSource = testSource;
        }

        private void ClickAddProjectBtn(object sender, EventArgs e)
        {
            ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog();
            if (showAddProjectDialog.ShowDialog() == DialogResult.OK) {
                string projectName = showAddProjectDialog.GetProjectName();
                string projectDescription = showAddProjectDialog.GetProjectDescription();
                _model.addProject(projectName, projectDescription);

                //Project project = new Project();
                //project.ProjectName = showAddProjectDialog.GetProjectName();
                //project.ProjectDescription = showAddProjectDialog.GetProjectDescription();

                //_projectList.Add(project);

            }
        }

        private void ClickAddRequirementBtn(object sender, EventArgs e)
        {
            ShowAddRequirementDialog showAddRequirementDialog = new ShowAddRequirementDialog();
            showAddRequirementDialog.Text = _projectComboBox.Text;
            
            if (showAddRequirementDialog.ShowDialog() == DialogResult.OK)
            {
                string requirementName = showAddRequirementDialog.GetRequirementName();
                string requirementDescription = showAddRequirementDialog.GetRequirementDescription();
                _model.addRequirement(requirementName, requirementDescription);
            }
        }

        private void ClickAddTestBtn(object sender, EventArgs e)
        {
            ShowAddTestDialog showAddTestDialog = new ShowAddTestDialog();
            if (showAddTestDialog.ShowDialog() == DialogResult.OK)
            {
                Test test = showAddTestDialog.GetTest();
                Console.WriteLine("testName: " + test.testName);
                Console.WriteLine("testDescription: " + test.testDescription);
                //_testList.Add(test);
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource requirementSource = new BindingSource(_model.getRequirementFromSelectProject(_projectComboBox.SelectedIndex), null);
            _requirementGridView.DataSource = requirementSource;
        }
    }
}
