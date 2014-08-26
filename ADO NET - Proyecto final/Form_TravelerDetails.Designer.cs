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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Fname = new System.Windows.Forms.Label();
            this.label_Lname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AdultFname = new System.Windows.Forms.TextBox();
            this.textBox_AdultLname = new System.Windows.Forms.TextBox();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Continue = new System.Windows.Forms.Button();
            this.textBox_ChildrenLname = new System.Windows.Forms.TextBox();
            this.textBox_ChildrenFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 188);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.textBox_ChildrenLname);
            this.tabPage2.Controls.Add(this.textBox_ChildrenFname);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(511, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Lname);
            this.groupBox1.Controls.Add(this.label_Fname);
            this.groupBox1.Controls.Add(this.label_Title);
            this.groupBox1.Location = new System.Drawing.Point(63, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(115, 29);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(23, 13);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "title";
            // 
            // label_Fname
            // 
            this.label_Fname.AutoSize = true;
            this.label_Fname.Location = new System.Drawing.Point(190, 29);
            this.label_Fname.Name = "label_Fname";
            this.label_Fname.Size = new System.Drawing.Size(23, 13);
            this.label_Fname.TabIndex = 1;
            this.label_Fname.Text = "title";
            // 
            // label_Lname
            // 
            this.label_Lname.AutoSize = true;
            this.label_Lname.Location = new System.Drawing.Point(269, 29);
            this.label_Lname.Name = "label_Lname";
            this.label_Lname.Size = new System.Drawing.Size(23, 13);
            this.label_Lname.TabIndex = 2;
            this.label_Lname.Text = "title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(63, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Traveler details";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.textBox_AdultLname);
            this.tabPage1.Controls.Add(this.textBox_AdultFname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox_Title);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(511, 162);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title: ";
            // 
            // comboBox_Title
            // 
            this.comboBox_Title.FormattingEnabled = true;
            this.comboBox_Title.Items.AddRange(new object[] {
            "Mr",
            "Ms"});
            this.comboBox_Title.Location = new System.Drawing.Point(63, 28);
            this.comboBox_Title.Name = "comboBox_Title";
            this.comboBox_Title.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Title.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name: ";
            // 
            // textBox_AdultFname
            // 
            this.textBox_AdultFname.Location = new System.Drawing.Point(91, 74);
            this.textBox_AdultFname.Name = "textBox_AdultFname";
            this.textBox_AdultFname.Size = new System.Drawing.Size(265, 20);
            this.textBox_AdultFname.TabIndex = 7;
            // 
            // textBox_AdultLname
            // 
            this.textBox_AdultLname.Location = new System.Drawing.Point(91, 124);
            this.textBox_AdultLname.Name = "textBox_AdultLname";
            this.textBox_AdultLname.Size = new System.Drawing.Size(265, 20);
            this.textBox_AdultLname.TabIndex = 8;
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(287, 386);
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
            this.button_Continue.Location = new System.Drawing.Point(527, 414);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(154, 46);
            this.button_Continue.TabIndex = 4;
            this.button_Continue.Text = "Continue with  payment";
            this.button_Continue.UseVisualStyleBackColor = true;
            // 
            // textBox_ChildrenLname
            // 
            this.textBox_ChildrenLname.Location = new System.Drawing.Point(96, 78);
            this.textBox_ChildrenLname.Name = "textBox_ChildrenLname";
            this.textBox_ChildrenLname.Size = new System.Drawing.Size(265, 20);
            this.textBox_ChildrenLname.TabIndex = 12;
            // 
            // textBox_ChildrenFname
            // 
            this.textBox_ChildrenFname.Location = new System.Drawing.Point(96, 28);
            this.textBox_ChildrenFname.Name = "textBox_ChildrenFname";
            this.textBox_ChildrenFname.Size = new System.Drawing.Size(265, 20);
            this.textBox_ChildrenFname.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First name: ";
            // 
            // Form_TravelerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 470);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_TravelerDetails";
            this.Text = "Make my trip - Traveler details";
            this.Load += new System.EventHandler(this.Form_TravelerDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Continue;
    }
}