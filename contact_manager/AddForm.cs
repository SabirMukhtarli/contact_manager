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
    public partial class AddForm : Form
    {
        public AddForm(string username, int id)
        {
            InitializeComponent();
            label8.Text = username;
            label8.Tag = id;

        }

       

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { this.Close(); }

        #region CancelButton
        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Are you sure ?";
            string caption = "Cancel";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MainForm mainForm = new MainForm(label8.Text, Convert.ToInt16(label8.Tag));
                mainForm.Show();
                this.Hide();
                
            }
        }
        #endregion

        #region AddButton
        private void button2_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO CONTACTS " +
                "VALUES (@name,@surname,@company,@countrycode,@prefix,@number,@insert_user)", con);

                cmd.Parameters.AddWithValue("@name",textBox1.Text);
                cmd.Parameters.AddWithValue("@surname", textBox2.Text);
                cmd.Parameters.AddWithValue("@company", textBox3.Text);
                cmd.Parameters.AddWithValue("@countrycode", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@prefix", textBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@number", textBox7.Text.ToString());
                cmd.Parameters.AddWithValue("@insert_user", label8.Tag.ToString());

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success");

                    string message = "Are you want to add more ?";
                    string caption = "Add more";
                    var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainForm mainForm = new MainForm(label8.Text, Convert.ToInt16(label8.Tag));
                        mainForm.Show();
                        this.Hide();

                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }

            }

        }

        #endregion


    }
}