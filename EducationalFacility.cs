using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ELS.Users;
using ELS.School;
namespace ELS
{
    public class EducationalFacility
    {
        private Director director;
        private Dictionary<string,User> users;
        private Dictionary<string, Teacher> teachers;
        private Dictionary<string, Student> students;
        private Dictionary<string,Class> schoolClasses;
        public EducationalFacility(String DirectorName,string DirectorEGN)
        {
            Users = new Dictionary<string, User>();
            Director = new Director(DirectorName, DirectorEGN,this);
            Classes = new Dictionary<string, Class>();
            Students = new Dictionary<string, Student>();
            Teachers = new Dictionary<string, Teacher>();
            
        }
        public Director Director
        {
            get 
            {
                return this.director;
            }
            private set
            {
                this.director = value;
            }
        }   
        public Dictionary<string,User> Users 
        {
            get
            {
                return users;
            }
            private set
            {
                this.users = value;
            }
        }
        public Dictionary<string, Class> Classes
        {
            get
            {
                return schoolClasses;
            }
            private set
            {
                this.schoolClasses = value;
            }
        }

        public Dictionary<string, Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }
        public Dictionary<string, Student> Students
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

        public User Identify(String Name, string EGN)
        {
            if (!Users.ContainsKey(Name))
            {
                throw new InvalidOperationException("No such user!");
            }
            User currentuser = Users[Name];
            if (currentuser.EGN != EGN)
            {
                throw new InvalidOperationException("Invalid password!");
            }
            return currentuser;

        }
       
    }
}
