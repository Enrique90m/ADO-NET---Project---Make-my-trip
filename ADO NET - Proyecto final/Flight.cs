using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET___Proyecto_final
{
    public class Flight
    {
        //Atributos
        protected int iFlightNo { get; set; }
        string sSource { get; set; }
        string sDestination { get; set; }
        DateTime dtDeparture { get; set; }
        DateTime dtArrivalDate { get; set; }
        int iAdultFare { get; set; }
        int iChildrenFare { get; set; }
        int iTotalPassenger { get; set; }

        //Constructores
        public Flight(int piFlightNo, string psSource, string psDestination, DateTime pdtDeparture, DateTime pdtArrivalDate, int piAdultFare, int piChildrenFare, int piTotalPassenger) 
        {
            iFlightNo = piFlightNo;
            sSource = psSource;
            sDestination = psDestination;
            dtDeparture = pdtDeparture;
            dtArrivalDate = pdtArrivalDate;
            iAdultFare = piAdultFare;
            iChildrenFare = piChildrenFare;
            iTotalPassenger = piTotalPassenger;
        }

        public Flight( Flight fl)
        {
            iFlightNo = fl.iFlightNo;
            sSource = fl.sSource;
            sDestination = fl.sDestination;
            dtDeparture = fl.dtDeparture;
            dtArrivalDate = fl.dtArrivalDate;
            iAdultFare = fl.iAdultFare;
            iChildrenFare = fl.iChildrenFare;
            iTotalPassenger = fl.iTotalPassenger;
        }

        public  string Source
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
        public int FlightNo
        {
            get
            {
                return iFlightNo;
            }

            set
            {
                iFlightNo = value;
            }
        }
        public int AdultFare
        {
            get
            {
                return iAdultFare;
            }

            set
            {
                iAdultFare = value;
            }
        }
        public int ChildrenFare
        {
            get
            {
                return iChildrenFare;
            }

            set
            {
                iChildrenFare = value;
            }
        }
        public int TotalPassenger
        {
            get
            {
                return iTotalPassenger;
            }

            set
            {
                iTotalPassenger = value;
            }
        }
        public DateTime Departure
        {
            get
            {
                return dtDeparture;
            }

            set
            {
                dtDeparture = value;
            }
        }
        public DateTime ArrivalDate
        {
            get
            {
                return dtArrivalDate;
            }

            set
            {
                dtArrivalDate = value;
            }
        }

    }
}
