using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;

namespace Evoting.Controller
{
    class Helpers
    {
        public static TextBox textbox = new TextBox();

        public Helpers()
        {
        }

        public static void textbox_Leave(object sender, EventArgs e)
        {
            double value;
            if (!double.TryParse(textbox.Text, out value))
            {
                MessageBox.Show("Please enter a valid number in the amount.");
                textbox.Focus();
            }
        }

        public static void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //MAKE FIRST LETTER UPPERCASE
        public static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        //generate random
        public static string generateVoterID()
        {
            DateTime now = DateTime.Now;

            Random rand = new Random();
            string result = rand.Next(1,9999).ToString() + now.Year;

            return result;
        }

        public static string generateToken()
        {
            DateTime now = DateTime.Now;

            Random rand = new Random();
            string result = rand.Next(1, 100).ToString();

            return result;
        }


        //calculate the amount and put it at the last row of the datagrid
        public void CalculateSumAndDisplayInLastRow(DataGridView dataGridView, string columnName)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView.Rows[i].Cells[columnName].Value);
            }
            int lastRowIndex = dataGridView.Rows.Count - 1;
            dataGridView.Rows[lastRowIndex].Cells[columnName].Value = sum;
            dataGridView.Rows[lastRowIndex].Cells[0].Value = "Total";
        }

        //export to excel
        public static void exportToExcel(DataGridView dataGridView, ProgressBar progressBar)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            //progress bar
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            progressBar.Step = 1;
            progressBar.PerformStep(); //start progress bar

            progressBar.Visible = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //change properties
                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        if (dataGridView.Rows[i].Cells[j].Value != null)
                        {
                            excelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            excelApp.Cells[i + 2, j + 1] = "";
                        }
                    }
                }

                excelApp.Columns.AutoFit();
                workbook.SaveAs(saveFileDialog.FileName);

                //end progress bar
                progressBar.Value = 100;

                MessageBox.Show("Data exported successfully");

                progressBar.Visible = false;
            }

            workbook.Close();
            excelApp.Quit();
        }

        //export as pdf
        public static void ExportDataGridViewToPDF(DataGridView dgv, ProgressBar progressBar)
        {
            // create a new SaveFileDialog
            SaveFileDialog saveDialog = new SaveFileDialog();

            // set the filter for the dialog
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveDialog.FilterIndex = 1;

            // set the default file name
            saveDialog.FileName = "";

            //progress bar
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            progressBar.Step = 1;
            progressBar.PerformStep(); //start progress bar

            progressBar.Visible = true;

            // show the dialog and check if the user selected a file
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // create a new PDF document
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                // set the font for the document
                pdfDoc.AddAuthor("Author Name");
                pdfDoc.AddCreationDate();
                pdfDoc.AddCreator("Application Name");
                pdfDoc.AddTitle("DataGridView Export to PDF");

                // create a new PDF writer
                PdfWriter.GetInstance(pdfDoc, new FileStream(saveDialog.FileName, FileMode.Create));
                pdfDoc.Open();

                // create a new table for the data
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;
                pdfTable.DefaultCell.Padding = 3;

                // set the font for the table
                pdfTable.DefaultCell.Phrase = new Phrase() { Font = FontFactory.GetFont("Arial", 12f, BaseColor.BLACK) };

                // add the table headers
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    pdfTable.AddCell(dgv.Columns[i].HeaderText);
                }

                // add the data to the table
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        if (dgv.Rows[i].Cells[j].Value == null)
                        {
                            pdfTable.AddCell("");
                        }
                        else
                        {
                            pdfTable.AddCell(dgv.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }

                // add the table to the document
                pdfDoc.Add(pdfTable);

                //end progress bar
                progressBar.Value = 100;

                MessageBox.Show("Data exported successfully");

                progressBar.Visible = false;

                // close the document
                pdfDoc.Close();
            }
        }
    }
}
