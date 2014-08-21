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
            this.projectAirlineDataSet = new ADO_NET___Proyecto_final.ProjectAirlineDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.CustomerTableAdapter();
            this.cityNameComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cityNameComboBox1 = new System.Windows.Forms.ComboBox();
            this.cityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeStart = new System.Windows.Forms.ComboBox();
            this.comboBox_TimeEnd = new System.Windows.Forms.ComboBox();
            cityNameLabel = new System.Windows.Forms.Label();
            cityNameLabel1 = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
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
            cityNameLabel.Size = new System.Drawing.Size(58, 13);
            cityNameLabel.TabIndex = 1;
            cityNameLabel.Text = "City Name:";
            // 
            // cityNameLabel1
            // 
            cityNameLabel1.AutoSize = true;
            cityNameLabel1.Location = new System.Drawing.Point(303, 53);
            cityNameLabel1.Name = "cityNameLabel1";
            cityNameLabel1.Size = new System.Drawing.Size(58, 13);
            cityNameLabel1.TabIndex = 2;
            cityNameLabel1.Text = "City Name:";
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
            // cityNameComboBox
            // 
            this.cityNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.cityNameComboBox.DataSource = this.cityBindingSource1;
            this.cityNameComboBox.DisplayMember = "CityName";
            this.cityNameComboBox.FormattingEnabled = true;
            this.cityNameComboBox.Location = new System.Drawing.Point(123, 47);
            this.cityNameComboBox.Name = "cityNameComboBox";
            this.cityNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityNameComboBox.TabIndex = 2;
            this.cityNameComboBox.ValueMember = "CityName";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "City";
            this.cityBindingSource1.DataSource = this.projectAirlineDataSet;
            // 
            // cityNameComboBox1
            // 
            this.cityNameComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.cityNameComboBox1.DataSource = this.cityBindingSource2;
            this.cityNameComboBox1.DisplayMember = "CityName";
            this.cityNameComboBox1.FormattingEnabled = true;
            this.cityNameComboBox1.Location = new System.Drawing.Point(367, 50);
            this.cityNameComboBox1.Name = "cityNameComboBox1";
            this.cityNameComboBox1.Size = new System.Drawing.Size(121, 21);
            this.cityNameComboBox1.TabIndex = 3;
            this.cityNameComboBox1.ValueMember = "CityName";
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
            // SearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 381);
            this.Controls.Add(this.comboBox_TimeEnd);
            this.Controls.Add(this.comboBox_TimeStart);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdComboBox);
            this.Controls.Add(cityNameLabel1);
            this.Controls.Add(this.cityNameComboBox1);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.cityNameComboBox);
            this.Name = "SearchFlight";
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
        private System.Windows.Forms.ComboBox cityNameComboBox;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private System.Windows.Forms.ComboBox cityNameComboBox1;
        private System.Windows.Forms.BindingSource cityBindingSource2;
        private ProjectAirlineDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.ComboBox comboBox_TimeStart;
        private System.Windows.Forms.ComboBox comboBox_TimeEnd;

    }
}

