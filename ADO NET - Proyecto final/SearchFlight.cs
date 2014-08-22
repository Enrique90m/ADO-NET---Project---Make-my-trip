using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET___Proyecto_final
{
    class SearchFlight : FlightBooking
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
    }
}
