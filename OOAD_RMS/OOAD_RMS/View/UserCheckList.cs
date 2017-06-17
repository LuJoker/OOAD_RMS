using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class UserCheckList : Form
    {
        ManagerCollecter _manages;
        List<User> _userList = new List<User>();
        public UserCheckList(List<User> users, ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();
            BindingSource bs = new BindingSource(_manages.UserManage.GetUsers(), null);
            ((ListBox)_userCheckedListBox).DataSource = bs;
            ((ListBox)_userCheckedListBox).DisplayMember = "UserAccount";

            for (int i = 0; i < _userCheckedListBox.Items.Count; i++)
            {
                foreach (User user in users)
                {
                    if (_userCheckedListBox.Items[i].Equals(user))
                    {
                        _userCheckedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void ClickOKBtn(object sender, EventArgs e)
        {
            for (int i = 0; i < _userCheckedListBox.Items.Count; i++)
            {
                if (_userCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    _userList.Add((User)_userCheckedListBox.Items[i]);
                }
            }
        }

        public List<User> GetSelectedUser()
        {
            return _userList;
        }
    }
}
