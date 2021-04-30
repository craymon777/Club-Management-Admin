namespace ClubOneAdmin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSelectedNav = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHeadTitle = new System.Windows.Forms.Label();
            this.pnlHeadTitle = new System.Windows.Forms.Panel();
            this.pnlChildFormContainer = new System.Windows.Forms.Panel();
            this.iconHeadTitle = new FontAwesome.Sharp.IconPictureBox();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.btnBookings = new FontAwesome.Sharp.IconButton();
            this.btnFacilities = new FontAwesome.Sharp.IconButton();
            this.btnTraningClasses = new FontAwesome.Sharp.IconButton();
            this.btnTutor = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlHeadTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeadTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnPayments);
            this.panel1.Controls.Add(this.pnlSelectedNav);
            this.panel1.Controls.Add(this.btnBookings);
            this.panel1.Controls.Add(this.btnFacilities);
            this.panel1.Controls.Add(this.btnTraningClasses);
            this.panel1.Controls.Add(this.btnTutor);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 809);
            this.panel1.TabIndex = 0;
            // 
            // pnlSelectedNav
            // 
            this.pnlSelectedNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlSelectedNav.Location = new System.Drawing.Point(0, 332);
            this.pnlSelectedNav.Name = "pnlSelectedNav";
            this.pnlSelectedNav.Size = new System.Drawing.Size(8, 100);
            this.pnlSelectedNav.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 182);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(70, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Allen Tom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(75, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHeadTitle
            // 
            this.lbHeadTitle.AutoSize = true;
            this.lbHeadTitle.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeadTitle.ForeColor = System.Drawing.Color.White;
            this.lbHeadTitle.Location = new System.Drawing.Point(78, 43);
            this.lbHeadTitle.Name = "lbHeadTitle";
            this.lbHeadTitle.Size = new System.Drawing.Size(143, 38);
            this.lbHeadTitle.TabIndex = 2;
            this.lbHeadTitle.Text = "HeadTitle";
            // 
            // pnlHeadTitle
            // 
            this.pnlHeadTitle.Controls.Add(this.lbHeadTitle);
            this.pnlHeadTitle.Controls.Add(this.iconHeadTitle);
            this.pnlHeadTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeadTitle.Location = new System.Drawing.Point(240, 0);
            this.pnlHeadTitle.Name = "pnlHeadTitle";
            this.pnlHeadTitle.Size = new System.Drawing.Size(1107, 100);
            this.pnlHeadTitle.TabIndex = 1;
            this.pnlHeadTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeadTitle_MouseDown);
            // 
            // pnlChildFormContainer
            // 
            this.pnlChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildFormContainer.Location = new System.Drawing.Point(240, 100);
            this.pnlChildFormContainer.Name = "pnlChildFormContainer";
            this.pnlChildFormContainer.Size = new System.Drawing.Size(1107, 709);
            this.pnlChildFormContainer.TabIndex = 2;
            this.pnlChildFormContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildFormContainer_Paint);
            // 
            // iconHeadTitle
            // 
            this.iconHeadTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.iconHeadTitle.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHeadTitle.IconColor = System.Drawing.Color.White;
            this.iconHeadTitle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHeadTitle.IconSize = 45;
            this.iconHeadTitle.Location = new System.Drawing.Point(27, 43);
            this.iconHeadTitle.Name = "iconHeadTitle";
            this.iconHeadTitle.Size = new System.Drawing.Size(45, 47);
            this.iconHeadTitle.TabIndex = 1;
            this.iconHeadTitle.TabStop = false;
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayments.IconSize = 40;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 557);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnPayments.Size = new System.Drawing.Size(240, 75);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payment Records";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnBookings
            // 
            this.btnBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBookings.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnBookings.IconColor = System.Drawing.Color.White;
            this.btnBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookings.IconSize = 40;
            this.btnBookings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.Location = new System.Drawing.Point(0, 482);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnBookings.Size = new System.Drawing.Size(240, 75);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnFacilities
            // 
            this.btnFacilities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacilities.FlatAppearance.BorderSize = 0;
            this.btnFacilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilities.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnFacilities.IconChar = FontAwesome.Sharp.IconChar.Futbol;
            this.btnFacilities.IconColor = System.Drawing.Color.White;
            this.btnFacilities.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacilities.IconSize = 40;
            this.btnFacilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.Location = new System.Drawing.Point(0, 407);
            this.btnFacilities.Name = "btnFacilities";
            this.btnFacilities.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnFacilities.Size = new System.Drawing.Size(240, 75);
            this.btnFacilities.TabIndex = 1;
            this.btnFacilities.Text = "Facilities";
            this.btnFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacilities.UseVisualStyleBackColor = true;
            this.btnFacilities.Click += new System.EventHandler(this.btnFacilities_Click);
            // 
            // btnTraningClasses
            // 
            this.btnTraningClasses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraningClasses.FlatAppearance.BorderSize = 0;
            this.btnTraningClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraningClasses.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraningClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTraningClasses.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnTraningClasses.IconColor = System.Drawing.Color.White;
            this.btnTraningClasses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTraningClasses.IconSize = 40;
            this.btnTraningClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraningClasses.Location = new System.Drawing.Point(0, 332);
            this.btnTraningClasses.Name = "btnTraningClasses";
            this.btnTraningClasses.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnTraningClasses.Size = new System.Drawing.Size(240, 75);
            this.btnTraningClasses.TabIndex = 1;
            this.btnTraningClasses.Text = "Training Classes";
            this.btnTraningClasses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraningClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraningClasses.UseVisualStyleBackColor = true;
            this.btnTraningClasses.Click += new System.EventHandler(this.btnTraningClasses_Click);
            // 
            // btnTutor
            // 
            this.btnTutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTutor.FlatAppearance.BorderSize = 0;
            this.btnTutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutor.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTutor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnTutor.IconColor = System.Drawing.Color.White;
            this.btnTutor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTutor.IconSize = 40;
            this.btnTutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutor.Location = new System.Drawing.Point(0, 257);
            this.btnTutor.Name = "btnTutor";
            this.btnTutor.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnTutor.Size = new System.Drawing.Size(240, 75);
            this.btnTutor.TabIndex = 1;
            this.btnTutor.Text = "Tutors";
            this.btnTutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutor.UseVisualStyleBackColor = true;
            this.btnTutor.Click += new System.EventHandler(this.btnTutor_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 40;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 182);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(240, 75);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubOneAdmin.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(79, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1347, 809);
            this.Controls.Add(this.pnlChildFormContainer);
            this.Controls.Add(this.pnlHeadTitle);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlHeadTitle.ResumeLayout(false);
            this.pnlHeadTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHeadTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnBookings;
        private FontAwesome.Sharp.IconButton btnFacilities;
        private FontAwesome.Sharp.IconButton btnTraningClasses;
        private FontAwesome.Sharp.IconButton btnTutor;
        private System.Windows.Forms.Panel pnlSelectedNav;
        private FontAwesome.Sharp.IconPictureBox iconHeadTitle;
        private System.Windows.Forms.Label lbHeadTitle;
        private System.Windows.Forms.Panel pnlHeadTitle;
        private System.Windows.Forms.Panel pnlChildFormContainer;
        private FontAwesome.Sharp.IconButton btnPayments;
    }
}