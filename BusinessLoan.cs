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
            calcInterestRate();
        }
        private void calcInterestRate()
        {
            InterestRate = InterestRate + 1d;
        }

        public double calcBuisnessTotalAmountDue()
        {
            double totalAmountDue = 0;
            totalAmountDue = LoanAmount + CalculateInterest();
            return totalAmountDue;
        }
        public override string ToString()
        {
            return $" Loan Number: {LoanNumber} \n Customer: {CustLastname} {CustFirstname} \n Loan Amount: R{LoanAmount} \n Loan Type: Business\n Interest Rate:  {InterestRate}% \n Term: {Term} year(s) \n Total Amount Due: R{calcBuisnessTotalAmountDue()}";
        }
    }
}
