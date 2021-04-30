namespace ClubOneAdmin
{
    partial class FormTrainingClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFacilities = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTrainingClass = new System.Windows.Forms.DataGridView();
            this.btnDeleteClass = new FontAwesome.Sharp.IconButton();
            this.btnEditClass = new FontAwesome.Sharp.IconButton();
            this.btnAddClass = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Classes:";
            // 
            // cmbFacilities
            // 
            this.cmbFacilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFacilities.FormattingEnabled = true;
            this.cmbFacilities.ItemHeight = 25;
            this.cmbFacilities.Location = new System.Drawing.Point(219, 29);
            this.cmbFacilities.Name = "cmbFacilities";
            this.cmbFacilities.Size = new System.Drawing.Size(208, 33);
            this.cmbFacilities.TabIndex = 1;
            this.cmbFacilities.SelectionChangeCommitted += new System.EventHandler(this.cmbFacilities_SelectionChangeCommitted);
            this.cmbFacilities.SelectedValueChanged += new System.EventHandler(this.cmbFacilities_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnDeleteClass);
            this.panel1.Controls.Add(this.btnEditClass);
            this.panel1.Controls.Add(this.btnAddClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbFacilities);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 93);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTrainingClass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 509);
            this.panel2.TabIndex = 3;
            // 
            // dgvTrainingClass
            // 
            this.dgvTrainingClass.AllowUserToAddRows = false;
            this.dgvTrainingClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvTrainingClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrainingClass.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTrainingClass.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainingClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainingClass.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainingClass.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainingClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingClass.EnableHeadersVisualStyles = false;
            this.dgvTrainingClass.Location = new System.Drawing.Point(0, 0);
            this.dgvTrainingClass.Name = "dgvTrainingClass";
            this.dgvTrainingClass.RowHeadersWidth = 30;
            this.dgvTrainingClass.RowTemplate.Height = 40;
            this.dgvTrainingClass.Size = new System.Drawing.Size(1038, 509);
            this.dgvTrainingClass.TabIndex = 0;
            this.dgvTrainingClass.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTrainingClass_RowHeaderMouseClick);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnDeleteClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDeleteClass.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnDeleteClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteClass.IconSize = 25;
            this.btnDeleteClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteClass.Location = new System.Drawing.Point(837, 26);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(169, 35);
            this.btnDeleteClass.TabIndex = 4;
            this.btnDeleteClass.Text = "Remove Class";
            this.btnDeleteClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnEditClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnEditClass.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnEditClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditClass.IconSize = 25;
            this.btnEditClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditClass.Location = new System.Drawing.Point(632, 26);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(136, 35);
            this.btnEditClass.TabIndex = 3;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditClass.UseVisualStyleBackColor = false;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnAddClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnAddClass.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddClass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnAddClass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClass.IconSize = 25;
            this.btnAddClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClass.Location = new System.Drawing.Point(478, 26);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(136, 35);
            this.btnAddClass.TabIndex = 2;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // FormTrainingClasses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormTrainingClasses";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "FormTrainingClasses";
            this.Load += new System.EventHandler(this.FormTrainingClasses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFacilities;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnAddClass;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEditClass;
        private System.Windows.Forms.DataGridView dgvTrainingClass;
        private FontAwesome.Sharp.IconButton btnDeleteClass;
    }
}