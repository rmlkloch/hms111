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
    public partial class eme_staff_reg : Form
    {
        private string userType;
        public eme_staff_reg(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }
        public eme_staff_reg()
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
        private void eme_staff_reg_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void save_Click(object sender, EventArgs e)
        {
            // connection string
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\eme_staff.mdf"";Integrated Security=True");

            // 
            string id = textBox1.Text.Trim();
            string name = txtname.Text.Trim();

            string password = pass.Text.Trim();
            string phone = txtphone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = cmbgender.Text;
            DateTime DOB = dob_picker.Value.Date;
            DateTime joinDate = joindate_picker.Value.Date;
            string Medical_Licence_No = mid.Text.Trim();


            // Validate 
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string query = "INSERT INTO emestaff (Medical_Licence_No, NIC, name, phone, email, gender, DOB, joinDate, password)" +
                               "VALUES (@Medical_Licence_No, @NIC, @name, @phone, @email, @gender, @DOB, @joinDate, @password)";

                SqlCommand cmd1 = new SqlCommand(query, con1);

                
                cmd1.Parameters.AddWithValue("@Medical_Licence_No", Medical_Licence_No);
                cmd1.Parameters.AddWithValue("@NIC", id);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@gender", gender);
                cmd1.Parameters.AddWithValue("@DOB", DOB);
                cmd1.Parameters.AddWithValue("@joinDate", joinDate);
                cmd1.Parameters.AddWithValue("@password", password);


                // Step 08: Execute the command
                con1.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show($"Registered {name} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                if (con1.State == ConnectionState.Open)
                    con1.Close();
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }

        private void eme_staff_reg_Load_1(object sender, EventArgs e)
        {

        }
    }
}
