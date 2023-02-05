using Evoting.Controller;
using Evoting.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Evoting.View.voter
{
    public partial class Voter : Form
    {
        public Voter()
        {
            InitializeComponent();
        }

        private void Voter_Load(object sender, EventArgs e)
        {
            getClass();

            show();

            txtVoterID.Text = Helpers.generateVoterID();
            txtToken.Text = Helpers.generateToken();
        }

        Voters voter = new Voters();

        public void getClass()
        {
            voter.getClass();
            comboClass.DataSource = voter.dt;
            comboClass.DisplayMember = "name";
            comboClass.ValueMember = "id";
        }


        private void store()
        {
            txtVoterID.Text = Helpers.generateVoterID();
            txtToken.Text = Helpers.generateToken();

            voter.name = txtName.Text;
            voter.gender = comboGender.Text;
            voter.index_number = txtVoterID.Text;
            voter.token = txtToken.Text;
            voter.classID = comboClass.Text;

            //check if index number is already chosen
            bool voterIdExist = voter.indexNumberExist();

            if (txtName.Text == "" || comboGender.Text == "")
            {
                MessageBox.Show("Please Fill all Field");
                return;
            }

            if (voterIdExist)
            {
                MessageBox.Show("Voter ID already Exist, Generating New One");
                return;
            }

            voter.store();
            MessageBox.Show("Data added Successfully");
            clearTextBox();

            show(); //refresh

        }

        private void show()
        {
            voter.show();
            dataGridViewVoter.DataSource = voter.dat;
        }

        private void clearTextBox()
        {
            txtName.Text = "";
            lblID.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Update")
            {
                update();
            }
            else
            {
                store();

            }
        }


        //activate or deactivate
        private void activateUpdateButton()
        {

            if (!string.IsNullOrEmpty(lblID.Text))
            {

                btnSubmit.Text = "Update";

            }
            else
            {

                btnSubmit.Text = "Submit";


            }
        }

        private void dataGridViewVoter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            if (dataGridViewVoter.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewVoter.Rows[e.RowIndex].Cells["VoterID"].Value);
                    voter.id = id.ToString();
                    if (Convert.ToInt32(voter.id) > 0)
                    {
                        //call the deleteUser method in the manageuser class
                        voter.destroy();
                        MessageBox.Show("Data deleted Successfully");
                        show(); //Refresh datagrid
                    }

                }
            }


            //code for the update
            if (dataGridViewVoter.Columns[e.ColumnIndex].HeaderText == "Update")
            {

                lblID.Text = dataGridViewVoter.Rows[e.RowIndex].Cells["VoterID"].Value.ToString();
                txtName.Text = dataGridViewVoter.Rows[e.RowIndex].Cells["VoterName"].Value.ToString(); 
                comboGender.Text = dataGridViewVoter.Rows[e.RowIndex].Cells["VoterGender"].Value.ToString();
            }
        }

        private void update()
        {
            voter.name = txtName.Text;
            voter.gender = comboGender.Text;
            voter.token = txtToken.Text;
            voter.classID = comboClass.Text;
            voter.id = lblID.Text;

            //check if index number is already chosen
            bool voterIdExist = voter.indexNumberExist();

            if (txtName.Text == "" || comboGender.Text == "")
            {
                MessageBox.Show("Please Fill all Field");
                return;
            }
            

            voter.update();
            MessageBox.Show("Data updated Successfully");
            clearTextBox();

            show(); //refresh
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            activateUpdateButton();
        }

        private void insertIntoExcel()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                Excel.Range range = worksheet.UsedRange;

                //progress bar
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 0;
                progressBar.Step = 1;
                progressBar.PerformStep(); //start progress bar

                progressBar.Visible = true;

                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    voter.classID = range.Cells[row, 1].Value2.ToString();
                    voter.name = range.Cells[row, 2].Value2.ToString();
                    voter.gender = range.Cells[row, 3].Value2.ToString();
                    voter.index_number = range.Cells[row, 4].Value2.ToString();
                    voter.token = range.Cells[row, 5].Value2.ToString();
                    voter.store();

                }
                workbook.Close();
                excelApp.Quit();

                //end progress bar
                progressBar.Value = 100;
                MessageBox.Show("Data imported Successfully");
                progressBar.Visible = false;
                show();
            }
        }

        private void exportToExcel()
        {
            Helpers.exportToExcel(dataGridViewVoter, progressBar);
        }

        private void exportToPDF()
        {
            Helpers.ExportDataGridViewToPDF(dataGridViewVoter, progressBar);
        }

        private void btnImportExcel_Click(object sender, EventArgs e) => insertIntoExcel();

        private void btnExportExcel_Click(object sender, EventArgs e) => exportToExcel();

        private void btnPDF_Click(object sender, EventArgs e) => exportToPDF();

    }
}
