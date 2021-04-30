using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubOneAdmin
{
    public partial class FacilityManagementForm : Form
    {
        public string action;
        public string fID, facility, availability, capacity;
        public Image image;
        

        public FacilityManagementForm()
        {
            InitializeComponent();
            
        }

        private void FacilityManagementForm_Load(object sender, EventArgs e)
        {
            //set Form title
            lbTitle.Text = action + " Facility";

            picboxImage.AllowDrop = true;
            
            loadAvailability();
            
            if(action.Equals("Edit"))
            {
                btnInsert.Visible = false;
                populateEditingData();
            }
            else if (action.Equals("Add"))
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
 
        }

        private void populateEditingData()
        {
            tbID.Text = fID;
            tbFacility.Text = facility;
            cmbAvailability.SelectedValue = availability;
            numpadCapacity.Value = Convert.ToInt32(capacity);
            picboxImage.Image = image;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message, title;
            byte[] image = ConvertImageToBytes(picboxImage.Image);

            SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("update Facility " +
                "set fName = @FN , availability = @A, capacity = @C, image=@IMG " +
                "where fID = @ID", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@FN", tbFacility.Text);
            sqlCommand.Parameters.AddWithValue("@A", cmbAvailability.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@C", numpadCapacity.Value);
            sqlCommand.Parameters.AddWithValue("@IMG", image);
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

        

        private void lbClassID_Click(object sender, EventArgs e)
        {

        }

        private void picboxImage_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);

            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    picboxImage.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void picboxImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string message, title;
            byte[] image = ConvertImageToBytes(picboxImage.Image);

            SqlConnection sqlConnection =
                    new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                    "Database=clubone;");
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("insert into Facility " +
                "(fName, availability, capacity, image) " +
                "values (@N, @A, @C, @I)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@N", tbFacility.Text);
            sqlCommand.Parameters.AddWithValue("@A", cmbAvailability.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@C", numpadCapacity.Value);
            sqlCommand.Parameters.AddWithValue("@I", image);

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

        private void btnDelete_Click(object sender, EventArgs e)
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

                SqlCommand sqlCommand
                    = new SqlCommand("delete from Facility where fID = @ID", sqlConnection);
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
            }

        }

        private void loadAvailability()
        {
            cmbAvailability.DisplayMember = "Text";
            cmbAvailability.ValueMember = "Value";

            var items = new[] {
                new { Text = "--Available--", Value = "1" },
                new { Text = "--Not Available--", Value = "0" },
            };

            cmbAvailability.DataSource = items;
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConvertBytesToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
                return Image.FromStream(ms);
        }
    }
}
