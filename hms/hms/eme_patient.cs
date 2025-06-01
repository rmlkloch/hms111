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
    public partial class eme_patient : Form
    {
        public eme_patient()
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;
            string nic = textnic.Text;
            string sex = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "Other";
            string arrival = txtArrival.Text;
            string broughtBy = txtBroughtBy.Text;
            string conditions = txtConditions.Text;
            string temp = txtTemp.Text;
            string pulse = txtPulse.Text;
            string bp = txtBP.Text;
            string resp = txtResp.Text;
            string spo2 = txtSpO2.Text;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user\\Documents\\# C #\\hms111\\hms\\hms\\eme_patient.mdf\";Integrated Security=True";

            string query = "INSERT INTO eme_patient ([name], [age], [arival time], [known conditions], [tem], [pulse], [BP], [respi], [Spo2], [sex], [brought by]) " +
                           "VALUES (@name, @age, @arrival, @conditions, @temp, @pulse, @bp, @resp, @spo2, @sex, @broughtBy)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(age));
                cmd.Parameters.AddWithValue("@arrival", arrival);
                cmd.Parameters.AddWithValue("@conditions", conditions);
                cmd.Parameters.AddWithValue("@temp", Convert.ToDouble(temp));
                cmd.Parameters.AddWithValue("@pulse", Convert.ToInt32(pulse));
                cmd.Parameters.AddWithValue("@bp", bp);
                cmd.Parameters.AddWithValue("@resp", Convert.ToInt32(resp));
                cmd.Parameters.AddWithValue("@spo2", Convert.ToInt32(spo2));
                cmd.Parameters.AddWithValue("@sex", sex);
                cmd.Parameters.AddWithValue("@broughtBy", broughtBy);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient data submitted successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }

        private void eme_patient_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form12 mainForm = new Form12();
            mainForm.Show();
            this.Close();
        }
    }
}
