using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Loan //Here, a Loan class has been created to hold objects from the User and Item classes.
    { //Below, attributes are established for the Loan class. The user will input these attributes in the main program.
        public User LoanOwner { get; set; }
        public Item LoanItem { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime LoanDuration { get; set; }

        public Guid LoanID { get; set; }


        public Loan(User LoanOwner, Item LoanItem, int loanDuration) //Here, LoanOwner, LoanItem and LoanDuration objects are added to the Loan.
        {
            this.LoanItem = LoanItem; //Here, the individual variables are created ready for data to be stored in them.
            this.LoanOwner = LoanOwner;
            this.LoanDate = DateTime.Now;
            this.LoanDuration = this.LoanDate.AddDays(loanDuration);
            this.LoanID = Guid.NewGuid();
        }
        public override string ToString() //Display all of the loan details when the user has finished inputting them.
        {
            return
                    $"\n=============================================" +
                    $"\nThis are the details of the customer:{LoanOwner} " +
                    $"\nThis it the item details: {LoanItem}" +
                    $"\nThis is the todays date:{LoanDate}" +
                    $"\nThis is the loan duration:{LoanDuration}" +
                    $"\n=============================================";
        }
    }
}
