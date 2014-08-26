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
        int iTotalAdults, iTotalChildren, iTotalTravelers, iIndicePasajerosCapturados;
        string sCustomerID;
        public Form_TravelerDetails(int [] Passengers)
        {
            InitializeComponent();
            //Guardo pasajeros y total pasajeros
            iTotalAdults = Passengers[0];
            iTotalChildren = Passengers[1];
            iTotalTravelers = iTotalAdults + iTotalChildren;
            //Guardo ID de cliente
            var SearchFlightForm = (Form_SearchFlight)Tag;
            sCustomerID = SearchFlightForm.CustomerID;
        }

        private void Form_TravelerDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            //Valido que halla capturado todo, checando tbn que esta capturando adultos
            if(groupBox2.TabIndex == 1)
                if (string.IsNullOrEmpty(textBox_AdultFname.Text) || string.IsNullOrEmpty(textBox_AdultLname.Text) || string.IsNullOrEmpty(comboBox_Title.Text))
                {
                    MessageBox.Show("Captura todos los datos antes de continuar!");
                    return;
                }
                else
                {
                    textBox_AdultFname.Text = string.Empty;
                    textBox_AdultLname.Text = string.Empty;
                }

            //Valido que halla capturado todos los datos en niños
            if (groupBox2.TabIndex == 2)
                if (string.IsNullOrEmpty(textBox_ChildrenFname.Text) || string.IsNullOrEmpty(textBox_ChildrenLname.Text))
                {
                    MessageBox.Show("Captura todos los datos antes de continuar!");
                    return;
                }
                else
                {
                    textBox_ChildrenFname.Text = string.Empty;
                    textBox_ChildrenLname.Text = string.Empty;
                }

            //Si el usuario acabo de captutrar adultos muestro tab de niños
            if (iIndicePasajerosCapturados == iTotalAdults)
                groupBox2.TabIndex = 2;

            //Aumento el total de travelers capturados
            iIndicePasajerosCapturados++;

            //Verifico si hay mas travelers por capturar
            if (iIndicePasajerosCapturados == iTotalTravelers)
            {
                button_Next.Enabled = false;
                button_Continue.Enabled = true;
            }
        }
    }
}
