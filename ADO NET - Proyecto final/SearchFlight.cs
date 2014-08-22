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

        //Contructores
        public SearchFlight(string psSource, string psDestination, int piTimeStart, int piTimeEnd)
        {
            sSource = psSource;
            sDestination = psDestination;
            iTimeStart = piTimeStart;
            iTimeEnd = piTimeEnd;
        }
    }
}
