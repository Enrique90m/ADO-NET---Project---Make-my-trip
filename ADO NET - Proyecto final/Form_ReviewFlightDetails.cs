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
    public partial class Form_ReviewFlightDetails : Form
    {
        Flight ObjFlight;
        int iAdults;
        int iChildren;

        public Form_ReviewFlightDetails(Flight fl, int piAdults, int piChildren)
        {
            InitializeComponent();
            ObjFlight = new Flight(fl);
            iAdults = piAdults;
            iChildren = piChildren;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void Form_ReviewFlightDetails_Load(object sender, EventArgs e)
        {
            //Calculo lo que debe pagar... tax, total
            double BaseFareAdults, BaseFareChildren, TaxAdult, TaxChildren, TotalAdult, TotalChildren, GrandTotal;
            BaseFareAdults = iAdults * ObjFlight.AdultFare;
            BaseFareChildren = iChildren * ObjFlight.ChildrenFare;
            TaxAdult = BaseFareAdults * 0.10;
            TaxChildren = BaseFareChildren * 0.10;
            TotalAdult = BaseFareAdults + TaxAdult;
            TotalChildren = BaseFareChildren + TaxChildren;
            GrandTotal = TotalAdult + TotalChildren;

            //Pongo totales en labels
            label_Destination.Text = ObjFlight.Destination;
            label_Source.Text = ObjFlight.Source;
            label_FlightNo.Text = ObjFlight.FlightNo.ToString();
            label_Departure.Text = ObjFlight.Departure.ToString("yyyy-MM-dd");
            label_Arrival.Text = ObjFlight.ArrivalDate.ToString("yyyy-MM-dd");
            label_NoOfAdults.Text = iAdults.ToString();
            label_NoOfChildren.Text = iChildren.ToString();
            label_BaseFareAdults.Text = iAdults.ToString() + "*" + ObjFlight.AdultFare.ToString() + "=" + BaseFareAdults.ToString();
            label_BaseFareChildren.Text = iChildren.ToString() + "*" + ObjFlight.ChildrenFare.ToString() + "=" + BaseFareChildren.ToString();
            label_TaxesAdult.Text = BaseFareAdults.ToString() + "* 10%" + "=" + TaxAdult.ToString();
            label_TaxesChildren.Text = BaseFareChildren.ToString() + "* 10%" + "=" + TaxChildren.ToString();
            label_TotalAdults.Text = TotalAdult.ToString();
            label_TotalChildren.Text = TotalChildren.ToString();
            label_GrandTotal.Text = GrandTotal.ToString();

        }




    }
}
