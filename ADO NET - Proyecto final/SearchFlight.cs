using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET___Proyecto_final
{
    public class SearchFlight: FlightBooking
    {
        //Atributos
        string sSource { get; set; }
        string sDestination { get; set; }
        int iTimeStart { get; set; }
        int iTimeEnd { get; set; }
        DateTime dtSearchedDate { get; set; }

        //Contructores
        public SearchFlight(string psSource, string psDestination, int piTimeStart, int piTimeEnd, int piCustomerId, DateTime pdtDateOfBooking, int piNoOfAdults, int piNoOfChildren, DateTime pdtSearchedDate)
        {
            sSource = psSource;
            sDestination = psDestination;
            iTimeStart = piTimeStart;
            iTimeEnd = piTimeEnd;
            dtDateOfBooking = pdtDateOfBooking;
            iNoOfChildren = piNoOfChildren;
            iNoOfAdults = piNoOfAdults;
            dtSearchedDate = pdtSearchedDate;
        }

        public string Source
        {
            get
            {
                return sSource;
            }

            set
            {
                sSource = value;
            }
        }
        public string Destination
        {
            get
            {
                return sDestination;
            }

            set
            {
                sDestination = value;
            }
        }
        public int TimeStart
        {
            get
            {
                return iTimeStart;
            }

            set
            {
                iTimeStart = value;
            }
        }
        public int TimeEnd
        {
            get
            {
                return iTimeEnd;
            }

            set
            {
                iTimeEnd = value;
            }
        }
        public DateTime SearchedDate
        {
            get
            {
                return dtSearchedDate;
            }

            set
            {
                dtSearchedDate = value;
            }
        }
        public int CustomerId
        {
            get
            {
                return iCustomerId;
            }

            set
            {
                iCustomerId = value;
            }
        }
        public int NoOfAdults
        {
            get
            {
                return iNoOfAdults;
            }

            set
            {
                iNoOfAdults = value;
            }
        }
        public int NoOfChildren
        {
            get
            {
                return iNoOfChildren;
            }

            set
            {
                iNoOfChildren = value;
            }
        }



    }
}
