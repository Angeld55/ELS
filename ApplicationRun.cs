using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
using ELS.School;
using ELS.Records;
using System.Windows.Forms;
using ELS.GUI;

namespace ELS
{
    public class ApplicationRun
    {
        public static Login theLogin; 
        static void Main(string[] args)
        {
            //EducationalFacility facility = new EducationalFacility("Petur Ivanov", 6712023451);
            //Director currentUser = (Director)facility.Identify("Petur Ivanov", 6712023451);
            //currentUser.CreateAssistantDirector("Angel Ivanov", 9504244449);
            //AssistantDirector currenUser2 = (AssistantDirector)facility.Identify("Angel Ivanov", 9504244449);
            //currenUser2.CreateTeacher("Stefan ivanov", 12423432, "Sports");
            //currenUser2.CreateClass(5, 'D', facility.Teachers["Stefan ivanov"], 2);
            //currenUser2.CreateStudent("Alex Savov", 13234234);
            //currenUser2.AddStudentToClass(facility.Students["Alex Savov"], facility.Classes["5D"]);

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            theLogin = new Login();
            Application.Run(theLogin);
        }
    }
}
