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
            //_userList = _model.GetAllUser();
            //foreach (User u in _userList)
            //{
            //    _userCheckedListBox.Items.Add(u);
            //}
            BindingSource bs = new BindingSource(_model.GetAllUser(), null);
            ((ListBox)_userCheckedListBox).DataSource = bs;
            ((ListBox)_userCheckedListBox).DisplayMember = "UserAccount";
        }
    }
}
