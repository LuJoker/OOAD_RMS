using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;


namespace OOAD_RMS
{
    public partial class ShowAddProjectDialog : Form
    {
        ManagerCollecter _manages;
        List<User> _selectedUserList = new List<User>();
        public ShowAddProjectDialog(ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();
            _checkedUserComboBox.DisplayMember = "UserAccount";
        }

        public ShowAddProjectDialog(Project project, ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();

            _projectNameTxt.Text = project.ProjectName;
            _projectDescriptionTxt.Text = project.ProjectDescription;
            _selectedUserList = _manages.ProjectManage.GetProjectMapUsers(project);
            BindingSource bs = new BindingSource(_selectedUserList, null);
            _checkedUserComboBox.DataSource = bs;
            _checkedUserComboBox.DisplayMember = "UserAccount";
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
            UserCheckList _userCheckList = new UserCheckList(_selectedUserList, _manages);
            if (_userCheckList.ShowDialog() == DialogResult.OK)
            {
                _selectedUserList = _userCheckList.GetSelectedUser();
                BindingSource userSource = new BindingSource(_selectedUserList, null);
                _checkedUserComboBox.DataSource = userSource;
            }
        }

        public List<User> GetSelectedUser()
        {
            return _selectedUserList;
        }

     
    }
}
