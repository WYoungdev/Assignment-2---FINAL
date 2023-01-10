using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class LoanInfo
        //The LoanInfo class was created to be called by the CreateNewLoan method to collect loan-specific data for the Loan class.
    {
        string loandate;
        int loantime;
        int loanduration;
        Guid loanID;

        public LoanInfo(string loandate, int loantime, int loanduration, Guid loanID)
        {
            this.loandate = loandate;
            this.loantime = loantime;
            this.loanduration = loanduration;
            this.loanID = loanID;
        }   
    }
}
