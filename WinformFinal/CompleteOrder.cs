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
    public partial class CompleteOrder : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CompleteOrder()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillDGV();

        }
        private void fillDGV()
        {
            List<Orders> orders = db.Orders.Where(o=>o.Status!="Completed").ToList();
            foreach (Orders i in orders)
            {
                int PriceFromCar = db.Cars.FirstOrDefault(c => c.Make == i.CarMake).Id;
                Cars abc = db.Cars.Find(PriceFromCar);
                TimeSpan tspanNormal = (i.FinishDate.Value - i.PickedDate.Value);
                int rentday = System.Math.Abs(tspanNormal.Days);

                if (i.FinishDate > DateTime.Now)
                {
                    decimal NormalPrice = Convert.ToDecimal(String.Format("{0:0.00}", (abc.Price * rentday)));

                    i.Price = NormalPrice;
                    i.Status = "Ongoing";
                }
                else
                {                   
                    i.Status = "expired";
                   
                    TimeSpan tspan = (DateTime.Now - i.FinishDate.Value);
                    int Expire = tspan.Days;
                    decimal sum = Convert.ToDecimal(String.Format("{0:0.00}", ((rentday * abc.Price) + (Expire * (abc.Price / 100*20)))));
                    String.Format("{0:0.00}", sum);
                    i.Price = sum;
                }

                db.SaveChanges();

                dgvComplete.Rows.Add(i.Id, i.ConsumerID, i.Consumers.FullName, i.CarMadeID, i.Mades.Made, i.CarMake, i.PickedDate, i.FinishDate, i.Price, i.Status);

            }
        }


        int comleteID;
        private void dgvComplete_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dateTimePicker1.Visible = true;
            comboBox1.Visible = true;
            btnUpdate.Visible = true;
            lblExpire.Visible = true;
            lblStatus.Visible = true;

            comleteID = Convert.ToInt32(dgvComplete.Rows[e.RowIndex].Cells[0].Value);
            comboBox1.Text =dgvComplete.Rows[e.RowIndex].Cells[9].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgvComplete.Rows[e.RowIndex].Cells[7].Value);

          
        }

        private void updateComplete()
        {
            Orders ordersss = db.Orders.Find(comleteID);
            ordersss.Status = comboBox1.Text;
            ordersss.FinishDate = dateTimePicker1.Value;

            if (ordersss.Status == "Completed")
            {
                dateTimePicker1.Value = DateTime.Now;


                AllOrders allOrders = new AllOrders();
                allOrders.ConsumerID = ordersss.ConsumerID;
                allOrders.CarmadeID = Convert.ToInt32(ordersss.CarMadeID);
                allOrders.Carmake = ordersss.CarMake;
                allOrders.Status = "Completed";
                allOrders.PickedDate = ordersss.PickedDate;
                allOrders.FinishDate = ordersss.FinishDate;
                allOrders.Price = ordersss.Price;
                db.AllOrders.Add(allOrders);
            }
            db.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateComplete();
            dgvComplete.Rows.Clear();
            fillDGV();


        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            CompletedOrders completedOrders = new CompletedOrders();
            completedOrders.Show();
        }
    }
}
