namespace ClubOneAdmin
{
    partial class FacilityItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFacility = new System.Windows.Forms.Label();
            this.picbxFacility = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFacility
            // 
            this.lbFacility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFacility.AutoSize = true;
            this.lbFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.lbFacility.Location = new System.Drawing.Point(3, 24);
            this.lbFacility.MinimumSize = new System.Drawing.Size(280, 0);
            this.lbFacility.Name = "lbFacility";
            this.lbFacility.Size = new System.Drawing.Size(280, 29);
            this.lbFacility.TabIndex = 2;
            this.lbFacility.Text = "gym";
            this.lbFacility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbxFacility
            // 
            this.picbxFacility.Image = global::ClubOneAdmin.Properties.Resources.gym;
            this.picbxFacility.Location = new System.Drawing.Point(57, 84);
            this.picbxFacility.Name = "picbxFacility";
            this.picbxFacility.Size = new System.Drawing.Size(170, 157);
            this.picbxFacility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxFacility.TabIndex = 0;
            this.picbxFacility.TabStop = false;
            // 
            // FacilityItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbFacility);
            this.Controls.Add(this.picbxFacility);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(25, 20, 25, 20);
            this.Name = "FacilityItem";
            this.Size = new System.Drawing.Size(286, 272);
            this.Load += new System.EventHandler(this.FacilityItem_Load);
            this.MouseEnter += new System.EventHandler(this.FacilityItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FacilityItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picbxFacility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxFacility;
        private System.Windows.Forms.Label lbFacility;
    }
}
