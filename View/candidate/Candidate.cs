using Evoting.Model;
using Evoting.View.candidate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoting.View.cadidate
{
    public partial class Candidate : Form
    {
        public Candidate()
        {
            InitializeComponent();
        }

        private void Candidate_Load(object sender, EventArgs e)
        {
            show();
            getElection();
        }

        Candidates candidate = new Candidates();

        public void getElection()
        {
            candidate.getElection();
            comboPosition.DataSource = candidate.dt;
            comboPosition.DisplayMember = "type";
            comboPosition.ValueMember = "id";
        }

        private void show()
        {
           
            candidate.show();
            dataGridViewCandidate.DataSource = candidate.dat;

        }

        public void search()
        {
            //handle sql injection
            string str = txtSearch.Text.Trim().Replace("'", "\\");

            DataView dv = candidate.dat.DefaultView;
            dv.RowFilter = string.Format("name LIKE '%" + str + "%' OR Position LIKE '%" + str + "%'");
            dataGridViewCandidate.DataSource = dv.ToTable();
        }

        private void clearTextBox()
        {
            txtName.Text = "";
            txtParty.Text = "";
            lblID.Text = "";
            pictureBox1.Image = null;
        }

        private void store()
        {

            Image img = pictureBox1.Image;
            byte[] imageData;
            ImageConverter converter = new ImageConverter();
            imageData = (byte[])converter.ConvertTo(img, typeof(byte[]));

            candidate.name = txtName.Text.Trim();
            candidate.party = txtParty.Text.Trim();
            candidate.election = comboPosition.SelectedValue.ToString();
            candidate.picture = imageData;

            if (txtName.Text == "" || txtParty.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            candidate.store();
            MessageBox.Show("Candidate Added Successfully");
            clearTextBox();
            show();

        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.Title = "Select an image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
            }
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

        private void dataGridViewCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            if (dataGridViewCandidate.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewCandidate.Rows[e.RowIndex].Cells["CandidateID"].Value);
                    candidate.id = id.ToString();
                    if (Convert.ToInt32(candidate.id) > 0)
                    {
                        //call the deleteUser method in the manageuser class
                        candidate.destroy();
                        MessageBox.Show("Data deleted Successfully");
                        show(); //Refresh datagrid
                    }

                }
            }


            //code for the update
            if (dataGridViewCandidate.Columns[e.ColumnIndex].HeaderText == "Update")
            {

                lblID.Text = dataGridViewCandidate.Rows[e.RowIndex].Cells["CandidateID"].Value.ToString();
                txtName.Text = dataGridViewCandidate.Rows[e.RowIndex].Cells["CandidateName"].Value.ToString();
                comboPosition.Text = dataGridViewCandidate.Rows[e.RowIndex].Cells["candidateElection"].Value.ToString();
                txtParty.Text = dataGridViewCandidate.Rows[e.RowIndex].Cells["candidateParty"].Value.ToString();
            }
        }


        private void update()
        {

            Image img = pictureBox1.Image;
            byte[] imageData;
            ImageConverter converter = new ImageConverter();
            imageData = (byte[])converter.ConvertTo(img, typeof(byte[]));

            candidate.name = txtName.Text.Trim();
            candidate.party = txtParty.Text.Trim();
            candidate.election = comboPosition.SelectedValue.ToString();
            candidate.picture = imageData;
            candidate.id = lblID.Text;

            if (txtName.Text == "" || txtParty.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            candidate.update();
            MessageBox.Show("Candidate Updated Successfully");
            clearTextBox();
            show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            activateUpdateButton();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnAspirants_Click(object sender, EventArgs e)
        {
            Aspirants user = new Aspirants();
            user.ShowDialog();
        }
    }
}
