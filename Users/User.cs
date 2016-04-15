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
        private long egn;
        
        public User(string name,long egn)
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
        public long EGN
        {
            get
            {
                return this.egn;
            }
        }
    }
}
