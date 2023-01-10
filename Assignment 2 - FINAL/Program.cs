using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thewordwagon;

namespace Thewordwagon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Here, a new loan is being created, calling the user class for user info, and the item class for the item info to complete the loan.
            Loan myLoan = new Loan(new User("Will", 07913902170, "willyoungslk@gmail.com"), new Item("Avatar", "DVD"));
        }
    }
}
