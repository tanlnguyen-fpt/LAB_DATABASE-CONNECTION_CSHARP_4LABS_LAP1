
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterClassID = new System.Windows.Forms.TextBox();
            this.btnViewInDetail = new System.Windows.Forms.Button();
            this.btnViewListOfStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Class ID";
            // 
            // txtEnterClassID
            // 
            this.txtEnterClassID.Location = new System.Drawing.Point(152, 51);
            this.txtEnterClassID.Name = "txtEnterClassID";
            this.txtEnterClassID.Size = new System.Drawing.Size(100, 23);
            this.txtEnterClassID.TabIndex = 1;
            // 
            // btnViewInDetail
            // 
            this.btnViewInDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewInDetail.Location = new System.Drawing.Point(33, 96);
            this.btnViewInDetail.Name = "btnViewInDetail";
            this.btnViewInDetail.Size = new System.Drawing.Size(219, 40);
            this.btnViewInDetail.TabIndex = 2;
            this.btnViewInDetail.Text = "View in Detail";
            this.btnViewInDetail.UseVisualStyleBackColor = true;
            this.btnViewInDetail.Click += new System.EventHandler(this.btnViewInDetail_Click);
            // 
            // btnViewListOfStudent
            // 
            this.btnViewListOfStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewListOfStudent.Location = new System.Drawing.Point(350, 96);
            this.btnViewListOfStudent.Name = "btnViewListOfStudent";
            this.btnViewListOfStudent.Size = new System.Drawing.Size(219, 40);
            this.btnViewListOfStudent.TabIndex = 2;
            this.btnViewListOfStudent.Text = "View List of Students";
            this.btnViewListOfStudent.UseVisualStyleBackColor = true;
            this.btnViewListOfStudent.Click += new System.EventHandler(this.btnViewListOfStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class ID";
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(152, 170);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(100, 23);
            this.txtClassID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Class Name";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(152, 211);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(100, 23);
            this.txtClassName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 256);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            this.txtYear.TabIndex = 1;
            // 
            // lsvStudents
            // 
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(295, 159);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(314, 120);
            this.lsvStudents.TabIndex = 3;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = View.Details;
            this.lsvStudents.GridLines = true;
            this.lsvStudents.FullRowSelect = true;

            this.lsvStudents.Columns.Add("Student ID", 70);
            this.lsvStudents.Columns.Add("Name", 150);
            this.lsvStudents.Columns.Add("Class ID", 70);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 319);
            this.Controls.Add(this.lsvStudents);
            this.Controls.Add(this.btnViewListOfStudent);
            this.Controls.Add(this.btnViewInDetail);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnterClassID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterClassID;
        private System.Windows.Forms.Button btnViewInDetail;
        private System.Windows.Forms.Button btnViewListOfStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ListView lsvStudents;
    }
}