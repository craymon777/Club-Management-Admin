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

namespace ClubOneAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Admin where username = @UN and " +
                "password = @PWD", sqlConnection);
            cmd.Parameters.AddWithValue("@UN", username);
            cmd.Parameters.AddWithValue("@PWD", password);


            IDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.username = username;
                mf.uid = ds.Tables[0].Rows[0]["aID"].ToString();

                mf.Show();
            }
            else
            {
                lbFail.Text = "Fail to Log in ! Incorrect username or password !";   
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(71, 117, 209);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(31, 31, 46);
        }

        private void btnMinimise_MouseEnter(object sender, EventArgs e)
        {
            btnMinimise.BackColor = Color.FromArgb(71, 117, 209);
        }

        private void btnMinimise_MouseLeave(object sender, EventArgs e)
        {
            btnMinimise.BackColor = Color.FromArgb(31, 31, 46);
        }
    }
}
