using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET___Proyecto_final
{
    class FlightBooking : Flight
    {
        //Atributos
        int iBookingId { get; set; }
        protected int iCustomerId { get; set; }
        protected DateTime dtDateOfBooking { get; set; }
        protected DateTime dtDateOfDeparture { get; set; }
        protected int iNoOfAdults { get; set; }
        protected int iNoOfChildren { get; set; }

        //Constructores 
        public FlightBooking(int piFlightNo, int piBookingId, int piCustomerId, DateTime pdtDateOfBooking, DateTime pdtDateOfDeparture, int piNoOfAdults, int piNoOfChildren) 
        {
            iFlightNo = piFlightNo;
            iBookingId = piBookingId;
            dtDateOfBooking = pdtDateOfBooking;
            dtDateOfDeparture = pdtDateOfDeparture;
            iNoOfAdults = piNoOfAdults;
            iNoOfChildren = piNoOfChildren;
        }
    }
}
