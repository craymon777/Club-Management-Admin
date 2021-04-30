using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;

namespace ClubOneAdmin
{
    public partial class MainForm : Form
    {
        public string username;
        public string uid;

        private IconButton currentButton;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int mWidthEllipse,
            int mHeightEllipse  );

        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
            /*Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlSelectedNav.Visible = false;*/

            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentButton = btnDashboard;
            ActivateButton(currentButton, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormDashBoard());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void ActivateButton(object senderBtn, Color color)
        {

            if(senderBtn != null)
            {
                DeAvtivateButton();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = color;
                currentButton.IconColor = Color.FromArgb(0, 126, 249);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                //panel
                pnlSelectedNav.Height = currentButton.Height;
                pnlSelectedNav.Location = new Point(0, currentButton.Location.Y);
                pnlSelectedNav.Visible = true;

                //HeadTitle section
                iconHeadTitle.IconChar = currentButton.IconChar;
                lbHeadTitle.Text = currentButton.Text;
            }
        }

        private void DeAvtivateButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(24, 30, 54);
                currentButton.IconColor = Color.FromArgb(255,255,255);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();

            //format current child form
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //fill the container with child form
            pnlChildFormContainer.Controls.Add(childForm);
            pnlChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //import function to allow windows dragging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHeadTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //dragging windows
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormDashBoard());
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormTutorsManagement());
        }

        private void btnTraningClasses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormTrainingClasses());
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormFacilities());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormBookings());
        }

        private void pnlChildFormContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(46, 51, 73));
            OpenChildForm(new FormPayments());
        }
    }
}
