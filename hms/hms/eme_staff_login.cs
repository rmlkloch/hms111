using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    public partial class eme_staff_login : Form
    {
        public eme_staff_login()
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

        private void eme_staff_login_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string licenceText = staffid.Text.Trim(); // Assuming staffid is the TextBox for Medical_Licence_No
            string password = Password.Text;

            // Validation
            if (string.IsNullOrEmpty(licenceText) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Medical Licence No and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(licenceText, out int medicalLicenceNo))
            {
                MessageBox.Show("Medical Licence No must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\eme_staff.mdf"";Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM emestaff WHERE Medical_Licence_No = @LicenceNo AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LicenceNo", medicalLicenceNo);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            eme_dashboard emedashboard = new eme_dashboard();
                            emedashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            

            staffid.Text = string.Empty;
            Password.Text = string.Empty;
        
    }
    }
    }


