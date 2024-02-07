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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=NOORY;Initial Catalog=Student;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboxusernme.Clear();
            textboxpassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textboxusernme.Text;
            string password = textboxpassword.Text;

            if (username == "Admin" && password == "Skills@123")
            {
                this.Hide();
                Registration_Form registration_Form = new Registration_Form();
                registration_Form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please check username and password and try again.", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult exitConfirmation = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitConfirmation == DialogResult.Yes)
            {
                CloseApplication();
            }

            void CloseApplication()
            {
                Application.Exit();
            }

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
