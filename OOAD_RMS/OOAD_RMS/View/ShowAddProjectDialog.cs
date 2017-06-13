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
        Model _model;
        List<User> _selectedUserList = new List<User>();
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
            Console.WriteLine(_projectNameTxt.Text);
            Console.WriteLine("@@@@@");
            List<User> usersInProject = _model.GetAllUser().FindAll(c => c.GetInProjects().Any(e => e.ProjectName == _projectNameTxt.Text));
            foreach (User user in usersInProject)
            {
                Console.WriteLine(user.UserAccount);
            }
            BindingSource bs = new BindingSource(usersInProject, null);
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
            UserCheckList _userCheckList = new UserCheckList(_model);
            if (_userCheckList.ShowDialog() == DialogResult.OK)
            {
                _selectedUserList = _userCheckList.GetSelectedUser();
                BindingSource userSource = new BindingSource(_selectedUserList, null);
                _checkedUserComboBox.DataSource = userSource;
                _checkedUserComboBox.DisplayMember = "UserAccount";
            }
        }

        public List<User> GetSelectedUser()
        {
            return _selectedUserList;
        }
    }
}
