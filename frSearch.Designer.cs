namespace BIT502_Assessment3
{
    partial class frSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frSearch));
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLbGridCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPdfReport = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.LinkLabel();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtMemType = new System.Windows.Forms.TextBox();
            this.lbMemType = new System.Windows.Forms.Label();
            this.txtMemDuration = new System.Windows.Forms.TextBox();
            this.lbMemDuration = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lbPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentFrequency = new System.Windows.Forms.TextBox();
            this.lbPaymentFrequency = new System.Windows.Forms.Label();
            this.txtExOnlineVideo = new System.Windows.Forms.TextBox();
            this.txtExConsultation = new System.Windows.Forms.TextBox();
            this.lbOnlineVideo = new System.Windows.Forms.Label();
            this.lbExAccess = new System.Windows.Forms.Label();
            this.txtExAccess = new System.Windows.Forms.TextBox();
            this.lbExConsultation = new System.Windows.Forms.Label();
            this.lbExTrainer = new System.Windows.Forms.Label();
            this.txtExTrainer = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lbPayment = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLbStatus,
            this.stLbGridCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1059, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLbStatus
            // 
            this.stLbStatus.Name = "stLbStatus";
            this.stLbStatus.Size = new System.Drawing.Size(52, 17);
            this.stLbStatus.Text = "db status";
            // 
            // stLbGridCount
            // 
            this.stLbGridCount.Name = "stLbGridCount";
            this.stLbGridCount.Size = new System.Drawing.Size(117, 17);
            this.stLbGridCount.Text = "  |  Searched Records: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPdfReport});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // menuPdfReport
            // 
            this.menuPdfReport.Name = "menuPdfReport";
            this.menuPdfReport.Size = new System.Drawing.Size(180, 22);
            this.menuPdfReport.Text = "Save As PDF";
            this.menuPdfReport.Click += new System.EventHandler(this.menuPdfReport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 94);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1035, 309);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(833, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(909, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(974, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 13);
            this.btnClear.TabIndex = 15;
            this.btnClear.TabStop = true;
            this.btnClear.Text = "Clear Search";
            this.btnClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClear_LinkClicked);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(34, 425);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 16;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(34, 470);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 17;
            this.lbLastName.Text = "Last Name";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(37, 441);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(195, 21);
            this.txtName.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(37, 486);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(195, 21);
            this.txtLastName.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(37, 531);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(195, 21);
            this.txtAddress.TabIndex = 21;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(34, 515);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 20;
            this.lbAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(37, 577);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(195, 21);
            this.txtPhone.TabIndex = 23;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(34, 562);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 13);
            this.lbPhone.TabIndex = 22;
            this.lbPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(37, 625);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(195, 21);
            this.txtEmail.TabIndex = 25;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(34, 609);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "Email";
            // 
            // txtMemType
            // 
            this.txtMemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemType.Location = new System.Drawing.Point(274, 440);
            this.txtMemType.Name = "txtMemType";
            this.txtMemType.ReadOnly = true;
            this.txtMemType.Size = new System.Drawing.Size(195, 21);
            this.txtMemType.TabIndex = 27;
            // 
            // lbMemType
            // 
            this.lbMemType.AutoSize = true;
            this.lbMemType.Location = new System.Drawing.Point(271, 424);
            this.lbMemType.Name = "lbMemType";
            this.lbMemType.Size = new System.Drawing.Size(91, 13);
            this.lbMemType.TabIndex = 26;
            this.lbMemType.Text = "Membership Type";
            // 
            // txtMemDuration
            // 
            this.txtMemDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMemDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemDuration.Location = new System.Drawing.Point(274, 485);
            this.txtMemDuration.Name = "txtMemDuration";
            this.txtMemDuration.ReadOnly = true;
            this.txtMemDuration.Size = new System.Drawing.Size(195, 21);
            this.txtMemDuration.TabIndex = 29;
            // 
            // lbMemDuration
            // 
            this.lbMemDuration.AutoSize = true;
            this.lbMemDuration.Location = new System.Drawing.Point(271, 469);
            this.lbMemDuration.Name = "lbMemDuration";
            this.lbMemDuration.Size = new System.Drawing.Size(107, 13);
            this.lbMemDuration.TabIndex = 28;
            this.lbMemDuration.Text = "Membership Duration";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentType.Location = new System.Drawing.Point(274, 530);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.ReadOnly = true;
            this.txtPaymentType.Size = new System.Drawing.Size(195, 21);
            this.txtPaymentType.TabIndex = 31;
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.AutoSize = true;
            this.lbPaymentType.Location = new System.Drawing.Point(271, 514);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.Size = new System.Drawing.Size(75, 13);
            this.lbPaymentType.TabIndex = 30;
            this.lbPaymentType.Text = "Payment Type";
            // 
            // txtPaymentFrequency
            // 
            this.txtPaymentFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentFrequency.Location = new System.Drawing.Point(274, 577);
            this.txtPaymentFrequency.Name = "txtPaymentFrequency";
            this.txtPaymentFrequency.ReadOnly = true;
            this.txtPaymentFrequency.Size = new System.Drawing.Size(195, 21);
            this.txtPaymentFrequency.TabIndex = 33;
            // 
            // lbPaymentFrequency
            // 
            this.lbPaymentFrequency.AutoSize = true;
            this.lbPaymentFrequency.Location = new System.Drawing.Point(271, 561);
            this.lbPaymentFrequency.Name = "lbPaymentFrequency";
            this.lbPaymentFrequency.Size = new System.Drawing.Size(101, 13);
            this.lbPaymentFrequency.TabIndex = 32;
            this.lbPaymentFrequency.Text = "Payment Frequency";
            // 
            // txtExOnlineVideo
            // 
            this.txtExOnlineVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExOnlineVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExOnlineVideo.Location = new System.Drawing.Point(508, 577);
            this.txtExOnlineVideo.Name = "txtExOnlineVideo";
            this.txtExOnlineVideo.ReadOnly = true;
            this.txtExOnlineVideo.Size = new System.Drawing.Size(195, 21);
            this.txtExOnlineVideo.TabIndex = 41;
            // 
            // txtExConsultation
            // 
            this.txtExConsultation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExConsultation.Location = new System.Drawing.Point(508, 530);
            this.txtExConsultation.Name = "txtExConsultation";
            this.txtExConsultation.ReadOnly = true;
            this.txtExConsultation.Size = new System.Drawing.Size(195, 21);
            this.txtExConsultation.TabIndex = 39;
            // 
            // lbOnlineVideo
            // 
            this.lbOnlineVideo.AutoSize = true;
            this.lbOnlineVideo.Location = new System.Drawing.Point(505, 561);
            this.lbOnlineVideo.Name = "lbOnlineVideo";
            this.lbOnlineVideo.Size = new System.Drawing.Size(105, 13);
            this.lbOnlineVideo.TabIndex = 40;
            this.lbOnlineVideo.Text = "Access Online Video";
            // 
            // lbExAccess
            // 
            this.lbExAccess.AutoSize = true;
            this.lbExAccess.Location = new System.Drawing.Point(505, 424);
            this.lbExAccess.Name = "lbExAccess";
            this.lbExAccess.Size = new System.Drawing.Size(68, 13);
            this.lbExAccess.TabIndex = 34;
            this.lbExAccess.Text = "24/7 Access";
            // 
            // txtExAccess
            // 
            this.txtExAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExAccess.Location = new System.Drawing.Point(508, 440);
            this.txtExAccess.Name = "txtExAccess";
            this.txtExAccess.ReadOnly = true;
            this.txtExAccess.Size = new System.Drawing.Size(195, 21);
            this.txtExAccess.TabIndex = 35;
            // 
            // lbExConsultation
            // 
            this.lbExConsultation.AutoSize = true;
            this.lbExConsultation.Location = new System.Drawing.Point(505, 514);
            this.lbExConsultation.Name = "lbExConsultation";
            this.lbExConsultation.Size = new System.Drawing.Size(87, 13);
            this.lbExConsultation.TabIndex = 38;
            this.lbExConsultation.Text = "Diet Consultation";
            // 
            // lbExTrainer
            // 
            this.lbExTrainer.AutoSize = true;
            this.lbExTrainer.Location = new System.Drawing.Point(505, 469);
            this.lbExTrainer.Name = "lbExTrainer";
            this.lbExTrainer.Size = new System.Drawing.Size(84, 13);
            this.lbExTrainer.TabIndex = 36;
            this.lbExTrainer.Text = "Personal Trainer";
            // 
            // txtExTrainer
            // 
            this.txtExTrainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExTrainer.Location = new System.Drawing.Point(508, 485);
            this.txtExTrainer.Name = "txtExTrainer";
            this.txtExTrainer.ReadOnly = true;
            this.txtExTrainer.Size = new System.Drawing.Size(195, 21);
            this.txtExTrainer.TabIndex = 37;
            // 
            // txtPayment
            // 
            this.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(274, 625);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(195, 21);
            this.txtPayment.TabIndex = 43;
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Location = new System.Drawing.Point(271, 609);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(48, 13);
            this.lbPayment.TabIndex = 42;
            this.lbPayment.Text = "Payment";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(505, 609);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(123, 13);
            this.lbDate.TabIndex = 44;
            this.lbDate.Text = "Membership Registration";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(508, 625);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(195, 21);
            this.txtDate.TabIndex = 45;
            // 
            // txtNote
            // 
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(734, 440);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(276, 116);
            this.txtNote.TabIndex = 47;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(731, 424);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(30, 13);
            this.lbNote.TabIndex = 46;
            this.lbNote.Text = "Note";
            // 
            // frSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 687);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lbPayment);
            this.Controls.Add(this.txtExOnlineVideo);
            this.Controls.Add(this.txtExConsultation);
            this.Controls.Add(this.lbOnlineVideo);
            this.Controls.Add(this.lbExAccess);
            this.Controls.Add(this.txtExAccess);
            this.Controls.Add(this.lbExConsultation);
            this.Controls.Add(this.lbExTrainer);
            this.Controls.Add(this.txtExTrainer);
            this.Controls.Add(this.txtPaymentFrequency);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lbPaymentFrequency);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbMemType);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMemType);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbPaymentType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbMemDuration);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtMemDuration);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frSearch_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuPdfReport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripStatusLabel stLbStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel btnClear;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtMemType;
        private System.Windows.Forms.Label lbMemType;
        private System.Windows.Forms.TextBox txtMemDuration;
        private System.Windows.Forms.Label lbMemDuration;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lbPaymentType;
        private System.Windows.Forms.TextBox txtPaymentFrequency;
        private System.Windows.Forms.Label lbPaymentFrequency;
        private System.Windows.Forms.TextBox txtExOnlineVideo;
        private System.Windows.Forms.TextBox txtExConsultation;
        private System.Windows.Forms.Label lbOnlineVideo;
        private System.Windows.Forms.Label lbExAccess;
        private System.Windows.Forms.TextBox txtExAccess;
        private System.Windows.Forms.Label lbExConsultation;
        private System.Windows.Forms.Label lbExTrainer;
        private System.Windows.Forms.TextBox txtExTrainer;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.ToolStripStatusLabel stLbGridCount;
    }
}