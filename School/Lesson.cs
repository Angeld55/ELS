using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
using ELS.Records;
namespace ELS.School
{
    public class Lesson
    {
        private Teacher teacher;
        private string subject;
        private Class schoolClass;
        private DateTime dateOFLesson;
        private List<Record> lessonRecords;
        private string description;
        private string homeWork;
        public Lesson(Teacher teacher, Class schoolClass,DateTime dateOfThisLesson)
        {
            this.Teacher = teacher;
            this.Subject = teacher.Subject;
            this.SchoolClass = schoolClass;
            this.DateOfLesson = dateOfThisLesson;
            this.lessonRecords = new List<Record>();
            this.Description = Description;
            this.HomeWork = HomeWork;
           
        }
        public Teacher Teacher 
        {
            get 
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }
        public String Subject
        {
            get
            {
                return this.subject;
            }
            private set
            {
                this.subject = value;
            }
        }
        public DateTime DateOfLesson
        {
            get
            {
                return this.dateOFLesson;
            }
            set
            {
                this.dateOFLesson = value;
            }
        }
        public Class SchoolClass
        {
            get
            {
                return this.schoolClass ;
            }
            set
            {
                this.schoolClass = value;
            }
        }
        public List<Record> LessonRecords
        {
            get
            {
                return this.lessonRecords;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
             private set
            {
                this.description = value;
            }
        }
        public string HomeWork
        {
            get
            {
                return this.homeWork;
            }
            private set
            {
                this.homeWork = value;
            }
        }
        public void AddDescription(string description)
        {
            this.Description = description;
        }
        public void AddHomeWork(string homework)
        {
            this.HomeWork = homework;
        }
    }
}
