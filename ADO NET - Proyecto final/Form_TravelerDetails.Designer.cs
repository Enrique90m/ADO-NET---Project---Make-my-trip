namespace ADO_NET___Proyecto_final
{
    partial class Form_TravelerDetails
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_AdultLname = new System.Windows.Forms.TextBox();
            this.textBox_AdultFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_ChildrenLname = new System.Windows.Forms.TextBox();
            this.textBox_ChildrenFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Lname = new System.Windows.Forms.Label();
            this.label_Fname = new System.Windows.Forms.Label();
            this.label_Adress = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Continue = new System.Windows.Forms.Button();
            this.passengerDetailsTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.PassengerDetailsTableAdapter();
            this.customerTableAdapter1 = new ADO_NET___Proyecto_final.ProjectAirlineDataSetTableAdapters.CustomerTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, 19);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(561, 195);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_AdultLname);
            this.tabPage1.Controls.Add(this.textBox_AdultFname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox_Title);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(534, 187);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // textBox_AdultLname
            // 
            this.textBox_AdultLname.Location = new System.Drawing.Point(101, 123);
            this.textBox_AdultLname.Name = "textBox_AdultLname";
            this.textBox_AdultLname.Size = new System.Drawing.Size(265, 20);
            this.textBox_AdultLname.TabIndex = 8;
            // 
            // textBox_AdultFname
            // 
            this.textBox_AdultFname.Location = new System.Drawing.Point(99, 83);
            this.textBox_AdultFname.Name = "textBox_AdultFname";
            this.textBox_AdultFname.Size = new System.Drawing.Size(265, 20);
            this.textBox_AdultFname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name: ";
            // 
            // comboBox_Title
            // 
            this.comboBox_Title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Title.FormattingEnabled = true;
            this.comboBox_Title.Items.AddRange(new object[] {
            "Mr",
            "Ms"});
            this.comboBox_Title.Location = new System.Drawing.Point(73, 56);
            this.comboBox_Title.Name = "comboBox_Title";
            this.comboBox_Title.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Title.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox_ChildrenLname);
            this.tabPage2.Controls.Add(this.textBox_ChildrenFname);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(534, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // textBox_ChildrenLname
            // 
            this.textBox_ChildrenLname.Location = new System.Drawing.Point(95, 107);
            this.textBox_ChildrenLname.Name = "textBox_ChildrenLname";
            this.textBox_ChildrenLname.Size = new System.Drawing.Size(265, 20);
            this.textBox_ChildrenLname.TabIndex = 12;
            // 
            // textBox_ChildrenFname
            // 
            this.textBox_ChildrenFname.Location = new System.Drawing.Point(95, 57);
            this.textBox_ChildrenFname.Name = "textBox_ChildrenFname";
            this.textBox_ChildrenFname.Size = new System.Drawing.Size(265, 20);
            this.textBox_ChildrenFname.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_Lname);
            this.groupBox1.Controls.Add(this.label_Fname);
            this.groupBox1.Controls.Add(this.label_Adress);
            this.groupBox1.Location = new System.Drawing.Point(19, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Last name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "First name: ";
            // 
            // label_Lname
            // 
            this.label_Lname.AutoSize = true;
            this.label_Lname.Location = new System.Drawing.Point(362, 34);
            this.label_Lname.Name = "label_Lname";
            this.label_Lname.Size = new System.Drawing.Size(23, 13);
            this.label_Lname.TabIndex = 2;
            this.label_Lname.Text = "title";
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Location = new System.Drawing.Point(185, 34);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(23, 13);
            this.label_Fname.TabIndex = 1;
            this.label_Fname.Text = "title";
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Location = new System.Drawing.Point(189, 63);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(23, 13);
            this.label_Adress.TabIndex = 0;
            this.label_Adress.Text = "title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(26, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traveler details";
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(221, 309);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(154, 46);
            this.button_Next.TabIndex = 3;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Continue
            // 
            this.button_Continue.Enabled = false;
            this.button_Continue.Location = new System.Drawing.Point(403, 341);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(154, 46);
            this.button_Continue.TabIndex = 4;
            this.button_Continue.Text = "Continue with  payment";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // passengerDetailsTableAdapter1
            // 
            this.passengerDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Adults";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(194, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Children";
            // 
            // Form_TravelerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_TravelerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make my trip - Traveler details";
            this.Load += new System.EventHandler(this.Form_TravelerDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_AdultLname;
        private System.Windows.Forms.TextBox textBox_AdultFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ChildrenLname;
        private System.Windows.Forms.TextBox textBox_ChildrenFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Lname;
        private System.Windows.Forms.Label label_Fname;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Continue;
        private ProjectAirlineDataSetTableAdapters.PassengerDetailsTableAdapter passengerDetailsTableAdapter1;
        private ProjectAirlineDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}