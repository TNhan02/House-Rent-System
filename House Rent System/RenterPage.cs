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
    public partial class deleteButton : Form
    {
        DataTable table = new DataTable();
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_HRS;Integrated Security=True";
        public deleteButton()
        {
            InitializeComponent();
            table.Columns.Add("IDNumber");
            table.Columns.Add("Name");
            table.Columns.Add("Phone");
            table.Columns.Add("PlaceofOrigin");
            table.Columns.Add("Room");

            RenterTable.DataSource = table;
            LoadData();
        }

        public void AddData()
        {
            SqlConnection con = new SqlConnection(constring);
            var query = "SET IDENTITY_INSERT Renter ON;"
                      + "INSERT INTO Renter(IDNumber, Name, Phone, PlaceofOrigin, Room) "
                      + "VALUES(@IDNumber, @Name, @Phone, @PlaceofOrigin, @Room)";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("IDNumber", addID.Text);
            cmd.Parameters.AddWithValue("Name", addName.Text);
            cmd.Parameters.AddWithValue("Phone", addPhone.Text);
            cmd.Parameters.AddWithValue("PlaceofOrigin", addOrigin.Text);
            cmd.Parameters.AddWithValue("Room", addRoom.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LoadData()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string query = @"SELECT * FROM Renter";

            try
            {
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                data.Fill(ds, "Renter");
                RenterTable.DataSource = ds.Tables["Renter"].DefaultView;
                con.Close();
            }
            catch (Exception ex) { }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
        }

        private void searchID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            string cmd = "SELECT * FROM Renter WHERE IDNumber LIKE '" + searchID.Text + "%' "
                        + "OR Name LIKE'" + searchID.Text + "%'";

            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(cmd, con);
            DataTable dt = new DataTable();
            data.Fill(dt);
            RenterTable.DataSource = dt;
            con.Close();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in RenterTable.SelectedRows)
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
