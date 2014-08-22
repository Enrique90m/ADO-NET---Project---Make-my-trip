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
    public partial class Form_SearchFlight : Form
    {
        public Form_SearchFlight()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectAirlineDataSet);

        }

        private void cityBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectAirlineDataSet);

        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAirlineDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.projectAirlineDataSet.Customer);
            // TODO: This line of code loads data into the 'projectAirlineDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.projectAirlineDataSet.City);

        }

        private void comboBox_TimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si no selecciono nada, lo deshabilito
            if (comboBox_TimeStart.SelectedIndex == -1)
                comboBox_TimeEnd.Enabled = false;
            else
            {
                //Habilito el combo y dependiendo de lo que halla seleccionado, agrego las horas siguientes
                comboBox_TimeEnd.Enabled = true;
                comboBox_TimeEnd.Items.Clear();
                comboBox_TimeEnd.Text = string.Empty;
                if (comboBox_TimeStart.SelectedIndex == 22)
                    comboBox_TimeEnd.Items.Add(23);
                else
                for (int i = comboBox_TimeStart.SelectedIndex + 2; i < 24; i++)
                    comboBox_TimeEnd.Items.Add(i);
            }
        }

        private void button_SearchFlights_Click(object sender, EventArgs e)
        {

            //Valido que halla capturado todo, aunque puede no capturar niños ya que no es obligatorio
            if(string.IsNullOrEmpty(customerIdComboBox.Text) || string.IsNullOrEmpty(ComboBox_Destination.Text) || string.IsNullOrEmpty(ComboBox_Source.Text) ||
                string.IsNullOrEmpty(comboBox_TimeStart.Text) || string.IsNullOrEmpty(comboBox_TimeEnd.Text) || string.IsNullOrEmpty(dateTimePicker_Departure.Text) || string.IsNullOrEmpty(comboBox_Adults.Text))
            {
                MessageBox.Show("Todos los campos a excepcion de niños, son obligatorios");
                return;
            }

            //Valido que las ciudades del viaje sean diferentes
            if (ComboBox_Destination.Text == ComboBox_Source.Text)
            {
                MessageBox.Show("Las ciudades deben ser diferentes");
                return;
            }

            //Valido que la fecha que busca sea mayor o igual a la de hoy
            if (DateTime.Parse(dateTimePicker_Departure.Value.ToString("yyyy-MM-dd")) < DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")))
            {

                MessageBox.Show("La fecha buscada no puede ser anterior al dia de hoy!");
                return;
            }

           
        }

       
    }
}
