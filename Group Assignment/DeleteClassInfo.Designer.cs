namespace Group_Assignment
{
    partial class frmDeleteClassInfo
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
            this.lblDelClass = new System.Windows.Forms.Label();
            this.lblDelClassText = new System.Windows.Forms.Label();
            this.lblSubjName = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtBoxDel = new System.Windows.Forms.TextBox();
            this.txtBoxDel1 = new System.Windows.Forms.TextBox();
            this.txtBoxDel2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDelClass
            // 
            this.lblDelClass.AutoSize = true;
            this.lblDelClass.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDelClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDelClass.Location = new System.Drawing.Point(152, 9);
            this.lblDelClass.Name = "lblDelClass";
            this.lblDelClass.Size = new System.Drawing.Size(484, 40);
            this.lblDelClass.TabIndex = 3;
            this.lblDelClass.Text = "Delete Class Information Page";
            // 
            // lblDelClassText
            // 
            this.lblDelClassText.AutoSize = true;
            this.lblDelClassText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDelClassText.Location = new System.Drawing.Point(190, 49);
            this.lblDelClassText.Name = "lblDelClassText";
            this.lblDelClassText.Size = new System.Drawing.Size(405, 23);
            this.lblDelClassText.TabIndex = 21;
            this.lblDelClassText.Text = "In this page, you allow to delete class information";
            // 
            // lblSubjName
            // 
            this.lblSubjName.AutoSize = true;
            this.lblSubjName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubjName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSubjName.Location = new System.Drawing.Point(237, 130);
            this.lblSubjName.Name = "lblSubjName";
            this.lblSubjName.Size = new System.Drawing.Size(124, 23);
            this.lblSubjName.TabIndex = 22;
            this.lblSubjName.Text = "Subject Name:";
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCharges.Location = new System.Drawing.Point(237, 198);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(122, 23);
            this.lblCharges.TabIndex = 24;
            this.lblCharges.Text = "Charges (RM):";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSchedule.Location = new System.Drawing.Point(237, 270);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(130, 23);
            this.lblSchedule.TabIndex = 25;
            this.lblSchedule.Text = "Class Schedule:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Silver;
            this.btnRemove.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Location = new System.Drawing.Point(308, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(176, 62);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtBoxDel
            // 
            this.txtBoxDel.Location = new System.Drawing.Point(415, 126);
            this.txtBoxDel.Name = "txtBoxDel";
            this.txtBoxDel.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDel.TabIndex = 27;
            // 
            // txtBoxDel1
            // 
            this.txtBoxDel1.Location = new System.Drawing.Point(415, 194);
            this.txtBoxDel1.Name = "txtBoxDel1";
            this.txtBoxDel1.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDel1.TabIndex = 28;
            // 
            // txtBoxDel2
            // 
            this.txtBoxDel2.Location = new System.Drawing.Point(415, 266);
            this.txtBoxDel2.Name = "txtBoxDel2";
            this.txtBoxDel2.Size = new System.Drawing.Size(125, 27);
            this.txtBoxDel2.TabIndex = 29;
            // 
            // frmDeleteClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDel2);
            this.Controls.Add(this.txtBoxDel1);
            this.Controls.Add(this.txtBoxDel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.lblSubjName);
            this.Controls.Add(this.lblDelClassText);
            this.Controls.Add(this.lblDelClass);
            this.Name = "frmDeleteClassInfo";
            this.Text = "Delete Class Information";
            this.Load += new System.EventHandler(this.frmDeleteClassInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDelClass;
        private Label lblDelClassText;
        private Label lblSubjName;
        private Label lblCharges;
        private Label lblSchedule;
        private Button btnRemove;
        private TextBox txtBoxDel;
        private TextBox txtBoxDel1;
        private TextBox txtBoxDel2;
    }
}