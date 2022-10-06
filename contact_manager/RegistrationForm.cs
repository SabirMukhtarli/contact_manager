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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        #region BactToSignIn
        private void ResgistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm registrationForm = new SignInForm();
            registrationForm.Show();
            this.Hide();
        }
        #endregion

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  this.Close();}

        #region SignUpButton
        private void button2_Click(object sender, EventArgs e)
        {
            string username, password, mail;
            username = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            mail = textBox3.Text.Trim();

            using (SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO USERS " +
                    "Values (@username,@password,@mail)", con);

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@mail", textBox3.Text);

                cmd.ExecuteNonQuery();
            }
            #endregion

        }
    }
}
