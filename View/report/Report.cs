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

namespace Evoting.View.report
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        Reports report = new Reports();

        private void Report_Load(object sender, EventArgs e)
        {

            getPosition();
            countVoters();
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
            showResult(id); //show the searched position
            countTotalCast(id);
        }

        private void showResult(string id)
        {
            
            report.id = id;
            report.getReport();

            chart1.DataSource = report.dt;
            chart1.Series[0].XValueMember = "name";
            chart1.Series[0].YValueMembers = "Votes";
            chart1.DataBind();
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0]["PointWidth"] = "0.6";
            chart1.Series[0].LabelFormat = "{0}";

        }

        private void countVoters()
        {
            report.countVoters();
            lblTotalVoter.Text = report.voters;
        }

        private void countTotalCast(string id)
        {
            report.id = id;
            report.countVoteCast();
            lblTotalVoteCast.Text = report.voters;

            //calc reamaing voters
            int result = Convert.ToInt32(lblTotalVoter.Text) - Convert.ToInt32(lblTotalVoteCast.Text);
            lblRemainingVoters.Text = result.ToString();
            
        }
    }
}
