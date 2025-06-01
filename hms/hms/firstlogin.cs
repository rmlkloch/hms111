using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class Form1: Form
    {
        public static System.Drawing.Size PreviousFormSize = new System.Drawing.Size(800, 600); // Default Size එකක් දෙන්න පුළුවන්
        public static System.Drawing.Point PreviousFormLocation = new System.Drawing.Point(100, 100); // Default Location එකක් දෙන්න පුළුවන්
        public Form1()
        {
            InitializeComponent();
        }

        public static class AppSettings
        {
            // DefaultFormSize ekata gannawa
            public static System.Drawing.Size DefaultFormSize;

            // DefaultFormLocation
            public static System.Drawing.Point DefaultFormLocation;
            static AppSettings()
            {
                // Working area eke size eka gannawa.
                DefaultFormSize = Screen.PrimaryScreen.WorkingArea.Size;

                // form eka screen eke left top corner ekata set karanna.
                DefaultFormLocation = new System.Drawing.Point(0, 0);
            }
        }

        private void usercmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserType = usercmb.SelectedItem.ToString();

            if (selectedUserType == "Patient")
            {

                Form3 patientForm = new Form3();
                patientForm.Show();
                this.Hide();
            }
            else if (selectedUserType == "Staff")
            {

                Form12 Form12 = new Form12();
                Form12.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a valid User Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usign_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }
    }
}
