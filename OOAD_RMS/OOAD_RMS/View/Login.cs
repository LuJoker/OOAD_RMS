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
        Model _model;
        public Login(Model model)
        {
            _model = model;
            InitializeComponent();
            _passwordTextBox.PasswordChar = '*';
        }

        private void LoginCheck(object sender, EventArgs e)
        {
            string account = _accountTextBox.Text;
            string password = _passwordTextBox.Text;
            if (_model.checkUser(account, password)) {
                Hide();
                Index indexForm = new Index(_model);
                indexForm.ShowDialog();
                Close();
            }
        }
    }
}
