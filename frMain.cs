using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace BIT502_Assessment3
{
    public partial class frMain : Form
    {
        /*
         * 
         * 
         * Note
         * database locations must be setup in <App.Config> file
         * current location is set: "C:\\Users\\admin\\Source\\Repos\\BIT502_Assessment3\\db\\city_gym_db.mdb"
         * 
         */
        public frMain()
        {
            InitializeComponent();
            lbError.Visible = false; // hide the error text filed
        }

        private void btnSeachForm_Click(object sender, EventArgs e) // display the search form
        {
            new frSearch().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) // leave the application
        {
            Application.Exit(); 
        }

        private void btnNewMemberForm_Click(object sender, EventArgs e) // display the new member reistration form
        {   
            new frRegistration().ShowDialog();
        }

        private void frMain_Load(object sender, EventArgs e) // check the database connection on the load
        {
            try // check if the app has access to the database
            {
                stBar.Text = "Total Members: " + TableRowCount("Member"); // display table row quantity in the status bar
            }
            catch (Exception ex)
            {
                lbError.Visible = true; // display the error message if any problem
                lbError.Text = "Database Error >> " + ex.Message; // display the message
                btnBookingForm.Enabled = false; // disable the button
                btnNewMemberForm.Enabled = false; // disable the button
                btnSeachForm.Enabled = false; // disable the button
            }
        }

        public static string TableRowCount(String tableName) // returns the table row count
        {     
            DataTable results = SqlExecution("SELECT COUNT("+tableName+"ID) FROM " + tableName); // get the qty of rows in the db
             // converting datatable to string and display the total qty of records
            return string.Join(Environment.NewLine, results.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
        }

        private void btnBookingForm_Click(object sender, EventArgs e) // display the new member reistration form
        {      
            new frBooking().ShowDialog(); 
        }

        public static DataTable SqlExecution(string sqlCmd) // SqlExecution 
        {
                DataTable dtMembers = new DataTable();
                string connString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
                using (OleDbConnection con = new OleDbConnection(connString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sqlCmd, con))
                    {
                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dtMembers.Load(reader);
                        con.Close();
                    }
                }
            return dtMembers;
        }     
    }

}
