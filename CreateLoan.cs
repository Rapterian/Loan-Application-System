using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class CreateLoan : Loan
    {
        private double primeIntRate;
        public CreateLoan(double primeIntRate, string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term) : base(loanNumber, custLastname, custFirstname, loanAmount, interestRate, term)
        {
            this.PrimeIntRate = primeIntRate;
        }

        public double PrimeIntRate { get => primeIntRate; set => primeIntRate = value; }

        public override double overMaxLoan()
        {
            if (LoanAmount > 100000)
            {
                return 1;
            }
            else return 0;
            
        }
    }

}