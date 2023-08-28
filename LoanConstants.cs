using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    public interface LoanConstants
    {
        double shortTerm { get; }
        double mediumTerm { get; }
        double longTerm { get; }
        string companyName { get; }
        double maxLoanAmount { get; }
    }
}
