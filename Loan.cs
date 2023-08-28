using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    abstract class Loan:LoanConstants
    {
        public int shortTerm { get { return 1; } }
        public int mediumTerm { get { return 3; } }
        public int longTerm { get { return 5; } }
        public string companyName { get { return ""; } }
        public double maxLoanAmount { get { return 100000d; } }

        private string loanNumber, custLastname, custFirstname;
        private double loanAmount, interestRate;
        private int term;

        public Loan(string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term)
        {
            this.LoanNumber = loanNumber;
            this.CustLastname = custLastname;
            this.CustFirstname = custFirstname;
            this.LoanAmount = loanAmount;
            this.InterestRate = interestRate;
            this.Term = term;
            if (loanAmount > maxLoanAmount)
            {
                this.LoanAmount = loanAmount;
                Console.WriteLine("Max Loan Amount is R100 000");
            }
            else { this.LoanAmount = loanAmount; }
            if (term != shortTerm || term != mediumTerm || term != longTerm)
            {
                this.term = shortTerm;
            }
            else { this.LoanAmount = term; }

        }

        public string LoanNumber { get => loanNumber; set => loanNumber = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int Term { get => term; set => term = value; }
        
        public override string ToString()
        {
             return $"Loan Number: \t \t{loanNumber} \n Customer lastname: \t{custLastname} \n Customer Name: \t{custFirstname} \n Loan Amount: \t\t{loanAmount} \n Interest Rate: \t {interestRate} \n Term: \t \t \t{term}";               
        }
        public abstract bool overMaxLoan(double value);
    }


}
