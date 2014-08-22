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
    public partial class DisplayFlight : Form
    {
        //Objeto para recibir datos 
        SearchFlight ObjSearchFligfht;

        public DisplayFlight(SearchFlight sf)
        {
            InitializeComponent();
            //Paso los datos al objeto local
            ObjSearchFligfht = new SearchFlight(sf.Source,sf.Destination,sf.TimeStart,sf.TimeEnd,sf.CustomerId,DateTime.Now,sf.NoOfAdults,sf.NoOfChildren, sf.SearchedDate);
        }

        private void DisplayFlight_Load(object sender, EventArgs e)
        {
            //Cargo datos en labels
            label_Source.Text = ObjSearchFligfht.Source;
            label_Destination.Text = ObjSearchFligfht.Destination;
            label_TimeStart.Text = ObjSearchFligfht.TimeStart.ToString();
            label_TimeEnd.Text = ObjSearchFligfht.TimeEnd.ToString();
            label_DepartureDate.Text = ObjSearchFligfht.SearchedDate.ToString("yyyy-MM-dd");
            label_Adults.Text = ObjSearchFligfht.NoOfAdults.ToString();

            //Si hay niños, muestro los labels de niños y pongo su numero
            if(ObjSearchFligfht.NoOfChildren != 0)
            {
                label_Children.Visible = true;
                label_ChildrenText.Visible = true;
                label_Children.Text = ObjSearchFligfht.NoOfChildren.ToString();
            }
        }
    }
}
