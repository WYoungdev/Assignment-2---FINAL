using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    class Library
    {
        public List<Loan> CurrentLoanList;
        public List<User> CurrentUserList;
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
