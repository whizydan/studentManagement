namespace Group_Assignment
{
    partial class frmAddClassInfo
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
            this.txtBoxAdd1 = new System.Windows.Forms.TextBox();
            this.lblSubjName = new System.Windows.Forms.Label();
            this.txtBoxAdd2 = new System.Windows.Forms.TextBox();
            this.lblCharges = new System.Windows.Forms.Label();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblAddClass = new System.Windows.Forms.Label();
            this.lblAddClassText = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxAdd1
            // 
            this.txtBoxAdd1.Location = new System.Drawing.Point(427, 201);
            this.txtBoxAdd1.Name = "txtBoxAdd1";
            this.txtBoxAdd1.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAdd1.TabIndex = 15;
            // 
            // lblSubjName
            // 
            this.lblSubjName.AutoSize = true;
            this.lblSubjName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubjName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSubjName.Location = new System.Drawing.Point(233, 134);
            this.lblSubjName.Name = "lblSubjName";
            this.lblSubjName.Size = new System.Drawing.Size(124, 23);
            this.lblSubjName.TabIndex = 10;
            this.lblSubjName.Text = "Subject Name:";
            // 
            // txtBoxAdd2
            // 
            this.txtBoxAdd2.Location = new System.Drawing.Point(427, 277);
            this.txtBoxAdd2.Name = "txtBoxAdd2";
            this.txtBoxAdd2.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAdd2.TabIndex = 14;
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCharges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCharges.Location = new System.Drawing.Point(233, 205);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(122, 23);
            this.lblCharges.TabIndex = 11;
            this.lblCharges.Text = "Charges (RM):";
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(427, 130);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(125, 27);
            this.txtBoxAdd.TabIndex = 13;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSchedule.Location = new System.Drawing.Point(233, 281);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(130, 23);
            this.lblSchedule.TabIndex = 12;
            this.lblSchedule.Text = "Class Schedule:";
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAddClass.Location = new System.Drawing.Point(180, 9);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(444, 40);
            this.lblAddClass.TabIndex = 18;
            this.lblAddClass.Text = "Add Class Information Page";
            // 
            // lblAddClassText
            // 
            this.lblAddClassText.AutoSize = true;
            this.lblAddClassText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAddClassText.Location = new System.Drawing.Point(206, 49);
            this.lblAddClassText.Name = "lblAddClassText";
            this.lblAddClassText.Size = new System.Drawing.Size(387, 23);
            this.lblAddClassText.TabIndex = 19;
            this.lblAddClassText.Text = "In this page, you allow to add class information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(308, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 62);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxAdd2);
            this.Controls.Add(this.txtBoxAdd1);
            this.Controls.Add(this.lblAddClassText);
            this.Controls.Add(this.lblSubjName);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.lblAddClass);
            this.Controls.Add(this.txtBoxAdd);
            this.Name = "frmAddClassInfo";
            this.Text = "Add Class Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBoxAdd1;
        private Label lblSubjName;
        private TextBox txtBoxAdd2;
        private Label lblCharges;
        private TextBox txtBoxAdd;
        private Label lblSchedule;
        private Label lblAddClass;
        private Label lblAddClassText;
        private Button btnSave;
    }
}