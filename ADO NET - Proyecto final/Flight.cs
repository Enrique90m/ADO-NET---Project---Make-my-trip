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

        public Flight()
        {
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



    }
}
