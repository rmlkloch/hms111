using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hms
{
    public partial class staffsignin : Form
    {
        private string userType;

        // Constructor with userType parameter
        public staffsignin(string userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        // Default constructor
        public staffsignin()
        {
            InitializeComponent();
        }

        // Static class to hold application settings like default form size and location
        public static class AppSettings
        {
            public static System.Drawing.Size DefaultFormSize;
            public static System.Drawing.Point DefaultFormLocation;

            static AppSettings()
            {
                // Get the size of the primary screen's working area (excluding taskbar)
                DefaultFormSize = Screen.PrimaryScreen.WorkingArea.Size;

                // Set the form to the top-left corner of the screen
                DefaultFormLocation = new System.Drawing.Point(0, 0);
            }
        }

        // Event handler for when the staffsignin form loads
        private void staffsignin_Load(object sender, EventArgs e)
        {
            // Set the form's size and location based on AppSettings
            this.Size = AppSettings.DefaultFormSize;
            this.Location = AppSettings.DefaultFormLocation;
        }

        // Event handler for label8 click (currently empty)
        private void label8_Click(object sender, EventArgs e)
        {
            // This event handler is currently empty and does nothing.
        }

        // Event handler for when the selected role in cmbrole changes
        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbrole.SelectedItem.ToString();

            // Show/hide group boxes and labels based on the selected role
            doctorgb.Visible = (selectedRole == "Doctor");
            nursegb.Visible = (selectedRole == "Nurse");
            PBD.Visible = (selectedRole == "Doctor"); // Assuming PBD is related to Doctor
            PBN.Visible = (selectedRole == "Nurse"); // Assuming PBN is related to Nurse
            lbrole.Visible = !((selectedRole == "Doctor") || (selectedRole == "Nurse")); // Show if not Doctor or Nurse
        }

        // Event handler for the back button click
        private void back_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form12 (main form)
            Form12 mainForm = new Form12();
            // Show the main form
            mainForm.Show();
            // Close the current form
            this.Close();
        }

        // Event handler for the browse button click (for selecting an image)
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set filter for image files
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the picture box
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                // Set the PictureBoxSizeMode to Zoom to fit the image
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // Event handler for the clear button click (to clear the image)
        private void clear_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                // Dispose of the current image to release resources
                pictureBox.Image.Dispose();
                // Set the image to null
                pictureBox.Image = null;
            }
        }

        // Event handler for tabPage1 click (currently empty)
        private void tabPage1_Click(object sender, EventArgs e)
        {
            // This event handler is currently empty and does nothing.
        }

        // Event handler for the save button click (to save staff registration data)
        private void save_Click(object sender, EventArgs e)
        {
            // Step 01: Create the connection string to the SQL Server LocalDB database
            // NOTE: The database path is hardcoded. In a production environment, this should be configurable.
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\user\Documents\# C #\hms111\hms\hms\StaffReg DB.mdf"";Integrated Security=True");

            // Step 02: Read input values from form controls
            string id = textBox1.Text.Trim();
            string name = txtname.Text.Trim();
            string role = cmbrole.Text;
            string department = cmbDepartment.Text;
            string phone = txtphone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gender = cmbgender.Text;
            DateTime DOB = dob_picker.Value.Date;
            DateTime joinDate = joindate_picker.Value.Date;
            string Medical_Licence_No = mln.Text.Trim();
            string Specilization = cmbspecialization.Text;
            string nurse_Id = nid.Text.Trim();
            string ward = cmbward.Text;
            string experiance = txtexperience.Text.Trim();

            // Step 03: Validate the input fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(department) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate phone number to be numeric
            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 04: Handle image (convert to byte array) - This section is commented out in the original code.
            /*
            byte[] imageData;
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */

            try
            {
                // Step 05: Define the SQL INSERT query with parameters to prevent SQL injection
                string query = "INSERT INTO StaffReg (name, role, department, phone, email, gender, DOB, joinDate, Medical_Licence_No, Specilization, nurse_Id, ward, experiance) " +
                               "VALUES (@name, @role, @department, @phone, @email, @gender, @DOB, @joinDate, @Medical_Licence_No, @Specilization, @nurse_Id, @ward, @experiance)";

                // Step 06: Prepare SQL command with the query and connection
                SqlCommand cmd1 = new SqlCommand(query, con1);

                // Step 07: Bind values to the parameters in the SQL command
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@role", role);
                cmd1.Parameters.AddWithValue("@department", department);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@gender", gender);
                cmd1.Parameters.AddWithValue("@DOB", DOB);
                cmd1.Parameters.AddWithValue("@joinDate", joinDate);
                cmd1.Parameters.AddWithValue("@Medical_Licence_No", Medical_Licence_No);
                cmd1.Parameters.AddWithValue("@Specilization", Specilization);
                cmd1.Parameters.AddWithValue("@nurse_Id", nurse_Id);
                cmd1.Parameters.AddWithValue("@ward", ward);
                cmd1.Parameters.AddWithValue("@experiance", experiance);
                // cmd1.Parameters.AddWithValue("@image", imageData); // This line is commented out as image handling was commented out

                // Step 08: Execute the command
                con1.Open(); // Open the database connection
                cmd1.ExecuteNonQuery(); // Execute the INSERT command
                MessageBox.Show($"Registered {name} successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Handle SQL-specific errors
                MessageBox.Show("SQL Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Step 09: Always close the connection in a finally block to ensure it's closed even if an error occurs
                if (con1.State == ConnectionState.Open)
                    con1.Close();
            }
        }

        // Event handler for label15 click (currently empty)
        private void label15_Click(object sender, EventArgs e)
        {
            // This event handler is currently empty and does nothing.
        }

        // Event handler for txtname text changed (currently empty)
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            // This event handler is currently empty and does nothing.
        }

        // Event handler for pictureBox click (currently empty)
        private void pictureBox_Click(object sender, EventArgs e)
        {
            // This event handler is currently empty and does nothing.
        }
    }
}
