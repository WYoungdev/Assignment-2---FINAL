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
        public static void Createnewloan(string[] args)
        {
            Console.WriteLine("Please fill in the new loan form below.");
            Console.WriteLine("-----------------------------------------------------");
            //Here, a new loan is being created, calling the user class for user info,
            //and the item class for the item info to complete the loan.
            Loan myLoan = new Loan(new User("Will", 07913902170, "willyoungslk@gmail.com"), new Item("Avatar", "DVD"), new LoanInfo("10/01/23", 1132, 30, Guid.Empty);
            Library.CurrentLoanList.Add(myLoan);
        }

        public static void PrintCurrentLoans() {


        }
    }
}
