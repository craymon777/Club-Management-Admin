using FontAwesome.Sharp;
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
    public partial class FormBookings : Form
    {
        //check whether which bookings are selected 
        //0 for Facility 
        //1 for Training Class
        private int selection = 0;

        private IconButton currentButton;

        public FormBookings()
        {
            InitializeComponent();
        }

        private void FormBookings_Load(object sender, EventArgs e)
        {
            loadStatus();

            //add a checkbox to first column
            dgvBookings.Columns.Add(new DataGridViewCheckBoxColumn());

            ActivateButton(btnBookFacility, Color.FromArgb(77, 184, 255));
            selection = 0;
            FacilityBookingLoad();

        }

        private void ActivateButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DeAvtivateButton();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.ForeColor = color;
                currentButton.IconColor = color;

                //panel
                pnlSelectedNav.Width = currentButton.Width;
                pnlSelectedNav.Location = new Point(currentButton.Location.X, 74);
                pnlSelectedNav.Visible = true;

            }
        }

        private void DeAvtivateButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.FromArgb(255, 255, 255);
                currentButton.IconColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void loadStatus()
        {
            cmbStatus.DisplayMember = "Text";
            cmbStatus.ValueMember = "Value";

            var items = new[] {
                new { Text = "--ALL STATUS--", Value = "0" },
                new { Text = "Pending", Value = "Pending" },
                new { Text = "Approved", Value = "Approved" },
                new { Text = "Declined", Value = "Declined" },
            };

            cmbStatus.DataSource = items;
        }

        private void TrainingClassBookingLoad()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd;

            

            if (cmbStatus.SelectedValue.ToString() == "0")
            {
                cmd = new SqlCommand("select btID, userID, tc.className, bt.timeSlot, bt.days, status " +
                    "from BookingTraining bt " +
                    "left join TrainingClass tc on bt.classID = tc.tcID ", sqlConnection);
            }
            else
            {
                string status = cmbStatus.SelectedValue.ToString();

                cmd = new SqlCommand("select btID, userID, tc.className, bt.timeSlot, bt.days, status " +
                    "from BookingTraining bt " +
                    "left join TrainingClass tc on bt.classID = tc.tcID " +
                    "where status = @STAT",
                    sqlConnection);
                cmd.Parameters.AddWithValue("@STAT", status);
            }

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgvBookings.DataSource = ds.Tables[0].DefaultView;

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.Columns[0].Width = 60;
            dgvBookings.Columns[1].Width = 60;
            dgvBookings.Columns[2].Width = 80;


            //set header text
            dgvBookings.Columns[1].HeaderText = "ID";
            dgvBookings.Columns[2].HeaderText = "UserID";
            dgvBookings.Columns[3].HeaderText = "CLASS";
            dgvBookings.Columns[4].HeaderText = "TIMESLOT";
            dgvBookings.Columns[5].HeaderText = "DAY";
            dgvBookings.Columns[6].HeaderText = "STATUS";
        }

        private void FacilityBookingLoad()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd;



            if (cmbStatus.SelectedValue.ToString() == "0")
            {
                cmd = new SqlCommand("select bfID, userID, fc.fName, timeSlot, days, status " +
                    "from BookingFacility bf " +
                    "left join Facility fc on bf.facilityID = fc.fID ", sqlConnection);
            }
            else
            {
                string status = cmbStatus.SelectedValue.ToString();

                cmd = new SqlCommand("select bfID, userID, fc.fName, timeSlot, days, status " +
                    "from BookingFacility bf " +
                    "left join Facility fc on bf.facilityID = fc.fID " +
                    "where status = @STAT",
                    sqlConnection);
                cmd.Parameters.AddWithValue("@STAT", status);
            }

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgvBookings.DataSource = ds.Tables[0].DefaultView;

            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.Columns[0].Width = 60;
            dgvBookings.Columns[1].Width = 60;
            dgvBookings.Columns[2].Width = 80;


            //set header text
            dgvBookings.Columns[1].HeaderText = "ID";
            dgvBookings.Columns[2].HeaderText = "UserID";
            dgvBookings.Columns[3].HeaderText = "FACILITY";
            dgvBookings.Columns[4].HeaderText = "TIMESLOT";
            dgvBookings.Columns[5].HeaderText = "DAY";
            dgvBookings.Columns[6].HeaderText = "STATUS";
        }

        private void btnBookFacility_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(77, 184, 255));

            selection = 0;
            FacilityBookingLoad();

        }

        private void btnBookClass_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(77, 184, 255));
            
            selection = 1;
            TrainingClassBookingLoad();
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbStatus.SelectedValue.Equals("Pending"))
            {
                btnApprove.Enabled = true;
                btnDecline.Enabled = true;
            }
            else
            {
                btnApprove.Enabled = false;
                btnDecline.Enabled = false;
            }

            if (selection == 1)
                TrainingClassBookingLoad();
            else
                FacilityBookingLoad();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string status = "Approved";
            
            string message = "Are You Sure to Approve Booking?";
            string caption = "Bookings";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (selection == 0) //approve Facility Booking
                {
                    updateFacilityBookingStatus(status);
                    FacilityBookingLoad();
                }
                else //approve Training Class Booking
                {
                    updateTrainingClassBookingStatus(status);
                    TrainingClassBookingLoad();
                }
                
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            string status = "Declined";

            string message = "Are You Sure to Decline Booking?";
            string caption = "Bookings";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (selection == 0) //approve Facility Booking
                {
                    updateFacilityBookingStatus(status);
                    FacilityBookingLoad();
                }
                else //approve Training Class Booking
                {
                    updateTrainingClassBookingStatus(status);
                    TrainingClassBookingLoad();
                }

            }
        }

        private void updateFacilityBookingStatus(string status)
        {
            SqlConnection sqlConnection =
            new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
            "Database=clubone;");
            sqlConnection.Open();

            SqlCommand sqlCommand;

            bool checkPoint = false;
            for (int i = 0; i < dgvBookings.Rows.Count; i++)
            {
                sqlCommand = new SqlCommand("update BookingFacility set status = @S " +
                "where bfID = @ID", sqlConnection);

                if (dgvBookings.Rows[i].Cells[0].Value != null && (bool)dgvBookings.Rows[i].Cells[0].Value == true)
                {
                    checkPoint = true;
                    sqlCommand.Parameters.AddWithValue("@S", status);
                    sqlCommand.Parameters.AddWithValue("@ID", dgvBookings.Rows[i].Cells[1].Value);
                    sqlCommand.ExecuteNonQuery();
                }

            }

            if (!checkPoint)
            {
                MessageBox.Show("No data is selected", "Operation Fail");
            }
            sqlConnection.Close();
            
        }

        private void updateTrainingClassBookingStatus(string status)
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand sqlCommand;

            bool checkPoint = false;
            for (int i = 0; i < dgvBookings.Rows.Count; i++)
            {
                sqlCommand = new SqlCommand("update BookingTraining set status = @S " +
                "where btID = @ID", sqlConnection);

                if (dgvBookings.Rows[i].Cells[0].Value != null && (bool)dgvBookings.Rows[i].Cells[0].Value == true)
                {
                    checkPoint = true;
                    sqlCommand.Parameters.AddWithValue("@S", status);
                    sqlCommand.Parameters.AddWithValue("@ID", dgvBookings.Rows[i].Cells[1].Value);
                    sqlCommand.ExecuteNonQuery();
                }
            }

            if (!checkPoint)
            {
                MessageBox.Show("No data is selected", "Operation Fail");
            }
            sqlConnection.Close();
        }

        
    }
}
