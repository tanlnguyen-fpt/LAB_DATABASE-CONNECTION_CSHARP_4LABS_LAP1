
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP1
{
    partial class Form3_v2
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
            this.lsbClass = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvStudents = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbClass
            // 
            this.lsbClass.FormattingEnabled = true;
            this.lsbClass.ItemHeight = 15;
            this.lsbClass.Location = new System.Drawing.Point(8, 80);
            this.lsbClass.Name = "lsbClass";
            this.lsbClass.Size = new System.Drawing.Size(264, 184);
            this.lsbClass.TabIndex = 0;
            this.lsbClass.SelectedIndexChanged += new System.EventHandler(this.lsbClass_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Classes";
            // 
            // lsvStudents
            // 
            this.lsvStudents.HideSelection = false;
            this.lsvStudents.Location = new System.Drawing.Point(296, 80);
            this.lsvStudents.Name = "lsvStudents";
            this.lsvStudents.Size = new System.Drawing.Size(368, 184);
            this.lsvStudents.TabIndex = 2;
            this.lsvStudents.UseCompatibleStateImageBehavior = false;
            this.lsvStudents.View = View.Details;
            this.lsvStudents.GridLines = true;
            this.lsvStudents.FullRowSelect = true;

            this.lsvStudents.Columns.Add("Student ID", 70);
            this.lsvStudents.Columns.Add("Name", 150);
            this.lsvStudents.Columns.Add("Class ID", 70);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(400, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "List of Students";
            // 
            // Form3_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 286);
            this.Controls.Add(this.lsvStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbClass);
            this.Name = "Form3_v2";
            this.Text = "Form3_v2";
            this.Load += new System.EventHandler(this.Form3_v2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvStudents;
        private System.Windows.Forms.Label label2;
    }
}