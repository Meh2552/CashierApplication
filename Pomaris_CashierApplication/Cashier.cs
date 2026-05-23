using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string fullName, string uName, string password, string dept) : base(fullName, uName, password) 
        { 
            this.department = dept;
        }

        public override bool validateLogin(string uName, string password)
        {
            return this.user_name.Equals(uName) && this.user_password.Equals(password);
        }

        public string getDepartment() { return department; }
    }
}
