using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;

namespace ELS.Records
{
    public abstract class Record
    {
        private string subject;
        private DateTime date;
        private string note;
        private Teacher teacher;
        public Record(Teacher teacher,DateTime Date,string note=null)
        {
            this.Teacher = teacher;
            this.Subject = teacher.Subject;
            this.Date = Date;
            this.Note = note;
        }
        public Teacher Teacher
        {
            get
            {
                return this.teacher;
            }
            private set
            {
                this.teacher = value;
            }
        }
        public string Subject 
        { 
            get
            {
                return this.subject;
            } 
            private set
            {
             this.subject=value;   
            } 
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }
            private set
            {
                this.note = value;
            }
        }
    }
}
