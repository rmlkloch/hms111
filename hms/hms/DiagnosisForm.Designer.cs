namespace hms
{
    partial class DiagnosisForm
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
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.date_lbl = new System.Windows.Forms.Label();
            this.patientname_textbox = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.patientid_textbox = new System.Windows.Forms.TextBox();
            this.patientid_lbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.diagnosis_richtextbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symptoms_richtextbox = new System.Windows.Forms.RichTextBox();
            this.symptoms_lbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.save_btn = new System.Windows.Forms.Button();
            this.removemedicine_btn = new System.Windows.Forms.Button();
            this.addmedicine_button = new System.Windows.Forms.Button();
            this.mwdicines_datagrideview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentplan_richtextbox = new System.Windows.Forms.RichTextBox();
            this.treatmentplan_lbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mwdicines_datagrideview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(36, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.datetimepicker);
            this.tabPage1.Controls.Add(this.date_lbl);
            this.tabPage1.Controls.Add(this.patientname_textbox);
            this.tabPage1.Controls.Add(this.name_lbl);
            this.tabPage1.Controls.Add(this.patientid_textbox);
            this.tabPage1.Controls.Add(this.patientid_lbl);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1014, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient Details";
            // 
            // datetimepicker
            // 
            this.datetimepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepicker.Location = new System.Drawing.Point(271, 162);
            this.datetimepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(227, 38);
            this.datetimepicker.TabIndex = 5;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(117, 162);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(74, 32);
            this.date_lbl.TabIndex = 4;
            this.date_lbl.Text = "Date";
            // 
            // patientname_textbox
            // 
            this.patientname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientname_textbox.Location = new System.Drawing.Point(271, 113);
            this.patientname_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientname_textbox.Name = "patientname_textbox";
            this.patientname_textbox.Size = new System.Drawing.Size(227, 38);
            this.patientname_textbox.TabIndex = 3;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(117, 113);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(89, 32);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name";
            // 
            // patientid_textbox
            // 
            this.patientid_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid_textbox.Location = new System.Drawing.Point(271, 75);
            this.patientid_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientid_textbox.Name = "patientid_textbox";
            this.patientid_textbox.Size = new System.Drawing.Size(227, 38);
            this.patientid_textbox.TabIndex = 1;
            // 
            // patientid_lbl
            // 
            this.patientid_lbl.AutoSize = true;
            this.patientid_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientid_lbl.Location = new System.Drawing.Point(114, 75);
            this.patientid_lbl.Name = "patientid_lbl";
            this.patientid_lbl.Size = new System.Drawing.Size(138, 32);
            this.patientid_lbl.TabIndex = 0;
            this.patientid_lbl.Text = "Patient ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.diagnosis_richtextbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.symptoms_richtextbox);
            this.tabPage2.Controls.Add(this.symptoms_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1014, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diagnosis Details";
            // 
            // diagnosis_richtextbox
            // 
            this.diagnosis_richtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosis_richtextbox.Location = new System.Drawing.Point(273, 149);
            this.diagnosis_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.diagnosis_richtextbox.Name = "diagnosis_richtextbox";
            this.diagnosis_richtextbox.Size = new System.Drawing.Size(331, 73);
            this.diagnosis_richtextbox.TabIndex = 3;
            this.diagnosis_richtextbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagnosis";
            // 
            // symptoms_richtextbox
            // 
            this.symptoms_richtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms_richtextbox.Location = new System.Drawing.Point(273, 65);
            this.symptoms_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.symptoms_richtextbox.Name = "symptoms_richtextbox";
            this.symptoms_richtextbox.Size = new System.Drawing.Size(331, 64);
            this.symptoms_richtextbox.TabIndex = 1;
            this.symptoms_richtextbox.Text = "";
            // 
            // symptoms_lbl
            // 
            this.symptoms_lbl.AutoSize = true;
            this.symptoms_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms_lbl.Location = new System.Drawing.Point(85, 68);
            this.symptoms_lbl.Name = "symptoms_lbl";
            this.symptoms_lbl.Size = new System.Drawing.Size(147, 32);
            this.symptoms_lbl.TabIndex = 0;
            this.symptoms_lbl.Text = "Symptoms";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.save_btn);
            this.tabPage3.Controls.Add(this.removemedicine_btn);
            this.tabPage3.Controls.Add(this.addmedicine_button);
            this.tabPage3.Controls.Add(this.mwdicines_datagrideview);
            this.tabPage3.Controls.Add(this.treatmentplan_richtextbox);
            this.tabPage3.Controls.Add(this.treatmentplan_lbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1014, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Treatment Details";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(586, 304);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(111, 52);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // removemedicine_btn
            // 
            this.removemedicine_btn.BackColor = System.Drawing.Color.Salmon;
            this.removemedicine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removemedicine_btn.Location = new System.Drawing.Point(408, 304);
            this.removemedicine_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removemedicine_btn.Name = "removemedicine_btn";
            this.removemedicine_btn.Size = new System.Drawing.Size(158, 52);
            this.removemedicine_btn.TabIndex = 4;
            this.removemedicine_btn.Text = "Remove medicine";
            this.removemedicine_btn.UseVisualStyleBackColor = false;
            this.removemedicine_btn.Click += new System.EventHandler(this.removemedicine_btn_Click);
            // 
            // addmedicine_button
            // 
            this.addmedicine_button.BackColor = System.Drawing.Color.MistyRose;
            this.addmedicine_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmedicine_button.Location = new System.Drawing.Point(269, 304);
            this.addmedicine_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addmedicine_button.Name = "addmedicine_button";
            this.addmedicine_button.Size = new System.Drawing.Size(118, 52);
            this.addmedicine_button.TabIndex = 3;
            this.addmedicine_button.Text = "Add Medicine";
            this.addmedicine_button.UseVisualStyleBackColor = false;
            this.addmedicine_button.Click += new System.EventHandler(this.addmedicine_button_Click);
            // 
            // mwdicines_datagrideview
            // 
            this.mwdicines_datagrideview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mwdicines_datagrideview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.mwdicines_datagrideview.Location = new System.Drawing.Point(269, 151);
            this.mwdicines_datagrideview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mwdicines_datagrideview.Name = "mwdicines_datagrideview";
            this.mwdicines_datagrideview.RowHeadersWidth = 51;
            this.mwdicines_datagrideview.RowTemplate.Height = 24;
            this.mwdicines_datagrideview.Size = new System.Drawing.Size(428, 70);
            this.mwdicines_datagrideview.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dosage";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // treatmentplan_richtextbox
            // 
            this.treatmentplan_richtextbox.Location = new System.Drawing.Point(269, 48);
            this.treatmentplan_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treatmentplan_richtextbox.Name = "treatmentplan_richtextbox";
            this.treatmentplan_richtextbox.Size = new System.Drawing.Size(428, 80);
            this.treatmentplan_richtextbox.TabIndex = 1;
            this.treatmentplan_richtextbox.Text = "";
            this.treatmentplan_richtextbox.TextChanged += new System.EventHandler(this.treatmentplan_richtextbox_TextChanged);
            // 
            // treatmentplan_lbl
            // 
            this.treatmentplan_lbl.AutoSize = true;
            this.treatmentplan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentplan_lbl.Location = new System.Drawing.Point(59, 48);
            this.treatmentplan_lbl.Name = "treatmentplan_lbl";
            this.treatmentplan_lbl.Size = new System.Drawing.Size(177, 29);
            this.treatmentplan_lbl.TabIndex = 0;
            this.treatmentplan_lbl.Text = "Treatment Plan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::hms.Properties.Resources.pngwing_com__6_;
            this.pictureBox2.Location = new System.Drawing.Point(2, 444);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1844, 459);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::hms.Properties.Resources.pngwing_com__5_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1222, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 223);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::hms.Properties.Resources.pngwing_com__6_;
            this.pictureBox3.Location = new System.Drawing.Point(2, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1844, 670);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1335, 760);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1839, 905);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DiagnosisForm";
            this.Text = "Dignosis Form";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mwdicines_datagrideview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.TextBox patientname_textbox;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox patientid_textbox;
        private System.Windows.Forms.Label patientid_lbl;
        private System.Windows.Forms.RichTextBox symptoms_richtextbox;
        private System.Windows.Forms.Label symptoms_lbl;
        private System.Windows.Forms.RichTextBox diagnosis_richtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox treatmentplan_richtextbox;
        private System.Windows.Forms.Label treatmentplan_lbl;
        private System.Windows.Forms.DataGridView mwdicines_datagrideview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button removemedicine_btn;
        private System.Windows.Forms.Button addmedicine_button;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}