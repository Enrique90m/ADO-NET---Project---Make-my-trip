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
        SearchFlight ObjSearchFligfht;
        public DisplayFlight(SearchFlight sf)
        {
            InitializeComponent();
            ObjSearchFligfht = new SearchFlight(sf.Source,sf.Destination,sf.TimeStart,sf.TimeEnd,sf.CustomerId,DateTime.Now,sf.NoOfAdults,sf.NoOfChildren, sf.SearchedDate);
        }

        private void DisplayFlight_Load(object sender, EventArgs e)
        {

        }
    }
}
