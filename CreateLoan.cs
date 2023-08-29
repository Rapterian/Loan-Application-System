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

        protected double CalculateInterest()
        {
            double interest=0;
            interest = LoanAmount * InterestRate * Term;
            return interest;
        }

    }

}
