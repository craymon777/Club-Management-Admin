namespace ClubOneAdmin
{
    partial class FacilityManagementForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbFacility = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbTimeslot = new System.Windows.Forms.Label();
            this.lbTutor = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.numpadCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numpadCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(43, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(99, 32);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "label1";
            // 
            // tbFacility
            // 
            this.tbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFacility.Location = new System.Drawing.Point(160, 236);
            this.tbFacility.Name = "tbFacility";
            this.tbFacility.Size = new System.Drawing.Size(221, 30);
            this.tbFacility.TabIndex = 22;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(160, 139);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(221, 30);
            this.tbID.TabIndex = 23;
            // 
            // lbTimeslot
            // 
            this.lbTimeslot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimeslot.AutoSize = true;
            this.lbTimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeslot.ForeColor = System.Drawing.Color.White;
            this.lbTimeslot.Location = new System.Drawing.Point(426, 238);
            this.lbTimeslot.Name = "lbTimeslot";
            this.lbTimeslot.Size = new System.Drawing.Size(113, 29);
            this.lbTimeslot.TabIndex = 21;
            this.lbTimeslot.Text = "Capacity";
            // 
            // lbTutor
            // 
            this.lbTutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTutor.AutoSize = true;
            this.lbTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTutor.ForeColor = System.Drawing.Color.White;
            this.lbTutor.Location = new System.Drawing.Point(426, 139);
            this.lbTutor.Name = "lbTutor";
            this.lbTutor.Size = new System.Drawing.Size(138, 29);
            this.lbTutor.TabIndex = 20;
            this.lbTutor.Text = "Availability";
            // 
            // lbClass
            // 
            this.lbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.White;
            this.lbClass.Location = new System.Drawing.Point(44, 237);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(96, 29);
            this.lbClass.TabIndex = 19;
            this.lbClass.Text = "Facility";
            // 
            // lbClassID
            // 
            this.lbClassID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassID.ForeColor = System.Drawing.Color.White;
            this.lbClassID.Location = new System.Drawing.Point(44, 139);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(38, 29);
            this.lbClassID.TabIndex = 18;
            this.lbClassID.Text = "ID";
            this.lbClassID.Click += new System.EventHandler(this.lbClassID_Click);
            // 
            // numpadCapacity
            // 
            this.numpadCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpadCapacity.Location = new System.Drawing.Point(570, 238);
            this.numpadCapacity.Name = "numpadCapacity";
            this.numpadCapacity.Size = new System.Drawing.Size(194, 30);
            this.numpadCapacity.TabIndex = 27;
            // 
            // cmbAvailability
            // 
            this.cmbAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvailability.FormattingEnabled = true;
            this.cmbAvailability.Location = new System.Drawing.Point(570, 139);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Size = new System.Drawing.Size(194, 33);
            this.cmbAvailability.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 359);
            this.label1.MaximumSize = new System.Drawing.Size(120, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "Drag Image Here ->>>>";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(669, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(117, 47);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picboxImage
            // 
            this.picboxImage.BackColor = System.Drawing.Color.White;
            this.picboxImage.Image = global::ClubOneAdmin.Properties.Resources.cancel;
            this.picboxImage.Location = new System.Drawing.Point(160, 320);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(145, 143);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImage.TabIndex = 32;
            this.picboxImage.TabStop = false;
            this.picboxImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.picboxImage_DragDrop);
            this.picboxImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.picboxImage_DragEnter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 24;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(669, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(117, 47);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 26;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(510, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(117, 47);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnInsert.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnInsert.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnInsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsert.IconSize = 24;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(669, 401);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(117, 47);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // FacilityManagementForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(809, 487);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxImage);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbAvailability);
            this.Controls.Add(this.numpadCapacity);
            this.Controls.Add(this.tbFacility);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbTimeslot);
            this.Controls.Add(this.lbTutor);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.Name = "FacilityManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacilityManagementForm";
            this.Load += new System.EventHandler(this.FacilityManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numpadCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbFacility;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbTimeslot;
        private System.Windows.Forms.Label lbTutor;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.NumericUpDown numpadCapacity;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnInsert;
        private System.Windows.Forms.PictureBox picboxImage;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}