﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Loan
    {
        int loandate;
        int loantime;
        int loanduration;
        Guid loanID;
        public User LoanOwner { get; set; }
        public Item LoanItem { get; set; }

        public Loan(User LoanOwner, Item LoanItem) { 
            this.LoanItem= LoanItem;
            this.LoanOwner = LoanOwner;
            //Is the section below correct ??
            this.loandate = loandate;
            this.loantime = loantime;
            this.loanduration = loanduration;
            this.loanID = loanID;

        }
    }
}
