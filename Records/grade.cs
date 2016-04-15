using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
namespace ELS.Records
{
    public class Grade : Record
    {
        private byte grade;
        public Grade(byte grade,Teacher teacher ,DateTime date, String note=null ):base(teacher,date,note)
        {
            if ((grade<2)||(grade>6))
            {
                throw new ArgumentException("Invalid grade! The grade should be between 2 and 6!");
            }
            this.GradeOfStudent = grade;
        }
        public byte GradeOfStudent
        {
            get
            {
                return this.grade;
            }
            private set 
            {
                this.grade = value;
            }
        }
    }
}
