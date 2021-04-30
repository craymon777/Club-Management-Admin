namespace ClubOneAdmin
{
    partial class ClassesManageForm
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
            this.lbFacility = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbTimeslot = new System.Windows.Forms.Label();
            this.lbTutor = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbTimeslot = new System.Windows.Forms.TextBox();
            this.cmbFacility = new System.Windows.Forms.ComboBox();
            this.cmbTutor = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFacility
            // 
            this.lbFacility.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFacility.AutoSize = true;
            this.lbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacility.ForeColor = System.Drawing.Color.White;
            this.lbFacility.Location = new System.Drawing.Point(43, 275);
            this.lbFacility.Name = "lbFacility";
            this.lbFacility.Size = new System.Drawing.Size(96, 29);
            this.lbFacility.TabIndex = 5;
            this.lbFacility.Text = "Facility";
            // 
            // lbClass
            // 
            this.lbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.White;
            this.lbClass.Location = new System.Drawing.Point(43, 196);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(78, 29);
            this.lbClass.TabIndex = 4;
            this.lbClass.Text = "Class";
            // 
            // lbClassID
            // 
            this.lbClassID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassID.ForeColor = System.Drawing.Color.White;
            this.lbClassID.Location = new System.Drawing.Point(43, 113);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(110, 29);
            this.lbClassID.TabIndex = 3;
            this.lbClassID.Text = "Class ID";
            // 
            // lbDay
            // 
            this.lbDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.ForeColor = System.Drawing.Color.White;
            this.lbDay.Location = new System.Drawing.Point(426, 276);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(57, 29);
            this.lbDay.TabIndex = 8;
            this.lbDay.Text = "Day";
            // 
            // lbTimeslot
            // 
            this.lbTimeslot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTimeslot.AutoSize = true;
            this.lbTimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeslot.ForeColor = System.Drawing.Color.White;
            this.lbTimeslot.Location = new System.Drawing.Point(426, 197);
            this.lbTimeslot.Name = "lbTimeslot";
            this.lbTimeslot.Size = new System.Drawing.Size(115, 29);
            this.lbTimeslot.TabIndex = 7;
            this.lbTimeslot.Text = "Timeslot";
            // 
            // lbTutor
            // 
            this.lbTutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTutor.AutoSize = true;
            this.lbTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTutor.ForeColor = System.Drawing.Color.White;
            this.lbTutor.Location = new System.Drawing.Point(426, 114);
            this.lbTutor.Name = "lbTutor";
            this.lbTutor.Size = new System.Drawing.Size(75, 29);
            this.lbTutor.TabIndex = 6;
            this.lbTutor.Text = "Tutor";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(159, 113);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(221, 30);
            this.tbID.TabIndex = 9;
            // 
            // tbClass
            // 
            this.tbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClass.Location = new System.Drawing.Point(159, 195);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(221, 30);
            this.tbClass.TabIndex = 9;
            // 
            // tbTimeslot
            // 
            this.tbTimeslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimeslot.Location = new System.Drawing.Point(547, 196);
            this.tbTimeslot.Name = "tbTimeslot";
            this.tbTimeslot.Size = new System.Drawing.Size(221, 30);
            this.tbTimeslot.TabIndex = 11;
            // 
            // cmbFacility
            // 
            this.cmbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacility.FormattingEnabled = true;
            this.cmbFacility.Location = new System.Drawing.Point(161, 275);
            this.cmbFacility.Name = "cmbFacility";
            this.cmbFacility.Size = new System.Drawing.Size(219, 33);
            this.cmbFacility.TabIndex = 13;
            // 
            // cmbTutor
            // 
            this.cmbTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTutor.FormattingEnabled = true;
            this.cmbTutor.Location = new System.Drawing.Point(547, 109);
            this.cmbTutor.Name = "cmbTutor";
            this.cmbTutor.Size = new System.Drawing.Size(221, 33);
            this.cmbTutor.TabIndex = 14;
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(547, 276);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(221, 33);
            this.cmbDay.TabIndex = 15;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(42, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(99, 32);
            this.lbTitle.TabIndex = 16;
            this.lbTitle.Text = "label1";
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(43, 349);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(74, 29);
            this.lbPrice.TabIndex = 21;
            this.lbPrice.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(159, 349);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(221, 30);
            this.numPrice.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnReset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 24;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(48, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReset.Size = new System.Drawing.Size(109, 42);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 24;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(659, 414);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(109, 42);
            this.btnUpdate.TabIndex = 19;
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
            this.btnCancel.IconSize = 24;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(513, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(109, 42);
            this.btnCancel.TabIndex = 18;
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
            this.btnInsert.Location = new System.Drawing.Point(659, 414);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(109, 42);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ClassesManageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(809, 487);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbTutor);
            this.Controls.Add(this.cmbFacility);
            this.Controls.Add(this.tbTimeslot);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbTimeslot);
            this.Controls.Add(this.lbTutor);
            this.Controls.Add(this.lbFacility);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbClassID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClassesManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassesManageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassesManageForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassesManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFacility;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbTimeslot;
        private System.Windows.Forms.Label lbTutor;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbTimeslot;
        private System.Windows.Forms.ComboBox cmbFacility;
        private System.Windows.Forms.ComboBox cmbTutor;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lbTitle;
        private FontAwesome.Sharp.IconButton btnInsert;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}