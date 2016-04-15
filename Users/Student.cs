using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.School;
using ELS.Users;
using ELS.Records;

namespace ELS.Users
{
    public class Student : User, IComparable<Student>
    {
        private byte numberInClass;
        private Class lerningClass;
        private Parent parent;
        private Dictionary<DateTime,List<Record>> dayRecords;
        private Dictionary<string,List<Grade>> gradesBySubject;
        private List<Absence> absences;
        private List<Note> notes;
        private int unexcusedAbsences;
        public Student(string name,long egn):base(name,egn)
        {
            dayRecords=new Dictionary<DateTime,List<Record>>();
            gradesBySubject = new Dictionary<string, List<Grade>>();
            absences=new List<Absence>();
            notes = new List<Note>();
        }
        public byte NumberInClass 
        {
            get
            { 
                return this.numberInClass; 
            }
            set
            {
                numberInClass=value;
            }
        }
        public int UnexcusedAbsences
        {
            get
            {
                return this.unexcusedAbsences;
            }
            set
            {
                unexcusedAbsences = value;
            }
        }
        public Class Class
        {
            get
            {
                return this.lerningClass;
            }
            set
            {
                lerningClass = value;
            }
        }
        public Parent Parent
        {
            get
            {
                return this.parent;
            }
            set 
            {
                parent = value;
            }
        }
        public Dictionary<DateTime, List<Record>> DayRecords
        {
            get
            {
                return dayRecords;
            }
         
        }
        public Dictionary<string, List<Grade>> GradesBySubject
        {
            get
            {
                return gradesBySubject;
            }

        }
        public List<Absence> Absences
        {
            get
            {
                return absences;
            }

        }
        public List<Note> Notes
        {
            get
            {
                return notes;
            }

        }
        public List<Lesson> LessonsByDay(DateTime date)
        {
            return this.Class.Lessons[date];
        }
   
        

        public int CompareTo(Student other)
        {
            return this.Name.CompareTo(other.Name);
        }
        
    }
}
