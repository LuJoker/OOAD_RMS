using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OOAD_RMS
{
    public partial class Login : Form
    {
        ManagerCollecter _manages;
        Regex regex= new Regex("^[A-Za-z0-9]+$");
        public Login(ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();
            _passwordTextBox.PasswordChar = '*';
        }

        private void LoginCheck(object sender, EventArgs e)
        {
            string account = _accountTextBox.Text.Trim();
            string password = _passwordTextBox.Text.Trim();
            if (!regex.IsMatch(account)|| !regex.IsMatch(password)) {
                MessageBox.Show("格式錯誤，請重新輸入!!\n請輸入英文或數字組合", "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_manages.UserManage.LoginCheck(account, password)) {
                Hide();
                User user = _manages.UserManage.getUser(account, password);
                Index indexForm = new Index(_manages, user);
                indexForm.ShowDialog();
                Close();
            }
            else {
                MessageBox.Show("帳號密碼錯誤，請重新登入!!", "Access Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _accountTextBox.Clear();
            _passwordTextBox.Clear();
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
