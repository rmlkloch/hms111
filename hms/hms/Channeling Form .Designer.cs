namespace hms
{
    partial class Form3
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
            this.patientdetails_grpbox = new System.Windows.Forms.GroupBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.patientid_textbox = new System.Windows.Forms.TextBox();
            this.patientid_lbl = new System.Windows.Forms.Label();
            this.appoinmentdetails_grpbox = new System.Windows.Forms.GroupBox();
            this.appoinment_txtbox = new System.Windows.Forms.TextBox();
            this.appoinmentfee_label = new System.Windows.Forms.Label();
            this.timeslot_combobox = new System.Windows.Forms.ComboBox();
            this.timeslot_lbl = new System.Windows.Forms.Label();
            this.appoinment_timepicker = new System.Windows.Forms.DateTimePicker();
            this.appoinmentdate_lbl = new System.Windows.Forms.Label();
            this.specialization_combobox = new System.Windows.Forms.ComboBox();
            this.specialization_lbl = new System.Windows.Forms.Label();
            this.doctor_combobox = new System.Windows.Forms.ComboBox();
            this.doctor_lbl = new System.Windows.Forms.Label();
            this.bookappinment_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.patientdetails_grpbox.SuspendLayout();
            this.appoinmentdetails_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientdetails_grpbox
            // 
            this.patientdetails_grpbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.patientdetails_grpbox.Controls.Add(this.name_txtbox);
            this.patientdetails_grpbox.Controls.Add(this.name_lbl);
            this.patientdetails_grpbox.Controls.Add(this.patientid_textbox);
            this.patientdetails_grpbox.Controls.Add(this.patientid_lbl);
            this.patientdetails_grpbox.Location = new System.Drawing.Point(12, 41);
            this.patientdetails_grpbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientdetails_grpbox.Name = "patientdetails_grpbox";
            this.patientdetails_grpbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientdetails_grpbox.Size = new System.Drawing.Size(751, 144);
            this.patientdetails_grpbox.TabIndex = 0;
            this.patientdetails_grpbox.TabStop = false;
            this.patientdetails_grpbox.Text = "Patient Details";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Enabled = false;
            this.name_txtbox.Location = new System.Drawing.Point(131, 87);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(160, 26);
            this.name_txtbox.TabIndex = 5;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(40, 87);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(53, 20);
            this.name_lbl.TabIndex = 4;
            this.name_lbl.Text = "Name";
            // 
            // patientid_textbox
            // 
            this.patientid_textbox.Location = new System.Drawing.Point(131, 39);
            this.patientid_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientid_textbox.Name = "patientid_textbox";
            this.patientid_textbox.Size = new System.Drawing.Size(160, 26);
            this.patientid_textbox.TabIndex = 1;
            // 
            // patientid_lbl
            // 
            this.patientid_lbl.AutoSize = true;
            this.patientid_lbl.Location = new System.Drawing.Point(36, 39);
            this.patientid_lbl.Name = "patientid_lbl";
            this.patientid_lbl.Size = new System.Drawing.Size(83, 20);
            this.patientid_lbl.TabIndex = 0;
            this.patientid_lbl.Text = "Patient ID";
            // 
            // appoinmentdetails_grpbox
            // 
            this.appoinmentdetails_grpbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.appoinmentdetails_grpbox.Controls.Add(this.appoinment_txtbox);
            this.appoinmentdetails_grpbox.Controls.Add(this.appoinmentfee_label);
            this.appoinmentdetails_grpbox.Controls.Add(this.timeslot_combobox);
            this.appoinmentdetails_grpbox.Controls.Add(this.timeslot_lbl);
            this.appoinmentdetails_grpbox.Controls.Add(this.appoinment_timepicker);
            this.appoinmentdetails_grpbox.Controls.Add(this.appoinmentdate_lbl);
            this.appoinmentdetails_grpbox.Controls.Add(this.specialization_combobox);
            this.appoinmentdetails_grpbox.Controls.Add(this.specialization_lbl);
            this.appoinmentdetails_grpbox.Controls.Add(this.doctor_combobox);
            this.appoinmentdetails_grpbox.Controls.Add(this.doctor_lbl);
            this.appoinmentdetails_grpbox.Location = new System.Drawing.Point(12, 209);
            this.appoinmentdetails_grpbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appoinmentdetails_grpbox.Name = "appoinmentdetails_grpbox";
            this.appoinmentdetails_grpbox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appoinmentdetails_grpbox.Size = new System.Drawing.Size(751, 267);
            this.appoinmentdetails_grpbox.TabIndex = 1;
            this.appoinmentdetails_grpbox.TabStop = false;
            this.appoinmentdetails_grpbox.Text = "Appointment Details";
            this.appoinmentdetails_grpbox.Enter += new System.EventHandler(this.appoinmentdetails_grpbox_Enter);
            // 
            // appoinment_txtbox
            // 
            this.appoinment_txtbox.Location = new System.Drawing.Point(196, 141);
            this.appoinment_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appoinment_txtbox.Name = "appoinment_txtbox";
            this.appoinment_txtbox.Size = new System.Drawing.Size(160, 26);
            this.appoinment_txtbox.TabIndex = 9;
            // 
            // appoinmentfee_label
            // 
            this.appoinmentfee_label.AutoSize = true;
            this.appoinmentfee_label.Location = new System.Drawing.Point(18, 147);
            this.appoinmentfee_label.Name = "appoinmentfee_label";
            this.appoinmentfee_label.Size = new System.Drawing.Size(172, 20);
            this.appoinmentfee_label.TabIndex = 8;
            this.appoinmentfee_label.Text = "Appoinment Fee (Rs.)";
            // 
            // timeslot_combobox
            // 
            this.timeslot_combobox.FormattingEnabled = true;
            this.timeslot_combobox.Location = new System.Drawing.Point(515, 85);
            this.timeslot_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeslot_combobox.Name = "timeslot_combobox";
            this.timeslot_combobox.Size = new System.Drawing.Size(160, 28);
            this.timeslot_combobox.TabIndex = 7;
            // 
            // timeslot_lbl
            // 
            this.timeslot_lbl.AutoSize = true;
            this.timeslot_lbl.Location = new System.Drawing.Point(371, 85);
            this.timeslot_lbl.Name = "timeslot_lbl";
            this.timeslot_lbl.Size = new System.Drawing.Size(80, 20);
            this.timeslot_lbl.TabIndex = 6;
            this.timeslot_lbl.Text = "Time Slot";
            // 
            // appoinment_timepicker
            // 
            this.appoinment_timepicker.Location = new System.Drawing.Point(196, 87);
            this.appoinment_timepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appoinment_timepicker.Name = "appoinment_timepicker";
            this.appoinment_timepicker.Size = new System.Drawing.Size(160, 26);
            this.appoinment_timepicker.TabIndex = 5;
            // 
            // appoinmentdate_lbl
            // 
            this.appoinmentdate_lbl.AutoSize = true;
            this.appoinmentdate_lbl.Location = new System.Drawing.Point(18, 92);
            this.appoinmentdate_lbl.Name = "appoinmentdate_lbl";
            this.appoinmentdate_lbl.Size = new System.Drawing.Size(138, 20);
            this.appoinmentdate_lbl.TabIndex = 4;
            this.appoinmentdate_lbl.Text = "Appoinment Date";
            // 
            // specialization_combobox
            // 
            this.specialization_combobox.FormattingEnabled = true;
            this.specialization_combobox.Location = new System.Drawing.Point(515, 37);
            this.specialization_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.specialization_combobox.Name = "specialization_combobox";
            this.specialization_combobox.Size = new System.Drawing.Size(160, 28);
            this.specialization_combobox.TabIndex = 3;
            this.specialization_combobox.SelectedIndexChanged += new System.EventHandler(this.specialization_combobox_SelectedIndexChanged);
            // 
            // specialization_lbl
            // 
            this.specialization_lbl.AutoSize = true;
            this.specialization_lbl.Location = new System.Drawing.Point(377, 45);
            this.specialization_lbl.Name = "specialization_lbl";
            this.specialization_lbl.Size = new System.Drawing.Size(113, 20);
            this.specialization_lbl.TabIndex = 2;
            this.specialization_lbl.Text = "Specialization";
            // 
            // doctor_combobox
            // 
            this.doctor_combobox.FormattingEnabled = true;
            this.doctor_combobox.Location = new System.Drawing.Point(196, 42);
            this.doctor_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctor_combobox.Name = "doctor_combobox";
            this.doctor_combobox.Size = new System.Drawing.Size(160, 28);
            this.doctor_combobox.TabIndex = 1;
            // 
            // doctor_lbl
            // 
            this.doctor_lbl.AutoSize = true;
            this.doctor_lbl.Location = new System.Drawing.Point(18, 42);
            this.doctor_lbl.Name = "doctor_lbl";
            this.doctor_lbl.Size = new System.Drawing.Size(60, 20);
            this.doctor_lbl.TabIndex = 0;
            this.doctor_lbl.Text = "Doctor";
            this.doctor_lbl.Click += new System.EventHandler(this.doctor_lbl_Click);
            // 
            // bookappinment_btn
            // 
            this.bookappinment_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookappinment_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookappinment_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookappinment_btn.Location = new System.Drawing.Point(799, 56);
            this.bookappinment_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookappinment_btn.Name = "bookappinment_btn";
            this.bookappinment_btn.Size = new System.Drawing.Size(163, 32);
            this.bookappinment_btn.TabIndex = 2;
            this.bookappinment_btn.Text = "Book Appinment";
            this.bookappinment_btn.UseVisualStyleBackColor = false;
            this.bookappinment_btn.Click += new System.EventHandler(this.bookappinment_btn_Click);
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.Wheat;
            this.back.Location = new System.Drawing.Point(799, 506);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(163, 41);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.Location = new System.Drawing.Point(799, 129);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(163, 32);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(974, 558);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bookappinment_btn);
            this.Controls.Add(this.appoinmentdetails_grpbox);
            this.Controls.Add(this.patientdetails_grpbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Chanelling Form";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.patientdetails_grpbox.ResumeLayout(false);
            this.patientdetails_grpbox.PerformLayout();
            this.appoinmentdetails_grpbox.ResumeLayout(false);
            this.appoinmentdetails_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patientdetails_grpbox;
        private System.Windows.Forms.TextBox patientid_textbox;
        private System.Windows.Forms.Label patientid_lbl;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.GroupBox appoinmentdetails_grpbox;
        private System.Windows.Forms.Label specialization_lbl;
        private System.Windows.Forms.ComboBox doctor_combobox;
        private System.Windows.Forms.Label doctor_lbl;
        private System.Windows.Forms.DateTimePicker appoinment_timepicker;
        private System.Windows.Forms.Label appoinmentdate_lbl;
        private System.Windows.Forms.ComboBox specialization_combobox;
        private System.Windows.Forms.Label timeslot_lbl;
        private System.Windows.Forms.TextBox appoinment_txtbox;
        private System.Windows.Forms.Label appoinmentfee_label;
        private System.Windows.Forms.ComboBox timeslot_combobox;
        private System.Windows.Forms.Button bookappinment_btn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnPay;
    }
}