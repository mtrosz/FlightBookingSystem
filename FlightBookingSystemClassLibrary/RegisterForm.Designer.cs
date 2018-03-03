namespace FlightBookingSystemClassLibrary
{
    partial class RegisterForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PassBox1 = new System.Windows.Forms.TextBox();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ShowPassChecBox = new System.Windows.Forms.CheckBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Password1Label = new System.Windows.Forms.Label();
            this.ConPasswordLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PassMatchLabel = new System.Windows.Forms.Label();
            this.Address1Box = new System.Windows.Forms.TextBox();
            this.Address1Label = new System.Windows.Forms.Label();
            this.Address2Box = new System.Windows.Forms.TextBox();
            this.Address2Label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 0;
            // 
            // PassBox1
            // 
            this.PassBox1.Location = new System.Drawing.Point(13, 73);
            this.PassBox1.Name = "PassBox1";
            this.PassBox1.Size = new System.Drawing.Size(159, 22);
            this.PassBox1.TabIndex = 1;
            this.PassBox1.UseSystemPasswordChar = true;
            this.PassBox1.TextChanged += new System.EventHandler(this.PassBox1_TextChanged);
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(13, 101);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.Size = new System.Drawing.Size(159, 22);
            this.PassBox2.TabIndex = 2;
            this.PassBox2.UseSystemPasswordChar = true;
            this.PassBox2.TextChanged += new System.EventHandler(this.PassBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 217);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 22);
            this.textBox5.TabIndex = 4;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(13, 246);
            this.BirthDatePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.BirthDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(159, 22);
            this.BirthDatePicker.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "England",
            "Germany",
            "Poland",
            "United States of America"});
            this.comboBox1.Location = new System.Drawing.Point(13, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mr",
            "Ms"});
            this.comboBox2.Location = new System.Drawing.Point(13, 161);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(42, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(337, 420);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 420);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ShowPassChecBox
            // 
            this.ShowPassChecBox.AutoSize = true;
            this.ShowPassChecBox.Location = new System.Drawing.Point(12, 130);
            this.ShowPassChecBox.Name = "ShowPassChecBox";
            this.ShowPassChecBox.Size = new System.Drawing.Size(107, 17);
            this.ShowPassChecBox.TabIndex = 10;
            this.ShowPassChecBox.Text = "Show Password";
            this.ShowPassChecBox.UseVisualStyleBackColor = true;
            this.ShowPassChecBox.CheckedChanged += new System.EventHandler(this.ShowPassChecBox_CheckedChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(177, 48);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(34, 13);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            // 
            // Password1Label
            // 
            this.Password1Label.AutoSize = true;
            this.Password1Label.Location = new System.Drawing.Point(178, 76);
            this.Password1Label.Name = "Password1Label";
            this.Password1Label.Size = new System.Drawing.Size(56, 13);
            this.Password1Label.TabIndex = 12;
            this.Password1Label.Text = "Password";
            // 
            // ConPasswordLabel
            // 
            this.ConPasswordLabel.AutoSize = true;
            this.ConPasswordLabel.Location = new System.Drawing.Point(178, 104);
            this.ConPasswordLabel.Name = "ConPasswordLabel";
            this.ConPasswordLabel.Size = new System.Drawing.Size(100, 13);
            this.ConPasswordLabel.TabIndex = 13;
            this.ConPasswordLabel.Text = "Confirm Password";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(178, 191);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(61, 13);
            this.FNameLabel.TabIndex = 14;
            this.FNameLabel.Text = "First Name";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(178, 220);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LNameLabel.TabIndex = 15;
            this.LNameLabel.Text = "Last Name";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(178, 253);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(59, 13);
            this.BirthLabel.TabIndex = 16;
            this.BirthLabel.Text = "Birth Date";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(178, 393);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(48, 13);
            this.CountryLabel.TabIndex = 17;
            this.CountryLabel.Text = "Country";
            // 
            // PassMatchLabel
            // 
            this.PassMatchLabel.AutoSize = true;
            this.PassMatchLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PassMatchLabel.Location = new System.Drawing.Point(178, 117);
            this.PassMatchLabel.Name = "PassMatchLabel";
            this.PassMatchLabel.Size = new System.Drawing.Size(126, 13);
            this.PassMatchLabel.TabIndex = 18;
            this.PassMatchLabel.Text = "*Password don\'t match";
            this.PassMatchLabel.Visible = false;
            // 
            // Address1Box
            // 
            this.Address1Box.Location = new System.Drawing.Point(13, 275);
            this.Address1Box.Name = "Address1Box";
            this.Address1Box.Size = new System.Drawing.Size(159, 22);
            this.Address1Box.TabIndex = 19;
            // 
            // Address1Label
            // 
            this.Address1Label.AutoSize = true;
            this.Address1Label.Location = new System.Drawing.Point(178, 278);
            this.Address1Label.Name = "Address1Label";
            this.Address1Label.Size = new System.Drawing.Size(48, 13);
            this.Address1Label.TabIndex = 20;
            this.Address1Label.Text = "Address";
            // 
            // Address2Box
            // 
            this.Address2Box.Location = new System.Drawing.Point(13, 304);
            this.Address2Box.Name = "Address2Box";
            this.Address2Box.Size = new System.Drawing.Size(159, 22);
            this.Address2Box.TabIndex = 21;
            // 
            // Address2Label
            // 
            this.Address2Label.AutoSize = true;
            this.Address2Label.Location = new System.Drawing.Point(178, 307);
            this.Address2Label.Name = "Address2Label";
            this.Address2Label.Size = new System.Drawing.Size(48, 13);
            this.Address2Label.TabIndex = 22;
            this.Address2Label.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 362);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 24;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(178, 336);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(26, 13);
            this.CityLabel.TabIndex = 25;
            this.CityLabel.Text = "City";
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(178, 365);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(68, 13);
            this.PostalCodeLabel.TabIndex = 26;
            this.PostalCodeLabel.Text = "Postal Code";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 455);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Address2Label);
            this.Controls.Add(this.Address2Box);
            this.Controls.Add(this.Address1Label);
            this.Controls.Add(this.Address1Box);
            this.Controls.Add(this.PassMatchLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.FNameLabel);
            this.Controls.Add(this.ConPasswordLabel);
            this.Controls.Add(this.Password1Label);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ShowPassChecBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.PassBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Booking - Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PassBox1;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox ShowPassChecBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Password1Label;
        private System.Windows.Forms.Label ConPasswordLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label PassMatchLabel;
        private System.Windows.Forms.TextBox Address1Box;
        private System.Windows.Forms.Label Address1Label;
        private System.Windows.Forms.TextBox Address2Box;
        private System.Windows.Forms.Label Address2Label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label PostalCodeLabel;

    }
}