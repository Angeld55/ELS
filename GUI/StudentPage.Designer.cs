namespace ELS.GUI
{
    partial class StudentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPage));
            this.b_records = new System.Windows.Forms.Button();
            this.cb_date = new System.Windows.Forms.ComboBox();
            this.cb_lesson = new System.Windows.Forms.ComboBox();
            this.b_view = new System.Windows.Forms.Button();
            this.cb_dateOfRecords = new System.Windows.Forms.ComboBox();
            this.b_viewRecords = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_records
            // 
            this.b_records.Location = new System.Drawing.Point(27, 49);
            this.b_records.Name = "b_records";
            this.b_records.Size = new System.Drawing.Size(145, 40);
            this.b_records.TabIndex = 6;
            this.b_records.Text = "View records";
            this.b_records.UseVisualStyleBackColor = true;
            this.b_records.Click += new System.EventHandler(this.b_records_Click);
            // 
            // cb_date
            // 
            this.cb_date.FormattingEnabled = true;
            this.cb_date.Location = new System.Drawing.Point(337, 49);
            this.cb_date.Name = "cb_date";
            this.cb_date.Size = new System.Drawing.Size(149, 21);
            this.cb_date.TabIndex = 7;
            this.cb_date.SelectedIndexChanged += new System.EventHandler(this.cb_date_SelectedIndexChanged);
            // 
            // cb_lesson
            // 
            this.cb_lesson.FormattingEnabled = true;
            this.cb_lesson.Location = new System.Drawing.Point(337, 76);
            this.cb_lesson.Name = "cb_lesson";
            this.cb_lesson.Size = new System.Drawing.Size(287, 21);
            this.cb_lesson.TabIndex = 8;
            // 
            // b_view
            // 
            this.b_view.Location = new System.Drawing.Point(492, 49);
            this.b_view.Name = "b_view";
            this.b_view.Size = new System.Drawing.Size(132, 21);
            this.b_view.TabIndex = 9;
            this.b_view.Text = "View";
            this.b_view.UseVisualStyleBackColor = true;
            this.b_view.Click += new System.EventHandler(this.b_view_Click);
            // 
            // cb_dateOfRecords
            // 
            this.cb_dateOfRecords.FormattingEnabled = true;
            this.cb_dateOfRecords.Location = new System.Drawing.Point(337, 161);
            this.cb_dateOfRecords.Name = "cb_dateOfRecords";
            this.cb_dateOfRecords.Size = new System.Drawing.Size(149, 21);
            this.cb_dateOfRecords.TabIndex = 10;
            // 
            // b_viewRecords
            // 
            this.b_viewRecords.Location = new System.Drawing.Point(492, 161);
            this.b_viewRecords.Name = "b_viewRecords";
            this.b_viewRecords.Size = new System.Drawing.Size(132, 21);
            this.b_viewRecords.TabIndex = 11;
            this.b_viewRecords.Text = "View";
            this.b_viewRecords.UseVisualStyleBackColor = true;
            this.b_viewRecords.Click += new System.EventHandler(this.b_viewRecords_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(639, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 68);
            this.button8.TabIndex = 12;
            this.button8.Text = "Logout";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "See day records:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "See records by lesson:";
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(774, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.b_viewRecords);
            this.Controls.Add(this.cb_dateOfRecords);
            this.Controls.Add(this.b_view);
            this.Controls.Add(this.cb_lesson);
            this.Controls.Add(this.cb_date);
            this.Controls.Add(this.b_records);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELS.Student";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_records;
        private System.Windows.Forms.ComboBox cb_date;
        private System.Windows.Forms.ComboBox cb_lesson;
        private System.Windows.Forms.Button b_view;
        private System.Windows.Forms.ComboBox cb_dateOfRecords;
        private System.Windows.Forms.Button b_viewRecords;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}