namespace BIT502_Assessment3
{
    partial class frBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBooking));
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLbStatusMember = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLbStatusClass = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLbStatusSearch = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentClassDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRemoveClass = new System.Windows.Forms.Button();
            this.lbCurrentClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Location = new System.Drawing.Point(12, 64);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memberDataGridView.Size = new System.Drawing.Size(536, 586);
            this.memberDataGridView.TabIndex = 1;
            this.memberDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.memberDataGridView_CellMouseClick);
            // 
            // classDataGridView
            // 
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Location = new System.Drawing.Point(564, 354);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.classDataGridView.Size = new System.Drawing.Size(475, 197);
            this.classDataGridView.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(909, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 31);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLbStatusMember,
            this.stLbStatusClass,
            this.stLbStatusSearch});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1057, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLbStatusMember
            // 
            this.stLbStatusMember.Name = "stLbStatusMember";
            this.stLbStatusMember.Size = new System.Drawing.Size(90, 17);
            this.stLbStatusMember.Text = "Total Members: 0";
            // 
            // stLbStatusClass
            // 
            this.stLbStatusClass.Name = "stLbStatusClass";
            this.stLbStatusClass.Size = new System.Drawing.Size(63, 17);
            this.stLbStatusClass.Text = "| Classes: 0";
            // 
            // stLbStatusSearch
            // 
            this.stLbStatusSearch.Name = "stLbStatusSearch";
            this.stLbStatusSearch.Size = new System.Drawing.Size(93, 17);
            this.stLbStatusSearch.Text = "| Search Result: 0";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(74, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 26);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(576, 78);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(938, 557);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(101, 31);
            this.btnBook.TabIndex = 20;
            this.btnBook.Text = "Book Class";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(649, 78);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(84, 17);
            this.lbFirstName.TabIndex = 21;
            this.lbFirstName.Text = "First Name: ";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(809, 78);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(84, 17);
            this.lbLastName.TabIndex = 22;
            this.lbLastName.Text = "Last Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 48);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Available Classes ";
            // 
            // currentClassDataGridView
            // 
            this.currentClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentClassDataGridView.Location = new System.Drawing.Point(565, 131);
            this.currentClassDataGridView.Name = "currentClassDataGridView";
            this.currentClassDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentClassDataGridView.Size = new System.Drawing.Size(474, 154);
            this.currentClassDataGridView.TabIndex = 25;
            // 
            // btnRemoveClass
            // 
            this.btnRemoveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClass.Location = new System.Drawing.Point(938, 291);
            this.btnRemoveClass.Name = "btnRemoveClass";
            this.btnRemoveClass.Size = new System.Drawing.Size(101, 31);
            this.btnRemoveClass.TabIndex = 26;
            this.btnRemoveClass.Text = "Remove Class";
            this.btnRemoveClass.UseVisualStyleBackColor = true;
            this.btnRemoveClass.Click += new System.EventHandler(this.btnRemoveClass_Click);
            // 
            // lbCurrentClass
            // 
            this.lbCurrentClass.AutoSize = true;
            this.lbCurrentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentClass.Location = new System.Drawing.Point(566, 108);
            this.lbCurrentClass.Name = "lbCurrentClass";
            this.lbCurrentClass.Size = new System.Drawing.Size(131, 20);
            this.lbCurrentClass.TabIndex = 27;
            this.lbCurrentClass.Text = "Member Classes ";
            // 
            // frBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 685);
            this.Controls.Add(this.lbCurrentClass);
            this.Controls.Add(this.btnRemoveClass);
            this.Controls.Add(this.currentClassDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Booking";
            this.Load += new System.EventHandler(this.frBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentClassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stLbStatusMember;
        private System.Windows.Forms.ToolStripStatusLabel stLbStatusClass;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView currentClassDataGridView;
        private System.Windows.Forms.Button btnRemoveClass;
        private System.Windows.Forms.Label lbCurrentClass;
        public System.Windows.Forms.DataGridView classDataGridView;
        private System.Windows.Forms.ToolStripStatusLabel stLbStatusSearch;
    }
}