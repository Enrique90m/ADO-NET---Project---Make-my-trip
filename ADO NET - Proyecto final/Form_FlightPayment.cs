using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_NET___Proyecto_final
{
    public partial class Form_FlightPayment : Form
    {
        double [] dTotals;
        Flight fl;
        int[] iPass;
        int iCustID;
        string [,] PassengerDetails;

        public Form_FlightPayment(double[] oTotals, Flight pfl, int[] pass, int piCustID, string[,] pPassengerDetails)
        {
            InitializeComponent();
            dTotals = oTotals;
            fl = new Flight(pfl);
            iPass = pass;
            iCustID = piCustID;
            PassengerDetails = pPassengerDetails;
        }

        private void Form_FlightPayment_Load(object sender, EventArgs e)
        {
            //Cargo datos en labels
            label_Source.Text = fl.Source;
            label_Destination.Text = fl.Destination;
            label_NoOfAdults.Text = iPass[0].ToString();
            label_NoOfChildren.Text = iPass[1].ToString();
            label_AdultFare.Text = dTotals[0].ToString();
            label_ChildrenFare.Text = dTotals[1].ToString();
            label_TaxAmount.Text = dTotals[2].ToString();
            label_Total.Text = dTotals[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inserto reservacion
            flight_BookingTableAdapter1.InsertQuery(fl.FlightNo, iCustID, DateTime.Now, fl.Departure, iPass[0], iPass[1]);

            //Actualizo total de pasajeros
            flightTableAdapter1.UpdatePassenger(fl.TotalPassenger, fl.FlightNo);
            
            //Inserto pasajeros en tabla 
            for (int i = 0; i < iPass[0]; i++)
                    passengerDetailsTableAdapter1.InsertPassenger(iCustID, fl.FlightNo, PassengerDetails[i,0], PassengerDetails[i,1], PassengerDetails[i,2]);

            for (int i = 0; i < iPass[1]; i++)   
                    passengerDetailsTableAdapter1.InsertPassenger(iCustID, fl.FlightNo, "CHL", PassengerDetails[i, 1], PassengerDetails[i, 2]);

            //Imprimo su booking ID
            string BookingID = flight_BookingTableAdapter1.NewBookingId().ToString();
            MessageBox.Show("Vuelo reservado, su numero de reserva es:  " + BookingID);

            //Regreso a formulario original
            Form_SearchFlight sf = new Form_SearchFlight();
            sf.Show();
            Close();
        }


    }
}
