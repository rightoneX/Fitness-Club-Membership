using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT502_Assessment3
{
    public partial class frBooking : Form
    {
        public frBooking()
        {
            InitializeComponent();
        }

        private void frBooking_Load(object sender, EventArgs e) // set the form
        {
            memberDataGridView.DataSource = frMain.SqlExecution("SELECT * FROM Member"); // fill the grid with data of member table
            classDataGridView.DataSource = frMain.SqlExecution("SELECT * FROM Class"); // fill the grid with data of class table
            MemberClassTable(CurrentTableID(memberDataGridView)); // fill up the member class current data grid view
            SetFormatting(); // set dataGridView look
            stLbStatusMember.Text = "Total Members: " + frMain.TableRowCount("Member");  // display table row quantity in the status bar
            stLbStatusClass.Text = " | Classes: " + frMain.TableRowCount("Class");  // display table row quantity in the status bar
            stLbStatusSearch.Text = "  |  Searched Records: ";
        }

        private void btnClose_Click(object sender, EventArgs e) // Close the form
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)  // search the member in database and display in dataGrid
        {
            try // check if the user enter not valid entry
            {
                string searchText = txtSearch.Text; // TODO protaction from sql injection 

            string outputSearch = "SELECT * FROM Member WHERE "; // search string 
            outputSearch += "MemberID LIKE '%" + searchText + "%' ";
            outputSearch += "OR [FirstName] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [LastName] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [Address] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [Email] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [Note] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [MemType] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [MemDuration] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [PaymentType] LIKE '%" + searchText + "%' ";
            outputSearch += "OR [PaymentFrequency] LIKE '%" + searchText + "%' ";

            memberDataGridView.DataSource = frMain.SqlExecution(outputSearch); // fill the grid with data searched data

            stLbStatusSearch.Text = "  |  Searched Records: " + memberDataGridView.Rows.Count.ToString(); // update status search information
            }
            catch
            {
                stLbStatusSearch.Text = "  |  Searched Records: Entry Error! Please correct your search entry";
            }
        }

        private void memberDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; // get the order of the current row 
            DataGridViewRow row = memberDataGridView.Rows[rowIndex]; // store the value of the current row in a variable

            // Display member information in the user fileds
            lbID.Text = "ID: " + row.Cells[0].Value.ToString(); // display the current member id
            lbFirstName.Text = "First Name: " + row.Cells[1].Value.ToString(); // display the current member data
            lbLastName.Text = "Last Name: " + row.Cells[2].Value.ToString(); // display the current member data

            MemberClassTable(row.Cells[0].Value.ToString()); // fill up the member class data grid view
        }

        private void btnBook_Click(object sender, EventArgs e) // book the class to selected member
        {
            DateTime currentDateTime = DateTime.Now; // get the current date, will be used in the name of the file  currentDateTime.ToString("dd/MM/yyyy")
            string sqlCmd = "INSERT INTO MemberClass ([MemberID], [ClassID], [Date]) VALUES" +
                            "(" + CurrentTableID(memberDataGridView) // get member table id
                            + "," 
                            + CurrentTableID(classDataGridView) // get class table id
                            + ","
                            + currentDateTime.ToString("dd/MM/yyyy") + ")";

            frMain.SqlExecution(sqlCmd); // excecute the sql command

            MemberClassTable(CurrentTableID(memberDataGridView)); // fill up the member class current data grid view
        }

        private void MemberClassTable(String memberID) // fill up the member class table 
        {
            // Display all member classes in the currentClassDataGrid
            DataTable currentClasses = new DataTable(); // setup current Calsses table and search the classes for slected member.
            // fill table  with the class redords of this member
            currentClasses = frMain.SqlExecution("SELECT * FROM MemberClass WHERE MemberID = " + memberID);

            string sqlCmd = "";
            for (int i = 0; i < currentClasses.Rows.Count; i++) // get the classess id to search them in class table
            {
                sqlCmd += currentClasses.Rows[i].ItemArray[1].ToString() + ", "; // get all class id's for this member
            }

            if (sqlCmd != "") // check if we have matching classes for this member, other way to clean the output
            {
                currentClassDataGridView.DataSource = frMain.SqlExecution("SELECT * FROM Class WHERE ClassID in(" + sqlCmd + ")");
                currentClassDataGridView.AllowUserToAddRows = false;
                currentClassDataGridView.Columns[3].DefaultCellStyle.Format = "HH:mm";
                currentClassDataGridView.Columns[4].DefaultCellStyle.Format = "HH:mm";
                btnRemoveClass.Enabled = true; // enable the booking button
            }
            else
            {
                currentClassDataGridView.DataSource = null; // display nothing if no classes for this member
                btnRemoveClass.Enabled = false; // no entry, disable the booking button
            }
        }

        private static String CurrentTableID(DataGridView currentTable) // get the selected id of the record     
        {
                int rowIndex = currentTable.CurrentCell.RowIndex;
                int columnIndex = currentTable.CurrentCell.ColumnIndex;
                return currentTable.Rows[rowIndex].Cells[columnIndex].Value.ToString(); // returns current table id
        }

        private void SetFormatting() // format member and class dataGridViews 
            {
                memberDataGridView.AllowUserToAddRows = false; // removing empty filed on the bottom
                classDataGridView.AllowUserToAddRows = false;
                classDataGridView.Columns[3].DefaultCellStyle.Format = "HH:mm"; // display time in the cell 
                classDataGridView.Columns[4].DefaultCellStyle.Format = "HH:mm";
            }

        private void btnRemoveClass_Click(object sender, EventArgs e) // unbook the member from a class
        {
            string sqlCmd = "DELETE FROM MemberClass WHERE MemberID = "
                             + CurrentTableID(memberDataGridView) // get the current member table id
                             + " AND ClassID = "
                             + CurrentTableID(currentClassDataGridView); // get the selected table idmemberClassTableID;
            if (memberDataGridView != null || currentClassDataGridView != null) // check if we have all data
            {
                frMain.SqlExecution(sqlCmd); // excecute the sql command
            } 
            MemberClassTable(CurrentTableID(memberDataGridView)); // fill up the member class current data grid view
        }


    }
}
