using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class Login : Form
    {
        ManagerCollecter _manages;
        public Login(ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();
            _passwordTextBox.PasswordChar = '*';
        }

        private void LoginCheck(object sender, EventArgs e)
        {
            string account = _accountTextBox.Text;
            string password = _passwordTextBox.Text;
            if (_manages.UserManage.LoginCheck(account, password)) {
                Hide();
                User user = _manages.UserManage.getUser(account, password);
                Index indexForm = new Index(_manages, user);
                indexForm.ShowDialog();
                Close();
            }
        }

        private void Register(object sender, EventArgs e)
        {
            Hide();
            Register registerForm = new Register(_manages);
            registerForm.ShowDialog();
            Close();
        }
    }
}
