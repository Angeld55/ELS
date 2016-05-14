using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELS.Users
{
    public abstract class User
    {

        private string NameOfUser;
        private string egn;

        public User(string name, string egn)
        {
            NameOfUser = name;
            this.egn = egn;
        }
        public string Name
        {
            get
            {
                return this.NameOfUser;
            }

        }
        public string EGN
        {
            get
            {
                return this.egn;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
        public static string userType(User user)
        {
            string typeOfUser = "";
            if (user is Director) {
                typeOfUser = "director";
            }

            if (user is Student)
            {
                typeOfUser = "student";
            }

            if (user is Teacher)
            {
                typeOfUser = "teacher";
            }

             if (user is Parent)
            {
                typeOfUser = "parent";
            }

             if (user is AssistantDirector) {
                 typeOfUser = "AssDirector";
             }
           
            return typeOfUser;
        }
    }
}
