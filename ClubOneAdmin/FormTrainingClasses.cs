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
    public partial class FormTrainingClasses : Form
    {
        public FormTrainingClasses()
        {
            InitializeComponent();
        }

        private void FormTrainingClasses_Load(object sender, EventArgs e)
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
            defaultRow[1] = "--All--";
            //insert the default row into the ds
            ds.Tables[0].Rows.InsertAt(defaultRow, 0);

            
            cmbFacilities.DataSource = ds.Tables[0].DefaultView;
            cmbFacilities.DisplayMember = "fName";
            cmbFacilities.ValueMember = "fID";

            sqlConnection.Close();

            //add a checkbox to first column
            dgvTrainingClass.Columns.Add(new DataGridViewCheckBoxColumn());
            dgvLoadTrainingClass();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFacilities_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFacilities_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvLoadTrainingClass();
        }

        private void dgvLoadTrainingClass()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd;

            //select all traning classes
            if ((int)cmbFacilities.SelectedValue == 0)
            {
                cmd = new SqlCommand("select tcID, className, fc.fName, tt.name, timeSlot, days, price " +
                    "from TrainingClass tc " +
                    "inner join Facility fc on tc.facilityID = fc.fID " +
                    "left join Tutor tt on tc.tutorID = tt.tID ", 
                sqlConnection);
            }
            else //select training classes corresponding to the selected facility
            {
                string fid = cmbFacilities.SelectedValue.ToString();

                cmd = new SqlCommand("select tcID, className, fc.fName, tt.name, timeSlot, days, price " +
                    "from TrainingClass tc " +
                    "inner join Facility fc on tc.facilityID = fc.fID " +
                    "left join Tutor tt on tc.tutorID = tt.tID " +
                    "where facilityID = @FID",
                    sqlConnection);
                cmd.Parameters.AddWithValue("@FID", fid);
            }

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dgvTrainingClass.DataSource = ds.Tables[0].DefaultView;
            
            dgvTrainingClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrainingClass.Columns[0].Width = 50;
            dgvTrainingClass.Columns[1].Width = 60;


            //set header text
            dgvTrainingClass.Columns[1].HeaderText = "ID";
            dgvTrainingClass.Columns[2].HeaderText = "CLASS";
            dgvTrainingClass.Columns[3].HeaderText = "LOCATION";
            dgvTrainingClass.Columns[4].HeaderText = "TUTOR";
            dgvTrainingClass.Columns[5].HeaderText = "TIMESLOT";
            dgvTrainingClass.Columns[6].HeaderText = "DAY";
            dgvTrainingClass.Columns[7].HeaderText = "PRICE";
            dgvTrainingClass.Columns[7].Width = 100;

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassesManageForm cmf = new ClassesManageForm();
            cmf.action = "Add";
            if(cmf.ShowDialog() == DialogResult.OK)
            {
                dgvLoadTrainingClass();
            }
        }

        private string classID = "0", className, facility, tutor, timeSlot, day, price;

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string message = "Are You Sure to Remove Selected Training Class?";
            string caption = "Remove Training Class";
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
                for (int i = 0; i < dgvTrainingClass.Rows.Count; i++)
                {
                    sqlCommand = new SqlCommand("delete from TrainingClass where tcID = @ID", sqlConnection);

                    if (dgvTrainingClass.Rows[i].Cells[0].Value != null && (bool)dgvTrainingClass.Rows[i].Cells[0].Value == true)
                    {
                        checkPoint = true;
                        sqlCommand.Parameters.AddWithValue("@ID", dgvTrainingClass.Rows[i].Cells[1].Value);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                
                sqlConnection.Close();
                if(!checkPoint)
                {
                    MessageBox.Show("No data is selected", "Operation Fail");
                    return;
                }

                
                dgvLoadTrainingClass();
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if(classID != "0")
            {
                ClassesManageForm cmf = new ClassesManageForm();
                cmf.action = "Edit";
                cmf.classID = classID;
                cmf.className = className;
                cmf.facility = facility;
                cmf.tutor = tutor;
                cmf.timeslot = timeSlot;
                cmf.day = day;
                cmf.price = price;

                if (cmf.ShowDialog() == DialogResult.OK)
                {
                    dgvLoadTrainingClass();
                }
            }
            else
            {
                MessageBox.Show("No data is selected", "Operation Fail");
            }
                
            
        }

        private void dgvTrainingClass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index_row = e.RowIndex;

            classID = dgvTrainingClass.Rows[index_row].Cells[1].Value.ToString();
            className = dgvTrainingClass.Rows[index_row].Cells[2].Value.ToString();
            facility = dgvTrainingClass.Rows[index_row].Cells[3].Value.ToString();
            tutor = dgvTrainingClass.Rows[index_row].Cells[4].Value.ToString();
            timeSlot = dgvTrainingClass.Rows[index_row].Cells[5].Value.ToString();
            day = dgvTrainingClass.Rows[index_row].Cells[6].Value.ToString();
            price = dgvTrainingClass.Rows[index_row].Cells[7].Value.ToString();
            
        }
    }
}
