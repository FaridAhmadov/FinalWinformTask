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
    public partial class CreateEmployees : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CreateEmployees()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillDGV();
        }

        private void CreateDetails()
        {
            Employees employees = new Employees();
            employees.FullName = txtName.Text;
            employees.IdentityNumber = Convert.ToInt32(txtIdentity.Text);
            employees.Position = txtPosition.Text;
            employees.Age = Convert.ToInt32(txtAge.Text);


            db.Employees.Add(employees);
            db.SaveChanges();
            MessageBox.Show("Succesfully Created!");
            txtName.Clear();
            txtIdentity.Clear();
            txtPosition.Clear();
            txtAge.Clear();
            lblFillFields.Visible = false;
            lblAge.Visible = false;
        }
        private void createEmployee()
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) &&
               !string.IsNullOrWhiteSpace(txtAge.Text) &&
               !string.IsNullOrWhiteSpace(txtPosition.Text) &&
               !string.IsNullOrWhiteSpace(txtIdentity.Text))
            {

                int a;

                if (int.TryParse(txtAge.Text, out a) && int.TryParse(txtIdentity.Text, out a))
                {
                    lblFillFields.Visible = false;
                    lblRight.Visible = false;
                    CreateDetails();
                }
                else
                {
                    lblFillFields.Visible = false;
                    lblRight.Visible = true;
                }
            }
            else
            {
                lblFillFields.Visible = true;
            }
        }

        private void fillDGV()
        {
            foreach (Employees i in db.Employees.ToList())
            {
                dgv.Rows.Add(i.Id, i.FullName, i.IdentityNumber, i.Position, i.Age);
            }
        }

     

        int UpdateDelete;

        private void UpdateThat()
        {
            Employees updateme = db.Employees.Find(UpdateDelete);
            updateme.FullName = txtName.Text;
            updateme.IdentityNumber = Convert.ToInt32(txtIdentity.Text);
            updateme.Position = txtPosition.Text;
            updateme.Age = Convert.ToInt32(txtAge.Text);
            db.SaveChanges();
            dgv.Rows.Clear();
            fillDGV();
            ClearUpDel();
        }

        private void ClearUpDel()
        {
            txtName.Clear();
            txtPosition.Clear();
            txtIdentity.Clear();
            txtAge.Clear();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCreateEmployee.Visible = true;
        }

        private void Delete()
        {
            Employees deleteMe = db.Employees.Find(UpdateDelete);
            db.Employees.Remove(deleteMe);
            db.SaveChanges();
            dgv.Rows.Clear();
            fillDGV();
            ClearUpDel();
        }



        private void btnCreateEmployee_Click_1(object sender, EventArgs e)
        {
            createEmployee();
            dgv.Rows.Clear();
            fillDGV();
        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDelete = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value);

            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdentity.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPosition.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAge.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnCreateEmployee.Visible = false;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            UpdateThat();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
