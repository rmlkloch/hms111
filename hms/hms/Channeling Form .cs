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
    public partial class Form3: Form
    {
        public Form3()
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

        private void searchpatient_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Sample doctor data (This needs to be loaded from the database)
            doctor_combobox.Items.AddRange(new string[] { "Dr. Kamal Perera", "Dr. Nimal Silva", "Dr. Sumith Fernando" });

            // Sample specialization data (This needs to be loaded from the database)
            specialization_combobox.Items.AddRange(new string[] { "Cardiology", "Neurology", "Pediatrics" });

            // Sample time slot data (This needs to be loaded from the database)
            timeslot_combobox.Items.AddRange(new string[] { "9:00 AM - 10:00 AM", "10:00 AM - 11:00 AM", "2:00 PM - 3:00 PM" });

            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void specialization_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show the fee for the selected specialization (this must be retrieved from the database)
            if (specialization_combobox.SelectedItem != null)
            {
                string selectedSpecialization = specialization_combobox.SelectedItem.ToString();
                if (selectedSpecialization == "Cardiology")
                {
                    appoinment_txtbox.Text = "1500.00";
                }
                else if (selectedSpecialization == "Neurology")
                {
                    appoinment_txtbox.Text = "2000.00";
                }
                else if (selectedSpecialization == "Pediatrics")
                {
                    appoinment_txtbox.Text = "1000.00";
                }
                else
                {
                    appoinment_txtbox.Text = "";
                }
            }
        }

        private void bookappinment_btn_Click(object sender, EventArgs e)
        {
            // Step 1 - Get data
            string patientId = patientid_textbox.Text.Trim();
            string patientName = name_txtbox.Text.Trim();
            string doctor = doctor_combobox.SelectedItem?.ToString() ?? "";
            string specialisation = specialization_combobox.SelectedItem?.ToString() ?? "";
            DateTime appointmentDate = appoinment_timepicker.Value.Date;
            string timeSlot = timeslot_combobox.SelectedItem?.ToString() ?? "";
            string feeText = appoinment_txtbox.Text.Trim();

            // Step 2 - Validate
            if (string.IsNullOrEmpty(patientId) || string.IsNullOrEmpty(patientName) ||
                string.IsNullOrEmpty(doctor) || string.IsNullOrEmpty(specialisation) ||
                string.IsNullOrEmpty(timeSlot) || string.IsNullOrEmpty(feeText))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(feeText, out decimal appointmentFee))
            {
                MessageBox.Show("Invalid fee format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 3 - DB connection
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms_assignment-3\hms\hms\Chanelling DB.mdf"";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"INSERT INTO Appoinments 
                         (PatientID, PatientName, Doctor, Specialisation, AppointmentDate, TimeSlot, AppointmentFee) 
                         VALUES 
                         (@PatientID, @PatientName, @Doctor, @Specialisation, @AppointmentDate, @TimeSlot, @AppointmentFee)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.Parameters.AddWithValue("@PatientName", patientName);
                    cmd.Parameters.AddWithValue("@Doctor", doctor);
                    cmd.Parameters.AddWithValue("@Specialisation", specialisation);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@TimeSlot", timeSlot);
                    cmd.Parameters.AddWithValue("@AppointmentFee", appointmentFee);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        private void back_Click(object sender, EventArgs e)
        {
            Form1.PreviousFormSize = this.Size;
            Form1.PreviousFormLocation = this.Location;

            Form1 mainForm = new Form1();

            mainForm.StartPosition = FormStartPosition.Manual; // Location එක අතින් සෙට් කරන නිසා Manual කරන්න
            mainForm.Location = Form1.PreviousFormLocation;   // Form1 එකට කලින් Location එක දෙන්න
            mainForm.Size = Form1.PreviousFormSize;

            mainForm.Show();

            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            paymentForm paymentForm = new paymentForm();
            paymentForm.Show();
            this.Close();
        }

        private void doctor_lbl_Click(object sender, EventArgs e)
        {

        }

        private void appoinmentdetails_grpbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
