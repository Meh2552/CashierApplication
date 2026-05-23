using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Pomaris_CashierApplication
{
    public class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public bool verigyLogin(string id, string pass)
        {
            if (this.user_id.Equals(id) && this.user_password.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public virtual void updatePasswoord(string newPassword)
        {
            
        }
    }
}
