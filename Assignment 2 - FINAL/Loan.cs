using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Loan
    { //Below, attributes are established for the Loan class. The user will input these attributes in the main format.
        public User LoanOwner { get; set; }
        public Item LoanItem { get; set; }
        public DateTime LoanDate { get; set; }
        public int LoanDuration { get; set; }
        public DateTime DueDate { get; set; }
        public Guid LoanID { get; set; }


        public Loan(User LoanOwner, Item LoanItem, DateTime LoanDate, int LoanDuration, DateTime DueDate) //This defines the format in which the user should input Loan attributes.
        {
            this.LoanItem= LoanItem;
            this.LoanOwner = LoanOwner;
            this.LoanDate = LoanDate;
            this.LoanDuration = LoanDuration;
            this.DueDate = this.LoanDate.AddDays(LoanDuration);
            this.LoanID = Guid.NewGuid();
        }
    }
}
