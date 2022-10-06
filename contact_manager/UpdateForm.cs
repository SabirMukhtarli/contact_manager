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
    public partial class UpdateForm : Form
    {
        public UpdateForm(string username, int id, DataGridViewRow Row)
        {
            InitializeComponent();

            #region AddInf 
            label8.Text = username;
            label8.Tag = id;
            textBox1.Tag = Row.Cells["ID"].Value.ToString();

            textBox1.Text = Row.Cells["NAME"].Value.ToString();
            textBox2.Text = Row.Cells["SURNAME"].Value.ToString();
            textBox3.Text = Row.Cells["COMPANY"].Value.ToString();
            textBox4.Text = Row.Cells["COUNTRY_CODE"].Value.ToString();
            textBox5.Text = Row.Cells["PREFIX"].Value.ToString();
            textBox7.Text = Row.Cells["NUMBER"].Value.ToString();
            #endregion

        }

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

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

        #region UpdateButton
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE CONTACTS SET" +
                    " NAME = @name, SURNAME =@surname,COMPANY = @company, " +
                    "COUNTRY_CODE = @countrycode, PREFIX = @prefix, NUMBER = @number WHERE ID ='"+ textBox1.Tag + "'",con);

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@surname", textBox2.Text);
                cmd.Parameters.AddWithValue("@company", textBox3.Text);
                cmd.Parameters.AddWithValue("@countrycode", textBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@prefix", textBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@number", textBox7.Text.ToString());


                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success");

                    MainForm mainForm = new MainForm(label8.Text, Convert.ToInt16(label8.Tag));
                    mainForm.Show();
                    this.Hide();
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
