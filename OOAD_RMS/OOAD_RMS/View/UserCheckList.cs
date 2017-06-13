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
        Model _model;
        List<User> _userList = new List<User>();
        public UserCheckList(Model model)
        {
            _model = model;
            InitializeComponent();
            BindingSource bs = new BindingSource(_model.GetAllUser(), null);
            ((ListBox)_userCheckedListBox).DataSource = bs;
            ((ListBox)_userCheckedListBox).DisplayMember = "UserAccount";
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
