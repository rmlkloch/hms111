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
    public partial class DiagnosisForm: Form
    {
        public DiagnosisForm()
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

        private void addmedicine_button_Click(object sender, EventArgs e)
        {
            mwdicines_datagrideview.Rows.Add(); // Add a new row to the DataGridView
        }

        private void removemedicine_btn_Click(object sender, EventArgs e)
        {
            if (mwdicines_datagrideview.SelectedRows.Count > 0)
            {
                mwdicines_datagrideview.Rows.RemoveAt(mwdicines_datagrideview.SelectedRows[0].Index); // Remove the selected row
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Diagnosis saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Step 1 - Collect data
            string patientId = patientid_textbox.Text.Trim();
            string patientName = patientname_textbox.Text.Trim();
            DateTime visitDate = datetimepicker.Value.Date;
            string symptoms = symptoms_richtextbox.Text.Trim();
            string diagnosis = diagnosis_richtextbox.Text.Trim();
            string treatmentPlan = treatmentplan_richtextbox.Text.Trim();

            // Step 2 - Validate
            if (string.IsNullOrEmpty(patientId) || string.IsNullOrEmpty(patientName))
            {
                MessageBox.Show("Patient ID and Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 3 - Connection string
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\Dignosis DB.mdf"";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Step 4 - Insert into PatientRecords
                    string query1 = @"INSERT INTO Dignosis (PatientID, PatientName, VisitDate, Symptoms, Diagnosis, TreatmentPlan) 
                              VALUES 
                              (@PatientID, @PatientName, @VisitDate, @Symptoms, @Diagnosis, @TreatmentPlan);
                              SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd1 = new SqlCommand(query1, con, transaction);
                    cmd1.Parameters.AddWithValue("@PatientID", patientId);
                    cmd1.Parameters.AddWithValue("@PatientName", patientName);
                    cmd1.Parameters.AddWithValue("@VisitDate", visitDate);
                    cmd1.Parameters.AddWithValue("@Symptoms", symptoms);
                    cmd1.Parameters.AddWithValue("@Diagnosis", diagnosis);
                    cmd1.Parameters.AddWithValue("@TreatmentPlan", treatmentPlan);

                    // Get inserted RecordID
                    int recordId = Convert.ToInt32(cmd1.ExecuteScalar());

                    // Step 5 - Insert medicines
                    foreach (DataGridViewRow row in mwdicines_datagrideview.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string medName = row.Cells["MedicineName"].Value?.ToString();
                        string dosage = row.Cells["Dosage"].Value?.ToString();
                        string freq = row.Cells["Frequency"].Value?.ToString();
                        string duration = row.Cells["Duration"].Value?.ToString();

                        if (!string.IsNullOrWhiteSpace(medName))
                        {
                            SqlCommand cmd2 = new SqlCommand(
                                @"INSERT INTO PrescribedMedicines 
                          (RecordID, MedicineName, Dosage, Frequency, Duration) 
                          VALUES (@RecordID, @MedicineName, @Dosage, @Frequency, @Duration)", con, transaction);

                            cmd2.Parameters.AddWithValue("@RecordID", recordId);
                            cmd2.Parameters.AddWithValue("@MedicineName", medName);
                            cmd2.Parameters.AddWithValue("@Dosage", dosage ?? "");
                            cmd2.Parameters.AddWithValue("@Frequency", freq ?? "");
                            cmd2.Parameters.AddWithValue("@Duration", duration ?? "");

                            cmd2.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Record saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error saving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void back_Click(object sender, EventArgs e)
        {
            
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void treatmentplan_richtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }
    }
}
