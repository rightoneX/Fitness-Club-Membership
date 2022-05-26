namespace BIT502_Assessment3
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.btnNewMemberForm = new System.Windows.Forms.Button();
            this.btnBookingForm = new System.Windows.Forms.Button();
            this.btnSeachForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewMemberForm
            // 
            this.btnNewMemberForm.Location = new System.Drawing.Point(60, 32);
            this.btnNewMemberForm.Name = "btnNewMemberForm";
            this.btnNewMemberForm.Size = new System.Drawing.Size(165, 45);
            this.btnNewMemberForm.TabIndex = 0;
            this.btnNewMemberForm.Text = "Add New Member";
            this.btnNewMemberForm.UseVisualStyleBackColor = true;
            this.btnNewMemberForm.Click += new System.EventHandler(this.btnNewMemberForm_Click);
            // 
            // btnBookingForm
            // 
            this.btnBookingForm.Location = new System.Drawing.Point(60, 83);
            this.btnBookingForm.Name = "btnBookingForm";
            this.btnBookingForm.Size = new System.Drawing.Size(165, 45);
            this.btnBookingForm.TabIndex = 1;
            this.btnBookingForm.Text = "Class Booking";
            this.btnBookingForm.UseVisualStyleBackColor = true;
            this.btnBookingForm.Click += new System.EventHandler(this.btnBookingForm_Click);
            // 
            // btnSeachForm
            // 
            this.btnSeachForm.Location = new System.Drawing.Point(60, 134);
            this.btnSeachForm.Name = "btnSeachForm";
            this.btnSeachForm.Size = new System.Drawing.Size(165, 45);
            this.btnSeachForm.TabIndex = 2;
            this.btnSeachForm.Text = "Seach Database";
            this.btnSeachForm.UseVisualStyleBackColor = true;
            this.btnSeachForm.Click += new System.EventHandler(this.btnSeachForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // 
            /*this.lbError.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "MemberID", true));*/
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(12, 245);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(263, 51);
            this.lbError.TabIndex = 6;
            this.lbError.Text = "Database Error";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 301);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(287, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stBar
            // 
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(118, 17);
            this.stBar.Text = "No Database Available ";
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 323);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSeachForm);
            this.Controls.Add(this.btnBookingForm);
            this.Controls.Add(this.btnNewMemberForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Gym Membership";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewMemberForm;
        private System.Windows.Forms.Button btnBookingForm;
        private System.Windows.Forms.Button btnSeachForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stBar;
    }
}