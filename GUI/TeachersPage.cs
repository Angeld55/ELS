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
    public partial class TeachersPage : Form
    {
        private  Users.Teacher theTeacher = Login.theTeacher;
        private static EducationalFacility facility = Login.facility;

       
        public TeachersPage(Users.Teacher teacher)
        {
            this.theTeacher = teacher;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cb_lessons.Visible = false;
            b_records.Visible = false;
            cb_student.Visible = false;
            txt_note.Visible = false;
            b_excuse.Visible = false;
            cb_absences.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            cb_class.Items.Clear();
            foreach (string theClass in facility.Classes.Keys)
            {
                cb_class.Items.Add(theClass);
            }


            cb_class.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_class.Visible = false;
            cb_student.Visible = false;
            b_records.Visible = false;
            txt_note.Visible = false;
            b_excuse.Visible = false;
            cb_absences.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            
            cb_lessons.Items.Clear();
            int count = 1;
            foreach (School.Lesson lesson in theTeacher.LessonsByThisTeacher)
            {
                cb_lessons.Items.Add(count + ". " + lesson.ToString());
                count++;
            }
            cb_lessons.Visible = true;
        }

        private void cb_lessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewLesson vl = new ViewLesson();
            string number = "";
            for (int i = 0; i < cb_lessons.Text.Length; i++)
            {
                if (cb_lessons.Text[i] == '.') {
                    number = cb_lessons.Text.Substring(0, i);
                    break;
                }
            } 
            vl.fillFields(theTeacher.LessonsByThisTeacher[Convert.ToInt32(number) - 1]);
            vl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.theTeacher.ClassOfTeacher == null)
            {
                MessageBox.Show("You can't administrate any class!");
            }
            else
            {
                cb_lessons.Visible = false;
                cb_class.Visible = false;

                cb_student.Items.Clear();

                foreach (Users.Student student in theTeacher.ClassOfTeacher.Students)
                {
                    cb_student.Items.Add(student.ToString());
                }



                cb_student.Visible = true;
                b_records.Visible = true;
                txt_note.Visible = true;
                b_excuse.Visible = true;
                cb_absences.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cb_student.Text == "") {
                MessageBox.Show("Student is not selected");
                    return; 
            }
            RecordsOfStudents ros = new RecordsOfStudents();
            ros.fillFields(facility.Students[cb_student.Text]);
            ros.Show();
            
        }

        private void cb_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_absences.Items.Clear();
            Users.Student currentStudent = facility.Students[cb_student.Text];
            int count = 1; 
            foreach (Records.Absence absence in currentStudent.Absences)
            {
                if (!absence.Excused)
                {
                    cb_absences.Items.Add(count + ". " + absence.Date.ToString("dd/MM/yyyy") + " " + absence.Teacher.Subject);
                }
                else {
                    cb_absences.Items.Add(count + ". " + absence.Date.ToString("dd/MM/yyyy") + " " + absence.Teacher.Subject + " - EXCUSED");
                }
                count++;
            } 
        }

        private void b_excuse_Click(object sender, EventArgs e)
        {
            if (txt_note.Text == "") {
                MessageBox.Show("Note is empty");
                return;
            }

            if (cb_absences.Text == "")
            {
                MessageBox.Show("Please select absence");
                return;
            }

            string absence = cb_absences.Text;
            Regex r = new Regex("[0-9]+");
            Match m = r.Match(absence);
            int count = Convert.ToInt32(m.Value) - 1;
            string note = txt_note.Text;
            Users.Student currentStudent = facility.Students[cb_student.Text];
            Records.Absence theAbsence = currentStudent.Absences[count];
            theTeacher.ExcuseAbsenceToStudent(currentStudent, theAbsence, note);

            MessageBox.Show("you have exused the absence: " + theAbsence.Date.ToString("dd/MM/yyyy"));
            cb_absences.Items.Remove(absence);

        }

        private void cb_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            School.Class theClass = facility.Classes[cb_class.Text];
            createdLesson cl = new createdLesson(theClass);
            theTeacher.CreateLesson(theClass);
            cl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationRun.theLogin.Show();
        }


    }
}
