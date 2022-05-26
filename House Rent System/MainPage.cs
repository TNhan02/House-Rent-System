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
    public partial class MainPage : Form
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_HRS;Integrated Security=True";
        List<Room> Existing_Room = new List<Room>();
        DataTable table = new DataTable();
        int available_room = 15;

        public MainPage()
        {
            InitializeComponent();
            GetAvailableRoom();
            available_room = 15 - Existing_Room.Count;
            AvailableRoom.Text = Convert.ToString(available_room);

            table.Columns.Add("Room");
            table.Columns.Add("NumberPeople");
            table.Columns.Add("Renter");
            table.Columns.Add("Date");
            table.Columns.Add("Total");
            BillTable.DataSource = table;
        }

        public void GetAvailableRoom()
        {
            SqlConnection con = new SqlConnection(constring);
            string query = @"SELECT Room FROM Room";
            var cmd = new SqlCommand(query, con);

            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Existing_Room.Add(new Room()
                    {
                        RoomNo = Convert.ToInt32(dr[0])
                    });
                };
            }
            con.Close();
        }

        private void Load()
        {
            SqlConnection con = new SqlConnection(constring);

            string query = @"SELECT Room.Room, Room.NumberPeople, Room.Renter, RoomBill.Date, RoomBill.Total";
            query += " FROM Room INNER JOIN RoomBill ON Room.Room = RoomBill.Room";

            SqlCommand cmd = new SqlCommand(query, con);
            
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(table);
            con.Close();
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
