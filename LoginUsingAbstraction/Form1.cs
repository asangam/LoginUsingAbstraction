using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LoginClassLibrary;
namespace LoginUsingAbstraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LoginClass lc = new LoginClass();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool lg = lc.login(txtUsername.Text, txtPassword.Text);
            if(lg==true)
            {
                MessageBox.Show("Login Successfull");

            }

            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
