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
    public partial class MainForm : Form
    {
        public MainForm(string name ,int id)
        {
            InitializeComponent();
            label1.Text = name.ToUpper();
            label1.Tag = id;

        }

        public void BackTo_SignIn()
        {
            string message = "Are you sure ?";
            string caption = "LOG OUT";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SignInForm signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
        }

        public void GetSqlData()
        {
            using (SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select CT.ID, CT.NAME, CT.SURNAME, CT.COMPANY, CT.COUNTRY_CODE, CT.PREFIX, CT.NUMBER " +
                    "from CONTACTS CT WHERE INSERT_USER = '" + label1.Tag + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable datatable = new DataTable();

                datatable.Load(dr);

                dataGridView1.DataSource = datatable;
            }
        }

        private void CloseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) 
        {this.Close();}

        private void MainForm_Load(object sender, EventArgs e){ GetSqlData();}

        #region LogOut
        private void logOutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackTo_SignIn();
        }

        private void pictureLogOut_Click(object sender, EventArgs e)
        {
            BackTo_SignIn();
        }
        #endregion

        #region InsertButton
        private void insertLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddForm addForm = new AddForm(label1.Text, Convert.ToInt16(label1.Tag));
            addForm.Show();
            this.Hide();
        }
        #endregion

        #region UpdateButton
        private void updateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataGridViewRow Row = dataGridView1.CurrentRow;
            UpdateForm updateForm = new UpdateForm(label1.Text, Convert.ToInt16(label1.Tag),Row);
            updateForm.Show();
            this.Hide();
            
        }
        #endregion

        #region DeleteButton
        private void deleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DALC.GetConnectionString()))
            {
                #region Connection
                con.Open();
                DataGridViewRow Row = dataGridView1.CurrentRow;
                SqlCommand cmd = new SqlCommand(" DELETE  FROM CONTACTS WHERE" +
                    " ID = '"+ Row.Cells["ID"].Value.ToString() + "' ", con);
                #endregion

                #region Message 
                string message = "Are you sure ?";
                string caption = "Delete Contact";
                var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                #endregion

                #region Execute
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        GetSqlData();

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }
                    
                }
                #endregion

            }
        }
        #endregion
    }
}
