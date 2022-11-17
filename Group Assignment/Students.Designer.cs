namespace Group_Assignment
{
    partial class frmStudents
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
            this.lblList = new System.Windows.Forms.Label();
            this.lblListText = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblList.Location = new System.Drawing.Point(229, 7);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(191, 31);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Students Page";
            // 
            // lblListText
            // 
            this.lblListText.AutoSize = true;
            this.lblListText.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblListText.Location = new System.Drawing.Point(157, 37);
            this.lblListText.Name = "lblListText";
            this.lblListText.Size = new System.Drawing.Size(325, 19);
            this.lblListText.TabIndex = 3;
            this.lblListText.Text = "In this page, you allow to view the list of students";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Silver;
            this.btnView.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnView.Location = new System.Drawing.Point(258, 261);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(154, 46);
            this.btnView.TabIndex = 10;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // studentList
            // 
            this.studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentList.Location = new System.Drawing.Point(12, 59);
            this.studentList.Name = "studentList";
            this.studentList.RowTemplate.Height = 25;
            this.studentList.Size = new System.Drawing.Size(676, 197);
            this.studentList.TabIndex = 11;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(690, 330);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblListText);
            this.Controls.Add(this.lblList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStudents";
            this.Text = "List of Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblList;
        private Label lblListText;
        private Button btnView;
        private DataGridView studentList;
    }
}