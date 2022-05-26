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
    public partial class ContractPage : Form
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_HRS;Integrated Security=True";
        DataTable table = new DataTable();
        public ContractPage()
        {
            InitializeComponent();
            table.Columns.Add("RoomNumber");
            table.Columns.Add("Renter");
            table.Columns.Add("Phone");
            table.Columns.Add("Rent");
            table.Columns.Add("StartDate");
            table.Columns.Add("EndDate");
            ContractTable.DataSource = table;

            LoadData();
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string query = @"SELECT * FROM Contract";

            try
            {
                con.Open();
                SqlDataAdapter data = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                data.Fill(ds, "Contract");
                ContractTable.DataSource = ds.Tables["Contract"].DefaultView;
                con.Close();
            }
            catch (Exception ex) { }
        }
        public void AddData()
        {
            SqlConnection con = new SqlConnection(constring);
            var query = "SET IDENTITY_INSERT Contract ON;"
                      + "INSERT INTO Contract(Room, Renter, Phone, Rent, StartDate, EndDate) "
                      + "VALUES(@Room, @Renter, @Phone, @Rent, @StartDate, @EndDate)";

            var cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("Room", addRoom.Text);
            cmd.Parameters.AddWithValue("Renter", addRenter.Text);
            cmd.Parameters.AddWithValue("Phone", addPhone.Text);
            cmd.Parameters.AddWithValue("Rent", addRent.Text);
            cmd.Parameters.AddWithValue("StartDate", addStartDate.Text);
            cmd.Parameters.AddWithValue("EndDate", addEndDate.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
            LoadData();
        }
    }
}
