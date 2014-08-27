﻿using System;
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

        public Form_FlightPayment(double [] oTotals, Flight pfl, int [] pass)
        {
            InitializeComponent();
            dTotals = oTotals;
            fl = new Flight(pfl);
            iPass = pass;
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


    }
}