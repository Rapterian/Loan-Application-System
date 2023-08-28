using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class CreateLoan : Loan
    {
        public CreateLoan(double primeInterestRate, string custLastname, string custFirstname) : base(custLastname, custFirstname)
        {
            PrimeInterestRate = primeInterestRate;
        }

        public double PrimeInterestRate { get; set; }
        
    }

}
