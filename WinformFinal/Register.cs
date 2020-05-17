using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFinal.Models;

namespace WinformFinal
{
    public partial class Register : Form
    {
        private WinFormFinalProjectEntities2 db;
        public Register()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
        }

        private void createRegister()
        {
            Admins admins = new Admins();
            admins.FullName = txtFullname.Text;
            admins.Username = txtUsername.Text;
            admins.Email = txtEmail.Text;
            admins.Password = txtPassword.Text;

            db.Admins.Add(admins);
            db.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createRegister();
            MessageBox.Show("Successfully Registered! Now You are an Admin");
            this.Close();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;

        }
    }
}
