using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace House_Rent_System
{
    public partial class RoomPage : Form
    {
        PrintBill Bill = new PrintBill();
        List<Room> RoomList = new List<Room>();
        DataTable table = new DataTable();
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_HRS;Integrated Security=True";
        string BillFolder = @"C:\Users\Admin\source\repos\House Rent System\House Rent System\Bill\2022";

        public RoomPage()
        {
            InitializeComponent();
            table.Columns.Add("Room");
            table.Columns.Add("NumberPeople");
            table.Columns.Add("Renter");
            table.Columns.Add("Rent");
            table.Columns.Add("ElectricFigure");
            table.Columns.Add("WaterFigure");
            RoomTable.DataSource = table;
            LoadData();

            Month_Year.Text = DateTime.Now.ToLongDateString();
        }

        public void AddData()
        {
            SqlConnection con = new SqlConnection(constring);
            var query = "SET IDENTITY_INSERT Room ON;"
                      + "INSERT INTO Room(Room, NumberPeople, Renter, Rent, ElectricFigure, WaterFigure) "
                      + "VALUES(@Room, @NumberPeople, @Renter, @Rent, @ElectricFigure, @WaterFigure)";

            var cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(table);
            con.Close();
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string query = @"SELECT * FROM Room";

            try
            {
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                data.Fill(ds, "Room");
                RoomTable.DataSource = ds.Tables["Room"].DefaultView;
                con.Close();
            }
            catch(Exception ex) { }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
        }

        private void searchRoom_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string command = "SELECT * FROM Room WHERE Room LIKE '" + searchRoom.Text + "%'";
            
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            RoomTable.DataSource = dt;
            con.Close();
        }


        public void GetDataFromTable()
        {
            int Rent = 0;
            int Electricitycost = 0;
            int Watercost = 0;
            int Total = 0;
            int Water = 0;
            int Electricity = 0;
            int Electricityprice = 3500;
            int Waterprice = 8000;
            int Internetcost = 65000;
            int Securitycost = 30000;

            foreach (DataGridViewRow row in RoomTable.SelectedRows)
            {
                Rent = Convert.ToInt32(row.Cells[3].Value);
                Electricity = Convert.ToInt32(row.Cells[4].Value);
                Water = Convert.ToInt32(row.Cells[5].Value);
                Electricitycost = Electricity * Electricityprice;
                Watercost = Water * Waterprice;
                Total = Rent + Watercost + Electricitycost + Internetcost + Securitycost;

                Bill.Date.Text = string.Format(DateTime.Now.ToString("dd/MM/yyyy"));
                Bill.Period.Text = string.Format(DateTime.Now.ToString("MM/yyyy"));
                Bill.Room.Text = Convert.ToString(row.Cells[0].Value);
                Bill.Renter.Text = Convert.ToString(row.Cells[2].Value);
                Bill.Rent.Text = Convert.ToString(row.Cells[3].Value);

                Bill.ElectricFigure.Text = Convert.ToString(Electricity);
                Bill.WaterFigure.Text = Convert.ToString(Water);
                Bill.ElectricityPrice.Text = Convert.ToString(Electricityprice);
                Bill.WaterPrice.Text = Convert.ToString(Waterprice);
                Bill.WaterCost.Text = Convert.ToString(Watercost);
                Bill.ElectricityCost.Text = Convert.ToString(Electricitycost);
                Bill.InternetCost.Text = Convert.ToString(Internetcost);
                Bill.SecurityCost.Text = Convert.ToString(Securitycost);

                Bill.Total.Text = Convert.ToString(Total);
            }
        }

        private void print_billButton_Click(object sender, EventArgs e)
        {
            GetDataFromTable();
            Bill.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in RoomTable.SelectedRows)
            {
                SqlConnection con = new SqlConnection(constring);
                var query = $"DELETE FROM Room WHERE Room = {row.Cells[0].Value} ";
                query += $"DELETE FROM Contract WHERE Room = {row.Cells[0].Value}";
                query += $"DELETE FROM Renter WHERE Room = {row.Cells[0].Value}";
                var cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(table);
                con.Close();

                LoadData();
            }
        }
    }
}
