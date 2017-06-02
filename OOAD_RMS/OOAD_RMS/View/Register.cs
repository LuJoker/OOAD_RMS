using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public partial class Register : Form
    {
        Model _model;
        public Register()
        {
            _model = new Model();
            InitializeComponent();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            Hide();
            string account = _accountTextBox.Text;
            string password = _passwordTextBox.Text;
            string title = "Member";
            _model.registerAccount(account, password, title);

            Login LoginForm = new Login(_model);
            LoginForm.ShowDialog();
            Close();
        }
    }
}
