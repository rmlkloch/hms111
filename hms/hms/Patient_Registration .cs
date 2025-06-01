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
using System.Xml.Linq;

namespace hms
{
    public partial class Patient_Registration: Form
    {
        public Patient_Registration()
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

        private void id_searchbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Functionality will be implemented later.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Allergy_btn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(allergy_txtbox.Text))
            {
                allergy_listbox.Items.Add(allergy_txtbox.Text);
                allergy_txtbox.Clear();
            }
        }

        private void removealergy_btn_Click(object sender, EventArgs e)
        {
            if(allergy_listbox.SelectedIndex != -1)
            {
                allergy_listbox.Items.Remove(allergy_listbox.SelectedIndex);
            }
        }

        private void dob_datapicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dob_datapicker.Value;
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }
            age_textbox.Text = age.ToString();
        }

        private void registerpatient_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Patient registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //string connectionString = @" ";
            //SqlConnection con = new SqlConnection(connectionString);

            try
            {
                // 1. Capture Data from Controls
                string NIC = textBox1.Text.Trim();
                string patientId = id_textbox.Text.Trim();
                string patientName = name_textbox.Text.Trim();
                DateTime dateOfBirth = dob_datapicker.Value;
                string age = age_textbox.Text.Trim();
                string gender = gender_combobox.Text;
                string maritalStatus = marstatus_combobox.Text;
                string address = address_textbox.Text.Trim();
                string phoneNumber = phonenumber_textbox.Text.Trim();
                string email = email_textbox.Text.Trim();
                string height = height_textbox.Text.Trim();
                string weight = weight_textbox.Text.Trim();
                string allergy = allergy_txtbox.Text.Trim();

                // Convert selected items in listbox to comma-separated string
                List<string> selectedAllergies = new List<string>();
                foreach (var item in allergy_listbox.SelectedItems)
                {
                    selectedAllergies.Add(item.ToString());
                }
                string listOfAllergies = string.Join(", ", selectedAllergies);

                // 2. Basic Input Validation
                if (string.IsNullOrEmpty(NIC) ||
                    string.IsNullOrEmpty(patientId) ||
                    string.IsNullOrEmpty(patientName) ||
                    string.IsNullOrEmpty(age) ||
                    string.IsNullOrEmpty(gender) ||
                    string.IsNullOrEmpty(address) ||
                    string.IsNullOrEmpty(phoneNumber))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(age, out _))
                {
                    MessageBox.Show("Age must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(phoneNumber, out _))
                {
                    MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Database Insert
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms_assignment-3\hms\hms\PatientReg DB.mdf"";Integrated Security=True"))
                {
                    string query = @"INSERT INTO PatientReg 
                            (NIC,PatientId, Name, DOB, Age, Gender, MaritalStatus, Address, Phone, Email, Height, Weight, Allergy, AllergyList)
                             VALUES
                            (@NIC, @PatientId, @Name, @DOB, @Age, @Gender, @MaritalStatus, @Address, @Phone, @Email, @Height, @Weight, @Allergy, @AllergyList)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NIC", NIC);
                    cmd.Parameters.AddWithValue("@PatientId", patientId);
                    cmd.Parameters.AddWithValue("@Name", patientName);
                    cmd.Parameters.AddWithValue("@DOB", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@MaritalStatus", maritalStatus);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Height", height);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Allergy", allergy);
                    cmd.Parameters.AddWithValue("@AllergyList", listOfAllergies);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record inserted. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();

        }

        private void Patient_Registration_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void marstatus_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}



        
