using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class CreateLoan : Loan
    {
        private double primeInterestRate;
        public CreateLoan(double primeIntRate, string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term) : base(loanNumber, custLastname, custFirstname, loanAmount, interestRate, term)
        {
            this.PrimeInterestRate = primeIntRate;
        }

        public double PrimeInterestRate { get => primeInterestRate; set => primeInterestRate = value; }

        public override bool overMaxLoan(double value)
        {
            if (value > maxLoanAmount)
            {
                return true;
            }
            else return false;
            
        }
    }

}