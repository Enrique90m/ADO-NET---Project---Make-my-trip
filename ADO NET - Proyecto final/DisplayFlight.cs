using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_NET___Proyecto_final
{
    public partial class DisplayFlight : Form
    {
        //Objeto para recibir datos 
        SearchFlight ObjSearchFlight;
        

        public DisplayFlight(SearchFlight sf)
        {
            InitializeComponent();
            //Paso los datos al objeto local
            ObjSearchFlight = new SearchFlight(sf.Source,sf.Destination,sf.TimeStart,sf.TimeEnd,sf.CustomerId,DateTime.Now,sf.NoOfAdults,sf.NoOfChildren, sf.SearchedDate,sf.CustomerId);
        }

        private void DisplayFlight_Load(object sender, EventArgs e)
        {
            //Cargo datos en labels
            label_Source.Text = ObjSearchFlight.Source;
            label_Destination.Text = ObjSearchFlight.Destination;
            label_TimeStart.Text = ObjSearchFlight.TimeStart.ToString();
            label_TimeEnd.Text = ObjSearchFlight.TimeEnd.ToString();
            label_DepartureDate.Text = ObjSearchFlight.SearchedDate.ToString("yyyy-MM-dd");
            label_Adults.Text = ObjSearchFlight.NoOfAdults.ToString();

            //Si hay niños, muestro los labels de niños y pongo su numero
            if (ObjSearchFlight.NoOfChildren != 0)
            {
                label_Children.Visible = true;
                label_ChildrenText.Visible = true;
                label_Children.Text = ObjSearchFlight.NoOfChildren.ToString();
            }

            DateTime dtStart = new DateTime(ObjSearchFlight.SearchedDate.Year,ObjSearchFlight.SearchedDate.Month,ObjSearchFlight.SearchedDate.Day,ObjSearchFlight.TimeStart,0,0);
            DateTime dtEnd = new DateTime(ObjSearchFlight.SearchedDate.Year, ObjSearchFlight.SearchedDate.Month, ObjSearchFlight.SearchedDate.Day, ObjSearchFlight.TimeEnd, 0, 0);
            //OR  datediff(hour, @HourEnd,DepartureDate) > 0 ) 

            //Muestro vuelos diponibles
            this.flightTableAdapter1.BuscaVuelos(this.projectAirlineDataSet.Flight,
                                                ObjSearchFlight.Source,
                                                ObjSearchFlight.Destination,
                                                ObjSearchFlight.SearchedDate.ToString("yyyy-MM-dd"),
                                                dtStart,
                                                dtEnd);
                                                

            dataGridView_Flights.DataSource = this.projectAirlineDataSet.Flight;

            //Si no hay datos muetro label de que no hay registros
            if (dataGridView_Flights.Rows.Count == 0)
            {
                dataGridView_Flights.Enabled = false;
                label_NoRecordsFound.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SearchFlightForm = (Form_SearchFlight)Tag;
            SearchFlightForm.Show();
            Close();
        }

        private void dataGridView_Flights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifico que la columna en la que hizo click sea la del botton
            if (e.ColumnIndex == dataGridView_Flights.Columns[8].Index)
            {
                //Creo objeto con los datos
                Flight fl = new Flight(int.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[0].Value.ToString()),
                                        ObjSearchFlight.Source,
                                        ObjSearchFlight.Destination,
                                        ObjSearchFlight.SearchedDate,
                                        DateTime.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[4].Value.ToString()),
                                        int.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[5].Value.ToString()),
                                        int.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[6].Value.ToString()),
                                        int.Parse(dataGridView_Flights.Rows[e.RowIndex].Cells[7].Value.ToString()));
                Form_ReviewFlightDetails rev = new Form_ReviewFlightDetails(fl, ObjSearchFlight.NoOfAdults, ObjSearchFlight.NoOfChildren, ObjSearchFlight.CustomerId);
                rev.Show();
                this.Hide();

            }
        }

      
    }
}
