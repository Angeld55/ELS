using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ELS.GUI
{
    public partial class ParentPage : Form
    {
        private Users.Parent theParent = Login.theParent;
        public ParentPage()
        {
            InitializeComponent();
            foreach (DateTime date in theParent.Student.Class.Lessons.Keys)
            {
                cb_date.Items.Add(date.ToString("dd/MM/yyyy"));
                cb_dateOfRecords.Items.Add(date.ToString("dd/MM/yyyy"));
            }
        }

        private void b_records_Click(object sender, EventArgs e)
        {
            RecordsOfStudents ros = new RecordsOfStudents();
            ros.fillFields(theParent.Student);
            ros.Show();
        }

        private void cb_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_lesson.Items.Clear();
            string[] dates = cb_date.Text.Split('/');
            DateTime dt = new DateTime(Convert.ToInt32(dates[2]), Convert.ToInt32(dates[1]), Convert.ToInt32(dates[0]));
            foreach (School.Lesson lesson in theParent.Student.Class.Lessons[dt])
            {
                cb_lesson.Items.Add(lesson.ToString());
            }
        }

        private void b_view_Click(object sender, EventArgs e)
        {
            if (cb_lesson.Text == "" || cb_date.Text == "")
            {
                MessageBox.Show("Please select date and lesson!");
                return;
            }
            string[] dates = cb_date.Text.Split('/');
            DateTime dt = new DateTime(Convert.ToInt32(dates[2]), Convert.ToInt32(dates[1]), Convert.ToInt32(dates[0]));
            Regex r = new Regex("[0-9]+");
            Match m = r.Match(cb_lesson.Text);
            int count = Convert.ToInt32(m.Value) - 1;
            School.Lesson currentLesson = theParent.Student.Class.Lessons[dt][count];

            ViewLesson vl = new ViewLesson();
            vl.fillFields(currentLesson);

            vl.Show();
        }

        private void b_viewRecords_Click(object sender, EventArgs e)
        {
            dayRecords dr = new dayRecords();
            dr.fillFields(theParent.Student, cb_dateOfRecords.Text);
            dr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationRun.theLogin.Show();
        }

   
    }
}
