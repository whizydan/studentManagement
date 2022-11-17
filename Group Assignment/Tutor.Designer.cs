namespace Group_Assignment
{
    partial class frmTutor
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
            this.lblTutor = new System.Windows.Forms.Label();
            this.lblTutorText = new System.Windows.Forms.Label();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTutor.Location = new System.Drawing.Point(297, 9);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(184, 40);
            this.lblTutor.TabIndex = 4;
            this.lblTutor.Text = "Tutor Page";
            // 
            // lblTutorText
            // 
            this.lblTutorText.AutoSize = true;
            this.lblTutorText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTutorText.Location = new System.Drawing.Point(173, 49);
            this.lblTutorText.Name = "lblTutorText";
            this.lblTutorText.Size = new System.Drawing.Size(433, 23);
            this.lblTutorText.TabIndex = 5;
            this.lblTutorText.Text = "Welcome to the ETC - You are now a tutor after login";
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.Silver;
            this.btnClass.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClass.Location = new System.Drawing.Point(305, 95);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(176, 62);
            this.btnClass.TabIndex = 10;
            this.btnClass.Text = "Class Information";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Silver;
            this.btnStudents.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStudents.Location = new System.Drawing.Point(305, 175);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(176, 62);
            this.btnStudents.TabIndex = 11;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(305, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 62);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Silver;
            this.btnProfile.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfile.Location = new System.Drawing.Point(305, 255);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(176, 62);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.lblTutorText);
            this.Controls.Add(this.lblTutor);
            this.Name = "frmTutor";
            this.Text = "Excellent Tuition Center (ETC) - Tutor Page";
            this.Load += new System.EventHandler(this.frmTutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTutor;
        private Label lblTutorText;
        private Button btnClass;
        private Button btnStudents;
        private Button btnExit;
        private Button btnProfile;
    }
}