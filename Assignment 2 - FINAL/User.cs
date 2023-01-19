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
        public string name; //The User class is configured with attributes that can later be created.
        public string phonenumber;
        public string emailaddress;



        public User(string name, string phonenumber, string emailaddress) //Here, variables are actually created based on the attributes above,
                                                                          //to store information about the user.
        {
            this.name = name;
            this.phonenumber = phonenumber;
            this.emailaddress = emailaddress;
        }
        public override string ToString() //Displays all of the User information based on what was entered when prompted.
        {
            return
                $"\n===============================================" +
                $"\nThis is the user name: {name}" +
                $"\nThis is the user phone number: {phonenumber}" +
                $"\nThis is the user email address: {emailaddress}" +
                $"\n===============================================";

        }
    }
}
