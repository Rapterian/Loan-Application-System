using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class PersonalLoan : CreateLoan
    {
        static double PersonalIntRate=0.02;
        public PersonalLoan(double interestRate,string custLastname, string custFirstname,double loanAmount) : 
            base(interestRate, custLastname, custFirstname)
        {

        }
        private double calcPersonalLoanFee()
        {
            double loanFee = 0;
            loanFee = LoanAmount * PersonalIntRate;
            return loanFee;
        }

        public double calcPersonalTotalAmountDue()
        {
            double totalAmountDue = 0;
            totalAmountDue = LoanAmount + InterestRate + calcPersonalLoanFee();
            return totalAmountDue;
        }
    }
}
