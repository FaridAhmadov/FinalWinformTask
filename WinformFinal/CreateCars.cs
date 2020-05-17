using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformFinal.Models;

namespace WinformFinal
{
    public partial class CreateCars : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CreateCars()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillCarMade();
            fillDGV();
        }

        private void createCars()
        {
            if (!string.IsNullOrWhiteSpace(comboBox1.Text) &&
              !string.IsNullOrWhiteSpace(txtMake.Text) &&
              !string.IsNullOrWhiteSpace(txtPrice.Text) &&
              !string.IsNullOrWhiteSpace(txtFuelC.Text) &&
              !string.IsNullOrWhiteSpace(txtEngine.Text) &&
              !string.IsNullOrWhiteSpace(txtYear.Text))
            {

                int a;
                decimal b;

                if (decimal.TryParse(txtEngine.Text, out b) &&
                    int.TryParse(txtFuelC.Text, out a) &&
                    decimal.TryParse(txtPrice.Text, out b) &&
                    int.TryParse(txtYear.Text, out a))
                {
                    int GetIdMades = db.Mades.FirstOrDefault(m => m.Made == comboBox1.Text).Id;
                    Cars cars = new Cars();

                    cars.Made = GetIdMades;
                    cars.Make = txtMake.Text;
                    cars.Year = Convert.ToInt32(txtYear.Text);
                    cars.Engine = Convert.ToDecimal(txtEngine.Text);
                    cars.FuelCons = Convert.ToInt32(txtFuelC.Text);
                    cars.Price = Convert.ToDecimal(txtPrice.Text);

                    db.Cars.Add(cars);
                    db.SaveChanges();
                    MessageBox.Show("Car Succesfully Created!");
                    txtMake.Clear();
                    txtYear.Clear();
                    txtEngine.Clear();
                    txtFuelC.Clear();
                    txtPrice.Clear();
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

            foreach (Cars i in db.Cars.ToList())
            {
                decimal price = Convert.ToDecimal(String.Format("{0:0.00}", i.Price));
                carDGV.Rows.Add(i.Id, i.Made, i.Mades.Made, i.Make, i.Engine, i.Year, i.FuelCons, price);
            }
        }

        private void fillCarMade()
        {
            List<Mades> CarsMade = db.Mades.ToList();
            foreach (Mades item in CarsMade)
            {
                comboBox1.Items.Add(item.Made);
            }
        }

        private void btnCreateEmployee_Click_1(object sender, EventArgs e)
        {
            createCars();
            carDGV.Rows.Clear();
            fillDGV();
        }

        private void UpdateThat()
        {
            int MadeID = db.Mades.FirstOrDefault(c => c.Made == comboBox1.Text).Id;
            Cars updateme = db.Cars.Find(UpdateDelete);
            updateme.Made = MadeID;
            updateme.Make = txtMake.Text;
            updateme.Year = Convert.ToInt32(txtYear.Text);
            updateme.FuelCons = Convert.ToInt32(txtFuelC.Text);
            updateme.Price = Convert.ToInt32(txtPrice.Text);

            db.SaveChanges();
            carDGV.Rows.Clear();
            fillDGV();

            //txtName.Clear();
            //txtDrivingLicence.Clear();
            //txtIdentity.Clear();
            //txtAge.Clear();
            ClearUpDel();

        }

        int UpdateDelete;
        private void carDGV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateDelete = Convert.ToInt32(carDGV.Rows[e.RowIndex].Cells[0].Value);

            comboBox1.Text = carDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMake.Text = carDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEngine.Text = carDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYear.Text = carDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtFuelC.Text = carDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPrice.Text = carDGV.Rows[e.RowIndex].Cells[7].Value.ToString();

            btnCarUpdate.Visible = true;
            btnDelete.Visible = true;
            btnCreateEmployee.Visible = false;
        }

        private void Delete()
        {
            Cars deleteMe = db.Cars.Find(UpdateDelete);
            db.Cars.Remove(deleteMe);
            db.SaveChanges();
            carDGV.Rows.Clear();
            fillDGV();
            ClearUpDel();
        }

        private void ClearUpDel()
        {
            txtMake.Clear();
            txtEngine.Clear();
            txtYear.Clear();
            txtFuelC.Clear();
            btnCarUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCreateEmployee.Visible = true;
        }

        private void btnCarUpdate_Click(object sender, EventArgs e)
        {
            UpdateThat();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
