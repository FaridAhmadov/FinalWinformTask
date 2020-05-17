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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;

namespace WinformFinal
{
    public partial class Accounting : Form
    {
        private WinFormFinalProjectEntities2 db;
        public Accounting()
        {
            InitializeComponent();
            this.db = new WinFormFinalProjectEntities2();
            fillAccountingDGV();

            DateTime MyDate = Convert.ToDateTime(db.Orders.Select(x => x.PickedDate).Min());
            DateTime YourDate = Convert.ToDateTime(db.Orders.Select(x => x.FinishDate).Max());

            dtFrom.Value = MyDate;
            dtTill.Value = YourDate;
        }

        private void fillAccountingDGV()
        {
            List<Orders> orders = db.Orders.ToList();
            foreach (Orders i in orders)
            {
                decimal price = Convert.ToDecimal(String.Format("{0:0.00}", i.Price));
                dgvComplete.Rows.Add(i.Id, i.ConsumerID, i.Consumers.FullName, i.CarMadeID, i.Mades.Made, i.CarMake, i.PickedDate, i.FinishDate, price, i.Status);
            }
        }

        private void DownloadExcel(List<Orders> myList)
        {
            var WB = new XLWorkbook();
            var WS = WB.Worksheets.Add("Final Project Table");

            WS.Range("B2:I2").Value = "Rent a Car Report";

            WS.Range("B2:I2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("B2:I2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Row(1).Height = 5;
            WS.Column("A").Width = 0.5;
            WS.Range("B2:I2").Merge();

            WS.Row(2).Height = 30;


            WS.Range("B3").Value = "ID";
            WS.Range("B3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("B3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("C3").Value = "Consumer";
            WS.Range("C3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("C3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("D3").Value = "Car Made";
            WS.Range("D3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("D3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("E3").Value = "Car Make";
            WS.Range("E3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("E3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("F3").Value = "Picked Date";
            WS.Range("F3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("F3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("G3").Value = "Expire Date";
            WS.Range("G3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("G3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("H3").Value = "Price";
            WS.Range("H3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("H3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

            WS.Range("I3").Value = "Status";
            WS.Range("I3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            WS.Range("I3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);



            int i = 4;
            List<Orders> orders = db.Orders.ToList();

            foreach (Orders item in myList)
            {
            
                WS.Cell("b" + i + "").Value = item.Id;
                WS.Cell("b" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("b" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                WS.Cell("c" + i + "").Value = item.Consumers.FullName;
                WS.Cell("c" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("c" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                WS.Columns("c").AdjustToContents();

                WS.Cell("d" + i + "").Value = item.Mades.Made;
                WS.Cell("d" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("d" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                WS.Columns("d").AdjustToContents();

                WS.Cell("e" + i + "").Value = item.CarMake;
                WS.Cell("e" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("e" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                WS.Cell("f" + i + "").Value = item.PickedDate;
                WS.Cell("f" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("f" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                WS.Columns("f").AdjustToContents();


                WS.Cell("g" + i + "").Value = item.FinishDate;
                WS.Cell("g" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("g" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                WS.Columns("g").AdjustToContents();

                WS.Cell("h" + i + "").Value = item.Price;
                WS.Cell("h" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("h" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                WS.Cell("i" + i + "").Value = item.Id;
                WS.Cell("i" + i + "").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                WS.Cell("i" + i + "").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);



                WB.SaveAs(@"C:\Users\Farid Ahmadov\Desktop\Food Excel File.xlsx");

                    i++;
                }
            
        }


        List<Orders> gLobalSearchDownload;
        private void Universal()
        {
            string tSearch = null;
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                tSearch = txtSearch.Text;
            }


            string cbS = null;
            if (!string.IsNullOrWhiteSpace(cbStatus.Text)&& cbStatus.Text!= "Choose...")
            {
                cbS = cbStatus.Text;
            }

           
            List<Orders> orders = db.Orders.Where(o =>
            ((tSearch != null ? o.CarMake.Contains(tSearch) : true) || (tSearch != null ? o.Mades.Made.Contains(tSearch) : true)) &&
            (cbS != null ? o.Status.Contains(cbS) : true) &&
            (cbS != null && cbS != "Choose..." ? o.Status.Contains(cbS) : true)&&
            (dtFrom.Value <= o.PickedDate) &&
            (o.PickedDate<= dtTill.Value)
            ).ToList();

            gLobalSearchDownload = orders;
            dgvComplete.Rows.Clear();

            foreach (Orders i in orders)
            {
                decimal price2 = Convert.ToDecimal(String.Format("{0:0.00}", i.Price));
                dgvComplete.Rows.Add(i.Id, i.ConsumerID, i.Consumers.FullName, i.CarMadeID, i.Mades.Made, i.CarMake, i.PickedDate, i.FinishDate, price2, i.Status);
            }
        }

        private void Search()
        {
            Universal();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DownloadExcel(gLobalSearchDownload);
            MessageBox.Show("Downloading succesfully completed!");
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }


        private void cbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Search();
        }

        private void cbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            Search();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dtTill_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
