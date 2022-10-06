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

namespace contact_manager
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
                {
                    con.Open();

                    int id = 0;

                    string username = textBox1.Text;
                    string password = textBox2.Text;

                    SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE USERNAME ='" + username + "' AND PASSWORD = '" + password + "' ", con);



                    id = Convert.ToInt32(cmd.ExecuteScalar());

                    if (id == 0)
                    {
                        MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK);
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"Welcome {username}", "Success", MessageBoxButtons.OK);

                        MainForm mainForm = new MainForm(username, id);

                        mainForm.Show();
                        this.Hide();

                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                textBox1.Focus();
                return;
            }
        }

        private void SignIn_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void ResgistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();

        }

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
