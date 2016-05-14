using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Records;

namespace ELS.Users
{
    public class Parent : User
    {
        private Student student;
        public Parent(string name,string egn,Student student):base(name,egn)
        {
            this.student = student;
        }
        public Student Student 
        { 
            get
            {
                return this.student;
            }
            private set
            {
                this.student = value;
            }
        }

        public Dictionary<string, List<Grade>> getStudentGrades()
        {
            return Student.GradesBySubject;
        }
        public List<Absence> getStudentAbsences()
        {
            return Student.Absences;
        }
        public Dictionary<DateTime,List<Record>> getStudentRecords()
        {
            return Student.DayRecords;
        }
        public List<Note> getStudentNotes()
        {
            return Student.Notes;
        }

    }
}
