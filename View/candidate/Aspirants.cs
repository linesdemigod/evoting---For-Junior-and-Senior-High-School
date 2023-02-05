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

namespace Evoting.View.candidate
{
    public partial class Aspirants : Form
    {
        public Aspirants()
        {
            InitializeComponent();
        }

       
        private void Aspirants_Load(object sender, EventArgs e)
        {
           
            getPosition();
        }

        //method to get the positions
        private void getPosition()
        {
            
            Aspirantss candidate = new Aspirantss();
            candidate.getPosition();

            flowLayoutPanel2.Controls.Clear(); //set to the panel
            flowLayoutPanel2.AutoScroll = true;


            foreach (var record in candidate.data)
            {
                
                Button btn = new Button()
                {
                    Text = record.Item2,
                    Size = new Size(75, 23),
                    Tag = record.Item1
                };

                btn.Click += IdButton_Click; //get the id of the position when the button is clicked
                flowLayoutPanel2.Controls.Add(btn); //the button to the panel

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

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;

            foreach (var record in candidate.records)
            {
                //usercontrol
                controls.Candidate candidateForm = new controls.Candidate();

                string name = record.Item2;
                string party = record.Item4;
                string id = record.Item1;
                string election = record.Item5;

                candidateForm.PICTURE = Image.FromStream(new MemoryStream(record.Item3));
                candidateForm.NAME = name;
                candidateForm.PARTY = party;
                candidateForm.POSITION = election;
                candidateForm.TEST = id;

                candidateForm.Button1.Click += UserControl_Click;

                flowLayoutPanel1.Controls.Add(candidateForm);

            }


        }

        private void UserControl_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Tag.ToString());
        }

        

    }
}
