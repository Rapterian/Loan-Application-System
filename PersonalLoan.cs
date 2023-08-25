using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
        public class PersonalLoan : Loan
        {
            public PersonalLoan(int loanNumber, string lastName, string firstName, double loanAmount, int term, double primeInterestRate) : base(loanNumber, lastName, firstName, loanAmount, term)
            {
                InterestRate = primeInterestRate + 0.02;
            }

            public override double CalculateTotalAmountOwed()
            {
                return LoanAmount * (1 + InterestRate);
            }
        }
}
