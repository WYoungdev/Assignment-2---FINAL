using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    class Library //The Library class is responsible for storing every
                  //user input in respective lists for later recalling.
    {
        public List<Loan> CurrentLoanList; //Here, lists are set out for each of the Classes in the program
        public List<User> CurrentUserList; //excluding the CLI, so that the objects of each class can be stored.
        public List<Item> CurrentItemList;

        public string LibraryName { get; set; }

        public Library(string LibraryName) //Here, the lists themselves are actually created for the program to use.
        {
            this.LibraryName = LibraryName;
            this.CurrentLoanList = new List<Loan>();
            this.CurrentUserList = new List<User>();
            this.CurrentItemList = new List<Item>();

        }


        public User GetUser(string Name) //The GetUser method checks the CurrentUserList to see if there is
                                         //a customer with the same name as the user input.
        {
            foreach (var user in this.CurrentUserList)
            {
                if (user.name == Name)
                {
                    return user; //If a user in the CurrentUserList is found, it is displayed.
                }

            }
            return null; //If a user is not found, nothing will happen.
        }

        public Loan GetLoan(User user) //The GetLoan method takes the result of the GetUser method to
                                       //check if there is a loan associated with the user. If there is, the loan is displayed.
        {
            foreach (var loan in this.CurrentLoanList)
            {

                if (loan.LoanOwner == user)
                {
                    return loan;

                }
            }
            return null; //If no loan is found, nothing will happen.
        }
    }
}
