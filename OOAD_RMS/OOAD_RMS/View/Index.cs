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

            _projectComboBox.DataSource = projectSource;
            _projectComboBox.DisplayMember = "ProjectName";
            _projectComboBox.SelectedIndex = 0;

            _projectComboBoxTest.DataSource = projectSource;
            _projectComboBoxTest.DisplayMember = "ProjectName";
            _projectComboBoxTest.SelectedIndex = 0;

            DataGridViewButtonColumn editProjectBtn = new DataGridViewButtonColumn();
            _projectGridView.Columns.Add(editProjectBtn);
            _projectGridView.DataSource = projectSource;
            editProjectBtn.Text = "Edit";
            editProjectBtn.Name = "editBtn";
            editProjectBtn.UseColumnTextForButtonValue = true;
            editProjectBtn.HeaderText = "Edit";
            editProjectBtn.Width = 50;
            editProjectBtn.DisplayIndex = 2;

            DataGridViewButtonColumn deleteProjectBtn = new DataGridViewButtonColumn();
            _projectGridView.Columns.Add(deleteProjectBtn);
            _projectGridView.DataSource = projectSource;
            deleteProjectBtn.Text = "x";
            deleteProjectBtn.Name = "deleteBtn";
            deleteProjectBtn.UseColumnTextForButtonValue = true;
            deleteProjectBtn.HeaderText = "Delete";
            deleteProjectBtn.Width = 50;
            deleteProjectBtn.DisplayIndex = 3;



            DataGridViewButtonColumn editRequirementBtn = new DataGridViewButtonColumn();
            _requirementGridView.Columns.Add(editRequirementBtn);
            editRequirementBtn.Text = "Edit";
            editRequirementBtn.Name = "editBtn";
            editRequirementBtn.UseColumnTextForButtonValue = true;
            editRequirementBtn.HeaderText = "Edit";
            editRequirementBtn.Width = 50;
            editRequirementBtn.DisplayIndex = 2;
            
            DataGridViewButtonColumn deleteRequirementBtn = new DataGridViewButtonColumn();
            _requirementGridView.Columns.Add(deleteRequirementBtn);
            deleteRequirementBtn.Text = "x";
            deleteRequirementBtn.Name = "deleteBtn";
            deleteRequirementBtn.UseColumnTextForButtonValue = true;
            deleteRequirementBtn.HeaderText = "Delete";
            deleteRequirementBtn.Width = 50;
            deleteRequirementBtn.DisplayIndex = 3;


            DataGridViewButtonColumn editTestBtn = new DataGridViewButtonColumn();
            _testGridView.Columns.Add(editTestBtn);
            editTestBtn.Text = "Edit";
            editTestBtn.Name = "editBtn";
            editTestBtn.UseColumnTextForButtonValue = true;
            editTestBtn.HeaderText = "Edit";
            editTestBtn.Width = 50;
            editTestBtn.DisplayIndex = 2;

            DataGridViewButtonColumn deleteTestBtn = new DataGridViewButtonColumn();
            _testGridView.Columns.Add(deleteTestBtn);
            deleteTestBtn.Text = "x";
            deleteTestBtn.Name = "deleteBtn";
            deleteTestBtn.UseColumnTextForButtonValue = true;
            deleteTestBtn.HeaderText = "Delete";
            deleteTestBtn.Width = 50;
            deleteTestBtn.DisplayIndex = 3;
        }



        private void ClickAddProjectBtn(object sender, EventArgs e)
        {
            ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog();
            if (showAddProjectDialog.ShowDialog() == DialogResult.OK) {
                string projectName = showAddProjectDialog.GetProjectName();
                string projectDescription = showAddProjectDialog.GetProjectDescription();
                _model.addProject(projectName, projectDescription);

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
            ShowAddTestDialog showAddTestDialog = new ShowAddTestDialog(_model);
            if (showAddTestDialog.ShowDialog() == DialogResult.OK)
            {
                _model.addTest(showAddTestDialog.GetTest());
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource requirementSource = new BindingSource(_model.getRequirementFromSelectProject(_projectComboBox.SelectedIndex), null);
            _requirementGridView.DataSource = requirementSource;
        }
        
        private void TestComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource testSource = new BindingSource(_model.getTestFromSelectProject(_projectComboBoxTest.SelectedIndex), null);
            _testGridView.DataSource = testSource;
        }

        private void SelectProjectGridViewEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            String getProjectNameFromDataGridView;
            String getProjectDescriptionFromDataGridView;
            DialogResult result;
            if (e.ColumnIndex == 0 && selectedRow>-1)
            {
              
                getProjectNameFromDataGridView = _projectGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getProjectDescriptionFromDataGridView = _projectGridView.Rows[selectedRow].Cells[3].Value.ToString();


                ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog();
                showAddProjectDialog.EditProjectName(getProjectNameFromDataGridView);
                showAddProjectDialog.EditProjectDescription(getProjectDescriptionFromDataGridView);
             

                if (showAddProjectDialog.ShowDialog() == DialogResult.OK)
                {
                    _model.editProject(showAddProjectDialog.GetProjectName(), showAddProjectDialog.GetProjectDescription(), selectedRow);
                }
                
            }
            if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                getProjectNameFromDataGridView = _projectGridView.Rows[selectedRow].Cells[2].Value.ToString();
                result=MessageBox.Show("確定要刪除專案: "+ getProjectNameFromDataGridView+" 嗎?", "確定刪除",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    _model.deleteProject(selectedRow);
                }
            }
        }


        private void SelectRequirementGridViewEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            String getRequirementNameFromDataGridView;
            String getRequirementDescriptionFromDataGridView;
            DialogResult result;

            if (e.ColumnIndex == 0 && selectedRow > -1)
            {
                getRequirementNameFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getRequirementDescriptionFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[3].Value.ToString();
                ShowAddRequirementDialog requirementDialog = new ShowAddRequirementDialog();
                requirementDialog.EditRequirementName(getRequirementNameFromDataGridView);
                requirementDialog.EditRequirementDescription(getRequirementDescriptionFromDataGridView);

                if (requirementDialog.ShowDialog() == DialogResult.OK)
                {
                    _model.editRequirement(requirementDialog.GetRequirementName(), requirementDialog.GetRequirementDescription(), selectedRow);
                }
            }
            else if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                getRequirementNameFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getRequirementDescriptionFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[3].Value.ToString();
                result = MessageBox.Show("確定要刪除需求: " + getRequirementNameFromDataGridView + " 嗎?", "確定刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _model.deleteRequirement(selectedRow);
                }

            }
        }

        private void SelectTestGridViewEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            String getTesrNameFromDataGridView;
            String getTestDescriptionFromDataGridView;

            if (e.ColumnIndex == 0 && selectedRow > -1)
            {
                ShowAddTestDialog testDialog = new ShowAddTestDialog((Test)_testGridView.Rows[selectedRow].DataBoundItem, _model);

                if (testDialog.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                getTesrNameFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getTestDescriptionFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show("確定要刪除需求: " + getTesrNameFromDataGridView + " 嗎?", "確定刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _model.deleteTest(selectedRow);
                }

            }
        }
    }
}
