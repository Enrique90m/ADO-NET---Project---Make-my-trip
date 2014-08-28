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
    public partial class Form_TravelerDetails : Form
    {
        //Variables para datos
        int iTotalAdults, iTotalChildren, iTotalTravelers, iIndicePasajerosCapturados, iCustID;
        int[] iPass;
        double [] dTotals;
        Flight fs;
        string[,] PassengerDetails;

        public Form_TravelerDetails(int[] Passengers, double[] totals, Flight pfl, int piCustID)
        {
            InitializeComponent();

            //Guardo pasajeros y total pasajeros
            iTotalAdults = Passengers[0];
            iTotalChildren = Passengers[1];
            iTotalTravelers = iTotalAdults + iTotalChildren;

            //Guardo ID de cliente
            var SearchFlightForm = (Form_SearchFlight)Tag;
            dTotals = totals;
            fs = new Flight(pfl);
            iPass = Passengers;
            iCustID = piCustID;
            iIndicePasajerosCapturados = 0;

            //Creo matriz  que guarda los datos de los clientes
            PassengerDetails = new string[iTotalTravelers,3];
        }

        private void Form_TravelerDetails_Load(object sender, EventArgs e)
        {
            //Cargo datos de cliente en labels
            DataTable dtCustomerDetails = customerTableAdapter1.CustomerDetails(iCustID);
            label_Fname.Text = dtCustomerDetails.Rows[0][1].ToString();
            label_Lname.Text = dtCustomerDetails.Rows[0][2].ToString();
            label_Adress.Text = dtCustomerDetails.Rows[0][3].ToString();
            dtCustomerDetails.Dispose();
            //tabControl1.SelectedIndex = 1;

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            //Valido que halla capturado todo, checando tbn que esta capturando adultos
            if(tabControl1.SelectedIndex == 0)
                if (string.IsNullOrEmpty(textBox_AdultFname.Text) || string.IsNullOrEmpty(textBox_AdultLname.Text) || string.IsNullOrEmpty(comboBox_Title.Text))
                {
                    MessageBox.Show("Captura todos los datos antes de continuar!");
                    return;
                }
                else
                {
                    PassengerDetails[iIndicePasajerosCapturados, 0] = comboBox_Title.Text;
                    PassengerDetails[iIndicePasajerosCapturados, 1] = textBox_AdultFname.Text;
                    PassengerDetails[iIndicePasajerosCapturados, 2] = textBox_AdultLname.Text;
                    textBox_AdultFname.Text = string.Empty;
                    textBox_AdultLname.Text = string.Empty;
                    comboBox_Title.Text = string.Empty;
                    comboBox_Title.Focus();
                }

            //Valido que halla capturado todos los datos en niños
            if (tabControl1.SelectedIndex == 1)
                if (string.IsNullOrEmpty(textBox_ChildrenFname.Text) || string.IsNullOrEmpty(textBox_ChildrenLname.Text))
                {
                    MessageBox.Show("Captura todos los datos antes de continuar!");
                    return;
                }
                else
                {
                   // PassengerDetails[iIndicePasajerosCapturados, 0] = comboBox_Title.Text;
                    PassengerDetails[iIndicePasajerosCapturados, 1] = textBox_ChildrenFname.Text;
                    PassengerDetails[iIndicePasajerosCapturados, 2] = textBox_ChildrenLname.Text;
                    textBox_ChildrenFname.Text = string.Empty;
                    textBox_ChildrenLname.Text = string.Empty;
                    textBox_ChildrenFname.Focus();
                }

            //Aumento el total de travelers capturados
            iIndicePasajerosCapturados++;

            //Si el usuario acabo de captutrar adultos muestro tab de niños
            if (iIndicePasajerosCapturados == iTotalAdults)
                tabControl1.SelectedIndex = 1;

            //Verifico si hay mas travelers por capturar
            if (iIndicePasajerosCapturados == iTotalTravelers)
            {
                button_Next.Enabled = false;
                button_Continue.Enabled = true;
                groupBox2.Enabled = false;
                button_Continue.Focus();
            }
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            Form_FlightPayment fl = new Form_FlightPayment(dTotals, fs,iPass, iCustID, PassengerDetails);
            this.Hide();
            fl.Show();
        }
    }
}
