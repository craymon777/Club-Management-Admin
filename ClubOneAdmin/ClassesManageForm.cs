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
    public partial class ClassesManageForm : Form
    {
        public string action;

        public string classID, className, facility, tutor, timeslot, day, price; 

        public ClassesManageForm()
        {
           
           InitializeComponent();
           
        }

        private void ClassesManageForm_Load(object sender, EventArgs e)
        {
            this.Text = action;
            lbTitle.Text = action + " Class";


            loadFacility();
            loadTutor();
            loadDay();


            if (action.Equals("Add"))
            {
                //btnInsert.Visible = true;
                btnUpdate.Visible = false;
                btnReset.Visible = false;
            }
            else if (action.Equals("Edit"))
            {
                btnInsert.Visible = false;
                //btnUpdate.Visible = true;
                populateEditingData();
            }
            
        }

        private void loadFacility()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select fID, fName from Facility", sqlConnection);

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //create a row
            DataRow defaultRow = ds.Tables[0].NewRow();
            //insert the default value to the row
            defaultRow[0] = 0;
            defaultRow[1] = "--SELECT Facility--";
            //insert the default row into the ds
            ds.Tables[0].Rows.InsertAt(defaultRow, 0);


            cmbFacility.DataSource = ds.Tables[0].DefaultView;
            cmbFacility.DisplayMember = "fName";
            cmbFacility.ValueMember = "fID";

            sqlConnection.Close();
        }

        private void loadTutor()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select tID, name from Tutor", sqlConnection);

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            //create a row
            DataRow defaultRow = ds.Tables[0].NewRow();
            //insert the default value to the row
            defaultRow[0] = 0;
            defaultRow[1] = "--SELECT Tutor--";
            //insert the default row into the ds
            ds.Tables[0].Rows.InsertAt(defaultRow, 0);


            cmbTutor.DataSource = ds.Tables[0].DefaultView;
            cmbTutor.DisplayMember = "name";
            cmbTutor.ValueMember = "tID";

            sqlConnection.Close();
        }
        
        private void loadDay()
        {
            cmbDay.DisplayMember = "Text";
            cmbDay.ValueMember = "Value";

            var items = new[] {
                new { Text = "--SELECT Day--", Value = "0" },
                new { Text = "Sunday", Value = "Sunday" },
                new { Text = "Monday", Value = "Monday" },
                new { Text = "Tuesday", Value = "Tuesday" },
                new { Text = "Wednesday", Value = "Wednesday" },
                new { Text = "Thursday", Value = "Thursday" },
                new { Text = "Friday", Value = "Friday" },
                new { Text = "Saturday", Value = "Saturday" }
            };

            cmbDay.DataSource = items;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            populateEditingData();
        }

        private void ClassesManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void populateEditingData()
        {
            tbID.Text = classID;
            tbClass.Text = className;
            cmbFacility.SelectedIndex = cmbFacility.FindString(facility);
            cmbTutor.SelectedIndex = cmbTutor.FindString(tutor);
            tbTimeslot.Text = timeslot;
            cmbDay.SelectedIndex = cmbDay.FindString(day);
            numPrice.Value = Convert.ToInt32(price);
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message, title;

            if ((int)cmbFacility.SelectedValue == 0)
            {
                message = "Please select a facility";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }
            else if ((int)cmbTutor.SelectedValue == 0)
            {
                message = "Please select a Tutor";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }
            else if ((string)cmbDay.SelectedValue == "0")
            {
                message = "Please select a Day";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }

            if ((int)cmbFacility.SelectedValue != 0 && (int)cmbTutor.SelectedValue != 0 && (string)cmbDay.SelectedValue != "0")
            {
                SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("update TrainingClass " +
                    "set className = @C , facilityID = @FID, tutorID = @TID, timeSlot = @TS," +
                    " days = @D, price = @P " +
                    "where tcID = @ID", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@C", tbClass.Text);
                sqlCommand.Parameters.AddWithValue("@FID", cmbFacility.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@TID", cmbTutor.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@TS", tbTimeslot.Text);
                sqlCommand.Parameters.AddWithValue("@D", cmbDay.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@P", numPrice.Value);
                sqlCommand.Parameters.AddWithValue("@ID", tbID.Text);


                int success = sqlCommand.ExecuteNonQuery();

                if (success != 0)
                {
                    message = "success";
                    title = "Operation";
                    MessageBox.Show(message, title);

                    this.DialogResult = DialogResult.OK;
                }

                sqlConnection.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string message = "";
            string title = "";

            if ((int)cmbFacility.SelectedValue == 0)
            {
                message = "Please select a facility";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }
            else if ((int)cmbTutor.SelectedValue == 0)
            {
                message = "Please select a Tutor";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }
            else if ((string)cmbDay.SelectedValue == "0")
            {
                message = "Please select a Day";
                title = "Insert Fail";
                MessageBox.Show(message, title);
            }
            if ((int)cmbFacility.SelectedValue != 0 && (int)cmbTutor.SelectedValue != 0 && (string)cmbDay.SelectedValue != "0")
            {

                SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("insert into TrainingClass " +
                    "(className, facilityID, tutorID, timeSlot, days, price) " +
                    "values (@C, @FID, @TID, @TS, @D, @P)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@C", tbClass.Text);
                sqlCommand.Parameters.AddWithValue("@FID", cmbFacility.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@TID", cmbTutor.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@TS", tbTimeslot.Text);
                sqlCommand.Parameters.AddWithValue("@D", cmbDay.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@P", numPrice.Value);

                int success = sqlCommand.ExecuteNonQuery();

                if (success != 0)
                {
                    message = "success";
                    title = "Operation";
                    MessageBox.Show(message, title);

                    this.DialogResult = DialogResult.OK;
                }

                sqlConnection.Close();
            }
            
        }
    }
}
