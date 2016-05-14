namespace ELS.GUI
{
    partial class addClass
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
            this.txt_numberOfStudents = new System.Windows.Forms.TextBox();
            this.txt_Letter = new System.Windows.Forms.TextBox();
            this.nup_grade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_teachers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_grade)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numberOfStudents
            // 
            this.txt_numberOfStudents.Location = new System.Drawing.Point(638, 56);
            this.txt_numberOfStudents.Name = "txt_numberOfStudents";
            this.txt_numberOfStudents.Size = new System.Drawing.Size(37, 20);
            this.txt_numberOfStudents.TabIndex = 2;
            this.txt_numberOfStudents.Text = "30";
            // 
            // txt_Letter
            // 
            this.txt_Letter.Location = new System.Drawing.Point(638, 111);
            this.txt_Letter.Name = "txt_Letter";
            this.txt_Letter.Size = new System.Drawing.Size(37, 20);
            this.txt_Letter.TabIndex = 3;
            // 
            // nup_grade
            // 
            this.nup_grade.Location = new System.Drawing.Point(221, 56);
            this.nup_grade.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nup_grade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_grade.Name = "nup_grade";
            this.nup_grade.Size = new System.Drawing.Size(199, 20);
            this.nup_grade.TabIndex = 4;
            this.nup_grade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grade: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teacher: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(516, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class Letter: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(448, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of students: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_teachers
            // 
            this.cb_teachers.FormattingEnabled = true;
            this.cb_teachers.Location = new System.Drawing.Point(221, 110);
            this.cb_teachers.Name = "cb_teachers";
            this.cb_teachers.Size = new System.Drawing.Size(199, 21);
            this.cb_teachers.TabIndex = 11;
            // 
            // addClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(867, 239);
            this.Controls.Add(this.cb_teachers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nup_grade);
            this.Controls.Add(this.txt_Letter);
            this.Controls.Add(this.txt_numberOfStudents);
            this.Name = "addClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a class";
            ((System.ComponentModel.ISupportInitialize)(this.nup_grade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numberOfStudents;
        private System.Windows.Forms.TextBox txt_Letter;
        private System.Windows.Forms.NumericUpDown nup_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_teachers;
    }
}