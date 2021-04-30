namespace ClubOneAdmin
{
    partial class FormBookings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSelectedNav = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDecline = new FontAwesome.Sharp.IconButton();
            this.btnBookClass = new FontAwesome.Sharp.IconButton();
            this.btnApprove = new FontAwesome.Sharp.IconButton();
            this.btnBookFacility = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSelectedNav
            // 
            this.pnlSelectedNav.BackColor = System.Drawing.Color.Cyan;
            this.pnlSelectedNav.Location = new System.Drawing.Point(106, 74);
            this.pnlSelectedNav.Name = "pnlSelectedNav";
            this.pnlSelectedNav.Size = new System.Drawing.Size(282, 8);
            this.pnlSelectedNav.TabIndex = 5;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(151, 111);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(211, 33);
            this.cmbStatus.TabIndex = 13;
            this.cmbStatus.SelectionChangeCommitted += new System.EventHandler(this.cmbStatus_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status:";
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.EnableHeadersVisualStyles = false;
            this.dgvBookings.Location = new System.Drawing.Point(0, 0);
            this.dgvBookings.Name = "dgvBookings";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.RowHeadersWidth = 50;
            this.dgvBookings.RowTemplate.Height = 40;
            this.dgvBookings.Size = new System.Drawing.Size(1028, 455);
            this.dgvBookings.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSelectedNav);
            this.panel1.Controls.Add(this.btnDecline);
            this.panel1.Controls.Add(this.btnBookClass);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBookFacility);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(35, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 167);
            this.panel1.TabIndex = 18;
            // 
            // btnDecline
            // 
            this.btnDecline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnDecline.Enabled = false;
            this.btnDecline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDecline.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnDecline.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDecline.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDecline.IconSize = 24;
            this.btnDecline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecline.Location = new System.Drawing.Point(738, 105);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDecline.Size = new System.Drawing.Size(116, 46);
            this.btnDecline.TabIndex = 17;
            this.btnDecline.Text = "Decline";
            this.btnDecline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnBookClass
            // 
            this.btnBookClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnBookClass.FlatAppearance.BorderSize = 0;
            this.btnBookClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.btnBookClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookClass.ForeColor = System.Drawing.Color.White;
            this.btnBookClass.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnBookClass.IconColor = System.Drawing.Color.White;
            this.btnBookClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookClass.IconSize = 22;
            this.btnBookClass.Location = new System.Drawing.Point(253, 23);
            this.btnBookClass.Name = "btnBookClass";
            this.btnBookClass.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBookClass.Size = new System.Drawing.Size(210, 59);
            this.btnBookClass.TabIndex = 12;
            this.btnBookClass.Text = "Traning Classes";
            this.btnBookClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookClass.UseVisualStyleBackColor = false;
            this.btnBookClass.Click += new System.EventHandler(this.btnBookClass_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnApprove.Enabled = false;
            this.btnApprove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnApprove.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnApprove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnApprove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApprove.IconSize = 24;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(882, 105);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnApprove.Size = new System.Drawing.Size(116, 46);
            this.btnApprove.TabIndex = 16;
            this.btnApprove.Text = "Approve";
            this.btnApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBookFacility
            // 
            this.btnBookFacility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnBookFacility.FlatAppearance.BorderSize = 0;
            this.btnBookFacility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(153)))));
            this.btnBookFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookFacility.ForeColor = System.Drawing.Color.White;
            this.btnBookFacility.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnBookFacility.IconColor = System.Drawing.Color.White;
            this.btnBookFacility.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookFacility.IconSize = 22;
            this.btnBookFacility.Location = new System.Drawing.Point(35, 23);
            this.btnBookFacility.Name = "btnBookFacility";
            this.btnBookFacility.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnBookFacility.Size = new System.Drawing.Size(212, 59);
            this.btnBookFacility.TabIndex = 11;
            this.btnBookFacility.Text = "Facilities";
            this.btnBookFacility.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookFacility.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookFacility.UseVisualStyleBackColor = false;
            this.btnBookFacility.Click += new System.EventHandler(this.btnBookFacility_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBookings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(35, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 455);
            this.panel2.TabIndex = 19;
            // 
            // FormBookings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormBookings";
            this.Padding = new System.Windows.Forms.Padding(35, 10, 35, 30);
            this.Text = "FormBookings";
            this.Load += new System.EventHandler(this.FormBookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBookFacility;
        private FontAwesome.Sharp.IconButton btnBookClass;
        private System.Windows.Forms.Panel pnlSelectedNav;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private FontAwesome.Sharp.IconButton btnApprove;
        private FontAwesome.Sharp.IconButton btnDecline;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}