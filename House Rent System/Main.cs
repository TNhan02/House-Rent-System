using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Rent_System
{
    public partial class Main : Form
    {
        MainPage main_page = new MainPage();
        RoomPage room_page = new RoomPage();
        ContractPage contract_page = new ContractPage();
        deleteButton renter_page = new deleteButton();

        public Main()
        {
            InitializeComponent();

            OpenTabForm(MainPage, main_page, mainButton);
        }
        public void OpenTabForm(TabPage tp, Form f, Button b)
        {
            f.TopLevel = false;
            //no border if needed
            f.FormBorderStyle = FormBorderStyle.None;
            f.AutoScaleMode = AutoScaleMode.Dpi;

            if ((!tp.Controls.Contains(f)) & (b.Enabled))
            {
                tp.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
                Refresh();
            }
            Refresh();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            OpenTabForm(MainPage, main_page, mainButton);
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            OpenTabForm(RoomPage, room_page, roomButton);
        }

        private void contractButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            OpenTabForm(ContractPage, contract_page, contractButton);
        }

        private void renterButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            OpenTabForm(RenterPage, renter_page, renterButton);
        }
    }
}
