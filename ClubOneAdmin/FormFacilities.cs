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
    public partial class FormFacilities : Form
    {
        public FormFacilities()
        {
            InitializeComponent();
        }

        private void FormFacilities_Load(object sender, EventArgs e)
        {

            loadFacilityData();
        }

        private void loadFacilityData()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server=LAPTOP-SMQPLLME\\SQLEXPRESS; UId=admin1; Password=123456; " +
                "Database=clubone;");
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("select * from Facility", sqlConnection);

            IDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            sqlConnection.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                FacilityItem fitem = new FacilityItem();
                fitem.fID = ds.Tables[0].Rows[i][0].ToString();
                fitem.ItemLabel = ds.Tables[0].Rows[i][1].ToString();
                fitem.Availability = ds.Tables[0].Rows[i][2].ToString();
                fitem.Capacity = ds.Tables[0].Rows[i][3].ToString();
                fitem.ItemImage = ConvertBytesToImage((byte[])ds.Tables[0].Rows[i][4]);
                flowpnlFacilities.Controls.Add(fitem);
                fitem.MouseClick += new MouseEventHandler(this.facilityEvent);
            }
        }

        void facilityEvent(object sender, MouseEventArgs e)
        {
            FacilityItem currentItem = (FacilityItem)sender;

            //show dialog
            FacilityManagementForm fmForm = new FacilityManagementForm();
            fmForm.fID = currentItem.fID;
            fmForm.facility = currentItem.ItemLabel;
            fmForm.availability = currentItem.Availability;
            fmForm.capacity = currentItem.Capacity;
            fmForm.image = currentItem.ItemImage;

            fmForm.action = "Edit";

            if (fmForm.ShowDialog() == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                FormFacilities_Load(null, EventArgs.Empty);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public Image ConvertBytesToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
                return Image.FromStream(ms);
        }

        private void btnAddFacility_Click(object sender, EventArgs e)
        {
            FacilityManagementForm fmForm = new FacilityManagementForm();
            fmForm.action = "Add";

            if (fmForm.ShowDialog() == DialogResult.OK)
            {
                this.Controls.Clear();
                InitializeComponent();
                FormFacilities_Load(null, EventArgs.Empty);
            }

        }
    }
}
