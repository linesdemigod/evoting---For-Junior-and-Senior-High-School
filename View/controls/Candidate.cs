using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoting.View.controls
{
    public partial class Candidate : UserControl
    {
        public Candidate()
        {
            InitializeComponent();
          
        }

        private string _test;
        private string _name;
        private string _party;
        private string _position;
        private Image _picture;

        
        public Button Button1 { get { return btnTest; } }

        public string TEST
        {
            get => _test;
            set => btnTest.Tag = value;
        }

        public string NAME
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        public string PARTY
        {
            get { return _party; }
            set { _party = value; lblParty.Text = value; }
        }

        public string POSITION
        {
            get { return _position; }
            set { _position = value; lblPosition.Text = value; }
        }

        public Image PICTURE
        {
            get { return _picture; }
            set { _picture = value; pictureBox1.Image = value; }
        }
 
    }
}
