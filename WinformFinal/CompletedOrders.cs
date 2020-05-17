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

namespace WinformFinal.Models
{
    public partial class CompletedOrders : Form
    {
        private WinFormFinalProjectEntities2 db;
        public CompletedOrders()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillit();
        }

        private void fillit()
        {

            List<AllOrders> Completedorders = db.AllOrders.ToList();
            foreach (AllOrders i in Completedorders)
            {
                dgvComplete.Rows.Add(i.Id, i.ConsumerID, i.Consumers.FullName, i.CarmadeID, i.Mades.Made, i.Carmake, i.PickedDate, i.FinishDate, i.Price, i.Status);
            }
        }
    }
}
