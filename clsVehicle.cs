using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBookingSystem
{
    class clsVehicle
    {
        public string vID, vName, vType;
        public int tSeat;

        public string cVehicle_ID
        {
            get
            {
                return vID;
            }
            set
            {
                vID = value;
            }
        }
        public string cVehicle_Name
        {
            get
            {
                return vName;
            }
            set
            {
                vName = value;
            }
        }
        public string cVehicle_Type
        {
            get
            {
                return vType;
            }
            set
            {
                vType = value;
            }
        }
        public int cTotal_Seat
        {
            get
            {
                return tSeat;
            }
            set
            {
                tSeat = value;
            }
        }
    }
}
