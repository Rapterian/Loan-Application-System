using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    abstract class Loan
    {
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
            if (loanAmount > 100000)
            {
                this.LoanAmount = loanAmount;
                Console.WriteLine("Max Loan Amount is R100 000");
            }
            else { this.LoanAmount = loanAmount; }
            if (term != 1 || term != 3 || term != 5)
            {
                this.term = 1;
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
        public abstract double overMaxLoan();
    }


}
