namespace ELS.GUI
{
    partial class ViewLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLesson));
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.rtxt_homework = new System.Windows.Forms.RichTextBox();
            this.rtxt_records = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxt_description
            // 
            this.rtxt_description.Location = new System.Drawing.Point(121, 47);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.ReadOnly = true;
            this.rtxt_description.Size = new System.Drawing.Size(245, 68);
            this.rtxt_description.TabIndex = 18;
            this.rtxt_description.Text = "";
            // 
            // rtxt_homework
            // 
            this.rtxt_homework.Location = new System.Drawing.Point(121, 147);
            this.rtxt_homework.Name = "rtxt_homework";
            this.rtxt_homework.ReadOnly = true;
            this.rtxt_homework.Size = new System.Drawing.Size(245, 68);
            this.rtxt_homework.TabIndex = 19;
            this.rtxt_homework.Text = "";
            // 
            // rtxt_records
            // 
            this.rtxt_records.Location = new System.Drawing.Point(121, 236);
            this.rtxt_records.Name = "rtxt_records";
            this.rtxt_records.ReadOnly = true;
            this.rtxt_records.Size = new System.Drawing.Size(245, 274);
            this.rtxt_records.TabIndex = 20;
            this.rtxt_records.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Homework:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Records:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ViewLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(486, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_records);
            this.Controls.Add(this.rtxt_homework);
            this.Controls.Add(this.rtxt_description);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLesson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.RichTextBox rtxt_homework;
        private System.Windows.Forms.RichTextBox rtxt_records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}