namespace ClubOneAdmin
{
    partial class FormTutorsManagement
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdviewTutor = new System.Windows.Forms.DataGridView();
            this.cluboneDataSet = new ClubOneAdmin.cluboneDataSet();
            this.tutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutorTableAdapter = new ClubOneAdmin.cluboneDataSetTableAdapters.TutorTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbExp = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTutorID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            this.btnModify = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewTutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cluboneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdviewTutor
            // 
            this.grdviewTutor.AllowUserToAddRows = false;
            this.grdviewTutor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.grdviewTutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdviewTutor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdviewTutor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdviewTutor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdviewTutor.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdviewTutor.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdviewTutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdviewTutor.EnableHeadersVisualStyles = false;
            this.grdviewTutor.Location = new System.Drawing.Point(0, 0);
            this.grdviewTutor.Name = "grdviewTutor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdviewTutor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdviewTutor.RowHeadersWidth = 50;
            this.grdviewTutor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.grdviewTutor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdviewTutor.RowTemplate.Height = 40;
            this.grdviewTutor.Size = new System.Drawing.Size(998, 365);
            this.grdviewTutor.TabIndex = 0;
            this.grdviewTutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewTutor_CellContentClick);
            this.grdviewTutor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdviewTutor_RowHeaderMouseClick);
            // 
            // cluboneDataSet
            // 
            this.cluboneDataSet.DataSetName = "cluboneDataSet";
            this.cluboneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tutorBindingSource
            // 
            this.tutorBindingSource.DataMember = "Tutor";
            this.tutorBindingSource.DataSource = this.cluboneDataSet;
            // 
            // tutorTableAdapter
            // 
            this.tutorTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbExp);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbAge);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbTutorID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 217);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(0, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 26);
            this.panel3.TabIndex = 1;
            // 
            // tbExp
            // 
            this.tbExp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExp.ForeColor = System.Drawing.Color.White;
            this.tbExp.Location = new System.Drawing.Point(676, 137);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(288, 30);
            this.tbExp.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.Location = new System.Drawing.Point(676, 100);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(288, 30);
            this.tbPhone.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(676, 61);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(288, 30);
            this.tbEmail.TabIndex = 9;
            // 
            // tbAge
            // 
            this.tbAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.ForeColor = System.Drawing.Color.White;
            this.tbAge.Location = new System.Drawing.Point(153, 138);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(288, 30);
            this.tbAge.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(153, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(288, 30);
            this.tbName.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.White;
            this.tbID.Location = new System.Drawing.Point(153, 60);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(288, 30);
            this.tbID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(506, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Experiences";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(506, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(506, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // lbAge
            // 
            this.lbAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.ForeColor = System.Drawing.Color.White;
            this.lbAge.Location = new System.Drawing.Point(46, 138);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(51, 25);
            this.lbAge.TabIndex = 2;
            this.lbAge.Text = "Age";
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(46, 101);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 25);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbTutorID
            // 
            this.lbTutorID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTutorID.AutoSize = true;
            this.lbTutorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTutorID.ForeColor = System.Drawing.Color.White;
            this.lbTutorID.Location = new System.Drawing.Point(46, 61);
            this.lbTutorID.Name = "lbTutorID";
            this.lbTutorID.Size = new System.Drawing.Size(90, 25);
            this.lbTutorID.TabIndex = 0;
            this.lbTutorID.Text = "Tutor ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdviewTutor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 365);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 24;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(861, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(103, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnInsert.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnInsert.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnInsert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInsert.IconSize = 24;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(51, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInsert.Size = new System.Drawing.Size(103, 33);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnModify.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnModify.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModify.IconSize = 22;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(176, 13);
            this.btnModify.Name = "btnModify";
            this.btnModify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnModify.Size = new System.Drawing.Size(103, 33);
            this.btnModify.TabIndex = 10;
            this.btnModify.Text = "Update";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FormTutorsManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTutorsManagement";
            this.Padding = new System.Windows.Forms.Padding(50, 30, 50, 50);
            this.Text = "FormTutorsManagement";
            this.Load += new System.EventHandler(this.FormTutorsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewTutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cluboneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdviewTutor;
        private cluboneDataSet cluboneDataSet;
        private System.Windows.Forms.BindingSource tutorBindingSource;
        private cluboneDataSetTableAdapters.TutorTableAdapter tutorTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTutorID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnModify;
        private FontAwesome.Sharp.IconButton btnInsert;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}