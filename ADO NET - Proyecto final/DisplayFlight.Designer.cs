namespace ADO_NET___Proyecto_final
{
    partial class DisplayFlight
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Source = new System.Windows.Forms.Label();
            this.label_Destination = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_DepartureDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_TimeEnd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Adults = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_Children = new System.Windows.Forms.Label();
            this.label_ChildrenText = new System.Windows.Forms.Label();
            this.dataGridView_Flights = new System.Windows.Forms.DataGridView();
            this.flightTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.FlightTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flights)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket from: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(184, 47);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(31, 15);
            this.label_Source.TabIndex = 2;
            this.label_Source.Text = "To: ";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destination.Location = new System.Drawing.Point(350, 47);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(31, 15);
            this.label_Destination.TabIndex = 3;
            this.label_Destination.Text = "To: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure date";
            // 
            // label_DepartureDate
            // 
            this.label_DepartureDate.AutoSize = true;
            this.label_DepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DepartureDate.Location = new System.Drawing.Point(184, 85);
            this.label_DepartureDate.Name = "label_DepartureDate";
            this.label_DepartureDate.Size = new System.Drawing.Size(31, 15);
            this.label_DepartureDate.TabIndex = 5;
            this.label_DepartureDate.Text = "To: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departure time between ";
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeStart.Location = new System.Drawing.Point(238, 116);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(31, 15);
            this.label_TimeStart.TabIndex = 7;
            this.label_TimeStart.Text = "To: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "To: ";
            // 
            // label_TimeEnd
            // 
            this.label_TimeEnd.AutoSize = true;
            this.label_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeEnd.Location = new System.Drawing.Point(350, 118);
            this.label_TimeEnd.Name = "label_TimeEnd";
            this.label_TimeEnd.Size = new System.Drawing.Size(31, 15);
            this.label_TimeEnd.TabIndex = 9;
            this.label_TimeEnd.Text = "To: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Travellers |";
            // 
            // label_Adults
            // 
            this.label_Adults.AutoSize = true;
            this.label_Adults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Adults.Location = new System.Drawing.Point(615, 47);
            this.label_Adults.Name = "label_Adults";
            this.label_Adults.Size = new System.Drawing.Size(15, 15);
            this.label_Adults.TabIndex = 11;
            this.label_Adults.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(644, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Adults";
            // 
            // label_Children
            // 
            this.label_Children.AutoSize = true;
            this.label_Children.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Children.Location = new System.Drawing.Point(740, 48);
            this.label_Children.Name = "label_Children";
            this.label_Children.Size = new System.Drawing.Size(15, 15);
            this.label_Children.TabIndex = 13;
            this.label_Children.Text = "0";
            this.label_Children.Visible = false;
            // 
            // label_ChildrenText
            // 
            this.label_ChildrenText.AutoSize = true;
            this.label_ChildrenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChildrenText.Location = new System.Drawing.Point(761, 49);
            this.label_ChildrenText.Name = "label_ChildrenText";
            this.label_ChildrenText.Size = new System.Drawing.Size(61, 15);
            this.label_ChildrenText.TabIndex = 14;
            this.label_ChildrenText.Text = "Children";
            this.label_ChildrenText.Visible = false;
            // 
            // dataGridView_Flights
            // 
            this.dataGridView_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Flights.Location = new System.Drawing.Point(100, 159);
            this.dataGridView_Flights.Name = "dataGridView_Flights";
            this.dataGridView_Flights.Size = new System.Drawing.Size(722, 185);
            this.dataGridView_Flights.TabIndex = 15;
            // 
            // flightTableAdapter1
            // 
            this.flightTableAdapter1.ClearBeforeFill = true;
            // 
            // DisplayFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 393);
            this.Controls.Add(this.dataGridView_Flights);
            this.Controls.Add(this.label_ChildrenText);
            this.Controls.Add(this.label_Children);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_Adults);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_TimeEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_TimeStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_DepartureDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Destination);
            this.Controls.Add(this.label_Source);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make my trip -DisplayFlight";
            this.Load += new System.EventHandler(this.DisplayFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Source;
        private System.Windows.Forms.Label label_Destination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_DepartureDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_TimeEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Adults;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_Children;
        private System.Windows.Forms.Label label_ChildrenText;
        private System.Windows.Forms.DataGridView dataGridView_Flights;
        private ProjectAirlineDataSetTableAdapters.FlightTableAdapter flightTableAdapter1;
    }
}