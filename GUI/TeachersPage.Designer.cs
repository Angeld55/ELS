namespace ELS.GUI
{
    partial class TeachersPage
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

            ApplicationRun.theLogin.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_lessons = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.b_records = new System.Windows.Forms.Button();
            this.cb_absences = new System.Windows.Forms.ComboBox();
            this.b_excuse = new System.Windows.Forms.Button();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.cb_class = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create lesson";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "View lessons";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_lessons
            // 
            this.cb_lessons.FormattingEnabled = true;
            this.cb_lessons.Location = new System.Drawing.Point(179, 119);
            this.cb_lessons.Name = "cb_lessons";
            this.cb_lessons.Size = new System.Drawing.Size(250, 21);
            this.cb_lessons.TabIndex = 2;
            this.cb_lessons.Visible = false;
            this.cb_lessons.SelectedIndexChanged += new System.EventHandler(this.cb_lessons_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "Administrate class";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_student
            // 
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(179, 221);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(250, 21);
            this.cb_student.TabIndex = 4;
            this.cb_student.Visible = false;
            this.cb_student.SelectedIndexChanged += new System.EventHandler(this.cb_student_SelectedIndexChanged);
            // 
            // b_records
            // 
            this.b_records.Location = new System.Drawing.Point(227, 248);
            this.b_records.Name = "b_records";
            this.b_records.Size = new System.Drawing.Size(145, 40);
            this.b_records.TabIndex = 5;
            this.b_records.Text = "view records";
            this.b_records.UseVisualStyleBackColor = true;
            this.b_records.Visible = false;
            this.b_records.Click += new System.EventHandler(this.button4_Click);
            // 
            // cb_absences
            // 
            this.cb_absences.FormattingEnabled = true;
            this.cb_absences.Location = new System.Drawing.Point(448, 221);
            this.cb_absences.Name = "cb_absences";
            this.cb_absences.Size = new System.Drawing.Size(250, 21);
            this.cb_absences.TabIndex = 6;
            this.cb_absences.Visible = false;
            // 
            // b_excuse
            // 
            this.b_excuse.Location = new System.Drawing.Point(502, 285);
            this.b_excuse.Name = "b_excuse";
            this.b_excuse.Size = new System.Drawing.Size(145, 40);
            this.b_excuse.TabIndex = 7;
            this.b_excuse.Text = "Excuse absence";
            this.b_excuse.UseVisualStyleBackColor = true;
            this.b_excuse.Visible = false;
            this.b_excuse.Click += new System.EventHandler(this.b_excuse_Click);
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(448, 259);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(250, 20);
            this.txt_note.TabIndex = 8;
            this.txt_note.Visible = false;
            // 
            // cb_class
            // 
            this.cb_class.FormattingEnabled = true;
            this.cb_class.Location = new System.Drawing.Point(179, 24);
            this.cb_class.Name = "cb_class";
            this.cb_class.Size = new System.Drawing.Size(84, 21);
            this.cb_class.TabIndex = 9;
            this.cb_class.Visible = false;
            this.cb_class.SelectedIndexChanged += new System.EventHandler(this.cb_class_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(639, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 68);
            this.button8.TabIndex = 10;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "See absences by student:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "See records by student:";
            this.label2.Visible = false;
            // 
            // TeachersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(774, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.cb_class);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.b_excuse);
            this.Controls.Add(this.cb_absences);
            this.Controls.Add(this.b_records);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cb_lessons);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TeachersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELS.Teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_lessons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.Button b_records;
        private System.Windows.Forms.ComboBox cb_absences;
        private System.Windows.Forms.Button b_excuse;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.ComboBox cb_class;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}