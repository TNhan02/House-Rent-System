using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Rent_System
{
    class Contract
    {
        List<Contract> ContractList = new List<Contract>();

        public int RoomNo;
        public string Renter;
        public string Phone;
        public int Rent;
        public DateTime StartDate;
        public DateTime EndDate;

        public void AddContract()
        {
            Contract con = new Contract();

            con.RoomNo = RoomNo;
            con.Renter = Renter;
            con.Rent = Rent;
            con.StartDate = StartDate;
            con.EndDate = EndDate;

            ContractList.Add(con);
        }
    }
}
