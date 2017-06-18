using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace OOAD_RMS
{
    public partial class Index : Form
    {
        ManagerCollecter _manages;
        User _user;

        public Index(ManagerCollecter manages, User user)
        {
            InitializeComponent();
            _manages = manages;
            _user = user;

            ChangeProjectDataSource();

            _projectComboBox.DisplayMember = "ProjectName";
            _projectComboBox.SelectedIndex = 0;
            
            _projectComboBoxTest.DisplayMember = "ProjectName";
            _projectComboBoxTest.SelectedIndex = 0;
            
            _matrixComboBox.DisplayMember = "ProjectName";
            _matrixComboBox.SelectedIndex = 0;

            DataGridViewButtonColumn editProjectBtn = new DataGridViewButtonColumn();
            _projectGridView.Columns.Add(editProjectBtn);
            editProjectBtn.Text = "Edit";
            editProjectBtn.Name = "editBtn";
            editProjectBtn.UseColumnTextForButtonValue = true;
            editProjectBtn.HeaderText = "Edit";
            editProjectBtn.Width = 50;
            editProjectBtn.DisplayIndex = 2;

            DataGridViewButtonColumn deleteProjectBtn = new DataGridViewButtonColumn();
            _projectGridView.Columns.Add(deleteProjectBtn);
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

            UpdateGridViewFont();
        }

        private void UpdateGridViewFont()
        {
            foreach (DataGridViewColumn c in _projectGridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("微軟正黑體", 16F, GraphicsUnit.Pixel);
                c.HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            }

            foreach (DataGridViewColumn c in _requirementGridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("微軟正黑體", 16F, GraphicsUnit.Pixel);
                c.HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            }

            foreach (DataGridViewColumn c in _testGridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("微軟正黑體", 16F, GraphicsUnit.Pixel);
                c.HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            }

            foreach (DataGridViewColumn c in _traceAbilityMatrixGridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("微軟正黑體", 16F, GraphicsUnit.Pixel);
                c.HeaderCell.Style.Font = new Font("微軟正黑體", 12F, FontStyle.Bold);
            }
        }



        private void ClickAddProjectBtn(object sender, EventArgs e)
        {
            List<User> selectedUserList;
            ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog(_manages);
            if (showAddProjectDialog.ShowDialog() == DialogResult.OK) {
                selectedUserList = showAddProjectDialog.GetSelectedUser();
                Project project = new Project();
                project.ProjectName = showAddProjectDialog.GetProjectName();
                project.ProjectDescription = showAddProjectDialog.GetProjectDescription();
                List<User> users = showAddProjectDialog.GetSelectedUser();
                users.Add(_user);
                _manages.ProjectManage.addProject(project, users);
                ChangeProjectDataSource();
            }
        }

        private void ClickAddRequirementBtn(object sender, EventArgs e)
        {
            ShowAddRequirementDialog showAddRequirementDialog = new ShowAddRequirementDialog();
            showAddRequirementDialog.Text = _projectComboBox.Text;
            
            if (showAddRequirementDialog.ShowDialog() == DialogResult.OK)
            {
                Requirement requirement = new Requirement();
                requirement.RequirementName = showAddRequirementDialog.GetRequirementName();
                requirement.RequirementDescription = showAddRequirementDialog.GetRequirementDescription();
                requirement.Project = (Project)_projectComboBox.SelectedItem;
                _manages.RequirementManage.addRequirement(requirement);
                ChangeRequirementDataSource();
                UpdateTraceAbilityMatrix();
            }
        }

        private void ClickAddTestBtn(object sender, EventArgs e)
        {
            ShowAddTestDialog showAddTestDialog = new ShowAddTestDialog((Project)_projectComboBox.SelectedItem, _manages);
            if (showAddTestDialog.ShowDialog() == DialogResult.OK)
            {
                Test test = new Test();
                test.TestName = showAddTestDialog.GetTestName();
                test.TestDescription = showAddTestDialog.GetTestDescription();
                test.Project = (Project)_projectComboBox.SelectedItem;
                List<Requirement> requirements = showAddTestDialog.GetRequirements();
                _manages.TestManage.addTest(test, requirements);
                ChangeTestDataSource();
                UpdateTraceAbilityMatrix();
            }
        }

        private void ChangeProjectDataSource()
        {
            BindingSource projectSource = new BindingSource(new BindingList<Project>(_manages.ProjectManage.GetProjects(_user)), null);

            _projectComboBox.DataSource = projectSource;
            _projectComboBoxTest.DataSource = projectSource;
            _matrixComboBox.DataSource = projectSource;
            _projectGridView.DataSource = projectSource;
        }

        private void ChangeRequirementDataSource()
        {
            BindingList<Requirement> requirements = new BindingList<Requirement>(_manages.RequirementManage.GetRequirements((Project)_projectComboBox.SelectedItem));
            BindingSource requirementSource = new BindingSource(requirements, null);
            _requirementGridView.DataSource = requirementSource;
        }

        private void ChangeTestDataSource()
        {
            BindingList<Test> tests = new BindingList<Test>(_manages.TestManage.GetTests((Project)_projectComboBoxTest.SelectedItem));
            BindingSource testSource = new BindingSource(tests, null);
            _testGridView.DataSource = testSource;
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeRequirementDataSource();
        }
        
        private void TestComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTestDataSource();
        }

        private void SelectProjectGridViewEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            
            DialogResult result;
            if (e.ColumnIndex == 0 && selectedRow>-1)
            {
                Project project = (Project)_projectGridView.Rows[selectedRow].DataBoundItem;
                ShowAddProjectDialog showAddProjectDialog = new ShowAddProjectDialog(project, _manages);
             

                if (showAddProjectDialog.ShowDialog() == DialogResult.OK)
                {
                    project.ProjectName = showAddProjectDialog.GetProjectName();
                    project.ProjectDescription = showAddProjectDialog.GetProjectDescription();
                    _manages.ProjectManage.editProject(project, showAddProjectDialog.GetSelectedUser());
                    ChangeProjectDataSource();
                }
            }
            if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                Project project = (Project)_projectGridView.Rows[selectedRow].DataBoundItem;
                string getProjectNameFromDataGridView = _projectGridView.Rows[selectedRow].Cells[2].Value.ToString();
                result=MessageBox.Show("確定要刪除專案: "+ getProjectNameFromDataGridView+" 嗎?", "確定刪除",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    _manages.ProjectManage.deleteProject(project);
                    ChangeProjectDataSource();
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
                Requirement requirement = (Requirement)_requirementGridView.Rows[selectedRow].DataBoundItem;

                ShowAddRequirementDialog requirementDialog = new ShowAddRequirementDialog(requirement);

                if (requirementDialog.ShowDialog() == DialogResult.OK)
                {
                    requirement.RequirementName = requirementDialog.GetRequirementName();
                    requirement.RequirementDescription = requirementDialog.GetRequirementDescription();
                    ChangeRequirementDataSource();
                    UpdateTraceAbilityMatrix();
                }
            }
            else if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                Requirement requirement = (Requirement)_requirementGridView.Rows[selectedRow].DataBoundItem;
                getRequirementNameFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getRequirementDescriptionFromDataGridView = _requirementGridView.Rows[selectedRow].Cells[3].Value.ToString();
                result = MessageBox.Show("確定要刪除需求: " + getRequirementNameFromDataGridView + " 嗎?", "確定刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _manages.RequirementManage.deleteRequirement(requirement);
                    ChangeRequirementDataSource();
                    UpdateTraceAbilityMatrix();
                }
            }
        }

        private void SelectTestGridViewEvent(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            String getTestNameFromDataGridView;
            String getTestDescriptionFromDataGridView;

            if (e.ColumnIndex == 0 && selectedRow > -1)
            {
                Test test = (Test)_testGridView.Rows[selectedRow].DataBoundItem;
                ShowAddTestDialog testDialog = new ShowAddTestDialog((Project)_projectComboBoxTest.SelectedItem ,test, _manages);

                if (testDialog.ShowDialog() == DialogResult.OK)
                {
                    test.TestName = testDialog.GetTestName();
                    test.TestDescription = testDialog.GetTestDescription();
                    _manages.TestManage.editTest(test, testDialog.GetRequirements());
                    ChangeTestDataSource();
                    UpdateTraceAbilityMatrix();
                }
            }
            else if (e.ColumnIndex == 1 && selectedRow > -1)
            {
                Test test = (Test)_testGridView.Rows[selectedRow].DataBoundItem;
                getTestNameFromDataGridView = _testGridView.Rows[selectedRow].Cells[2].Value.ToString();
                getTestDescriptionFromDataGridView = _testGridView.Rows[selectedRow].Cells[3].Value.ToString();
                DialogResult result = MessageBox.Show("確定要刪除需求: " + getTestNameFromDataGridView + " 嗎?", "確定刪除", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _manages.TestManage.deleteTest(test);
                    ChangeTestDataSource();
                    UpdateTraceAbilityMatrix();
                }
            }
            else
            {
                if (e.RowIndex > -1)
                {
                    TestDetailInfo testInfo = new TestDetailInfo(_manages, (Test)_testGridView.Rows[selectedRow].DataBoundItem, (Project)_projectComboBoxTest.SelectedItem);

                    if (testInfo.ShowDialog() == DialogResult.OK)
                    {
                        UpdateTraceAbilityMatrix();
                    }
                } 
            }
        }

        public void FormatProjectGridViewCell(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = _projectGridView.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "ProjectDescription":
                    _projectGridView.Columns[e.ColumnIndex].Width = 700;
                    break;
                case "editBtn":
                    _projectGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                case "deleteBtn":
                    _projectGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                default:
                    break;
            }
        }

        public void FormatRequirementGridViewCell(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = _requirementGridView.Columns[e.ColumnIndex].Name;
            Console.WriteLine(columnName);
            switch (columnName)
            {
                case "RequirementDescription":
                    _requirementGridView.Columns[e.ColumnIndex].Width = 700;
                    break;
                case "Project":
                    _requirementGridView.Columns[e.ColumnIndex].Visible = false;
                    break;
                case "editBtn":
                    _requirementGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                case "deleteBtn":
                    _requirementGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                default:
                    break;
            }
        }

        public void FormatTestGridViewCell(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = _testGridView.Columns[e.ColumnIndex].Name;
            switch (columnName)
            {
                case "testDescription":
                    _testGridView.Columns[e.ColumnIndex].Width = 700;
                    break;
                case "Project":
                    _testGridView.Columns[e.ColumnIndex].Visible = false;
                    break;
                case "editBtn":
                    _testGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                case "deleteBtn":
                    _testGridView.Columns[e.ColumnIndex].Width = 60;
                    break;
                default:
                    break;
            }
        }

        private void MatrixComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTraceAbilityMatrix();
        }

        private void UpdateTraceAbilityMatrix()
        {
            TraceabilityMatrix tcx = new TraceabilityMatrix(_manages.RequirementManage.GetRequirements((Project)_matrixComboBox.SelectedItem), _manages.TestManage.GetTestMapRequirement().FindAll(c => c.Test.Project == _matrixComboBox.SelectedItem && c.Requirement.Project == _matrixComboBox.SelectedItem));
            tcx.SetTraceAbilityMatrix(_traceAbilityMatrixGridView);
        }
    }
}
