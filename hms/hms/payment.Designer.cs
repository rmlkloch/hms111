namespace hms
{
    partial class paymentForm
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
            this.back = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.cashierDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.cashierIdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cardDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cardExpiryTextBox = new System.Windows.Forms.TextBox();
            this.cardCVVTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cashierDetailsGroupBox.SuspendLayout();
            this.cardDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.Wheat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1360, 718);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(113, 49);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(70, 75);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 408);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.nextButton);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.patientNameTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(929, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Service Details";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Patient Name";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.Location = new System.Drawing.Point(527, 245);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(99, 52);
            this.nextButton.TabIndex = 8;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(271, 189);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Channeling",
            "Pharmacy",
            "Reports"});
            this.comboBox1.Location = new System.Drawing.Point(270, 124);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(267, 59);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(153, 26);
            this.patientNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Type:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.paymentMethodComboBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.payButton);
            this.tabPage2.Controls.Add(this.cashierDetailsGroupBox);
            this.tabPage2.Controls.Add(this.cardDetailsGroupBox);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(929, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payment Method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Payment method";
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(181, 30);
            this.paymentMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(121, 28);
            this.paymentMethodComboBox.TabIndex = 5;
            this.paymentMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentMethodComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total Amount: 0.00";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.payButton.Location = new System.Drawing.Point(52, 100);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(125, 52);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cashierDetailsGroupBox
            // 
            this.cashierDetailsGroupBox.Controls.Add(this.cashierIdTextBox);
            this.cashierDetailsGroupBox.Controls.Add(this.label6);
            this.cashierDetailsGroupBox.Location = new System.Drawing.Point(338, 33);
            this.cashierDetailsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashierDetailsGroupBox.Name = "cashierDetailsGroupBox";
            this.cashierDetailsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashierDetailsGroupBox.Size = new System.Drawing.Size(365, 105);
            this.cashierDetailsGroupBox.TabIndex = 2;
            this.cashierDetailsGroupBox.TabStop = false;
            this.cashierDetailsGroupBox.Text = "Cashier Details";
            this.cashierDetailsGroupBox.Visible = false;
            // 
            // cashierIdTextBox
            // 
            this.cashierIdTextBox.Location = new System.Drawing.Point(136, 37);
            this.cashierIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cashierIdTextBox.Name = "cashierIdTextBox";
            this.cashierIdTextBox.Size = new System.Drawing.Size(100, 26);
            this.cashierIdTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cashier ID:";
            // 
            // cardDetailsGroupBox
            // 
            this.cardDetailsGroupBox.Controls.Add(this.label5);
            this.cardDetailsGroupBox.Controls.Add(this.cardExpiryTextBox);
            this.cardDetailsGroupBox.Controls.Add(this.cardCVVTextBox);
            this.cardDetailsGroupBox.Controls.Add(this.cardNumberTextBox);
            this.cardDetailsGroupBox.Controls.Add(this.label4);
            this.cardDetailsGroupBox.Controls.Add(this.label3);
            this.cardDetailsGroupBox.Location = new System.Drawing.Point(338, 30);
            this.cardDetailsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardDetailsGroupBox.Name = "cardDetailsGroupBox";
            this.cardDetailsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardDetailsGroupBox.Size = new System.Drawing.Size(412, 154);
            this.cardDetailsGroupBox.TabIndex = 1;
            this.cardDetailsGroupBox.TabStop = false;
            this.cardDetailsGroupBox.Text = "Card Details";
            this.cardDetailsGroupBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Card Number:";
            // 
            // cardExpiryTextBox
            // 
            this.cardExpiryTextBox.Location = new System.Drawing.Point(185, 66);
            this.cardExpiryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardExpiryTextBox.Name = "cardExpiryTextBox";
            this.cardExpiryTextBox.Size = new System.Drawing.Size(168, 26);
            this.cardExpiryTextBox.TabIndex = 3;
            // 
            // cardCVVTextBox
            // 
            this.cardCVVTextBox.Location = new System.Drawing.Point(185, 107);
            this.cardCVVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardCVVTextBox.Name = "cardCVVTextBox";
            this.cardCVVTextBox.Size = new System.Drawing.Size(168, 26);
            this.cardCVVTextBox.TabIndex = 2;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(185, 30);
            this.cardNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(168, 26);
            this.cardNumberTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expiry Date:";
            // 
            // paymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1688, 824);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "paymentForm";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.patient_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.cashierDetailsGroupBox.ResumeLayout(false);
            this.cashierDetailsGroupBox.PerformLayout();
            this.cardDetailsGroupBox.ResumeLayout(false);
            this.cardDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox cardDetailsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.GroupBox cashierDetailsGroupBox;
        private System.Windows.Forms.TextBox cardExpiryTextBox;
        private System.Windows.Forms.TextBox cardCVVTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cashierIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private System.Windows.Forms.Label label9;
    }
}