using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoting.View.splashscreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if (panel2.Width >= 460)
            {
                if (Login.Login_role == "Admin")
                {
                    //CALL THE LOGIN METHOD
                    admin.AdminDash user = new admin.AdminDash();
                    user.Show();
                    Hide();
                    timer1.Enabled = false;
                }
                else
                {
                    student.VoterDash student = new student.VoterDash();
                    student.Show();
                    Hide();
                    timer1.Enabled = false;

                }
            }
        }
    }
}
