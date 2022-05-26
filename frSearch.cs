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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace BIT502_Assessment3
{
    public partial class frSearch : Form
    {

        public frSearch()
        {
            InitializeComponent();
        }

        private void frSearch_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = frMain.SqlExecution("SELECT * FROM Member"); // file the grid with data
            stLbStatus.Text = "Total Members: " + frMain.TableRowCount("Member");  // display table row quantity in the status bar
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) // when user types in the search field, fill the grid
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

                dataGridView.DataSource = frMain.SqlExecution(outputSearch); // file the grid with data 

                stLbGridCount.Text = "  |  Searched Records: " + dataGridView.Rows.Count.ToString();
            }
            catch
            {
                stLbGridCount.Text = "  |  Searched Records: Entry Error! Please correct your search entry";
            }
        }

        private void btnClose_Click(object sender, EventArgs e) // close the form 
        {
            this.Close();
        }

        private void btnClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // clear the search entry 
        {
            txtSearch.Text = "";
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) // display the current member data
        {
            int rowIndex = e.RowIndex; // get the order of the current row 
            DataGridViewRow row = dataGridView.Rows[rowIndex]; // store the value of the current row in a variable

            txtName.Text = row.Cells[1].Value.ToString(); // display the current member data
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtAddress.Text = row.Cells[3].Value.ToString();
            txtPhone.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtDate.Text = row.Cells[6].Value.ToString();
            txtMemType.Text = row.Cells[7].Value.ToString();
            txtMemDuration.Text = row.Cells[8].Value.ToString();
            txtPaymentType.Text = row.Cells[9].Value.ToString();
            txtPaymentFrequency.Text = row.Cells[10].Value.ToString();
            if (row.Cells[11].Value.ToString() == "True") { txtExAccess.Text = "Yes"; } else { txtExAccess.Text = ""; }
            if (row.Cells[12].Value.ToString() == "True") { txtExTrainer.Text = "Yes"; } else { txtExTrainer.Text = ""; }
            if (row.Cells[13].Value.ToString() == "True") { txtExConsultation.Text = "Yes"; } else { txtExConsultation.Text = ""; }
            if (row.Cells[14].Value.ToString() == "True") { txtExOnlineVideo.Text = "Yes"; } else { txtExOnlineVideo.Text = ""; }
            txtPayment.Text = "$" + row.Cells[15].Value.ToString();
            txtNote.Text = row.Cells[16].Value.ToString();
        }

        private void menuPdfReport_Click(object sender, EventArgs e) // print tabledata to pdf file, used external library iTextSharp 
        { // please install "iTextSharp" library before use this code
            if (dataGridView.Rows.Count > 0) // check if data exist
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf"; // file format
                sfd.FileName = "Output.pdf"; // default file name
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName)) // check if the file exist already
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError) // check if the file can be saved to the destination
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100; // percentage space on page
                            pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;

                              foreach (DataGridViewColumn column in dataGridView.Columns) // read all columns 
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView.Rows) // read all rows
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create)) // create and save data to the file
                            {
                                Document pdfDoc = new Document(PageSize.A2.Rotate(), 10f, 20f, 20f, 10f); // file settings
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
        }


    }

}
