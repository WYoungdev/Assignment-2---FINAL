using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class User
    {
        string name;
        long phonenumber;
        string emailaddress;

        public User(string name, long phonenumber, string emailaddress)
        { 
            this.name = name;
            this.phonenumber = phonenumber;
            this .emailaddress = emailaddress;
        }
    }
}
