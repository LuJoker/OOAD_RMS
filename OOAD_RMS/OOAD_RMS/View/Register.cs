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
    public partial class Register : Form
    {
        ManagerCollecter _manages;
        public Register(ManagerCollecter manages)
        {
            _manages = manages;
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            Hide();
            string account = _accountTextBox.Text.Trim();
            string password = _passwordTextBox.Text.Trim();
            if (FormateCheck(account, password))
            {
                string title = "Member";
                _manages.UserManage.registerAccount(account, password, title);

                Login LoginForm = new Login(_manages);
                LoginForm.ShowDialog();
                Close();
            }
            else {
                Show();
                _accountTextBox.Clear();
                _passwordTextBox.Clear();
            }
            
           
        }

        private Boolean FormateCheck(string account, string password)
        {
            Regex regex = new Regex("^[A-Za-z0-9]+$");
            if (!regex.IsMatch(account) || !regex.IsMatch(password))
            {
                MessageBox.Show("格式錯誤，請重新輸入!!\n請輸入英文或數字組合", "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
