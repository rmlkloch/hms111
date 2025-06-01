namespace hms
{
    partial class Patient_Registration
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
            this.back_button = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.marstatus_combobox = new System.Windows.Forms.ComboBox();
            this.maritalstatus_label = new System.Windows.Forms.Label();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.gender_lebal = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.dob_datapicker = new System.Windows.Forms.DateTimePicker();
            this.dob_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_searchbutton = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.phonenumber_textbox = new System.Windows.Forms.TextBox();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.weight_textbox = new System.Windows.Forms.TextBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.height_textbox = new System.Windows.Forms.TextBox();
            this.height_lbl = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.registerpatient_btn = new System.Windows.Forms.Button();
            this.removealergy_btn = new System.Windows.Forms.Button();
            this.allergy_listbox = new System.Windows.Forms.ListBox();
            this.Allergy_btn = new System.Windows.Forms.Button();
            this.allergy_txtbox = new System.Windows.Forms.TextBox();
            this.allergy_lbl = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button.BackColor = System.Drawing.Color.Wheat;
            this.back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(1353, 740);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 46);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tabPage1);
            this.tbc.Controls.Add(this.tabPage2);
            this.tbc.Controls.Add(this.tabPage3);
            this.tbc.Controls.Add(this.tabPage4);
            this.tbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc.Location = new System.Drawing.Point(62, 30);
            this.tbc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(1328, 587);
            this.tbc.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.marstatus_combobox);
            this.tabPage1.Controls.Add(this.maritalstatus_label);
            this.tabPage1.Controls.Add(this.gender_combobox);
            this.tabPage1.Controls.Add(this.gender_lebal);
            this.tabPage1.Controls.Add(this.age_textbox);
            this.tabPage1.Controls.Add(this.age_label);
            this.tabPage1.Controls.Add(this.dob_datapicker);
            this.tabPage1.Controls.Add(this.dob_label);
            this.tabPage1.Controls.Add(this.name_textbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.id_searchbutton);
            this.tabPage1.Controls.Add(this.id_textbox);
            this.tabPage1.Controls.Add(this.id_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1320, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Info";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 30);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "NIC";
            // 
            // marstatus_combobox
            // 
            this.marstatus_combobox.FormattingEnabled = true;
            this.marstatus_combobox.Items.AddRange(new object[] {
            "Married",
            "UnMarried"});
            this.marstatus_combobox.Location = new System.Drawing.Point(621, 220);
            this.marstatus_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marstatus_combobox.Name = "marstatus_combobox";
            this.marstatus_combobox.Size = new System.Drawing.Size(121, 33);
            this.marstatus_combobox.TabIndex = 12;
            this.marstatus_combobox.SelectedIndexChanged += new System.EventHandler(this.marstatus_combobox_SelectedIndexChanged);
            // 
            // maritalstatus_label
            // 
            this.maritalstatus_label.AutoSize = true;
            this.maritalstatus_label.Location = new System.Drawing.Point(460, 223);
            this.maritalstatus_label.Name = "maritalstatus_label";
            this.maritalstatus_label.Size = new System.Drawing.Size(131, 25);
            this.maritalstatus_label.TabIndex = 11;
            this.maritalstatus_label.Text = "Marital Status";
            // 
            // gender_combobox
            // 
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gender_combobox.Location = new System.Drawing.Point(621, 128);
            this.gender_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(121, 33);
            this.gender_combobox.TabIndex = 10;
            // 
            // gender_lebal
            // 
            this.gender_lebal.AutoSize = true;
            this.gender_lebal.Location = new System.Drawing.Point(474, 138);
            this.gender_lebal.Name = "gender_lebal";
            this.gender_lebal.Size = new System.Drawing.Size(77, 25);
            this.gender_lebal.TabIndex = 9;
            this.gender_lebal.Text = "Gender";
            // 
            // age_textbox
            // 
            this.age_textbox.Location = new System.Drawing.Point(616, 66);
            this.age_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(126, 30);
            this.age_textbox.TabIndex = 8;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(474, 71);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(48, 25);
            this.age_label.TabIndex = 7;
            this.age_label.Text = "Age";
            // 
            // dob_datapicker
            // 
            this.dob_datapicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_datapicker.Location = new System.Drawing.Point(234, 223);
            this.dob_datapicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dob_datapicker.Name = "dob_datapicker";
            this.dob_datapicker.Size = new System.Drawing.Size(136, 30);
            this.dob_datapicker.TabIndex = 6;
            this.dob_datapicker.ValueChanged += new System.EventHandler(this.dob_datapicker_ValueChanged);
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Location = new System.Drawing.Point(72, 231);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(118, 25);
            this.dob_label.TabIndex = 5;
            this.dob_label.Text = "Date of Birth";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(234, 138);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(136, 30);
            this.name_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Name";
            // 
            // id_searchbutton
            // 
            this.id_searchbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_searchbutton.Location = new System.Drawing.Point(951, 175);
            this.id_searchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_searchbutton.Name = "id_searchbutton";
            this.id_searchbutton.Size = new System.Drawing.Size(128, 66);
            this.id_searchbutton.TabIndex = 2;
            this.id_searchbutton.Text = "search";
            this.id_searchbutton.UseVisualStyleBackColor = false;
            this.id_searchbutton.Click += new System.EventHandler(this.id_searchbutton_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(1007, 66);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(100, 30);
            this.id_textbox.TabIndex = 1;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(858, 66);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(96, 25);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "Patient ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.email_textbox);
            this.tabPage2.Controls.Add(this.email_label);
            this.tabPage2.Controls.Add(this.phonenumber_textbox);
            this.tabPage2.Controls.Add(this.phonenumber_label);
            this.tabPage2.Controls.Add(this.address_textbox);
            this.tabPage2.Controls.Add(this.address_label);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1320, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contact Info";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(338, 212);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(233, 30);
            this.email_textbox.TabIndex = 5;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(124, 220);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(58, 25);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "email";
            // 
            // phonenumber_textbox
            // 
            this.phonenumber_textbox.Location = new System.Drawing.Point(341, 136);
            this.phonenumber_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenumber_textbox.Name = "phonenumber_textbox";
            this.phonenumber_textbox.Size = new System.Drawing.Size(233, 30);
            this.phonenumber_textbox.TabIndex = 3;
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Location = new System.Drawing.Point(124, 142);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(140, 25);
            this.phonenumber_label.TabIndex = 2;
            this.phonenumber_label.Text = "Phone number";
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(341, 64);
            this.address_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(233, 30);
            this.address_textbox.TabIndex = 1;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(124, 64);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(85, 25);
            this.address_label.TabIndex = 0;
            this.address_label.Text = "Address";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.weight_textbox);
            this.tabPage3.Controls.Add(this.weight_lbl);
            this.tabPage3.Controls.Add(this.height_textbox);
            this.tabPage3.Controls.Add(this.height_lbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1320, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vitals";
            // 
            // weight_textbox
            // 
            this.weight_textbox.Location = new System.Drawing.Point(236, 148);
            this.weight_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.Size = new System.Drawing.Size(100, 30);
            this.weight_textbox.TabIndex = 3;
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.Location = new System.Drawing.Point(107, 155);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(74, 25);
            this.weight_lbl.TabIndex = 2;
            this.weight_lbl.Text = "Weight";
            // 
            // height_textbox
            // 
            this.height_textbox.Location = new System.Drawing.Point(240, 69);
            this.height_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height_textbox.Name = "height_textbox";
            this.height_textbox.Size = new System.Drawing.Size(100, 30);
            this.height_textbox.TabIndex = 1;
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(107, 76);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(68, 25);
            this.height_lbl.TabIndex = 0;
            this.height_lbl.Text = "Height";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.registerpatient_btn);
            this.tabPage4.Controls.Add(this.removealergy_btn);
            this.tabPage4.Controls.Add(this.allergy_listbox);
            this.tabPage4.Controls.Add(this.Allergy_btn);
            this.tabPage4.Controls.Add(this.allergy_txtbox);
            this.tabPage4.Controls.Add(this.allergy_lbl);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1320, 549);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Allergies";
            // 
            // registerpatient_btn
            // 
            this.registerpatient_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerpatient_btn.Location = new System.Drawing.Point(688, 62);
            this.registerpatient_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerpatient_btn.Name = "registerpatient_btn";
            this.registerpatient_btn.Size = new System.Drawing.Size(168, 57);
            this.registerpatient_btn.TabIndex = 5;
            this.registerpatient_btn.Text = "Register Patient";
            this.registerpatient_btn.UseVisualStyleBackColor = false;
            this.registerpatient_btn.Click += new System.EventHandler(this.registerpatient_btn_Click);
            // 
            // removealergy_btn
            // 
            this.removealergy_btn.BackColor = System.Drawing.Color.Salmon;
            this.removealergy_btn.Location = new System.Drawing.Point(129, 400);
            this.removealergy_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removealergy_btn.Name = "removealergy_btn";
            this.removealergy_btn.Size = new System.Drawing.Size(172, 57);
            this.removealergy_btn.TabIndex = 4;
            this.removealergy_btn.Text = "Remove Allergy";
            this.removealergy_btn.UseVisualStyleBackColor = false;
            this.removealergy_btn.Click += new System.EventHandler(this.removealergy_btn_Click);
            // 
            // allergy_listbox
            // 
            this.allergy_listbox.FormattingEnabled = true;
            this.allergy_listbox.ItemHeight = 25;
            this.allergy_listbox.Location = new System.Drawing.Point(108, 150);
            this.allergy_listbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergy_listbox.Name = "allergy_listbox";
            this.allergy_listbox.Size = new System.Drawing.Size(488, 204);
            this.allergy_listbox.TabIndex = 3;
            // 
            // Allergy_btn
            // 
            this.Allergy_btn.BackColor = System.Drawing.Color.MistyRose;
            this.Allergy_btn.Location = new System.Drawing.Point(374, 400);
            this.Allergy_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Allergy_btn.Name = "Allergy_btn";
            this.Allergy_btn.Size = new System.Drawing.Size(149, 57);
            this.Allergy_btn.TabIndex = 2;
            this.Allergy_btn.Text = "Add Allergy";
            this.Allergy_btn.UseVisualStyleBackColor = false;
            this.Allergy_btn.Click += new System.EventHandler(this.Allergy_btn_Click);
            // 
            // allergy_txtbox
            // 
            this.allergy_txtbox.Location = new System.Drawing.Point(306, 78);
            this.allergy_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergy_txtbox.Name = "allergy_txtbox";
            this.allergy_txtbox.Size = new System.Drawing.Size(290, 30);
            this.allergy_txtbox.TabIndex = 1;
            // 
            // allergy_lbl
            // 
            this.allergy_lbl.AutoSize = true;
            this.allergy_lbl.Location = new System.Drawing.Point(111, 78);
            this.allergy_lbl.Name = "allergy_lbl";
            this.allergy_lbl.Size = new System.Drawing.Size(157, 25);
            this.allergy_lbl.TabIndex = 0;
            this.allergy_lbl.Text = "Add New Allergy";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::hms.Properties.Resources.pngwing_com__10_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1669, 829);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Patient_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1714, 853);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient_Registration";
            this.Text = "Patient_Registration";
            this.Load += new System.EventHandler(this.Patient_Registration_Load);
            this.tbc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button id_searchbutton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.DateTimePicker dob_datapicker;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label gender_lebal;
        private System.Windows.Forms.TextBox age_textbox;
        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.ComboBox marstatus_combobox;
        private System.Windows.Forms.Label maritalstatus_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox phonenumber_textbox;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox height_textbox;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.TextBox weight_textbox;
        private System.Windows.Forms.Label weight_lbl;
        private System.Windows.Forms.Button Allergy_btn;
        private System.Windows.Forms.TextBox allergy_txtbox;
        private System.Windows.Forms.Label allergy_lbl;
        private System.Windows.Forms.ListBox allergy_listbox;
        private System.Windows.Forms.Button removealergy_btn;
        private System.Windows.Forms.Button registerpatient_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}