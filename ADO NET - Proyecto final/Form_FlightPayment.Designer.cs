namespace ADO_NET___Proyecto_final
{
    partial class Form_FlightPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label16;
            this.button1 = new System.Windows.Forms.Button();
            this.label_Source = new System.Windows.Forms.Label();
            this.label_Destination = new System.Windows.Forms.Label();
            this.label_NoOfAdults = new System.Windows.Forms.Label();
            this.label_NoOfChildren = new System.Windows.Forms.Label();
            this.label_AdultFare = new System.Windows.Forms.Label();
            this.label_ChildrenFare = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_TaxAmount = new System.Windows.Forms.Label();
            this.flight_BookingTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.Flight_BookingTableAdapter();
            this.flightTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.FlightTableAdapter();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(222, 16);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 13);
            label5.TabIndex = 15;
            label5.Text = "To: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(83, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 13);
            label4.TabIndex = 14;
            label4.Text = "Ticket from: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(83, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 13);
            label3.TabIndex = 19;
            label3.Text = "Children: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(83, 60);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 13);
            label6.TabIndex = 18;
            label6.Text = "Adults: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(83, 145);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(84, 13);
            label10.TabIndex = 22;
            label10.Text = "Total adult fare: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(83, 183);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(98, 13);
            label12.TabIndex = 24;
            label12.Text = "Total children fare: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(83, 221);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(69, 13);
            label14.TabIndex = 26;
            label14.Text = "Tax amount: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(83, 257);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(75, 13);
            label16.TabIndex = 28;
            label16.Text = "Total amount: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Make payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Location = new System.Drawing.Point(156, 16);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(35, 13);
            this.label_Source.TabIndex = 31;
            this.label_Source.Text = "label1";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Location = new System.Drawing.Point(266, 16);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(35, 13);
            this.label_Destination.TabIndex = 32;
            this.label_Destination.Text = "label1";
            // 
            // label_NoOfAdults
            // 
            this.label_NoOfAdults.AutoSize = true;
            this.label_NoOfAdults.Location = new System.Drawing.Point(140, 60);
            this.label_NoOfAdults.Name = "label_NoOfAdults";
            this.label_NoOfAdults.Size = new System.Drawing.Size(35, 13);
            this.label_NoOfAdults.TabIndex = 33;
            this.label_NoOfAdults.Text = "label1";
            // 
            // label_NoOfChildren
            // 
            this.label_NoOfChildren.AutoSize = true;
            this.label_NoOfChildren.Location = new System.Drawing.Point(140, 104);
            this.label_NoOfChildren.Name = "label_NoOfChildren";
            this.label_NoOfChildren.Size = new System.Drawing.Size(35, 13);
            this.label_NoOfChildren.TabIndex = 34;
            this.label_NoOfChildren.Text = "label1";
            // 
            // label_AdultFare
            // 
            this.label_AdultFare.AutoSize = true;
            this.label_AdultFare.Location = new System.Drawing.Point(168, 146);
            this.label_AdultFare.Name = "label_AdultFare";
            this.label_AdultFare.Size = new System.Drawing.Size(35, 13);
            this.label_AdultFare.TabIndex = 35;
            this.label_AdultFare.Text = "label1";
            // 
            // label_ChildrenFare
            // 
            this.label_ChildrenFare.AutoSize = true;
            this.label_ChildrenFare.Location = new System.Drawing.Point(182, 184);
            this.label_ChildrenFare.Name = "label_ChildrenFare";
            this.label_ChildrenFare.Size = new System.Drawing.Size(35, 13);
            this.label_ChildrenFare.TabIndex = 36;
            this.label_ChildrenFare.Text = "label1";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(156, 257);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(35, 13);
            this.label_Total.TabIndex = 38;
            this.label_Total.Text = "label1";
            // 
            // label_TaxAmount
            // 
            this.label_TaxAmount.AutoSize = true;
            this.label_TaxAmount.Location = new System.Drawing.Point(156, 221);
            this.label_TaxAmount.Name = "label_TaxAmount";
            this.label_TaxAmount.Size = new System.Drawing.Size(35, 13);
            this.label_TaxAmount.TabIndex = 37;
            this.label_TaxAmount.Text = "label1";
            // 
            // flight_BookingTableAdapter1
            // 
            this.flight_BookingTableAdapter1.ClearBeforeFill = true;
            // 
            // flightTableAdapter1
            // 
            this.flightTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_FlightPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 354);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_TaxAmount);
            this.Controls.Add(this.label_ChildrenFare);
            this.Controls.Add(this.label_AdultFare);
            this.Controls.Add(this.label_NoOfChildren);
            this.Controls.Add(this.label_NoOfAdults);
            this.Controls.Add(this.label_Destination);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.button1);
            this.Controls.Add(label16);
            this.Controls.Add(label14);
            this.Controls.Add(label12);
            this.Controls.Add(label10);
            this.Controls.Add(label3);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Name = "Form_FlightPayment";
            this.Text = "Make my trip - FlightPayment";
            this.Load += new System.EventHandler(this.Form_FlightPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.Label label_NoOfAdults;
        private System.Windows.Forms.Label label_NoOfChildren;
        private System.Windows.Forms.Label label_AdultFare;
        private System.Windows.Forms.Label label_ChildrenFare;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label_TaxAmount;
        private ProjectAirlineDataSetTableAdapters.Flight_BookingTableAdapter flight_BookingTableAdapter1;
        private ProjectAirlineDataSetTableAdapters.FlightTableAdapter flightTableAdapter1;
    }
}