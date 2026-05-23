using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string fullName, string uName, string password)
        {
            this.full_name = fullName;
            this.user_name = uName;
            this.user_password = password;
        }

        public virtual bool validateLogin(string uName, string password)
        {
            return false;
        }

        public string getFullName()
        {
            return this.full_name;
        }
    }
}
