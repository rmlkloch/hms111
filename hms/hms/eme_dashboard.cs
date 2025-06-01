using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace hms
{
    public partial class eme_dashboard : Form
    {
        public eme_dashboard()
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


        private void button1_Click(object sender, EventArgs e)
        {
            eme_patient emepatient = new eme_patient();
            emepatient.Show();
            this.Hide();
        }

        private void eme_dashboard_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
            timerClock.Start(); // start the live clock
            LoadPatientVitals();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void LoadPatientVitals()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\eme_patient.mdf"";Integrated Security=True";

            string query = @"SELECT 
                        [arival time],
                        [name], 
                        [sex], 
                        [known conditions], 
                        [age], 
                        [tem], 
                        [pulse], 
                        [BP], 
                        [respi], 
                        [Spo2]
                    FROM eme_patient";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridVieweme.DataSource = dt;

                    // Color coding logic
                    foreach (DataGridViewRow row in dataGridVieweme.Rows)
                    {
                        if (row.IsNewRow) continue;

                        try
                        {
                            double temp = Convert.ToDouble(row.Cells["tem"].Value);
                            if (temp < 36.5 || temp > 37.5)
                                row.Cells["tem"].Style.BackColor = Color.OrangeRed;
                            else
                                row.Cells["tem"].Style.BackColor = Color.LightGreen;

                            int pulse = Convert.ToInt32(row.Cells["pulse"].Value);
                            if (pulse < 60 || pulse > 100)
                                row.Cells["pulse"].Style.BackColor = Color.OrangeRed;
                            else
                                row.Cells["pulse"].Style.BackColor = Color.LightGreen;

                            string bp = row.Cells["BP"].Value.ToString();
                            if (!bp.Contains("120") || !bp.Contains("80"))
                                row.Cells["BP"].Style.BackColor = Color.OrangeRed;
                            else
                                row.Cells["BP"].Style.BackColor = Color.LightGreen;

                            int resp = Convert.ToInt32(row.Cells["respi"].Value);
                            if (resp < 12 || resp > 20)
                                row.Cells["respi"].Style.BackColor = Color.OrangeRed;
                            else
                                row.Cells["respi"].Style.BackColor = Color.LightGreen;

                            int spo2 = Convert.ToInt32(row.Cells["Spo2"].Value);
                            if (spo2 < 95)
                                row.Cells["Spo2"].Style.BackColor = Color.OrangeRed;
                            else
                                row.Cells["Spo2"].Style.BackColor = Color.LightGreen;
                        }
                        catch
                        {
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient data: " + ex.Message);
                }

                //column headers
                dataGridVieweme.Columns["arival time"].HeaderText = "Arrival Time";
                dataGridVieweme.Columns["name"].HeaderText = "Name";
                dataGridVieweme.Columns["sex"].HeaderText = "Gender";
                dataGridVieweme.Columns["known conditions"].HeaderText = "Conditions";
                dataGridVieweme.Columns["tem"].HeaderText = "Temperature (°C)";
                dataGridVieweme.Columns["pulse"].HeaderText = "Pulse (bpm)";
                dataGridVieweme.Columns["BP"].HeaderText = "Blood Pressure";
                dataGridVieweme.Columns["respi"].HeaderText = "Respiratory Rate";
                dataGridVieweme.Columns["Spo2"].HeaderText = "SpO₂ (%)";

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
