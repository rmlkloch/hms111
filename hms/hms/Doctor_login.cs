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
    public partial class DoctorLogin: Form
    {
        public DoctorLogin()
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

        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }

        private void staffid_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            

            string staffId = staffid.Text.Trim();
            string password = Password.Text;

            // Validation
            if (string.IsNullOrEmpty(staffId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Staff ID and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\LogIn DB.mdf"";Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM StaffLogin WHERE StaffId = @StaffId AND Password = @Password AND Role = 'Doctor'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffId", staffId);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Nurse login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Redirect to Nurse Dashboard
                        }
                        else
                        {
                            MessageBox.Show("Invalid Nurse credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            staffid.Text = string.Empty;
            Password.Text = string.Empty;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
