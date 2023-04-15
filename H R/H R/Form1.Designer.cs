namespace H_R
{
    partial class Form1
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
            this.label1nationalnumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblfullname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblThegender = new System.Windows.Forms.Label();
            this.checkBox1male = new System.Windows.Forms.CheckBox();
            this.checkBox2female = new System.Windows.Forms.CheckBox();
            this.lblkills = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1nationalnumber
            // 
            this.label1nationalnumber.AutoSize = true;
            this.label1nationalnumber.Location = new System.Drawing.Point(31, 36);
            this.label1nationalnumber.Name = "label1nationalnumber";
            this.label1nationalnumber.Size = new System.Drawing.Size(114, 16);
            this.label1nationalnumber.TabIndex = 0;
            this.label1nationalnumber.Text = "National Number :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Location = new System.Drawing.Point(58, 75);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(71, 16);
            this.lblfullname.TabIndex = 2;
            this.lblfullname.Text = "Full name :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 120);
            this.dateTimePicker1.MaxDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(1991, 1, 1, 0, 0, 0, 0);
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Location = new System.Drawing.Point(50, 120);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(79, 16);
            this.lbldateofbirth.TabIndex = 5;
            this.lbldateofbirth.Text = "Date of Birth";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(58, 163);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 16);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country  :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jordan",
            "Syria",
            "Lebanon",
            " Iraq"});
            this.comboBox1.Location = new System.Drawing.Point(175, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(58, 204);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 16);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = " City :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Amman",
            "Damascus",
            "Baghdad",
            "Beirut"});
            this.comboBox2.Location = new System.Drawing.Point(175, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // lblThegender
            // 
            this.lblThegender.AutoSize = true;
            this.lblThegender.Location = new System.Drawing.Point(51, 245);
            this.lblThegender.Name = "lblThegender";
            this.lblThegender.Size = new System.Drawing.Size(83, 16);
            this.lblThegender.TabIndex = 10;
            this.lblThegender.Text = "The gender :";
            // 
            // checkBox1male
            // 
            this.checkBox1male.AutoSize = true;
            this.checkBox1male.Location = new System.Drawing.Point(175, 240);
            this.checkBox1male.Name = "checkBox1male";
            this.checkBox1male.Size = new System.Drawing.Size(59, 20);
            this.checkBox1male.TabIndex = 11;
            this.checkBox1male.Text = "Male";
            this.checkBox1male.UseVisualStyleBackColor = true;
            // 
            // checkBox2female
            // 
            this.checkBox2female.AutoSize = true;
            this.checkBox2female.Location = new System.Drawing.Point(287, 239);
            this.checkBox2female.Name = "checkBox2female";
            this.checkBox2female.Size = new System.Drawing.Size(75, 20);
            this.checkBox2female.TabIndex = 12;
            this.checkBox2female.Text = "Female";
            this.checkBox2female.UseVisualStyleBackColor = true;
            // 
            // lblkills
            // 
            this.lblkills.AutoSize = true;
            this.lblkills.Location = new System.Drawing.Point(68, 301);
            this.lblkills.Name = "lblkills";
            this.lblkills.Size = new System.Drawing.Size(39, 16);
            this.lblkills.TabIndex = 13;
            this.lblkills.Text = "Skills";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "programming",
            "web design",
            " UI/UX"});
            this.listBox1.Location = new System.Drawing.Point(152, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 68);
            this.listBox1.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(205, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(157, 44);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 557);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblkills);
            this.Controls.Add(this.checkBox2female);
            this.Controls.Add(this.checkBox1male);
            this.Controls.Add(this.lblThegender);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lbldateofbirth);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1nationalnumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1nationalnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblThegender;
        private System.Windows.Forms.CheckBox checkBox1male;
        private System.Windows.Forms.CheckBox checkBox2female;
        private System.Windows.Forms.Label lblkills;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRegister;
    }
}

