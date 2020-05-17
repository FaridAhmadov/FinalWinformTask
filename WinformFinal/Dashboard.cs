using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class Dashboard : Form
    {
        private WinFormFinalProjectEntities2 db;
        public Dashboard()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            AddOrderstoDash();
        }
        private void AddOrderstoDash()
        {
            List<Orders> orderss = db.Orders.ToList();
            List<Orders> orders = db.Orders.ToList().GetRange(orderss.Count - 10, 10);

            foreach (Orders i in orders)
            {
                dgvDash.Rows.Add(i.Id, i.ConsumerID, i.Consumers.FullName, i.CarMadeID, i.Mades.Made, i.CarMake, i.PickedDate, i.FinishDate);
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateConsumers consumers = new CreateConsumers();
            consumers.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            CreateNewOrder createNewOrder = new CreateNewOrder();
            createNewOrder.Show();
        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCars createCars = new CreateCars();
            createCars.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEmployees createEmployees = new CreateEmployees();
            createEmployees.Show();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            CompleteOrder completeOrder = new CompleteOrder();
            completeOrder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Show();
        }
    }
}
