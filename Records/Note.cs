using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
namespace ELS.Records
{
    public class Note : Record
    {
        public Note(Teacher teacher,DateTime date, String note):base(teacher,date,note)
        {

        }
    }
}
