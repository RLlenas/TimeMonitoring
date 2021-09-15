namespace TimeMonitoring
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDsboard = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnGuidance = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studendInfo1 = new TimeMonitoring.StudendInfo();
            this.guidance1 = new TimeMonitoring.Guidance();
            this.faculty1 = new TimeMonitoring.Faculty();
            this.dashboard1 = new TimeMonitoring.Dashboard();
            this.admission1 = new TimeMonitoring.Admission();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnNotif = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDsboard
            // 
            this.btnDsboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDsboard.Location = new System.Drawing.Point(0, 13);
            this.btnDsboard.Name = "btnDsboard";
            this.btnDsboard.Size = new System.Drawing.Size(178, 65);
            this.btnDsboard.TabIndex = 0;
            this.btnDsboard.Text = "Dashboard";
            this.btnDsboard.UseVisualStyleBackColor = true;
            this.btnDsboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(0, 74);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(178, 65);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Student Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(12, 154);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(175, 65);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 314);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 65);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnAdmission);
            this.panel1.Controls.Add(this.btnGuidance);
            this.panel1.Controls.Add(this.btnFaculty);
            this.panel1.Controls.Add(this.btnDsboard);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 391);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.studendInfo1);
            this.panel2.Controls.Add(this.guidance1);
            this.panel2.Controls.Add(this.faculty1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Controls.Add(this.admission1);
            this.panel2.Location = new System.Drawing.Point(196, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 640);
            this.panel2.TabIndex = 5;
            // 
            // btnFaculty
            // 
            this.btnFaculty.Location = new System.Drawing.Point(0, 133);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(178, 65);
            this.btnFaculty.TabIndex = 4;
            this.btnFaculty.Text = "Faculty";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGuidance
            // 
            this.btnGuidance.Location = new System.Drawing.Point(0, 195);
            this.btnGuidance.Name = "btnGuidance";
            this.btnGuidance.Size = new System.Drawing.Size(178, 65);
            this.btnGuidance.TabIndex = 5;
            this.btnGuidance.Text = "Guidance";
            this.btnGuidance.UseVisualStyleBackColor = true;
            this.btnGuidance.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAdmission
            // 
            this.btnAdmission.Location = new System.Drawing.Point(0, 253);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(178, 65);
            this.btnAdmission.TabIndex = 6;
            this.btnAdmission.Text = "Admission";
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnNotif);
            this.panel3.Controls.Add(this.btnManageUser);
            this.panel3.Location = new System.Drawing.Point(196, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 40);
            this.panel3.TabIndex = 6;
            // 
            // studendInfo1
            // 
            this.studendInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studendInfo1.Location = new System.Drawing.Point(0, 0);
            this.studendInfo1.Name = "studendInfo1";
            this.studendInfo1.Size = new System.Drawing.Size(1050, 640);
            this.studendInfo1.TabIndex = 4;
            this.studendInfo1.Load += new System.EventHandler(this.studendInfo1_Load);
            // 
            // guidance1
            // 
            this.guidance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guidance1.Location = new System.Drawing.Point(0, 0);
            this.guidance1.Name = "guidance1";
            this.guidance1.Size = new System.Drawing.Size(1050, 640);
            this.guidance1.TabIndex = 3;
            // 
            // faculty1
            // 
            this.faculty1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faculty1.Location = new System.Drawing.Point(0, 0);
            this.faculty1.Name = "faculty1";
            this.faculty1.Size = new System.Drawing.Size(1050, 640);
            this.faculty1.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1050, 640);
            this.dashboard1.TabIndex = 1;
            // 
            // admission1
            // 
            this.admission1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admission1.Location = new System.Drawing.Point(0, 0);
            this.admission1.Name = "admission1";
            this.admission1.Size = new System.Drawing.Size(1050, 640);
            this.admission1.TabIndex = 0;
            // 
            // btnManageUser
            // 
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageUser.Location = new System.Drawing.Point(18, 0);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(118, 37);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            // 
            // btnNotif
            // 
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNotif.Location = new System.Drawing.Point(164, 1);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(118, 37);
            this.btnNotif.TabIndex = 1;
            this.btnNotif.Text = "Notification";
            this.btnNotif.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1355, 740);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReports);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDsboard;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnGuidance;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Panel panel3;
        private StudendInfo studendInfo1;
        private Guidance guidance1;
        private Faculty faculty1;
        private Dashboard dashboard1;
        private Admission admission1;
        private System.Windows.Forms.Button btnNotif;
        private System.Windows.Forms.Button btnManageUser;
    }
}