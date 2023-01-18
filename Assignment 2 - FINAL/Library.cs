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
        public List<Loan> CurrentLoanList; //Here, lists are created for each of the Classes in the program
        public List<User> CurrentUserList; //excluding the CLI, so that the objects of each class can be stored.
        public List<Item> CurrentItemList;

        public string LibraryName { get; set; }

        public Library(string LibraryName)
        {
            this.LibraryName = LibraryName;
            this.CurrentLoanList = new List<Loan>();
            this.CurrentUserList = new List<User>();
            this.CurrentItemList = new List<Item>();

        }
    }
}
