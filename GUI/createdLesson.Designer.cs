namespace ELS.GUI
{
    partial class createdLesson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createdLesson));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cb_grade = new System.Windows.Forms.ComboBox();
            this.nup_grade = new System.Windows.Forms.NumericUpDown();
            this.b_grade = new System.Windows.Forms.Button();
            this.cb_absence = new System.Windows.Forms.ComboBox();
            this.b_absence = new System.Windows.Forms.Button();
            this.cb_note = new System.Windows.Forms.ComboBox();
            this.b_note = new System.Windows.Forms.Button();
            this.rtxt_note = new System.Windows.Forms.RichTextBox();
            this.rtxt_homework = new System.Windows.Forms.RichTextBox();
            this.b_homework = new System.Windows.Forms.Button();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.b_description = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add description";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add homework";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add grade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add absence";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(30, 378);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 68);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add note";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(473, 378);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 68);
            this.button7.TabIndex = 6;
            this.button7.Text = "view ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cb_grade
            // 
            this.cb_grade.FormattingEnabled = true;
            this.cb_grade.Location = new System.Drawing.Point(217, 201);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(235, 21);
            this.cb_grade.TabIndex = 7;
            this.cb_grade.Visible = false;
            // 
            // nup_grade
            // 
            this.nup_grade.Location = new System.Drawing.Point(217, 237);
            this.nup_grade.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nup_grade.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_grade.Name = "nup_grade";
            this.nup_grade.Size = new System.Drawing.Size(44, 20);
            this.nup_grade.TabIndex = 8;
            this.nup_grade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nup_grade.Visible = false;
            // 
            // b_grade
            // 
            this.b_grade.Location = new System.Drawing.Point(356, 230);
            this.b_grade.Name = "b_grade";
            this.b_grade.Size = new System.Drawing.Size(96, 31);
            this.b_grade.TabIndex = 9;
            this.b_grade.Text = "add";
            this.b_grade.UseVisualStyleBackColor = true;
            this.b_grade.Visible = false;
            this.b_grade.Click += new System.EventHandler(this.b_grade_Click);
            // 
            // cb_absence
            // 
            this.cb_absence.FormattingEnabled = true;
            this.cb_absence.Location = new System.Drawing.Point(217, 291);
            this.cb_absence.Name = "cb_absence";
            this.cb_absence.Size = new System.Drawing.Size(235, 21);
            this.cb_absence.TabIndex = 10;
            this.cb_absence.Visible = false;
            // 
            // b_absence
            // 
            this.b_absence.Location = new System.Drawing.Point(356, 328);
            this.b_absence.Name = "b_absence";
            this.b_absence.Size = new System.Drawing.Size(96, 31);
            this.b_absence.TabIndex = 11;
            this.b_absence.Text = "add";
            this.b_absence.UseVisualStyleBackColor = true;
            this.b_absence.Visible = false;
            this.b_absence.Click += new System.EventHandler(this.b_absence_Click);
            // 
            // cb_note
            // 
            this.cb_note.FormattingEnabled = true;
            this.cb_note.Location = new System.Drawing.Point(217, 382);
            this.cb_note.Name = "cb_note";
            this.cb_note.Size = new System.Drawing.Size(133, 21);
            this.cb_note.TabIndex = 12;
            this.cb_note.Visible = false;
            this.cb_note.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // b_note
            // 
            this.b_note.Location = new System.Drawing.Point(356, 379);
            this.b_note.Name = "b_note";
            this.b_note.Size = new System.Drawing.Size(96, 25);
            this.b_note.TabIndex = 13;
            this.b_note.Text = "add";
            this.b_note.UseVisualStyleBackColor = true;
            this.b_note.Visible = false;
            this.b_note.Click += new System.EventHandler(this.b_note_Click);
            // 
            // rtxt_note
            // 
            this.rtxt_note.Location = new System.Drawing.Point(217, 415);
            this.rtxt_note.Name = "rtxt_note";
            this.rtxt_note.Size = new System.Drawing.Size(235, 31);
            this.rtxt_note.TabIndex = 14;
            this.rtxt_note.Text = "";
            this.rtxt_note.Visible = false;
            // 
            // rtxt_homework
            // 
            this.rtxt_homework.Location = new System.Drawing.Point(207, 112);
            this.rtxt_homework.Name = "rtxt_homework";
            this.rtxt_homework.Size = new System.Drawing.Size(245, 68);
            this.rtxt_homework.TabIndex = 15;
            this.rtxt_homework.Text = "";
            this.rtxt_homework.Visible = false;
            // 
            // b_homework
            // 
            this.b_homework.Location = new System.Drawing.Point(458, 112);
            this.b_homework.Name = "b_homework";
            this.b_homework.Size = new System.Drawing.Size(96, 68);
            this.b_homework.TabIndex = 16;
            this.b_homework.Text = "add";
            this.b_homework.UseVisualStyleBackColor = true;
            this.b_homework.Visible = false;
            this.b_homework.Click += new System.EventHandler(this.b_homework_Click);
            // 
            // rtxt_description
            // 
            this.rtxt_description.Location = new System.Drawing.Point(207, 21);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(245, 68);
            this.rtxt_description.TabIndex = 17;
            this.rtxt_description.Text = "";
            this.rtxt_description.Visible = false;
            // 
            // b_description
            // 
            this.b_description.Location = new System.Drawing.Point(458, 21);
            this.b_description.Name = "b_description";
            this.b_description.Size = new System.Drawing.Size(96, 68);
            this.b_description.TabIndex = 18;
            this.b_description.Text = "add";
            this.b_description.UseVisualStyleBackColor = true;
            this.b_description.Visible = false;
            this.b_description.Click += new System.EventHandler(this.b_description_Click);
            // 
            // createdLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(657, 470);
            this.Controls.Add(this.b_description);
            this.Controls.Add(this.rtxt_description);
            this.Controls.Add(this.b_homework);
            this.Controls.Add(this.rtxt_homework);
            this.Controls.Add(this.rtxt_note);
            this.Controls.Add(this.b_note);
            this.Controls.Add(this.cb_note);
            this.Controls.Add(this.b_absence);
            this.Controls.Add(this.cb_absence);
            this.Controls.Add(this.b_grade);
            this.Controls.Add(this.nup_grade);
            this.Controls.Add(this.cb_grade);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "createdLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesson";
            ((System.ComponentModel.ISupportInitialize)(this.nup_grade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cb_grade;
        private System.Windows.Forms.NumericUpDown nup_grade;
        private System.Windows.Forms.Button b_grade;
        private System.Windows.Forms.ComboBox cb_absence;
        private System.Windows.Forms.Button b_absence;
        private System.Windows.Forms.ComboBox cb_note;
        private System.Windows.Forms.Button b_note;
        private System.Windows.Forms.RichTextBox rtxt_note;
        private System.Windows.Forms.RichTextBox rtxt_homework;
        private System.Windows.Forms.Button b_homework;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.Button b_description;
    }
}