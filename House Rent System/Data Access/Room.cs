using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent_System
{
    class Room 
    {
        List<Room> RoomList = new List<Room>();

        public int RoomNo;
        public int NoPeople;
        public string Renter;
        public int Rent;
        public int ElectricFigure;
        public int WaterFigure;
        public string Items;

        public void AddRoom()
        {
            Room r = new Room();

            r.RoomNo = RoomNo;
            r.NoPeople = NoPeople;
            r.Renter = Renter;
            r.Rent = Rent;
            r.ElectricFigure = ElectricFigure;
            r.WaterFigure = WaterFigure;
            r.Items = Items;

            RoomList.Add(r);
        }
    }
}
