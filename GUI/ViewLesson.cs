using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELS.GUI
{

    public partial class ViewLesson : Form
    {
      
        public ViewLesson()
        {
            InitializeComponent();
        }

        public void fillFields(School.Lesson lesson) {

            rtxt_description.Text = lesson.Description;
            rtxt_homework.Text = lesson.HomeWork;
            foreach (Records.Record record in lesson.LessonRecords)
            {
                string type = record.GetType().ToString().Substring(12);
                rtxt_records.Text += type + " " + record.Student;
                if (type == "Grade") {
                    rtxt_records.Text += " " + ((Records.Grade)record).GradeOfStudent;
                }
                else if(type == "Note")
                {
                    rtxt_records.Text += ": \" " + record.Note + "\"";
                }
                rtxt_records.Text += "\n";           
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
