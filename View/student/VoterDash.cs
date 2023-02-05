using Evoting.Model;
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

namespace Evoting.View.student
{
    public partial class VoterDash : Form
    {
        private DataTable dataTable;
        Votes vote = new Votes();

        public VoterDash()
        {
            InitializeComponent();

            addToDataGrid();

        }

        private void addToDataGrid()
        {
            // Initialize the DataTable and set as the DataSource for the DataGridView
            dataTable = new DataTable();
            dataTable.Columns.Add("VoterID", typeof(string));
            dataTable.Columns.Add("CanID", typeof(string));
            dataTable.Columns.Add("PostID", typeof(string));
            dataTable.Columns.Add("CanName", typeof(string));
            dataTable.Columns.Add("CanPosition", typeof(string));
            dataGridViewVote.DataSource = dataTable;

            //set the header name
            dataGridViewVote.Columns[0].HeaderText = "Voter ID";
            dataGridViewVote.Columns[1].HeaderText = "Candidate ID";
            dataGridViewVote.Columns[2].HeaderText = "Position ID";
            dataGridViewVote.Columns[3].HeaderText = "Candidate";
            dataGridViewVote.Columns[4].HeaderText = "Position";

            //set the visibility
            dataGridViewVote.Columns[0].Visible = false;
            dataGridViewVote.Columns[1].Visible = false;
            dataGridViewVote.Columns[2].Visible = false;

            //create remove
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Remove";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridViewVote.Columns.Add(buttonColumn);

            // Add a CellClick event to handle removing the row when the Remove button is clicked
            dataGridViewVote.CellClick += DataGridViewVote_CellClick;
        }

        private void DataGridViewVote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int rowIndex = 0;


            if (e.RowIndex < 0) return;
            //code the delete
            if (dataGridViewVote.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                dataGridViewVote.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                dataGridViewVote.CurrentCell = dataGridViewVote.Rows[e.RowIndex].Cells[5];

                dataGridViewVote.Rows.RemoveAt(rowIndex);
                dataGridViewVote.Refresh();
            }
        }

        private void storeVoterVote()
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to submit your vote? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewVote.Rows)
                {
                    vote.position = Convert.ToString(row.Cells["PostID"].Value);
                    vote.candidate = Convert.ToString(row.Cells["CanID"].Value);
                    vote.voter = Login.Login_id;
                    vote.store();
                }
                MessageBox.Show("Thank you for voting");

                //update user vote status
                vote.status = "1";
                vote.id = Login.Login_id;
                vote.updateVoterStatus();

                //log user out
                Login form = new Login();
                form.Show();
                Hide();
            }
            
        }

        private void VoterDash_Load(object sender, EventArgs e)
        {
            getPosition();
            lblName.Text = Login.Login_name;
        }

        //method to get the positions
        private void getPosition()
        {

            Aspirantss candidate = new Aspirantss();
            candidate.getPosition();

            flowLayoutPanel1.Controls.Clear(); //set to the panel
            flowLayoutPanel1.AutoScroll = true;


            foreach (var record in candidate.data)
            {

                Button btn = new Button()
                {
                    Text = record.Item2,
                    Size = new Size(100, 40),
                    BackColor = ColorTranslator.FromHtml("#A7907D"),
                    ForeColor = Color.White,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Century Gothic", 11.0F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),

                    Tag = record.Item1
                };

                btn.Click += IdButton_Click; //get the id of the position when the button is clicked
                flowLayoutPanel1.Controls.Add(btn); //the button to the panel

            }

        }

        private void IdButton_Click(object sender, EventArgs e)
        {
            string id = (string)((Button)sender).Tag; //get the tag id of the button 
            show(id); //show the searched position
        }

        private void show(string position)
        {
            Aspirantss candidate = new Aspirantss();
            candidate.id = position;
            candidate.show();

            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel2.AutoScroll = true;

            foreach (var record in candidate.records)
            {
                //usercontrol
                VoteControl candidateForm = new VoteControl();

                string name = record.Item2;
                string party = record.Item4;
                string id = record.Item1;
                string election = record.Item5;
                string electionID = record.Item6;

                candidateForm.PICTURE = Image.FromStream(new MemoryStream(record.Item3));
                candidateForm.NAME = name;
                candidateForm.PARTY = party;
                candidateForm.POSITION = election;
                candidateForm.TEST = id;
                candidateForm.POSITIONID = electionID;
                candidateForm.CANDIDATEID = id;

                candidateForm.Button1.Click += UserControl_Click;

                flowLayoutPanel2.Controls.Add(candidateForm);

            }


        }
        

        private void UserControl_Click(object sender, EventArgs e)
        {
            // Get the ID, Name, and Position from the CustomUserControl
            Button button = (Button)sender;
            string name = ((VoteControl)button.Parent).NAME;
            string position = ((VoteControl)button.Parent).POSITION;
            string positionID = ((VoteControl)button.Parent).POSITIONID;
            string candidateID = ((VoteControl)button.Parent).CANDIDATEID;
            string voter = Login.Login_id;

            foreach (DataRow row in dataTable.Rows)
            {
                // Check if the record already exists in the DataGridView
                if ((string)row["PostID"] == positionID)
                {
                    MessageBox.Show("You already voted for " + name + "\n" + "Remove " + name + " if you want to vote for new person");
                    return;
                }
            }

            // Add the record to the DataTable
            dataTable.Rows.Add(voter, candidateID, positionID, name, position);
        }



        private void VoterDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVote_Click(object sender, EventArgs e) => storeVoterVote();


    }
}
