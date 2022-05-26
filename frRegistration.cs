using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;
using System.Data.OleDb;

namespace BIT502_Assessment3
{
    public partial class frRegistration : Form
    {
        // diclear global values
        // member details 
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string address;
        public string email;
        // membership details
        public string membershipType;
        public string paymentOption;
        public string paymentFrequency;
        public string duration;
        public bool access;
        public bool personalTrainer;
        public bool dietConsultation;
        public bool onlineVideos;
        // payment values
        public decimal baseCost; // membership cost(e.g., $10, $15 or $20)
        public decimal totalDiscount; // total discount applied(duration discount + direct debit discount)
        public decimal totalExtras; // total of all selected extras(e.g., 24/7, PT)
        public decimal netCost; // net membership cost(base - discount + extras)
        public decimal regularPayment; // regular payment amount(net or net* 4 if monthly payment selected)
        // path to storage folder

        public frRegistration()
        {
            InitializeComponent();    
            ResetForm(); // set default component visibility      
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
            PaymentCalculator(); // recall calculation subroutine when user activates the calculate button
        }

        public void PaymentCalculator()
        {
            // reset calculated settings
            decimal durationDiscount = 0;
            decimal debitDiscount = 0;
            totalExtras = 0;
            baseCost = 0;
            totalDiscount = 0;
            netCost = 0;
            regularPayment = 0; 
            access = false;          // "24/7 Access";
            personalTrainer = false; // "Personal Trainer";
            dietConsultation = false;// "Diet Consultation";
            onlineVideos = false;    // online Videos
   
            if (rdMembershipBasic.Checked == Enabled) // membership selection
            {
                membershipType = "Basic";
                baseCost = 10;
            } else if (rdMembershipRegular.Checked == Enabled)
            {
                membershipType = "Regular";
                baseCost = 15;
            }
            else if (rdMembershipPremium.Checked == Enabled)
            {
                membershipType = "Premium";
                baseCost = 20;
            }
         
            if (chExtrasAccess.Checked == Enabled) // extras selection
            {
                access = true;  // 24/7 Access
                totalExtras += 1;  // add $1
            }
            if (chExtrasTrainer.Checked == Enabled)
            {
                personalTrainer = true; // Personal Trainer
                totalExtras += 20; // add $20
            }
            if (chExtrasConsultation.Checked == Enabled)
            {
                dietConsultation = true; // Diet Consultation
                totalExtras += 20; // add $20
            }
            if (chExtrasVideos.Checked == Enabled)
            {
                onlineVideos = true;   // Online Fitness Videos
                totalExtras += 2; // add $2
            }
       
            if (rdDuration3.Checked == Enabled) // membership duratin selection
            {
                duration = "3 months";
                durationDiscount = 0; // discount of $0 p.w.
            }
            else if (rdDuration12.Checked == Enabled)
            {
                duration = "12 months";
                durationDiscount = 2; // discount of $2 p.w.
            }
            else if (rdDuration24.Checked == Enabled)
            {
                duration = "24 months"; 
                durationDiscount = 5; //discount of $5 p.w.
            }
     
            if (rdPaymentDirectDebit.Checked == Enabled) // payment option selection
            {
                paymentOption = "Direct Debit";
                debitDiscount = (baseCost / 100);  // discount 1% apply
            }
            if (rdPaymentCreditCard.Checked == Enabled)
            {
                paymentOption = "Credit Card";
            }

            totalDiscount = (durationDiscount + debitDiscount);           
            netCost = baseCost - totalDiscount + totalExtras; // net membership cost (base - discount + extras)
         
            if (rdPaymentWeekly.Checked == Enabled) // payment frequency selection
            {
                paymentFrequency = "Weekly";
                regularPayment = netCost;
            }
            else if (rdPaymentMonthly.Checked == Enabled)
            {
                paymentFrequency = "Monthly";
                regularPayment = netCost * 4;
            }         
            
            //make the payment value visible
            lbMembershipCost.Visible = true;
            lbDiscount.Visible = true;
            lbExtra.Visible = true;
            lbNetMembership.Visible = true;
            lbRegularPayment.Visible = true;

            //show the payment value to the user
            lbMembershipCost.Text = "Membership Cost $" + baseCost + " p.w."; // base membership cost (e.g., $10, $15 or $20)
            lbDiscount.Text = "Total Discount $" + totalDiscount + " p.w."; // total discount applied (duration discount + direct debit discount)
            lbExtra.Text = "Total of Extras $" + totalExtras + " p.w."; // totalExtras; o total of all selected extras (e.g., 24/7, PT)
            lbNetMembership.Text = "Net Membership Cost $" + netCost + " p.w."; // net membership cost (base - discount + extras)
            lbRegularPayment.Text = "Regular " + paymentFrequency + " Payment $" + regularPayment; // regular payment amount (net or net * 4 if monthly payment selected)
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {        
            if (CheckEntry()) //check if user filled information correctly
            {            
                PaymentCalculator(); // calculat payment if the user did not use the button "calculate" on the form
                SaveUser(); // saving user data to the database              
                ResetForm(); // clean the form for new membership                
                MessageBox.Show("Thank You To Join Our Club!"); //inform the usert that form had been submited
            }
        }

        public bool CheckEntry()
        {
            //set default settings for message fields 
            string alertMessage = "";
            lbAlarmMessage.Text = "";
            lbAlarmMessage.Visible = false;
            lbFirstName.ForeColor = Color.Black;
            lbLastName.ForeColor = Color.Black;
            lbPhoneNumber.ForeColor = Color.Black;
            lbAddress.ForeColor = Color.Black;
            lbEmail.ForeColor = Color.Black;
            chTerms.ForeColor = Color.Black;
        
            if(txtFirstName.Text.Any(c => char.IsDigit(c)) || txtFirstName.TextLength < 2) // check first name entry for numbers and length
            {
                lbFirstName.ForeColor = Color.Red;
                alertMessage += "*Please check your first name\r\n";
            }           
            if (txtLastName.Text.Any(c => char.IsDigit(c)) || txtLastName.TextLength < 2) // check last name entry for numbers and length
            {
                lbLastName.ForeColor = Color.Red;
                alertMessage += "*Please check your last name\r\n";
            }
            if (!int.TryParse(txtPhoneNumber.Text, out int number)) // check phone number entry
            {
                lbPhoneNumber.ForeColor = Color.Red;
                alertMessage += "*Please enter your phone number\r\n";
            }          
            if (String.IsNullOrEmpty(txtAddress.Text)) // check address entry
            {
                lbAddress.ForeColor = Color.Red;
                alertMessage += "*Please enter your address\r\n";
            }           
            if (!IsValidEmail(txtEmail.Text)) // check if user enter email address
            {
                lbEmail.ForeColor = Color.Red;
                alertMessage += "*Please check your email entered correctly\r\n";
            }     
            if (!chTerms.Checked) // check if user accepts the terms and conditions
            {
                chTerms.ForeColor = Color.Red;
                alertMessage += "*Please accept our Terms and Contidions\r\n";
            }            
            if (alertMessage != "") // check if any error need to be showed for a user
            {
                lbAlarmMessage.Visible = true;
                lbAlarmMessage.Text = alertMessage;
                return false; // the user needs to check the entry 
            }
            // prepare data for to the database
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            phoneNumber = txtPhoneNumber.Text;
            address = txtAddress.Text;
            email = txtEmail.Text;
            return true; // all data ware filled correctly
        }

        public static bool IsValidEmail(string email)
        {   
            if (string.IsNullOrWhiteSpace(email)) // check if any space in the email
                return false;

            try
            {
                
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,  
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200)); // normalise the domain
                
                string DomainMapper(Match match) // examines the domain part of the email and normalises it
                {                   
                    var idn = new IdnMapping(); // use IdnMapping class to convert Unicode domain names     
                    string domainName = idn.GetAscii(match.Groups[2].Value); // pull out and process domain name (throws ArgumentException on invalid)
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public void ResetForm()
        {   //reset the form for new member
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            lbAlarmMessage.Visible = false;
            rdMembershipBasic.Checked = true;
            rdDuration3.Checked = true;
            rdPaymentDirectDebit.Checked = true;
            rdPaymentWeekly.Checked = true;
            chExtrasAccess.Checked = false;
            chExtrasConsultation.Checked = false;
            chExtrasTrainer.Checked = false;
            chExtrasVideos.Checked = false;
            lbMembershipCost.Text = "";
            lbMembershipCost.Visible = false;
            lbRegularPayment.Text = "";
            lbRegularPayment.Visible = false;
            lbMembershipCost.Text = "";
            lbDiscount.Visible = false;
            lbNetMembership.Text = "";
            lbNetMembership.Visible = false;
            lbDiscount.Text = "";
            lbExtra.Visible = false;
            lbExtra.Text = "";
            chTerms.Checked = false;
        }

        public void SaveUser() // seve user data to database
        {   
            DateTime currentDate = DateTime.Now; // get the current date, will be used in the name of the file

            try
            {
                DateTime currentDateTime = DateTime.Now; // get the current date, will be used in the name of the file  currentDateTime.ToString("dd/MM/yyyy")
                string sqlCmd = "INSERT INTO Member ([FirstName], [LastName], [Address], [Phone], [Email], [Date], [MemType], [MemDuration], [PaymentType], [PaymentFrequency], [ExAccess], [ExTrainer], [ExConsultation], [ExOnlineVideo], [TotalPayment]) VALUES" +
                                "('" + firstName 
                                + "','" + lastName
                                + "','" + address
                                + "','" + phoneNumber
                                + "','" + email
                                + "'," + currentDate.ToString("dd/MM/yyyy")
                                + ",'" + membershipType
                                + "','" + duration
                                + "','" + paymentOption
                                + "','" + paymentFrequency
                                + "'," + access
                                + "," + personalTrainer
                                + "," + dietConsultation
                                + "," + onlineVideos
                                + "," + regularPayment + ")";
                frMain.SqlExecution(sqlCmd); // excecute the sql command
            }
            catch (Exception ex)
            {               
                MessageBox.Show("The user data can not be saved to the database!" + ex.Message); // file can not be saved
            }
        }

        private void linkPrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // privacy message
        {   
            MessageBox.Show("City Gym is committed to protecting its customers' personal information.\r\n" +
                            "This Privacy Policy sets out how we collect, use and protect " +
                            "your information when you visit any of the websites we own or operate" +
                            " or use any apps, products or services which we provide (for the purposes " +
                            "of this policy, we'll just call them our 'services'). " +
                            "We may need to update this policy from time to time, " +
                            "including when necessary to reflect changes to our services or changes in law." +
                            "When we update this policy, we will revise the 'Last updated' at the top of " +
                            "the policy. Where the changes are material, we will use reasonable endeavours" +
                            " notify you – usually by prominently posting a notice of those changes" +
                            " on our website or by sending you an email.", "Privacy Policy");
        }

        private void linkTerms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // terms & conditions message
        {  
            MessageBox.Show("These conditions of use set out the terms between you and us" +
                            " under which you may access our City Gym , " +
                            "any social networking sites (eg Facebook or Twitter) " +
                            "or apps (our sites). These conditions of use apply to all users of," +
                            " and visitors to, any of our sites. Your use of any of our sites " +
                            "means that you accept, and agree to abide by, all the policies" +
                            " in our conditions of use.Our sites are operated by or " +
                            "for City Gym on behalf of City Gym in New Zealand." +
                            "They are subject to New Zealand law.", "Terms and Conditions");
        }

        private void btnClose_Click(object sender, EventArgs e) // close the form
        {
            this.Close();
        }

    }
}
