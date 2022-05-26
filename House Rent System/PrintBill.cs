using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent_System
{
    public partial class PrintBill : Form
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_HRS;Integrated Security=True";
        public PrintBill()
        {
            InitializeComponent();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewPDF.Document = printPDF;
            printPDF.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewPDF.ShowDialog();
        }
        private void SaveBill()
        {
            DateTime date = DateTime.Now.Date;

            SqlConnection con = new SqlConnection(constring);
            var query = "SET IDENTITY_INSERT RoomBill ON;"
                      + "INSERT INTO RoomBill(Room, Renter, Rent, Electricity, Water, Internet, Security, Date, Total) "
                      + "VALUES(@Room, @Renter, @Rent, @Electricity, @Water, @Internet, @Security, @Date, @Total)";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Room", Room.Text);
            cmd.Parameters.AddWithValue("Renter", Renter.Text);
            cmd.Parameters.AddWithValue("Rent", Rent.Text);
            cmd.Parameters.AddWithValue("Electricity", ElectricityCost.Text);
            cmd.Parameters.AddWithValue("Water", WaterCost.Text);
            cmd.Parameters.AddWithValue("Internet", InternetCost.Text);
            cmd.Parameters.AddWithValue("Security", SecurityCost.Text);
            cmd.Parameters.AddWithValue("Date", date);
            cmd.Parameters.AddWithValue("Total", Total.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            SaveBill();
            Print(this.panelPrint);
        }
    }
}
