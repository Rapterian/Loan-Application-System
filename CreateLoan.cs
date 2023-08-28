using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class CreateLoan : Loan
    {
        public CreateLoan(double interestRate, string custLastname, string custFirstname) : base(interestRate, custLastname, custFirstname)
        {
        }

        public double CalculateInterest()
        {
            double interest=0;
            //TODO - Interest = LoanAmount * InterestRate * LoanTerm
            return interest;
        }
    }

}
