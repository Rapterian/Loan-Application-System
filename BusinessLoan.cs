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
    }
}
