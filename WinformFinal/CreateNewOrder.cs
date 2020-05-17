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
    public partial class CreateNewOrder : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CreateNewOrder()
        {
            this.db = new WinFormFinalProjectEntities2();
            InitializeComponent();
            fillConsumers();
            fillCarMade();
        }


        private void qqq()
        {
            if (!string.IsNullOrWhiteSpace(cbConsumerName.Text) &&
                !string.IsNullOrWhiteSpace(cbCarMade.Text) &&
                !string.IsNullOrWhiteSpace(cbCarMake.Text) &&
                cbConsumerName.Text != "Choose..." &&
                cbCarMake.Text != "Choose..." &&
                cbCarMade.Text != "Choose..."
                )
            {
                AllOrders allOrders = new AllOrders();
                Orders orders = new Orders();

                int getCarConsumerID = db.Consumers.FirstOrDefault(m => m.FullName == cbConsumerName.Text).Id;
                int getCarMadeID = db.Mades.FirstOrDefault(m => m.Made == cbCarMade.Text).Id;
                int getCarPrice = db.Cars.FirstOrDefault(m => m.Make == cbCarMake.Text).Id;

                Cars inttt = db.Cars.Find(getCarPrice);

                orders.ConsumerID = Convert.ToInt32(getCarConsumerID);
                orders.CarMadeID = Convert.ToInt32(getCarMadeID);
                orders.CarId = Convert.ToInt32(getCarPrice);
                orders.CarMake = cbCarMake.Text;
                orders.PickedDate = dtFrom.Value;
                orders.FinishDate = dtTill.Value;
                orders.Price = inttt.Price;

                db.Orders.Add(orders);
                db.SaveChanges();
                MessageBox.Show("Order Succesfully Created!");
            }
            else
            {
                MessageBox.Show("Please Fill All Fields! By the way 'Choose' is not an option");
            }
        }

        private void AddToOrders()
        {

            if (db.Orders.FirstOrDefault(o => o.CarMake == cbCarMake.Text && o.Status != "Completed") != null)
            {
                MessageBox.Show("Sorry! But this car is not available for now!");
            }
            else
            {
                qqq();
            }
        }


        private void fillConsumers()
        {
            List<Consumers> consumers = db.Consumers.ToList();
            foreach (Consumers item in consumers)
            {
                cbConsumerName.Items.Add(item.FullName);
            }
        }
        private void fillCarMade()
        {
            List<Mades> CarsMade = db.Mades.ToList();
            foreach (Mades item in CarsMade)
            {
                cbCarMade.Items.Add(item.Made);
            }
        }

        private void fillCarMake()
        {
            cbCarMake.Items.Clear();
            int CarsMade = db.Mades.FirstOrDefault(m => m.Made == cbCarMade.Text).Id;
            List<Cars> CarsMakes = db.Cars.ToList();
            foreach (Cars i in CarsMakes)
            {
                if (i.Made == CarsMade)
                {
                    cbCarMake.Items.Add(i.Make);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CreateConsumers ccreateConsumers = new CreateConsumers())
            {
                ccreateConsumers.ShowDialog(this);
            }
            cbConsumerName.Items.Clear();
            fillConsumers();
        }


        private void cbCarMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCarMake();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddToOrders();
        }


        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            using (CreateCars createCars = new CreateCars())
            {
                createCars.ShowDialog(this);
            }
        }
    }
}

