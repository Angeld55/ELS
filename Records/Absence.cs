using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
namespace ELS.Records
{
    public class Absence : Record
    {
        private bool excused;
        private string noteForExusingTheAbsence;
        public Absence(Teacher teacher,DateTime Date,string Note=null):base(teacher ,Date,Note)
        {
            excused = false;
        }
        public bool Excused
        {
            get
            {
                return this.excused;
            }
            set
            {
                this.excused = value;
            }
        }

        public String NoteForExusingTheAbsence
        {
            get
            {
                return noteForExusingTheAbsence;
            }
            set
            {
                this.noteForExusingTheAbsence = value;
            }
        }
    }
}
