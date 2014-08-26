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
            this.components = new System.ComponentModel.Container();
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
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectAirlineDataSet = new ADO_NET___Proyecto_final.ProjectAirlineDataSet();
            this.flightTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.FlightTableAdapter();
            this.label_NoRecordsFound = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.flightNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultFareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childFareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPassengerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSelectFlight = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Flights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAirlineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket from: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // label_Source
            // 
            this.label_Source.AutoSize = true;
            this.label_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Source.Location = new System.Drawing.Point(241, 23);
            this.label_Source.Name = "label_Source";
            this.label_Source.Size = new System.Drawing.Size(31, 15);
            this.label_Source.TabIndex = 2;
            this.label_Source.Text = "To: ";
            // 
            // label_Destination
            // 
            this.label_Destination.AutoSize = true;
            this.label_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Destination.Location = new System.Drawing.Point(407, 23);
            this.label_Destination.Name = "label_Destination";
            this.label_Destination.Size = new System.Drawing.Size(31, 15);
            this.label_Destination.TabIndex = 3;
            this.label_Destination.Text = "To: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departure date";
            // 
            // label_DepartureDate
            // 
            this.label_DepartureDate.AutoSize = true;
            this.label_DepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DepartureDate.Location = new System.Drawing.Point(241, 61);
            this.label_DepartureDate.Name = "label_DepartureDate";
            this.label_DepartureDate.Size = new System.Drawing.Size(31, 15);
            this.label_DepartureDate.TabIndex = 5;
            this.label_DepartureDate.Text = "To: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Departure time between ";
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeStart.Location = new System.Drawing.Point(295, 92);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(31, 15);
            this.label_TimeStart.TabIndex = 7;
            this.label_TimeStart.Text = "To: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "To: ";
            // 
            // label_TimeEnd
            // 
            this.label_TimeEnd.AutoSize = true;
            this.label_TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeEnd.Location = new System.Drawing.Point(407, 94);
            this.label_TimeEnd.Name = "label_TimeEnd";
            this.label_TimeEnd.Size = new System.Drawing.Size(31, 15);
            this.label_TimeEnd.TabIndex = 9;
            this.label_TimeEnd.Text = "To: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Travellers |";
            // 
            // label_Adults
            // 
            this.label_Adults.AutoSize = true;
            this.label_Adults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Adults.Location = new System.Drawing.Point(672, 23);
            this.label_Adults.Name = "label_Adults";
            this.label_Adults.Size = new System.Drawing.Size(15, 15);
            this.label_Adults.TabIndex = 11;
            this.label_Adults.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(701, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Adults";
            // 
            // label_Children
            // 
            this.label_Children.AutoSize = true;
            this.label_Children.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Children.Location = new System.Drawing.Point(797, 24);
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
            this.label_ChildrenText.Location = new System.Drawing.Point(818, 25);
            this.label_ChildrenText.Name = "label_ChildrenText";
            this.label_ChildrenText.Size = new System.Drawing.Size(61, 15);
            this.label_ChildrenText.TabIndex = 14;
            this.label_ChildrenText.Text = "Children";
            this.label_ChildrenText.Visible = false;
            // 
            // dataGridView_Flights
            // 
            this.dataGridView_Flights.AllowUserToAddRows = false;
            this.dataGridView_Flights.AutoGenerateColumns = false;
            this.dataGridView_Flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Flights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.adultFareDataGridViewTextBoxColumn,
            this.childFareDataGridViewTextBoxColumn,
            this.totalPassengerDataGridViewTextBoxColumn,
            this.ButtonSelectFlight});
            this.dataGridView_Flights.DataSource = this.flightBindingSource;
            this.dataGridView_Flights.Location = new System.Drawing.Point(54, 125);
            this.dataGridView_Flights.Name = "dataGridView_Flights";
            this.dataGridView_Flights.ReadOnly = true;
            this.dataGridView_Flights.Size = new System.Drawing.Size(943, 185);
            this.dataGridView_Flights.TabIndex = 15;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.projectAirlineDataSet;
            // 
            // projectAirlineDataSet
            // 
            this.projectAirlineDataSet.DataSetName = "ProjectAirlineDataSet";
            this.projectAirlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightTableAdapter1
            // 
            this.flightTableAdapter1.ClearBeforeFill = true;
            // 
            // label_NoRecordsFound
            // 
            this.label_NoRecordsFound.AutoSize = true;
            this.label_NoRecordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoRecordsFound.Location = new System.Drawing.Point(406, 319);
            this.label_NoRecordsFound.Name = "label_NoRecordsFound";
            this.label_NoRecordsFound.Size = new System.Drawing.Size(281, 37);
            this.label_NoRecordsFound.TabIndex = 17;
            this.label_NoRecordsFound.Text = "No records found";
            this.label_NoRecordsFound.Visible = false;
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(54, 316);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(192, 37);
            this.button_Back.TabIndex = 18;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // flightNoDataGridViewTextBoxColumn
            // 
            this.flightNoDataGridViewTextBoxColumn.DataPropertyName = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.HeaderText = "FlightNo";
            this.flightNoDataGridViewTextBoxColumn.Name = "flightNoDataGridViewTextBoxColumn";
            this.flightNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // adultFareDataGridViewTextBoxColumn
            // 
            this.adultFareDataGridViewTextBoxColumn.DataPropertyName = "AdultFare";
            this.adultFareDataGridViewTextBoxColumn.HeaderText = "AdultFare";
            this.adultFareDataGridViewTextBoxColumn.Name = "adultFareDataGridViewTextBoxColumn";
            // 
            // childFareDataGridViewTextBoxColumn
            // 
            this.childFareDataGridViewTextBoxColumn.DataPropertyName = "ChildFare";
            this.childFareDataGridViewTextBoxColumn.HeaderText = "ChildFare";
            this.childFareDataGridViewTextBoxColumn.Name = "childFareDataGridViewTextBoxColumn";
            // 
            // totalPassengerDataGridViewTextBoxColumn
            // 
            this.totalPassengerDataGridViewTextBoxColumn.DataPropertyName = "TotalPassenger";
            this.totalPassengerDataGridViewTextBoxColumn.HeaderText = "TotalPassenger";
            this.totalPassengerDataGridViewTextBoxColumn.Name = "totalPassengerDataGridViewTextBoxColumn";
            // 
            // ButtonSelectFlight
            // 
            this.ButtonSelectFlight.HeaderText = "";
            this.ButtonSelectFlight.Name = "ButtonSelectFlight";
            this.ButtonSelectFlight.Text = "Choose this flight";
            this.ButtonSelectFlight.ToolTipText = "Choose this flight";
            this.ButtonSelectFlight.UseColumnTextForButtonValue = true;
            // 
            // DisplayFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 394);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_NoRecordsFound);
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
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAirlineDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource flightBindingSource;
        private ProjectAirlineDataSet projectAirlineDataSet;
        private System.Windows.Forms.Label label_NoRecordsFound;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultFareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childFareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPassengerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonSelectFlight;
    }
}