using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBookingSystem
{
    class clsRoute
    {
        public string cRID, cFrom, cTo, cRType;
        public int cP;

        public string cRoute_ID
        {
            get
            {
                return cRID;
            }
            set
            {
                cRID = value;
            }
        }
        public string cRoute_From
        {
            get
            {
                return cFrom;
            }
            set
            {
                cFrom = value;
            }
        }
        public int cPrice
        {
            get
            {
                return cP;
            }
            set
            {
                cP = value;
            }
        }
        public string cRoute_Type
        {
            get
            {
                return cRType;
            }
            set
            {
                cRType = value;
            }
        }
    }
}
