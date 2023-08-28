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
        public CreateLoan(double primeInterestRate, string custLastname, string custFirstname) : base(custLastname, custFirstname)
        {
            this.PrimeInterestRate = primeInterestRate;
        }

        public double PrimeInterestRate { get => primeInterestRate; set => primeInterestRate = value; }

        
    }

}