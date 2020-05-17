using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFinal.Models;

namespace WinformFinal
{
    public partial class CreateConsumers : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CreateConsumers()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillDGV();
        }

        private void createConsumer()
        {

            Consumers consumers = new Consumers();
            if(!string.IsNullOrWhiteSpace(txtName.Text) &&
                !string.IsNullOrWhiteSpace(txtAge.Text) &&
                !string.IsNullOrWhiteSpace(txtDrivingLicence.Text) &&
                !string.IsNullOrWhiteSpace(txtIdentity.Text)){

                int a;

                if (int.TryParse(txtAge.Text, out a) &&
                   int.TryParse(txtDrivingLicence.Text, out a)&&
                   int.TryParse(txtIdentity.Text, out a))
                {
                    consumers.IdentityNumber = Convert.ToInt32(txtIdentity.Text);
                    consumers.DrivingLicence = Convert.ToInt32(txtDrivingLicence.Text);
                    consumers.FullName = txtName.Text;
                    consumers.Age = Convert.ToInt32(txtAge.Text);

                    lblFillFields.Visible = false;
                    lblRight.Visible = false;
                    db.Consumers.Add(consumers);
                    db.SaveChanges();
                    MessageBox.Show("Succesfully Created!");
                    txtIdentity.Clear();
                    txtDrivingLicence.Clear();
                    txtName.Clear();
                    txtAge.Clear();
                  

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
            foreach (Consumers i in db.Consumers.ToList())
            {
                consumerDgv.Rows.Add(i.Id, i.FullName, i.IdentityNumber, i.DrivingLicence, i.Age);
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            createConsumer();
            consumerDgv.Rows.Clear();
            fillDGV();

        }

        int UpdateDelete;
        private void consumerDgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDelete = Convert.ToInt32(consumerDgv.Rows[e.RowIndex].Cells[0].Value);

            txtName.Text = consumerDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdentity.Text = consumerDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDrivingLicence.Text = consumerDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAge.Text = consumerDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnCreateEmployee.Visible = false;
        }

        private void UpdateThat()
        {
            Consumers updateme = db.Consumers.Find(UpdateDelete);
            updateme.FullName = txtName.Text;
            updateme.IdentityNumber =Convert.ToInt32(txtIdentity.Text);
            updateme.DrivingLicence = Convert.ToInt32(txtDrivingLicence.Text);
            updateme.Age = Convert.ToInt32(txtAge.Text);
            db.SaveChanges();
            consumerDgv.Rows.Clear();
            fillDGV();
            ClearUpDel();
        }

        private void ClearUpDel()
        {
            txtName.Clear();
            txtDrivingLicence.Clear();
            txtIdentity.Clear();
            txtAge.Clear();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCreateEmployee.Visible = true;
        }

        private void Delete()
        {
            Consumers deleteMe = db.Consumers.Find(UpdateDelete);
            db.Consumers.Remove(deleteMe);
            db.SaveChanges();
            consumerDgv.Rows.Clear();
            fillDGV();
            ClearUpDel();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateThat();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
