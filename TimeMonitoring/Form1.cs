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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLgIn_Click(object sender, EventArgs e)
        {
                Process process = new Process();
                process.Show();
                this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm ");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblWeek.Text = DateTime.Now.ToString("dddd");
            lblClock.Text = DateTime.Now.ToString("tt");

            lblSeconds.Location = new Point(lblTime.Location.X + lblTime.Width +5 , lblSeconds.Location.Y);

            timer.Enabled = false;
            backgroundWorker.RunWorkerAsync();
            timer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
