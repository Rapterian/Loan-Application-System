using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    
    internal class BusinessLoan : CreateLoan
    {
        double BusIntRate;

        public BusinessLoan(double BusIntRate,double primeIntRate, string loanNumber, string custLastname, string custFirstname, double loanAmount, double interestRate, int term) : base(primeIntRate, custLastname, custFirstname)
        {
            BusIntRate = interestRate + (primeIntRate * 0.01);
        }
    }
}
