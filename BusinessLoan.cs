using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{

    internal class BusinessLoan : CreateLoan
    {
        static double BuisnessIntRate = 0.01;
        public BusinessLoan(double interestRate, string custLastname, string custFirstname) :
            base(interestRate, custLastname, custFirstname)
        { 

        }
        private double calcBuisnessLoanFee()
        {
            double loanFee = 0;
            loanFee = LoanAmount * BuisnessIntRate;
            return loanFee;
        }

        public double calcBuisnessTotalAmountDue()
        {
            double totalAmountDue = 0;
            totalAmountDue = LoanAmount + InterestRate + calcBuisnessLoanFee();
            return totalAmountDue;
        }
    }
}
