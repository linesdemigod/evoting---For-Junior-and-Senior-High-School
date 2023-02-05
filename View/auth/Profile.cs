using Evoting.Model.auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evoting.View.auth
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private Profiles profile = new Profiles();

        private void store()
        {
            //assign password to the instance variable
            profile.password = txtPassword.Text.Trim();
            profile.id = Login.Login_id;
            txtConfirmPassword.Text.Trim();

            //assign uidExist to the method in AddUsers class
            bool passwordSame = profile.password_verification();
            string oldPassword = profile.oldPassword;

            if (txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            if (profile.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (profile.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");
                return;
            }

            //check if current password is the same as passwordprovided
            if (oldPassword != txtOldPassword.Text)
            {
                MessageBox.Show("Current Password is incorrect");
                return;
            }

            //call the method in the AddProduct class
            profile.updatePassword();
            MessageBox.Show("Password Updated");

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtOldPassword.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            store();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtOldPassword.Text = "";
            txtPassword.Text = "";
        }
    }
}
