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
    public partial class SearchFlight : Form
    {
        public SearchFlight()
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
            if (comboBox_TimeStart.SelectedIndex == -1)
                comboBox_TimeEnd.Enabled = false;
            else
            {
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

       
    }
}
