using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ClickOkBtn(object sender, EventArgs e)
        {
            string account = _accountTextBox.Text;
            string password = _passwordTextBox.Text;
            User manager = new User();
            manager.UserAccount = "admin";
            manager.UserPassword = "admin";
            manager.UserIdentity = "Manager";

            if (account == manager.UserAccount && password == manager.UserPassword)
            {
                Hide();
                Index indexForm = new Index(manager);
                indexForm.ShowDialog();
                Close();
            }
        }
    }
}
