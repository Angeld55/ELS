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
    public partial class RecordsOfStudents : Form
    {
        public RecordsOfStudents()
        {
            InitializeComponent();
        }

        public void fillFields(Users.Student student) {
            foreach (String subject in student.GradesBySubject.Keys)
            {
                rtxt_grades.Text += subject + ": \n";
                foreach (Records.Grade grade in student.GradesBySubject[subject])
                {
                    rtxt_grades.Text += grade.GradeOfStudent + "(" + grade.Date.ToString("dd/MM/yyyy") + ") ";
                }
                rtxt_grades.Text += "\n";
            }
            
                rtxt_absences.Text +=  "Absences: \n";
                foreach (Records.Absence absence in student.Absences)
                {
                    rtxt_absences.Text +=absence.Subject+" "+ "(" + absence.Date.ToString("dd/MM/yyyy") + ") is excused: " + (absence.Excused ? "YES" : "NO")+"  ";
                    rtxt_grades.Text += "\n";
                }


                rtxt_note.Text += "Notes: \n";
                foreach (Records.Note note in student.Notes)
                {
                    rtxt_note.Text += "(" + note.Date.ToString("dd/MM/yyyy") + "): \n" + note.Note;
                    rtxt_note.Text += "\n";
                }
        }
    
    }
}


