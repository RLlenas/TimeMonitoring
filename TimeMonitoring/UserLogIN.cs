using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeMonitoring
{
    public partial class UserLogIN : Form
    {
        public UserLogIN()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string  user, userpass; //adminUser, //adminpass,
          //  adminUser = txtUser.Text;
         //   adminpass = txtPass.Text;
          //  user = txtUser.Text;
         //   userpass = txtPass.Text;
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                lblMessage.Text = "Successfully Login";
                lblMessage.ForeColor = Color.DarkSeaGreen;
                txtUser.Clear();
                txtPass.Clear();

                Admin admin = new Admin(txtUser.Text);
                admin.Show();
                this.Hide();

            }
            else if (txtUser.Text == "assistant" && txtPass.Text == "pass00")
            {
                lblMessage.Text = "Successfully Login";
                lblMessage.ForeColor = Color.DarkSeaGreen;
                txtUser.Clear();
                txtPass.Clear();

                Admin admin = new Admin(txtUser.Text);
                admin.Show();
                this.Hide();
            }
            else
            {
                lblMessage.Text = "Error";
                lblMessage.ForeColor = Color.DarkRed;
                txtUser.Clear();
                txtPass.Clear();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkboxShow_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;

            if (txtPass.Text == "password")
            {
                txtPass.ForeColor = Color.White;
                txtPass.Clear();
            }
        }

        private void lnkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnkShow.Text == "Show")
            {
                txtPass.UseSystemPasswordChar = false;
                lnkShow.Text = "Hide";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                lnkShow.Text = "Show";
            }
        }

        private void UserLogIN_Load(object sender, EventArgs e)
        {

        }
    }
}
