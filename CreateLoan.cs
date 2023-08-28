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
        private double loanFee;
        private double interest;
        private double totalAmountDue;
        public CreateLoan(double totalAmountDue, double interest, double loanFee, double primeIntRate, string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term) : 
            base(loanNumber, custLastname, custFirstname, loanAmount, interestRate, term)
        {
            this.PrimeInterestRate = primeIntRate;

            interest = loanAmount * interestRate * term;
            loanFee = loanAmount * loanFee;
            totalAmountDue = loanAmount + interest + loanFee;
        }

        public double PrimeInterestRate { get => primeInterestRate; set => primeInterestRate = value; }
        public double LoanFee { get => loanFee; set => loanFee = value; }
        public double Interest { get => interest; set => interest = value; }
        public double TotalAmountDue1 { get => totalAmountDue; set => totalAmountDue = value; }

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
