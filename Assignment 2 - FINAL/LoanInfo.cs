using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class LoanInfo
    {
        int loandate;
        int loantime;
        int loanduration;
        Guid loanID;

        public LoanInfo(int loandate, int loantime, int loanduration, Guid loanID)
        {
            this.loandate = loandate;
            this.loantime = loantime;
            this.loanduration = loanduration;
            this.loanID = loanID;
        }   
    }
}
