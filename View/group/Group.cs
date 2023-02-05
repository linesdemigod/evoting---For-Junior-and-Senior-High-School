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

namespace Evoting.View.group
{
    public partial class Group : Form
    {
        public Group()
        {
            InitializeComponent();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            show();
        }

        Groups cls = new Groups();

        private void show()
        {
            cls.show();
            dataGridViewClasses.DataSource = cls.dt;
        }

        private void store()
        {

            cls.name = Helpers.UppercaseFirst(txtName.Text.Trim());


            if (txtName.Text == "")
            {
                MessageBox.Show("Please fill all field");

                return;
            }

            cls.store();
            MessageBox.Show("Class added successfully");


            clearTextBox(); //clear textbox

            show(); //CALL SHOW TO REFRESH
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

        private void dataGridViewClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == -1) return;

            if (dataGridViewClasses.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewClasses.Rows[e.RowIndex].Cells["CID"].Value);
                    cls.id = id.ToString();
                    if (Convert.ToInt32(cls.id) > 0)
                    {
                        //call the deleteUser method in the manageuser class
                        cls.destroy();
                        MessageBox.Show("Class deleted Successfully");
                        show(); //Refresh datagrid
                    }

                }
            }


            //code for the update
            if (dataGridViewClasses.Columns[e.ColumnIndex].HeaderText == "Update")
            {

                lblID.Text = dataGridViewClasses.Rows[e.RowIndex].Cells["ClassID"].Value.ToString();
                txtName.Text = dataGridViewClasses.Rows[e.RowIndex].Cells["ClassName"].Value.ToString(); ;
            }
        }


        private void update()
        {

            cls.name = Helpers.UppercaseFirst(txtName.Text.Trim());

            cls.id = lblID.Text;

            if (txtName.Text == "")
            {
                MessageBox.Show("Please fill all field");

                return;
            }

            cls.update();
            MessageBox.Show("Class updated successfully");


            clearTextBox(); //clear textbox

            show(); //CALL SHOW TO REFRESH
        }

        private void lblID_TextChanged(object sender, EventArgs e)
        {
            activateUpdateButton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void Group_Load(object sender, EventArgs e)
        {

        }
    }
}
