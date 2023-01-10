using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Loan
    {
        public User LoanOwner { get; set; }
        public Item LoanItem { get; set; }

        public Loan(User LoanOwner, Item LoanItem) { 
            this.LoanItem= LoanItem;
            this.LoanOwner = LoanOwner;
        }
    }
}
