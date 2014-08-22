namespace ADO_NET___Proyecto_final
{
    partial class SearchFlight
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
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label cityNameLabel1;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.projectAirlineDataSet = new ADO_NET___Proyecto_final.ProjectAirlineDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.CustomerTableAdapter();
            this.ComboBox_Source = new System.Windows.Forms.ComboBox();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBox_Destination = new System.Windows.Forms.ComboBox();
            this.cityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeStart = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeEnd = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Departure = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Adults = new System.Windows.Forms.ComboBox();
            this.comboBox_Children = new System.Windows.Forms.ComboBox();
            this.button_SearchFlights = new System.Windows.Forms.Button();
            cityNameLabel = new System.Windows.Forms.Label();
            cityNameLabel1 = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectAirlineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(59, 50);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(44, 13);
            cityNameLabel.TabIndex = 1;
            cityNameLabel.Text = "Source ";
            // 
            // cityNameLabel1
            // 
            cityNameLabel1.AutoSize = true;
            cityNameLabel1.Location = new System.Drawing.Point(303, 53);
            cityNameLabel1.Name = "cityNameLabel1";
            cityNameLabel1.Size = new System.Drawing.Size(60, 13);
            cityNameLabel1.TabIndex = 2;
            cityNameLabel1.Text = "Destination";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(159, 20);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(66, 13);
            customerIdLabel.TabIndex = 4;
            customerIdLabel.Text = "Customer Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(162, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 6;
            label1.Text = "Time: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(270, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(20, 13);
            label2.TabIndex = 7;
            label2.Text = "To";
            // 
            // projectAirlineDataSet
            // 
            this.projectAirlineDataSet.DataSetName = "ProjectAirlineDataSet";
            this.projectAirlineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.projectAirlineDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Flight_BookingTableAdapter = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.PassengerDetailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // ComboBox_Source
            // 
            this.ComboBox_Source.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.ComboBox_Source.DataSource = this.cityBindingSource1;
            this.ComboBox_Source.DisplayMember = "CityName";
            this.ComboBox_Source.FormattingEnabled = true;
            this.ComboBox_Source.Location = new System.Drawing.Point(123, 47);
            this.ComboBox_Source.Name = "ComboBox_Source";
            this.ComboBox_Source.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Source.TabIndex = 2;
            this.ComboBox_Source.ValueMember = "CityName";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.projectAirlineDataSet;
            // 
            // ComboBox_Destination
            // 
            this.ComboBox_Destination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.ComboBox_Destination.DataSource = this.cityBindingSource2;
            this.ComboBox_Destination.DisplayMember = "CityName";
            this.ComboBox_Destination.FormattingEnabled = true;
            this.ComboBox_Destination.Location = new System.Drawing.Point(367, 50);
            this.ComboBox_Destination.Name = "ComboBox_Destination";
            this.ComboBox_Destination.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Destination.TabIndex = 3;
            this.ComboBox_Destination.ValueMember = "CityName";
            // 
            // cityBindingSource2
            // 
            this.cityBindingSource2.DataMember = "City";
            this.cityBindingSource2.DataSource = this.projectAirlineDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.projectAirlineDataSet;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerId", true));
            this.customerIdComboBox.DataSource = this.customerBindingSource;
            this.customerIdComboBox.DisplayMember = "CustomerId";
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(231, 17);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerIdComboBox.TabIndex = 5;
            // 
            // comboBox_TimeStart
            // 
            this.comboBox_TimeStart.FormattingEnabled = true;
            this.comboBox_TimeStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_TimeStart.Location = new System.Drawing.Point(204, 83);
            this.comboBox_TimeStart.Name = "comboBox_TimeStart";
            this.comboBox_TimeStart.Size = new System.Drawing.Size(57, 21);
            this.comboBox_TimeStart.TabIndex = 8;
            this.comboBox_TimeStart.SelectedIndexChanged += new System.EventHandler(this.comboBox_TimeStart_SelectedIndexChanged);
            // 
            // comboBox_TimeEnd
            // 
            this.comboBox_TimeEnd.Enabled = false;
            this.comboBox_TimeEnd.FormattingEnabled = true;
            this.comboBox_TimeEnd.Location = new System.Drawing.Point(306, 83);
            this.comboBox_TimeEnd.Name = "comboBox_TimeEnd";
            this.comboBox_TimeEnd.Size = new System.Drawing.Size(57, 21);
            this.comboBox_TimeEnd.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(120, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 13);
            label3.TabIndex = 10;
            label3.Text = "Departure date: ";
            // 
            // dateTimePicker_Departure
            // 
            this.dateTimePicker_Departure.Location = new System.Drawing.Point(205, 121);
            this.dateTimePicker_Departure.Name = "dateTimePicker_Departure";
            this.dateTimePicker_Departure.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Departure.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(147, 162);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 12;
            label4.Text = "Adults: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(286, 161);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 13);
            label5.TabIndex = 13;
            label5.Text = "Children: ";
            // 
            // comboBox_Adults
            // 
            this.comboBox_Adults.FormattingEnabled = true;
            this.comboBox_Adults.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_Adults.Location = new System.Drawing.Point(204, 159);
            this.comboBox_Adults.Name = "comboBox_Adults";
            this.comboBox_Adults.Size = new System.Drawing.Size(57, 21);
            this.comboBox_Adults.TabIndex = 14;
            // 
            // comboBox_Children
            // 
            this.comboBox_Children.FormattingEnabled = true;
            this.comboBox_Children.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox_Children.Location = new System.Drawing.Point(343, 158);
            this.comboBox_Children.Name = "comboBox_Children";
            this.comboBox_Children.Size = new System.Drawing.Size(57, 21);
            this.comboBox_Children.TabIndex = 15;
            // 
            // button_SearchFlights
            // 
            this.button_SearchFlights.Location = new System.Drawing.Point(106, 200);
            this.button_SearchFlights.Name = "button_SearchFlights";
            this.button_SearchFlights.Size = new System.Drawing.Size(364, 46);
            this.button_SearchFlights.TabIndex = 16;
            this.button_SearchFlights.Text = "Search flights";
            this.button_SearchFlights.UseVisualStyleBackColor = true;
            this.button_SearchFlights.Click += new System.EventHandler(this.button_SearchFlights_Click);
            // 
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 300);
            this.Controls.Add(this.button_SearchFlights);
            this.Controls.Add(this.comboBox_Children);
            this.Controls.Add(this.comboBox_Adults);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.dateTimePicker_Departure);
            this.Controls.Add(label3);
            this.Controls.Add(this.comboBox_TimeEnd);
            this.Controls.Add(this.comboBox_TimeStart);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdComboBox);
            this.Controls.Add(cityNameLabel1);
            this.Controls.Add(this.ComboBox_Destination);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.ComboBox_Source);
            this.Name = "SearchFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make my trip - SearchFlight";
            this.Load += new System.EventHandler(this.SearchFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectAirlineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectAirlineDataSet projectAirlineDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private ProjectAirlineDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private ProjectAirlineDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ComboBox_Source;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private System.Windows.Forms.ComboBox ComboBox_Destination;
        private System.Windows.Forms.BindingSource cityBindingSource2;
        private ProjectAirlineDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.ComboBox comboBox_TimeStart;
        private System.Windows.Forms.ComboBox comboBox_TimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Departure;
        private System.Windows.Forms.ComboBox comboBox_Adults;
        private System.Windows.Forms.ComboBox comboBox_Children;
        private System.Windows.Forms.Button button_SearchFlights;

    }
}

