namespace ELS.GUI
{
    partial class RecordsOfStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsOfStudents));
            this.rtxt_grades = new System.Windows.Forms.RichTextBox();
            this.rtxt_absences = new System.Windows.Forms.RichTextBox();
            this.rtxt_note = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxt_grades
            // 
            this.rtxt_grades.Location = new System.Drawing.Point(56, 39);
            this.rtxt_grades.Name = "rtxt_grades";
            this.rtxt_grades.ReadOnly = true;
            this.rtxt_grades.Size = new System.Drawing.Size(237, 113);
            this.rtxt_grades.TabIndex = 0;
            this.rtxt_grades.Text = "";
            // 
            // rtxt_absences
            // 
            this.rtxt_absences.Location = new System.Drawing.Point(56, 186);
            this.rtxt_absences.Name = "rtxt_absences";
            this.rtxt_absences.Size = new System.Drawing.Size(237, 113);
            this.rtxt_absences.TabIndex = 1;
            this.rtxt_absences.Text = "";
            // 
            // rtxt_note
            // 
            this.rtxt_note.Location = new System.Drawing.Point(56, 330);
            this.rtxt_note.Name = "rtxt_note";
            this.rtxt_note.Size = new System.Drawing.Size(237, 113);
            this.rtxt_note.TabIndex = 2;
            this.rtxt_note.Text = "";
            // 
            // RecordsOfStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(384, 546);
            this.Controls.Add(this.rtxt_note);
            this.Controls.Add(this.rtxt_absences);
            this.Controls.Add(this.rtxt_grades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordsOfStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_grades;
        private System.Windows.Forms.RichTextBox rtxt_absences;
        private System.Windows.Forms.RichTextBox rtxt_note;
    }
}