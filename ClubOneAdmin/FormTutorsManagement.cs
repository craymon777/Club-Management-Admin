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
    public partial class FormTutorsManagement : Form
    {
        

        public FormTutorsManagement()
        {
            InitializeComponent();
        }

        private void FormTutorsManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cluboneDataSet.Tutor' table. You can move, or remove it, as needed.
            this.tutorTableAdapter.Fill(this.cluboneDataSet.Tutor);
            
            //add a checkbox to first column
            grdviewTutor.Columns.Add(new DataGridViewCheckBoxColumn());
            gridView_LoadData();


        }

        private void gridView_LoadData()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Tutor", sqlConnection);

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            sqlConnection.Close();

            grdviewTutor.DataSource = ds.Tables[0].DefaultView;

            grdviewTutor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdviewTutor.Columns[0].Width = 60;
            grdviewTutor.Columns[1].Width = 60;

            //set header text
            grdviewTutor.Columns[1].HeaderText = "ID";
            grdviewTutor.Columns[2].HeaderText = "NAME";
            grdviewTutor.Columns[3].HeaderText = "AGE";
            grdviewTutor.Columns[4].HeaderText = "EMAIL";
            grdviewTutor.Columns[5].HeaderText = "PHONE";
            grdviewTutor.Columns[6].HeaderText = "EXPERIENCES";

            
        }

        private void grdviewTutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdviewTutor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            int index_row = e.RowIndex;

            tbID.Text = grdviewTutor.Rows[index_row].Cells[1].Value.ToString();
            tbName.Text = grdviewTutor.Rows[index_row].Cells[2].Value.ToString();
            tbAge.Text = grdviewTutor.Rows[index_row].Cells[3].Value.ToString();
            tbEmail.Text = grdviewTutor.Rows[index_row].Cells[4].Value.ToString();
            tbPhone.Text = grdviewTutor.Rows[index_row].Cells[5].Value.ToString();
            tbExp.Text = grdviewTutor.Rows[index_row].Cells[6].Value.ToString();

            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "")
            {
                string message;
                string caption;

                SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("update Tutor set name = @N, " +
                    "age = @A, email = @E, phone = @P, experience = @EXP where tID = @ID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@N", tbName.Text);
                sqlCommand.Parameters.AddWithValue("@A", tbAge.Text);
                sqlCommand.Parameters.AddWithValue("@E", tbEmail.Text);
                sqlCommand.Parameters.AddWithValue("@P", tbPhone.Text);
                sqlCommand.Parameters.AddWithValue("@EXP", tbExp.Text);
                sqlCommand.Parameters.AddWithValue("@ID", tbID.Text);

                int success = sqlCommand.ExecuteNonQuery();

                if (success != 0)
                {
                    message = "success";
                    caption = "Operation";
                    MessageBox.Show(message, caption);

                    this.DialogResult = DialogResult.OK;
                }

                sqlConnection.Close();

                gridView_LoadData();
            }
            else
            {
                MessageBox.Show("No data is selected", "Operation Fail");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Tutor " +
                "(name, age, email, phone, experience) values (@N, @A, @E, @P, @EXP)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@N", tbName.Text);
            sqlCommand.Parameters.AddWithValue("@A", tbAge.Text);
            sqlCommand.Parameters.AddWithValue("@E", tbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@P", tbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@EXP", tbExp.Text);
            sqlCommand.Parameters.AddWithValue("@ID", tbID.Text);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            gridView_LoadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure to Remove Selected Tutor Information?";
            string caption = "Remove Tutor Information";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
                sqlConnection.Open();

                SqlCommand sqlCommand;

                bool checkPoint = false;

                for (int i = 0; i < grdviewTutor.Rows.Count; i++)
                {
                    sqlCommand = new SqlCommand("delete from Tutor where tID = @ID", sqlConnection);

                    if (grdviewTutor.Rows[i].Cells[0].Value != null && (bool)grdviewTutor.Rows[i].Cells[0].Value == true)
                    {
                        checkPoint = true;
                        sqlCommand.Parameters.AddWithValue("@ID", grdviewTutor.Rows[i].Cells[1].Value);

                        int success = sqlCommand.ExecuteNonQuery();

                        if (success != 0)
                        {
                            message = "success";
                            caption = "Operation";
                            MessageBox.Show(message, caption);

                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }

                if (!checkPoint)
                {
                    MessageBox.Show("No data is selected", "Operation Fail");
                    return;
                }

                sqlConnection.Close();


                gridView_LoadData();
            }
        }
    }
}
