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

        private double calcLoanFee()
        {
            double fee = 0;
            //TODO - LoanFee = LoanAmount * PersonalInt...
            return fee;
        }

        public double calcTotalAmountDue()
        {
            double totalAmountDue = 0;
            //TODO - TotalAmountDue = LoanAmount + interestRate + calcLoanFee()
            return totalAmountDue;
        }
    }
}
