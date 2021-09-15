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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Load += Admin_Load;
        }
        String username;
        public Admin(String user)
        {
            InitializeComponent();
            username = user;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            SetActivePanel(dashboard1);
            if (username == "assistant")
            {
                btnFaculty.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        public void SetActivePanel(UserControl control)
        {
            dashboard1.Visible = false;
            faculty1.Visible = false;
            admission1.Visible = false;
            studendInfo1.Visible = false;
            guidance1.Visible = false;

            control.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetActivePanel(studendInfo1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(faculty1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(guidance1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(admission1);
        }

        private void studendInfo1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
