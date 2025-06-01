namespace hms
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.ulog = new System.Windows.Forms.Button();
            this.usign = new System.Windows.Forms.Button();
            this.usercmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ulog
            // 
            this.ulog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ulog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ulog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ulog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulog.Location = new System.Drawing.Point(536, 123);
            this.ulog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulog.Name = "ulog";
            this.ulog.Size = new System.Drawing.Size(122, 40);
            this.ulog.TabIndex = 0;
            this.ulog.Text = "Login";
            this.ulog.UseVisualStyleBackColor = false;
            this.ulog.Visible = false;
            this.ulog.Click += new System.EventHandler(this.ulog_Click);
            // 
            // usign
            // 
            this.usign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usign.BackColor = System.Drawing.Color.Salmon;
            this.usign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usign.Location = new System.Drawing.Point(408, 123);
            this.usign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usign.Name = "usign";
            this.usign.Size = new System.Drawing.Size(112, 40);
            this.usign.TabIndex = 5;
            this.usign.Text = "Signup";
            this.usign.UseVisualStyleBackColor = false;
            this.usign.Visible = false;
            this.usign.Click += new System.EventHandler(this.usign_Click);
            // 
            // usercmb
            // 
            this.usercmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usercmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercmb.FormattingEnabled = true;
            this.usercmb.Items.AddRange(new object[] {
            "Doctor",
            "Nurse"});
            this.usercmb.Location = new System.Drawing.Point(491, 56);
            this.usercmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usercmb.Name = "usercmb";
            this.usercmb.Size = new System.Drawing.Size(180, 37);
            this.usercmb.TabIndex = 9;
            this.usercmb.SelectedIndexChanged += new System.EventHandler(this.usercmb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "User";
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(656, 383);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(107, 36);
            this.back.TabIndex = 16;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usercmb);
            this.Controls.Add(this.usign);
            this.Controls.Add(this.ulog);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form12";
            this.Text = "Form12";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ulog;
        private System.Windows.Forms.Button usign;
        private System.Windows.Forms.ComboBox usercmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button back;
    }
}

