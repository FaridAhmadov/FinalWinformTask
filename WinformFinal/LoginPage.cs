using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using WinformFinal.Models;

namespace WinformFinal
{
    public partial class LoginPage : Form
    {
        private WinFormFinalProjectEntities2 db;
        public LoginPage()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
        }


     

        private void CheckLogin(Form abc)
        {

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtPass.Text))
            {
                if (db.Admins.FirstOrDefault(a => a.Email == txtEmail.Text && a.Password == txtPass.Text) != null)
                {
                    abc.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter a Right Information!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Required Fills!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            CheckLogin(dashboard);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            CheckLogin(register);
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }
    }
}
