using System;
using System.Collections;
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
    public partial class paymentForm: Form
    {
        public paymentForm()
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

        private void ok_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void cardPaymentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cashPaymentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void paymentMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = paymentMethodComboBox.SelectedItem.ToString();

            cardDetailsGroupBox.Visible = (selectedRole == "Card");
            cashierDetailsGroupBox.Visible = (selectedRole == "Cash");

            //paymentMethodComboBox.Items.AddRange(new string[] { "Card", "Cash" });
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Step 01 - Capture input data
            string patientName = patientNameTextBox.Text.Trim();
            string serviceType = comboBox1.SelectedItem?.ToString() ?? "";
            string doctorName = comboBox2.SelectedItem?.ToString() ?? "";
            string paymentMethod = paymentMethodComboBox.SelectedItem?.ToString() ?? "";
            string cardNumber = cardNumberTextBox.Text.Trim();
            string expiryDate = cardExpiryTextBox.Text.Trim();
            string cvv = cardCVVTextBox.Text.Trim();
            string cashierId = cashierIdTextBox.Text.Trim();

            /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hms_assignment_111\hms_assignment\hms\hms\Payment.mdf;Integrated Security=True");

            // Step 03 - Write the SQL insert query (consider parameterized query for security)
            string query = "INSERT INTO PatientPayments (PatientName, ServiceType, Doctor, PaymentMethod, CardNumber, ExpiryDate, CVV, CashierID) " +
                           "VALUES (@PatientName, @ServiceType, @Doctor, @PaymentMethod, @CardNumber, @ExpiryDate, @CVV, @CashierID)";
            */

            // Step 02 - Validate fields
            if (string.IsNullOrEmpty(patientName) || string.IsNullOrEmpty(serviceType) ||
                string.IsNullOrEmpty(doctorName) || string.IsNullOrEmpty(paymentMethod) ||
                string.IsNullOrEmpty(cashierId))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate card details if payment method is not cash
            if (paymentMethod != "Cash")
            {
                if (string.IsNullOrEmpty(cardNumber) || string.IsNullOrEmpty(expiryDate) || string.IsNullOrEmpty(cvv))
                {
                    MessageBox.Show("Please enter all card details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Simple validations
                if (cardNumber.Length < 12 || cardNumber.Length > 19)
                {
                    MessageBox.Show("Invalid card number length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cvv.Length != 3)
                {
                    MessageBox.Show("CVV must be 3 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // If payment is by Cash, clear card data
                cardNumber = "";
                expiryDate = "";
                cvv = "";
            }

            // Step 03 - Connection string
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\Payment.mdf"";Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Payment (PatientName, ServiceType, Doctor, PaymentMethod, CardNumber, ExpiryDate, CVV, CashierID) " +
                               "VALUES (@PatientName, @ServiceType, @Doctor, @PaymentMethod, @CardNumber, @ExpiryDate, @CVV, @CashierID)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PatientName", patientName);
                    cmd.Parameters.AddWithValue("@ServiceType", serviceType);
                    cmd.Parameters.AddWithValue("@Doctor", doctorName);
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    cmd.Parameters.AddWithValue("@CardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                    cmd.Parameters.AddWithValue("@CVV", cvv);
                    cmd.Parameters.AddWithValue("@CashierID", cashierId);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Patient {patientName} registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
