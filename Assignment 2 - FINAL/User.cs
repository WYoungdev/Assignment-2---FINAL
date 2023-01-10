using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class User
        //Here, a User class has been created to specify the information relating to the user.
        //This class is called in the main program when new loans are created, as loans are inherited from the User.
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
