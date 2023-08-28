using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class PersonalLoan : CreateLoan
    {
        double PersonalIntRate;
        public PersonalLoan(double PersonalIntRate, double primeIntRate, string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term) : 
            base(primeIntRate, loanNumber, custLastname, custFirstname, loanAmount, interestRate, term)
        {
            PersonalIntRate = interestRate + (primeIntRate * 0.02);
        }

    }
}
