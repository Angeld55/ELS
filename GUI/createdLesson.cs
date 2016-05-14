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
  
    public partial class createdLesson : Form
    {
        private EducationalFacility facility = Login.facility;
        private Users.Teacher theTeacher = Login.theTeacher;
        private School.Class theClass = null;
        public createdLesson(School.Class classes)
        {
            theClass = classes;
            InitializeComponent();
            foreach (Object student in theClass.Students)
            {
                cb_grade.Items.Add(student.ToString());
                cb_absence.Items.Add(student.ToString());
                cb_note.Items.Add(student.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtxt_description.Visible = false;
            b_description.Visible = false;
            cb_absence.Visible = false;
            b_absence.Visible = false;
            rtxt_note.Visible = false;
            cb_note.Visible = false;
            b_note.Visible = false;
            rtxt_homework.Visible = false;
            b_homework.Visible = false; 

            nup_grade.Visible = true;
            cb_grade.Visible = true;
            b_grade.Visible = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtxt_description.Visible = false;
            b_description.Visible = false;
            cb_absence.Visible = false;
            b_absence.Visible = false;
            nup_grade.Visible = false;
            cb_grade.Visible = false;
            b_grade.Visible = false;
            rtxt_note.Visible = false;
            cb_note.Visible = false;
            b_note.Visible = false;

            rtxt_homework.Visible = true;
            b_homework.Visible = true; 
        }

        private void b_grade_Click(object sender, EventArgs e)
        {
            if (cb_grade.Text == "") {
                MessageBox.Show("There is no selected student!");
                return;
            }

            School.Lesson currentLesson = theTeacher.CurrentLesson;
            byte numberOfStudent = facility.Students[cb_grade.Text].NumberInClass;
            byte grade = (byte)nup_grade.Value;

            theTeacher.AddGradeToStudent(currentLesson, numberOfStudent, grade);

            MessageBox.Show(nup_grade.Value + " is added as Grade to " + cb_grade.Text);
            cb_grade.ResetText();
            nup_grade.ResetText();                 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nup_grade.Visible = false;
            cb_grade.Visible = false;
            b_grade.Visible = false;
            b_note.Visible = false;
            rtxt_note.Visible = false;
            cb_note.Visible = false;
            rtxt_homework.Visible = false;
            b_homework.Visible = false;
            rtxt_description.Visible = false;
            b_description.Visible = false;

            cb_absence.Visible = true;
            b_absence.Visible = true;


        }

        private void b_absence_Click(object sender, EventArgs e)
        {
            if (cb_absence.Text == "")
            {
                MessageBox.Show("There is no selected student!");
                return;
            }    
            School.Lesson currentLesson = theTeacher.CurrentLesson;
            byte numberOfStudent = facility.Students[cb_absence.Text].NumberInClass;

            theTeacher.AddAbsenceToStudent(currentLesson, numberOfStudent);
            MessageBox.Show("Absence is added to the student " + cb_absence.Text);
            cb_absence.ResetText();
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cb_absence.Visible = false;
            b_absence.Visible = false;
            nup_grade.Visible = false;
            cb_grade.Visible = false;
            b_grade.Visible = false;
            rtxt_homework.Visible = false;
            b_homework.Visible = false;
            rtxt_description.Visible = false;
            b_description.Visible = false;

            b_note.Visible = true;
            rtxt_note.Visible = true;
            cb_note.Visible = true;

        }

        private void b_note_Click(object sender, EventArgs e)
        {
            if (cb_note.Text == "")
            {
                MessageBox.Show("There is no selected student!");
                return;
            }

              if (rtxt_note.Text == "")
            {
                MessageBox.Show("There is no note!");
                return;
            }

            School.Lesson currentLesson = theTeacher.CurrentLesson;
            byte numberOfStudent = facility.Students[cb_note.Text].NumberInClass;
            string note = rtxt_note.Text;

            theTeacher.AddNoteToStudent(currentLesson, numberOfStudent, note);
            MessageBox.Show("Note added to student " + cb_note.Text);
            cb_absence.ResetText();
        }

        private void b_homework_Click(object sender, EventArgs e)
        {
            if (rtxt_homework.Text == "")
            {
                MessageBox.Show("There is no text!");
                return;
            }

            School.Lesson currentLesson = theTeacher.CurrentLesson;
            string homeworkText = rtxt_homework.Text;
            theTeacher.LessonAddHomeWork(currentLesson, homeworkText);

            MessageBox.Show("Homework added!");
            rtxt_homework.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_absence.Visible = false;
            b_absence.Visible = false;
            nup_grade.Visible = false;
            cb_grade.Visible = false;
            b_grade.Visible = false;
            rtxt_note.Visible = false;
            cb_note.Visible = false;
            b_note.Visible = false;
            rtxt_homework.Visible = false;
            b_homework.Visible = false;
            rtxt_description.Visible = true;
            b_description.Visible = true;
        }

        private void b_description_Click(object sender, EventArgs e)
        {

            if (rtxt_description.Text == "")
            {
                MessageBox.Show("There is no text!");
                return;
            }

            School.Lesson currentLesson = theTeacher.CurrentLesson;
            string descriptionText = rtxt_description.Text;
            theTeacher.LessonAddDescription(currentLesson, descriptionText);

            MessageBox.Show("Description added!");
            rtxt_description.ResetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showLesson(theTeacher.CurrentLesson);
        }

        public void showLesson(School.Lesson lesson){
            
            ViewLesson vl = new ViewLesson();
            vl.fillFields(lesson);
            vl.Show();

        }


    }
}
