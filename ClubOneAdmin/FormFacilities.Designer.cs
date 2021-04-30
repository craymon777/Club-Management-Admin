namespace ClubOneAdmin
{
    partial class FormFacilities
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
            this.flowpnlFacilities = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddFacility = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowpnlFacilities
            // 
            this.flowpnlFacilities.AutoScroll = true;
            this.flowpnlFacilities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowpnlFacilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpnlFacilities.Location = new System.Drawing.Point(40, 0);
            this.flowpnlFacilities.Margin = new System.Windows.Forms.Padding(0);
            this.flowpnlFacilities.Name = "flowpnlFacilities";
            this.flowpnlFacilities.Size = new System.Drawing.Size(1058, 617);
            this.flowpnlFacilities.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFacility);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 45);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowpnlFacilities);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1098, 617);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddFacility
            // 
            this.btnAddFacility.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFacility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.btnAddFacility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFacility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnAddFacility.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddFacility.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnAddFacility.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFacility.IconSize = 25;
            this.btnAddFacility.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFacility.Location = new System.Drawing.Point(874, 7);
            this.btnAddFacility.Name = "btnAddFacility";
            this.btnAddFacility.Size = new System.Drawing.Size(146, 35);
            this.btnAddFacility.TabIndex = 3;
            this.btnAddFacility.Text = "Add Facility";
            this.btnAddFacility.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFacility.UseVisualStyleBackColor = false;
            this.btnAddFacility.Click += new System.EventHandler(this.btnAddFacility_Click);
            // 
            // FormFacilities
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormFacilities";
            this.Text = "FormFacilities";
            this.Load += new System.EventHandler(this.FormFacilities_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowpnlFacilities;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddFacility;
    }
}