using Evoting.Model.auth;
using Evoting.View.splashscreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoting
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        public static string Login_name { get; set; }
        public static string Login_id { get; set; }
        public static string Login_status { get; set; }
        public static string Login_role { get; set; }


        Logins user = new Logins();

        private void admin()
        {
            user.username = txtUsername.Text;
            user.Password = txtPassword.Text;
            bool verify = user.user_verification();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill all field");
                return;
            }

            if (verify)
            {
                Login_id = user.id;
                Login_name = user.name;

                SplashScreen load = new SplashScreen();
                load.Show();
                Hide();


            } else
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            

        }

        private void voter()
        {
            user.username = txtUsername.Text;
            user.Password = txtPassword.Text;
            bool verify = user.voter_verification();

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill all field");
                return;
            }

            if (verify)
            {

                if (user.status == "1")
                {
                    MessageBox.Show("Please you have already Voted");
                }
                else
                {
                    Login_id = user.id;
                    Login_name = user.name;
                    Login_status = user.status;

                    SplashScreen load = new SplashScreen();
                    load.Show();
                    Hide();

                }


            }
            else
            {
                MessageBox.Show("Your Credentials are incorrect");
            }


        }


        //HIDE OR SHOW PASSWORD
        private void showHidePassword()
        {
            if (checkBoxPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
                checkBoxPassword.Text = "Hide Token";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                checkBoxPassword.Text = "Show Token";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (comboRole.Text == "Admin")
            {
                Login_role = comboRole.Text;
                admin();
            }
            else
            {
                Login_role = comboRole.Text;
                voter();
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            showHidePassword();
        }

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRole.Text == "Student")
            {
                lblUsername.Text = "Your ID";
                lblPassword.Text = "Your Token";
            }
            else if (comboRole.Text == "Admin")
            {
                lblUsername.Text = "Username";
                lblPassword.Text = "Password";
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
