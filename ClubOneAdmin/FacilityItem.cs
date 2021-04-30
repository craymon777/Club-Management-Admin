using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubOneAdmin
{
    public partial class FacilityItem : UserControl
    {
        private string fid, availability, capacity;


        public string fID
        {
            get { return this.fid; }

            set { this.fid = value; }
        }

        public string Availability
        {
            get { return this.availability; }

            set { this.availability = value; }
        }

        public string Capacity
        {
            get { return this.capacity; }

            set { this.capacity = value; }
        }

        public FacilityItem()
        {
            InitializeComponent();
        }

        private void FacilityItem_Load(object sender, EventArgs e)
        {

        }

        public Image ItemImage
        {
            get { return picbxFacility.Image; }

            set { picbxFacility.Image = value; }
        }

        public string ItemLabel
        {
            get { return lbFacility.Text; }

            set { lbFacility.Text = value; }
        }

        

        private void FacilityItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(71, 117, 209);
        }

        private void FacilityItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(37, 42, 64);
        }
    }
}
