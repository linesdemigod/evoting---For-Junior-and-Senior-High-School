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
using System.Windows.Forms;

namespace Evoting.View.election
{
    public partial class Election : Form
    {
        public Election()
        {
            InitializeComponent();
        }

        private void Election_Load(object sender, EventArgs e)
        {
            show();
        }

        Elections elect = new Elections();

        private void show()
        {
            elect.show();
            dataGridViewElection.DataSource = elect.dt;
        }

        private void store()
        {

            elect.name = Helpers.UppercaseFirst(txtPosition.Text.Trim());
            elect.date = dateElection.Text;

            if (txtPosition.Text == "")
            {
                MessageBox.Show("Please fill all field");

                return;
            }

            elect.store();
            MessageBox.Show("Position added successfully");


            clearTextBox(); //clear textbox

            show(); //CALL SHOW TO REFRESH
        }

        private void clearTextBox()
        {
            txtPosition.Text = "";

            lblID.Text = "";
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

        private void dataGridViewElection_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            if (dataGridViewElection.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewElection.Rows[e.RowIndex].Cells["ElectionID"].Value);
                    elect.id = id.ToString();
                    if (Convert.ToInt32(elect.id) > 0)
                    {
                        //call the deleteUser method in the manageuser class
                        elect.destroy();
                        MessageBox.Show("Position deleted Successfully");
                        show(); //Refresh datagrid
                    }

                }
            }


            //code for the update
            if (dataGridViewElection.Columns[e.ColumnIndex].HeaderText == "Update")
            {

                lblID.Text = dataGridViewElection.Rows[e.RowIndex].Cells["ElectionID"].Value.ToString();
                txtPosition.Text = dataGridViewElection.Rows[e.RowIndex].Cells["ElectionType"].Value.ToString(); 
                dateElection.Text = dataGridViewElection.Rows[e.RowIndex].Cells["ElectionDate"].Value.ToString();
            }
        }

        private void update()
        {

            elect.name = Helpers.UppercaseFirst(txtPosition.Text.Trim());
            elect.date = dateElection.Text;
            elect.id = lblID.Text;

            if (txtPosition.Text == "")
            {
                MessageBox.Show("Please fill all field");

                return;
            }

            elect.update();
            MessageBox.Show("Position updated successfully");


            clearTextBox(); //clear textbox

            show(); //CALL SHOW TO REFRESH
        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            activateUpdateButton();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
    }
}
