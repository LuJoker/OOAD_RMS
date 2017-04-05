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
        BindingList<Project> _projectList;
        BindingList<Requirement> _requirementList;
        BindingList<Test> _testList;
        User _user;
        public Index(User user)
        {
            InitializeComponent();
            _user = user;
            _projectList = new BindingList<Project>(_user.GetInProjects());
            BindingSource projectSource = new BindingSource(_projectList, null);
            _projectGridView.DataSource = projectSource;
            _projectComboBox.DataSource = projectSource;
            _projectComboBox.DisplayMember = "ProjectName";

            //_requirementList = new BindingList<Requirement>();
            //BindingSource requirementSource = new BindingSource(_requirementList, null);
            //_requirementGridView.DataSource = requirementSource;

            _testList = new BindingList<Test>();
            BindingSource testSource = new BindingSource(_testList, null);
            _testGridView.DataSource = testSource;
        }

        private void ClickAddProjectBtn(object sender, EventArgs e)
        {
            ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog();
            if (showAddProjectDialog.ShowDialog() == DialogResult.OK) {
                Project project = showAddProjectDialog.GetProject();
                Console.WriteLine("projectName: " + project.ProjectName);
                Console.WriteLine("projectDescription: " + project.ProjectDescription);
                _projectList.Add(project);
            }
        }

        private void ClickAddRequirementBtn(object sender, EventArgs e)
        {
            ShowAddRequirementDialog showAddRequirementDialog = new ShowAddRequirementDialog();
            showAddRequirementDialog.Text = _projectComboBox.Text;

            Console.WriteLine("TestGetProjectIndex: " + _projectList[_projectComboBox.SelectedIndex].ProjectName);
            if (showAddRequirementDialog.ShowDialog() == DialogResult.OK)
            {
                Requirement requirement = showAddRequirementDialog.GetRequirement();
                Console.WriteLine("requirementName: " + requirement.RequirementName);
                Console.WriteLine("requirementDescription: " + requirement.RequirementDescription);
                _requirementList.Add(requirement);
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
                _testList.Add(test);
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _requirementList = new BindingList<Requirement>(_projectList[_projectComboBox.SelectedIndex].GetRequirements());
            BindingSource requirementSource = new BindingSource(_requirementList, null);
            _requirementGridView.DataSource = requirementSource;
        }
    }
}
