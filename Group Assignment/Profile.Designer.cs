namespace Group_Assignment
{
    partial class frmProfile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblProfileText = new System.Windows.Forms.Label();
            this.btnUdt = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblProfile.Location = new System.Drawing.Point(287, 9);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(202, 40);
            this.lblProfile.TabIndex = 3;
            this.lblProfile.Text = "Profile Page";
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            // 
            // lblProfileText
            // 
            this.lblProfileText.AutoSize = true;
            this.lblProfileText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProfileText.Location = new System.Drawing.Point(184, 49);
            this.lblProfileText.Name = "lblProfileText";
            this.lblProfileText.Size = new System.Drawing.Size(408, 23);
            this.lblProfileText.TabIndex = 4;
            this.lblProfileText.Text = "In this page, you allow to update your own profile";
            // 
            // btnUdt
            // 
            this.btnUdt.BackColor = System.Drawing.Color.Silver;
            this.btnUdt.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUdt.Location = new System.Drawing.Point(298, 389);
            this.btnUdt.Name = "btnUdt";
            this.btnUdt.Size = new System.Drawing.Size(176, 62);
            this.btnUdt.TabIndex = 10;
            this.btnUdt.Text = "Update";
            this.btnUdt.UseVisualStyleBackColor = false;
            this.btnUdt.Click += new System.EventHandler(this.btnUdt_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(184, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 23);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(184, 168);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 23);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPhoneNum.Location = new System.Drawing.Point(184, 214);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(135, 23);
            this.lblPhoneNum.TabIndex = 13;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(184, 265);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(126, 23);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Address:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(383, 117);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxName.TabIndex = 15;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(383, 164);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPassword.TabIndex = 16;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(383, 264);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEmail.TabIndex = 17;
            // 
            // txtBoxPhoneNum
            // 
            this.txtBoxPhoneNum.Location = new System.Drawing.Point(383, 213);
            this.txtBoxPhoneNum.Name = "txtBoxPhoneNum";
            this.txtBoxPhoneNum.Size = new System.Drawing.Size(125, 27);
            this.txtBoxPhoneNum.TabIndex = 18;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSubject.Location = new System.Drawing.Point(184, 315);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(71, 23);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Subject:";
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Location = new System.Drawing.Point(383, 314);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(125, 27);
            this.txtBoxSubject.TabIndex = 20;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtBoxPhoneNum);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUdt);
            this.Controls.Add(this.lblProfileText);
            this.Controls.Add(this.lblProfile);
            this.Name = "frmProfile";
            this.Text = "Tutor\'s Profile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProfile;
        private Label lblProfileText;
        private Button btnUdt;
        private Label lblName;
        private Label lblPassword;
        private Label lblPhoneNum;
        private Label lblEmail;
        private TextBox txtBoxName;
        private TextBox txtBoxPassword;
        private TextBox txtBoxEmail;
        private TextBox txtBoxPhoneNum;
        private Label lblSubject;
        private TextBox txtBoxSubject;
    }
}