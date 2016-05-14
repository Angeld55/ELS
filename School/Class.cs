using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;

namespace ELS.School
{
    public class Class
    {
        private short grade;
        private char letter;
        private Teacher ClassTeacher;
        private List<Student> students;
        private bool initialized;// checks if the class is ready for work!(the numbers of the students are seted)
        private Dictionary<DateTime, List<Lesson>> lessons;
        public Class(short Grade,char letter,Teacher teacher,byte studentsInClass=30)
        {
            this.Grade = Grade;
            this.ClassLetter = letter;
            this.Teacher = teacher;
            Students = new List<Student>(studentsInClass);
            Lessons=new Dictionary<DateTime,List<Lesson>>();
            initialized = false; 
        }

        public bool isIntialized {
            get
            {
                return initialized;
            }  
       
        }
        public short Grade 
        {
            get 
            {
                return grade;
            }
            private set
            {
                if ((value<1)||(value>12))
                {
                    throw new InvalidOperationException("Invalid class!The grade should be between 1 and 12!");
                }
                grade = value;
            }
        }
        public Char ClassLetter
        {
            get
            {
                return letter;
            }
            private set
            {
                letter = value;
            }
        }
        public Dictionary<DateTime, List<Lesson>> Lessons
        {
            get
            {
                return lessons;
            }
            private set
            {
                this.lessons = value;
            }

        }

        public List<Student> Students
        {
            get
            {
                return students;
            }
            private set
            {
                this.students = value;
            }

        }

        public Teacher Teacher
        {
            get
            {
                return ClassTeacher;
            }
            private set
            {
                ClassTeacher = value;
            }
        }
        public void setStudentNumbers()
        {
            Students.Sort();
            
            ///set the students numbers (0 in the array --> 1 in class)
            for (byte i = 0; i < students.Count; i++)
            {
                students[i].NumberInClass =Convert.ToByte(i+1);
            }
            initialized = true;
        }
        public Student getStudentByNumber(byte number)
        {
            if (!initialized)
            {
                throw new ArgumentException("The class is not initialized!");
            }
            if ((students.Count<number)||(number<1))
            {
                throw new InvalidOperationException("There is no such student in this class");
            }
            return students[number - 1];
        }
        public override string ToString()
        {
            return Grade + ClassLetter.ToString();
        }

    }
}
