using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Final_Project_Noory
{
    public partial class Registration_Form : Form
    {
        private void AutoRefreshComboBox()
        {
            try
            {
                con.Open();
                string query_select = "SELECT regno FROM [dbo].[Registration]";
                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                REgistrationCombobox.Items.Clear();
                REgistrationCombobox.Items.Add("New Register");
                while (reader.Read())
                {
                    REgistrationCombobox.Items.Add(reader["regno"].ToString());
                }
                REgistrationCombobox.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error refreshing registration numbers: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        SqlConnection con = new SqlConnection(@"Data Source=NOORY;Initial Catalog=Student;Integrated Security=True");

        public Registration_Form()
        {
            InitializeComponent();
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime dobValue = DateOfBirth.Value;

                string query_insert = "INSERT INTO [dbo].[Registration] VALUES (@FirstName, @LastName, @Dob, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentsName, @NIC, @ContactNumber)";
                using (SqlCommand cmnd = new SqlCommand(query_insert, con))
                {
                    cmnd.Parameters.AddWithValue("@FirstName", textboxfirstname.Text);
                    cmnd.Parameters.AddWithValue("@LastName", textboxlastname.Text);
                    cmnd.Parameters.AddWithValue("@Dob", dobValue);

                    string gender = rbmale.Checked ? "Male" : "Female";
                    cmnd.Parameters.AddWithValue("@Gender", gender);

                    cmnd.Parameters.AddWithValue("@Address", TextBoxAddress.Text);
                    cmnd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                    cmnd.Parameters.AddWithValue("@MobilePhone", int.Parse(TextBoxMobilePhone.Text));
                    cmnd.Parameters.AddWithValue("@HomePhone", int.Parse(TextBoxHomePhone.Text));
                    cmnd.Parameters.AddWithValue("@ParentsName", TextBoxParentsname.Text);
                    cmnd.Parameters.AddWithValue("@NIC", TextBoxNIC.Text);
                    cmnd.Parameters.AddWithValue("@ContactNumber", int.Parse(TextBoxCondactDetails.Text));

                    con.Open();
                    cmnd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Record Added Successfully!", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AutoRefreshComboBox();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Registration Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string no = REgistrationCombobox.Text;
            if (no != "New Register")
            {
                try
                {
                    string firstName = textboxfirstname.Text;
                    string lastName = textboxlastname.Text;
                    DateTime dobValue = DateOfBirth.Value;
                    string gender = rbmale.Checked ? "Male" : "Female";
                    string address = TextBoxAddress.Text;
                    string email = TextBoxEmail.Text;
                    int mobilePhone = int.Parse(TextBoxMobilePhone.Text);
                    int homePhone = int.Parse(TextBoxHomePhone.Text);
                    string parentsName = TextBoxParentsname.Text;
                    string NIC = TextBoxNIC.Text;
                    int contactNumber = int.Parse(TextBoxCondactDetails.Text);

                    string query_update = "UPDATE [dbo].[Registration] SET " +
                        "firstName = @FirstName, " +
                        "lastName = @LastName, " +
                        "dateOfBirth = @Dob, " +
                        "gender = @Gender, " +
                        "address = @Address, " +
                        "email = @Email, " +
                        "mobilePhone = @MobilePhone, " +
                        "homePhone = @HomePhone, " +
                        "parentName = @ParentsName, " +
                        "nic = @NIC, " +
                        "contactNo = @ContactNumber " +
                        "WHERE regno = @RegNo";

                    using (SqlCommand cmnd = new SqlCommand(query_update, con))
                    {
                        cmnd.Parameters.AddWithValue("@RegNo", no);
                        cmnd.Parameters.AddWithValue("@FirstName", firstName);
                        cmnd.Parameters.AddWithValue("@LastName", lastName);
                        cmnd.Parameters.AddWithValue("@Dob", dobValue);
                        cmnd.Parameters.AddWithValue("@Gender", gender);
                        cmnd.Parameters.AddWithValue("@Address", address);
                        cmnd.Parameters.AddWithValue("@Email", email);
                        cmnd.Parameters.AddWithValue("@MobilePhone", mobilePhone);
                        cmnd.Parameters.AddWithValue("@HomePhone", homePhone);
                        cmnd.Parameters.AddWithValue("@ParentsName", parentsName);
                        cmnd.Parameters.AddWithValue("@NIC", NIC);
                        cmnd.Parameters.AddWithValue("@ContactNumber", contactNumber);

                        con.Open();
                        cmnd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("Record updated Successfully!", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoRefreshComboBox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REgistrationCombobox.Text = "";
            textboxfirstname.Text = "";
            textboxlastname.Text = "";
            DateOfBirth.Format = DateTimePickerFormat.Custom;
            DateOfBirth.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            DateOfBirth.Text = thisDay.ToString();

            rbmale.Checked = false;
            rbfemale.Checked = false;

            TextBoxAddress.Text = "";
            TextBoxEmail.Text = "";
            TextBoxMobilePhone.Text = "";
            TextBoxHomePhone.Text = "";
            TextBoxParentsname.Text = "";
            TextBoxNIC.Text = "";
            TextBoxCondactDetails.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string no = REgistrationCombobox.Text;
            if (no !="New Register")
            {
                con.Open();
                string query_select = "SELECT * FROM [dbo].[Registration] WHERE regno=" + no;
                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataReader row = cmd.ExecuteReader();
                while(row.Read())
                {
                    textboxfirstname.Text = row[1].ToString();
                    textboxlastname.Text = row[2].ToString();
                    DateOfBirth.Format = DateTimePickerFormat.Custom;
                    DateOfBirth.CustomFormat = "yyyy/MM/dd";

                    string dateString = row[3].ToString();
                    DateTime dobDate;
                    if (DateTime.TryParse(dateString, out dobDate))
                    {
                        DateOfBirth.Value = dobDate;
                    }
                    if (row[4].ToString() == "Male")
                    {
                        rbmale.Checked = true;
                        rbfemale.Checked = false;
                    }
                    else
                    {
                        rbmale.Checked = false;
                        rbfemale.Checked = true;
                    }
                    TextBoxAddress.Text = row[5].ToString();
                    TextBoxEmail.Text = row[6].ToString();
                    TextBoxMobilePhone.Text = row[7].ToString();
                    TextBoxHomePhone.Text = row[8].ToString();
                    TextBoxParentsname.Text = row[9].ToString();
                    TextBoxNIC.Text = row[10].ToString();
                    TextBoxCondactDetails.Text = row[11].ToString();

                }
                con.Close();
                registerbtn.Enabled = false;
                updatebtn.Enabled = true;
                deltebtn.Enabled = true;
            }
            else
            {
                textboxfirstname.Text = "";
                textboxlastname.Text = "";
                DateOfBirth.Format = DateTimePickerFormat.Custom;
                DateOfBirth.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                DateOfBirth.Text = thisDay.ToString();

                rbmale.Checked = true;
                rbfemale.Checked = false;

                TextBoxAddress.Text = "";
                TextBoxEmail.Text = "";
                TextBoxMobilePhone.Text = "";
                TextBoxHomePhone.Text = "";
                TextBoxParentsname.Text = "";
                TextBoxNIC.Text = "";
                TextBoxCondactDetails.Text = "";
                {
                    registerbtn.Enabled = true;
                    updatebtn.Enabled = false;
                    deltebtn.Enabled = false;
                }
            }
        }

        private void logoutlinklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            loginform form1 = new loginform();
            form1.ShowDialog();
            this.Close();
            Close();
        }

        private void deltebtn_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Are you sure, Do you really want to Delete this Record....?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string no = REgistrationCombobox.Text;

                    string query_insert = "DELETE FROM [dbo].[Registration] WHERE regno =" + no + "";
                    con.Open();
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    cmnd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted successfully!", "Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AutoRefreshComboBox();
                }
                else if(result==DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void exitlinklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result== DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            { 
}
            try
        {
        con.Open();
        string query_select = "SELECT regno FROM [dbo].[Registration]";
        SqlCommand cmd = new SqlCommand(query_select, con);
        SqlDataReader reader = cmd.ExecuteReader();
        REgistrationCombobox.Items.Clear();
        REgistrationCombobox.Items.Add("New Register");
        while (reader.Read())
        {
            REgistrationCombobox.Items.Add(reader["regno"].ToString());
        }
        REgistrationCombobox.SelectedIndex = 0;
        }
        catch (SqlException ex)
        {
        MessageBox.Show("Error loading registration numbers: " + ex.Message);
        }
        finally
        {
        con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
