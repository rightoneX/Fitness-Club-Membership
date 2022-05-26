namespace BIT502_Assessment3
{
    partial class frRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRegistration));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grMain = new System.Windows.Forms.GroupBox();
            this.lbRegularPayment = new System.Windows.Forms.Label();
            this.lbNetMembership = new System.Windows.Forms.Label();
            this.lbExtra = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbAlarmMessage = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grPaymentFrequency = new System.Windows.Forms.GroupBox();
            this.rdPaymentMonthly = new System.Windows.Forms.RadioButton();
            this.rdPaymentWeekly = new System.Windows.Forms.RadioButton();
            this.lbMembershipCost = new System.Windows.Forms.Label();
            this.grPaymentOption = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdPaymentCreditCard = new System.Windows.Forms.RadioButton();
            this.rdPaymentDirectDebit = new System.Windows.Forms.RadioButton();
            this.grDuration = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdDuration24 = new System.Windows.Forms.RadioButton();
            this.rdDuration12 = new System.Windows.Forms.RadioButton();
            this.rdDuration3 = new System.Windows.Forms.RadioButton();
            this.grMembership = new System.Windows.Forms.GroupBox();
            this.rdMembershipPremium = new System.Windows.Forms.RadioButton();
            this.rdMembershipRegular = new System.Windows.Forms.RadioButton();
            this.rdMembershipBasic = new System.Windows.Forms.RadioButton();
            this.grExtras = new System.Windows.Forms.GroupBox();
            this.chExtrasVideos = new System.Windows.Forms.CheckBox();
            this.chExtrasConsultation = new System.Windows.Forms.CheckBox();
            this.chExtrasTrainer = new System.Windows.Forms.CheckBox();
            this.chExtrasAccess = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkTerms = new System.Windows.Forms.LinkLabel();
            this.chTerms = new System.Windows.Forms.CheckBox();
            this.linkPrivacyPolicy = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.grMain.SuspendLayout();
            this.grPaymentFrequency.SuspendLayout();
            this.grPaymentOption.SuspendLayout();
            this.grDuration.SuspendLayout();
            this.grMembership.SuspendLayout();
            this.grExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(576, 642);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 33);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grMain
            // 
            this.grMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grMain.Controls.Add(this.pictureBox1);
            this.grMain.Controls.Add(this.lbRegularPayment);
            this.grMain.Controls.Add(this.lbNetMembership);
            this.grMain.Controls.Add(this.lbExtra);
            this.grMain.Controls.Add(this.lbDiscount);
            this.grMain.Controls.Add(this.lbAlarmMessage);
            this.grMain.Controls.Add(this.btnCalculate);
            this.grMain.Controls.Add(this.grPaymentFrequency);
            this.grMain.Controls.Add(this.lbMembershipCost);
            this.grMain.Controls.Add(this.grPaymentOption);
            this.grMain.Controls.Add(this.grDuration);
            this.grMain.Controls.Add(this.grMembership);
            this.grMain.Controls.Add(this.grExtras);
            this.grMain.Controls.Add(this.txtEmail);
            this.grMain.Controls.Add(this.lbEmail);
            this.grMain.Controls.Add(this.txtAddress);
            this.grMain.Controls.Add(this.lbAddress);
            this.grMain.Controls.Add(this.txtPhoneNumber);
            this.grMain.Controls.Add(this.lbPhoneNumber);
            this.grMain.Controls.Add(this.txtLastName);
            this.grMain.Controls.Add(this.lbLastName);
            this.grMain.Controls.Add(this.txtFirstName);
            this.grMain.Controls.Add(this.lbFirstName);
            this.grMain.Location = new System.Drawing.Point(29, 39);
            this.grMain.Name = "grMain";
            this.grMain.Size = new System.Drawing.Size(1000, 589);
            this.grMain.TabIndex = 2;
            this.grMain.TabStop = false;
            // 
            // lbRegularPayment
            // 
            this.lbRegularPayment.AutoSize = true;
            this.lbRegularPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegularPayment.Location = new System.Drawing.Point(651, 558);
            this.lbRegularPayment.Name = "lbRegularPayment";
            this.lbRegularPayment.Size = new System.Drawing.Size(131, 20);
            this.lbRegularPayment.TabIndex = 28;
            this.lbRegularPayment.Text = "Regular Payment";
            // 
            // lbNetMembership
            // 
            this.lbNetMembership.AutoSize = true;
            this.lbNetMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetMembership.Location = new System.Drawing.Point(390, 558);
            this.lbNetMembership.Name = "lbNetMembership";
            this.lbNetMembership.Size = new System.Drawing.Size(125, 20);
            this.lbNetMembership.TabIndex = 27;
            this.lbNetMembership.Text = "Net Membership";
            // 
            // lbExtra
            // 
            this.lbExtra.AutoSize = true;
            this.lbExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExtra.Location = new System.Drawing.Point(390, 530);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(46, 20);
            this.lbExtra.TabIndex = 26;
            this.lbExtra.Text = "Extra";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(651, 530);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(72, 20);
            this.lbDiscount.TabIndex = 24;
            this.lbDiscount.Text = "Discount";
            // 
            // lbAlarmMessage
            // 
            this.lbAlarmMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlarmMessage.ForeColor = System.Drawing.Color.Red;
            this.lbAlarmMessage.Location = new System.Drawing.Point(24, 452);
            this.lbAlarmMessage.Name = "lbAlarmMessage";
            this.lbAlarmMessage.Size = new System.Drawing.Size(348, 131);
            this.lbAlarmMessage.TabIndex = 25;
            this.lbAlarmMessage.Text = "* error message";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(857, 500);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 37);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grPaymentFrequency
            // 
            this.grPaymentFrequency.Controls.Add(this.rdPaymentMonthly);
            this.grPaymentFrequency.Controls.Add(this.rdPaymentWeekly);
            this.grPaymentFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPaymentFrequency.Location = new System.Drawing.Point(735, 203);
            this.grPaymentFrequency.Name = "grPaymentFrequency";
            this.grPaymentFrequency.Size = new System.Drawing.Size(240, 130);
            this.grPaymentFrequency.TabIndex = 22;
            this.grPaymentFrequency.TabStop = false;
            this.grPaymentFrequency.Text = "PAYMENT FREQUENCY";
            // 
            // rdPaymentMonthly
            // 
            this.rdPaymentMonthly.AutoSize = true;
            this.rdPaymentMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaymentMonthly.Location = new System.Drawing.Point(20, 92);
            this.rdPaymentMonthly.Name = "rdPaymentMonthly";
            this.rdPaymentMonthly.Size = new System.Drawing.Size(82, 24);
            this.rdPaymentMonthly.TabIndex = 3;
            this.rdPaymentMonthly.TabStop = true;
            this.rdPaymentMonthly.Text = "Monthly";
            this.rdPaymentMonthly.UseVisualStyleBackColor = true;
            // 
            // rdPaymentWeekly
            // 
            this.rdPaymentWeekly.AutoSize = true;
            this.rdPaymentWeekly.Checked = true;
            this.rdPaymentWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaymentWeekly.Location = new System.Drawing.Point(20, 47);
            this.rdPaymentWeekly.Name = "rdPaymentWeekly";
            this.rdPaymentWeekly.Size = new System.Drawing.Size(78, 24);
            this.rdPaymentWeekly.TabIndex = 2;
            this.rdPaymentWeekly.TabStop = true;
            this.rdPaymentWeekly.Text = "Weekly";
            this.rdPaymentWeekly.UseVisualStyleBackColor = true;
            // 
            // lbMembershipCost
            // 
            this.lbMembershipCost.AutoSize = true;
            this.lbMembershipCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembershipCost.Location = new System.Drawing.Point(390, 500);
            this.lbMembershipCost.Name = "lbMembershipCost";
            this.lbMembershipCost.Size = new System.Drawing.Size(133, 20);
            this.lbMembershipCost.TabIndex = 23;
            this.lbMembershipCost.Text = "Membership Cost";
            // 
            // grPaymentOption
            // 
            this.grPaymentOption.Controls.Add(this.label9);
            this.grPaymentOption.Controls.Add(this.rdPaymentCreditCard);
            this.grPaymentOption.Controls.Add(this.rdPaymentDirectDebit);
            this.grPaymentOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPaymentOption.Location = new System.Drawing.Point(472, 203);
            this.grPaymentOption.Name = "grPaymentOption";
            this.grPaymentOption.Size = new System.Drawing.Size(240, 130);
            this.grPaymentOption.TabIndex = 21;
            this.grPaymentOption.TabStop = false;
            this.grPaymentOption.Text = "PAYMENT OPTION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(128, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "(1% discount)";
            // 
            // rdPaymentCreditCard
            // 
            this.rdPaymentCreditCard.AutoSize = true;
            this.rdPaymentCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaymentCreditCard.Location = new System.Drawing.Point(20, 92);
            this.rdPaymentCreditCard.Name = "rdPaymentCreditCard";
            this.rdPaymentCreditCard.Size = new System.Drawing.Size(107, 24);
            this.rdPaymentCreditCard.TabIndex = 3;
            this.rdPaymentCreditCard.TabStop = true;
            this.rdPaymentCreditCard.Text = "Credit Card";
            this.rdPaymentCreditCard.UseVisualStyleBackColor = true;
            // 
            // rdPaymentDirectDebit
            // 
            this.rdPaymentDirectDebit.AutoSize = true;
            this.rdPaymentDirectDebit.Checked = true;
            this.rdPaymentDirectDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPaymentDirectDebit.Location = new System.Drawing.Point(20, 47);
            this.rdPaymentDirectDebit.Name = "rdPaymentDirectDebit";
            this.rdPaymentDirectDebit.Size = new System.Drawing.Size(111, 24);
            this.rdPaymentDirectDebit.TabIndex = 2;
            this.rdPaymentDirectDebit.TabStop = true;
            this.rdPaymentDirectDebit.Text = "Direct Debit";
            this.rdPaymentDirectDebit.UseVisualStyleBackColor = true;
            // 
            // grDuration
            // 
            this.grDuration.Controls.Add(this.label8);
            this.grDuration.Controls.Add(this.label7);
            this.grDuration.Controls.Add(this.rdDuration24);
            this.grDuration.Controls.Add(this.rdDuration12);
            this.grDuration.Controls.Add(this.rdDuration3);
            this.grDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDuration.Location = new System.Drawing.Point(735, 13);
            this.grDuration.Name = "grDuration";
            this.grDuration.Size = new System.Drawing.Size(240, 176);
            this.grDuration.TabIndex = 18;
            this.grDuration.TabStop = false;
            this.grDuration.Text = "DURATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(118, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "(save $2 p.w.)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(118, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "(save $5 p.w.)";
            // 
            // rdDuration24
            // 
            this.rdDuration24.AutoSize = true;
            this.rdDuration24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDuration24.Location = new System.Drawing.Point(20, 135);
            this.rdDuration24.Name = "rdDuration24";
            this.rdDuration24.Size = new System.Drawing.Size(102, 24);
            this.rdDuration24.TabIndex = 4;
            this.rdDuration24.TabStop = true;
            this.rdDuration24.Text = "24 months";
            this.rdDuration24.UseVisualStyleBackColor = true;
            // 
            // rdDuration12
            // 
            this.rdDuration12.AutoSize = true;
            this.rdDuration12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDuration12.Location = new System.Drawing.Point(20, 92);
            this.rdDuration12.Name = "rdDuration12";
            this.rdDuration12.Size = new System.Drawing.Size(102, 24);
            this.rdDuration12.TabIndex = 3;
            this.rdDuration12.TabStop = true;
            this.rdDuration12.Text = "12 months";
            this.rdDuration12.UseVisualStyleBackColor = true;
            // 
            // rdDuration3
            // 
            this.rdDuration3.AutoSize = true;
            this.rdDuration3.Checked = true;
            this.rdDuration3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDuration3.Location = new System.Drawing.Point(20, 47);
            this.rdDuration3.Name = "rdDuration3";
            this.rdDuration3.Size = new System.Drawing.Size(93, 24);
            this.rdDuration3.TabIndex = 2;
            this.rdDuration3.TabStop = true;
            this.rdDuration3.Text = "3 months";
            this.rdDuration3.UseVisualStyleBackColor = true;
            // 
            // grMembership
            // 
            this.grMembership.Controls.Add(this.rdMembershipPremium);
            this.grMembership.Controls.Add(this.rdMembershipRegular);
            this.grMembership.Controls.Add(this.rdMembershipBasic);
            this.grMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grMembership.Location = new System.Drawing.Point(472, 13);
            this.grMembership.Name = "grMembership";
            this.grMembership.Size = new System.Drawing.Size(240, 176);
            this.grMembership.TabIndex = 17;
            this.grMembership.TabStop = false;
            this.grMembership.Text = "MEMBERSHIP TYPE";
            // 
            // rdMembershipPremium
            // 
            this.rdMembershipPremium.AutoSize = true;
            this.rdMembershipPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMembershipPremium.Location = new System.Drawing.Point(20, 135);
            this.rdMembershipPremium.Name = "rdMembershipPremium";
            this.rdMembershipPremium.Size = new System.Drawing.Size(162, 24);
            this.rdMembershipPremium.TabIndex = 4;
            this.rdMembershipPremium.Text = "Premium ($20 p.w.)";
            this.rdMembershipPremium.UseVisualStyleBackColor = true;
            // 
            // rdMembershipRegular
            // 
            this.rdMembershipRegular.AutoSize = true;
            this.rdMembershipRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMembershipRegular.Location = new System.Drawing.Point(20, 92);
            this.rdMembershipRegular.Name = "rdMembershipRegular";
            this.rdMembershipRegular.Size = new System.Drawing.Size(156, 24);
            this.rdMembershipRegular.TabIndex = 3;
            this.rdMembershipRegular.Text = "Regular ($15 p.w.)";
            this.rdMembershipRegular.UseVisualStyleBackColor = true;
            // 
            // rdMembershipBasic
            // 
            this.rdMembershipBasic.AutoSize = true;
            this.rdMembershipBasic.Checked = true;
            this.rdMembershipBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMembershipBasic.Location = new System.Drawing.Point(20, 47);
            this.rdMembershipBasic.Name = "rdMembershipBasic";
            this.rdMembershipBasic.Size = new System.Drawing.Size(139, 24);
            this.rdMembershipBasic.TabIndex = 2;
            this.rdMembershipBasic.TabStop = true;
            this.rdMembershipBasic.Text = "Basic ($10 p.w.)";
            this.rdMembershipBasic.UseVisualStyleBackColor = true;
            // 
            // grExtras
            // 
            this.grExtras.Controls.Add(this.chExtrasVideos);
            this.grExtras.Controls.Add(this.chExtrasConsultation);
            this.grExtras.Controls.Add(this.chExtrasTrainer);
            this.grExtras.Controls.Add(this.chExtrasAccess);
            this.grExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grExtras.Location = new System.Drawing.Point(472, 348);
            this.grExtras.Name = "grExtras";
            this.grExtras.Size = new System.Drawing.Size(503, 139);
            this.grExtras.TabIndex = 18;
            this.grExtras.TabStop = false;
            this.grExtras.Text = "EXTRAS";
            // 
            // chExtrasVideos
            // 
            this.chExtrasVideos.AutoSize = true;
            this.chExtrasVideos.Location = new System.Drawing.Point(247, 92);
            this.chExtrasVideos.Name = "chExtrasVideos";
            this.chExtrasVideos.Size = new System.Drawing.Size(246, 24);
            this.chExtrasVideos.TabIndex = 4;
            this.chExtrasVideos.Text = "Online Fitness Videos ($2 p.w.)";
            this.chExtrasVideos.UseVisualStyleBackColor = true;
            // 
            // chExtrasConsultation
            // 
            this.chExtrasConsultation.AutoSize = true;
            this.chExtrasConsultation.Location = new System.Drawing.Point(247, 48);
            this.chExtrasConsultation.Name = "chExtrasConsultation";
            this.chExtrasConsultation.Size = new System.Drawing.Size(223, 24);
            this.chExtrasConsultation.TabIndex = 3;
            this.chExtrasConsultation.Text = "Diet Consultation ($20 p.w.)";
            this.chExtrasConsultation.UseVisualStyleBackColor = true;
            // 
            // chExtrasTrainer
            // 
            this.chExtrasTrainer.AutoSize = true;
            this.chExtrasTrainer.Location = new System.Drawing.Point(19, 92);
            this.chExtrasTrainer.Name = "chExtrasTrainer";
            this.chExtrasTrainer.Size = new System.Drawing.Size(216, 24);
            this.chExtrasTrainer.TabIndex = 2;
            this.chExtrasTrainer.Text = "Personal Trainer ($20 p.w.)";
            this.chExtrasTrainer.UseVisualStyleBackColor = true;
            // 
            // chExtrasAccess
            // 
            this.chExtrasAccess.AutoSize = true;
            this.chExtrasAccess.Location = new System.Drawing.Point(19, 48);
            this.chExtrasAccess.Name = "chExtrasAccess";
            this.chExtrasAccess.Size = new System.Drawing.Size(179, 24);
            this.chExtrasAccess.TabIndex = 1;
            this.chExtrasAccess.Text = "24/7 Access ($1 p.w.)";
            this.chExtrasAccess.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(28, 418);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(24, 395);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 20);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(28, 353);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(290, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(24, 330);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(68, 20);
            this.lbAddress.TabIndex = 12;
            this.lbAddress.Text = "Address";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(28, 288);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(290, 26);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(24, 265);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lbPhoneNumber.TabIndex = 10;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(28, 226);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(290, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(24, 203);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(86, 20);
            this.lbLastName.TabIndex = 8;
            this.lbLastName.Text = "Last Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 127);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(28, 163);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(24, 140);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(86, 20);
            this.lbFirstName.TabIndex = 3;
            this.lbFirstName.Text = "First Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(357, -2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(420, 39);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Member Registration Form";
            // 
            // linkTerms
            // 
            this.linkTerms.AutoSize = true;
            this.linkTerms.BackColor = System.Drawing.Color.Transparent;
            this.linkTerms.Location = new System.Drawing.Point(459, 654);
            this.linkTerms.Name = "linkTerms";
            this.linkTerms.Size = new System.Drawing.Size(109, 13);
            this.linkTerms.TabIndex = 6;
            this.linkTerms.TabStop = true;
            this.linkTerms.Text = "Terms and Conditions";
            this.linkTerms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTerms_LinkClicked);
            // 
            // chTerms
            // 
            this.chTerms.AutoSize = true;
            this.chTerms.BackColor = System.Drawing.Color.Transparent;
            this.chTerms.Location = new System.Drawing.Point(290, 652);
            this.chTerms.Name = "chTerms";
            this.chTerms.Size = new System.Drawing.Size(176, 17);
            this.chTerms.TabIndex = 6;
            this.chTerms.Text = "By clicking this box I accept the";
            this.chTerms.UseVisualStyleBackColor = false;
            // 
            // linkPrivacyPolicy
            // 
            this.linkPrivacyPolicy.AutoSize = true;
            this.linkPrivacyPolicy.BackColor = System.Drawing.Color.Transparent;
            this.linkPrivacyPolicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrivacyPolicy.Location = new System.Drawing.Point(61, 649);
            this.linkPrivacyPolicy.Name = "linkPrivacyPolicy";
            this.linkPrivacyPolicy.Size = new System.Drawing.Size(115, 16);
            this.linkPrivacyPolicy.TabIndex = 8;
            this.linkPrivacyPolicy.TabStop = true;
            this.linkPrivacyPolicy.Text = "PRIVACY POLICY";
            this.linkPrivacyPolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrivacyPolicy_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(910, 642);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 33);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Main Menu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1059, 687);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkPrivacyPolicy);
            this.Controls.Add(this.linkTerms);
            this.Controls.Add(this.grMain);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.chTerms);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Registration Form";
            this.grMain.ResumeLayout(false);
            this.grMain.PerformLayout();
            this.grPaymentFrequency.ResumeLayout(false);
            this.grPaymentFrequency.PerformLayout();
            this.grPaymentOption.ResumeLayout(false);
            this.grPaymentOption.PerformLayout();
            this.grDuration.ResumeLayout(false);
            this.grDuration.PerformLayout();
            this.grMembership.ResumeLayout(false);
            this.grMembership.PerformLayout();
            this.grExtras.ResumeLayout(false);
            this.grExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grMain;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.LinkLabel linkTerms;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chTerms;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.GroupBox grMembership;
        private System.Windows.Forms.GroupBox grExtras;
        private System.Windows.Forms.CheckBox chExtrasVideos;
        private System.Windows.Forms.CheckBox chExtrasConsultation;
        private System.Windows.Forms.CheckBox chExtrasTrainer;
        private System.Windows.Forms.CheckBox chExtrasAccess;
        private System.Windows.Forms.RadioButton rdMembershipPremium;
        private System.Windows.Forms.RadioButton rdMembershipRegular;
        private System.Windows.Forms.RadioButton rdMembershipBasic;
        private System.Windows.Forms.GroupBox grDuration;
        private System.Windows.Forms.RadioButton rdDuration24;
        private System.Windows.Forms.RadioButton rdDuration12;
        private System.Windows.Forms.RadioButton rdDuration3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grPaymentFrequency;
        private System.Windows.Forms.RadioButton rdPaymentMonthly;
        private System.Windows.Forms.RadioButton rdPaymentWeekly;
        private System.Windows.Forms.GroupBox grPaymentOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdPaymentCreditCard;
        private System.Windows.Forms.RadioButton rdPaymentDirectDebit;
        private System.Windows.Forms.LinkLabel linkPrivacyPolicy;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbMembershipCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbAlarmMessage;
        private System.Windows.Forms.Label lbExtra;
        private System.Windows.Forms.Label lbNetMembership;
        private System.Windows.Forms.Label lbRegularPayment;
        private System.Windows.Forms.Button btnClose;
    }
}

