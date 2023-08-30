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
        public PersonalLoan(double interestRate,string custLastname, string custFirstname) : 
            base(interestRate, custLastname, custFirstname)
        {
            calcInterestRate();
        }

        private void calcInterestRate()
        {
            InterestRate = InterestRate + 2d;
        }

        public double calcPersonalTotalAmountDue()
        {
            double totalAmountDue = 0;
            totalAmountDue = LoanAmount + CalculateInterest();
            return totalAmountDue;
        }
        public override string ToString()
        {
            return $" Loan Number: {LoanNumber} \n Customer: {CustLastname} {CustFirstname} \n Loan Amount: R{LoanAmount}\n  Loan Type: Personal\n Interest Rate:  {InterestRate}% \n Term: {Term} year(s) \n Total Amount Due: R{calcPersonalTotalAmountDue()}";
        }
    }

}
