using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Loan_Application_System
{
    /// <summary>
    /// Abstract class implementing the LoanConstants Interface. 
    /// This base class stores all necesary info about a loan in one object
    /// as well as have some useful functions.
    /// </summary>
    abstract class Loan : LoanConstants
    {
        /// <summary>
        /// The constant amount of years for the Short Term 
        /// </summary>
        public int shortTerm { get { return 1; } }
        /// <summary>
        /// The constant amount of years for the Medium Term 
        /// </summary>
        public int mediumTerm { get { return 3; } }
        /// <summary>
        /// The constant amount of years for the Long Term 
        /// </summary>
        public int longTerm { get { return 5; } }
        /// <summary>
        /// The company name as a constant value
        /// </summary>
        public string companyName { get { return "Loan Sharks"; } }
        /// <summary>
        /// The max amount you may borrow as a constant
        /// </summary>
        public double maxLoanAmount { get { return 100000d; } }
        /// <summary>
        /// The min amount you may borrow as a constant
        /// </summary>
        public double minLoanAmount { get { return 500d; } }
        /// <summary>
        /// Constructor for a Loan that generates a random loan number
        /// </summary>
        /// <param name="custLastname">Customers Last Name</param>
        /// <param name="custFirstname">Customers First Name</param>
        public Loan(double interestRate, string custLastname, string custFirstname)
        {
            LoanNumber = randomInteger();
            CustLastname = custLastname;
            CustFirstname = custFirstname;
            InterestRate = interestRate;
        }

        protected Loan(string custLastname, string custFirstname)
        {
            CustLastname = custLastname;
            CustFirstname = custFirstname;
        }

        /// <summary>
        /// Loan number is randomly generated thus it only gets a get function
        /// </summary>
        public int LoanNumber { get; }
        /// <summary>
        /// Getter or Setter function for Customer Last Name
        /// </summary>
        public string CustLastname { get; set; }
        /// <summary>
        /// Getter or Setter function for Customer Last Name
        /// </summary>
        public string CustFirstname { get; set; }
        /// <summary>
        /// Getter or Setter for the amount that is being lent
        /// </summary>
        public double LoanAmount { get; set; }
        /// <summary>
        /// The interset rate in double format.
        /// </summary>
        public double InterestRate { get; set; }
        /// <summary>
        /// The amount of years before loan is payed back
        /// </summary>
        public int Term { get; set; }
        /// <summary>
        /// Loan to string function
        /// </summary>
        /// <returns>summary of loan</returns>
        public override string ToString()
        {
            return $"Loan Number: {LoanNumber} \n Customer lastname: {CustLastname} \n Customer Name:{CustFirstname} \n Loan Amount: {LoanAmount} \n Interest Rate:  {InterestRate} \n Term: {Term}";
        }


        /// <summary>
        /// Checks wether the amount of years are one of the choices given
        /// </summary>
        /// <returns>boolean</returns>
        public void loanTermValid(string term)
        {
            if (Term != shortTerm || Term != mediumTerm || Term != longTerm)
            {
                Console.WriteLine($"Term duration is not one of the options given. Term amount will be set to {shortTerm}");
            }
        }
        /// <summary>
        /// Creates a random interger between 0 and 10000
        /// </summary>
        /// <returns>Random integer</returns>
        private int randomInteger()
        {

            var random = new Random();
            return random.Next(0, 10000);

        }

        public static string nameCheck(string name)
        {
            while (!Checks.stringLengthCheck(name, 2, 50) || Checks.hasSpecialCharector(name))
            {
                Console.WriteLine("Please re-enter:");
                name = Console.ReadLine();
            }
            return name;
        }

        public static double loanAmountCheck(string loanAmount, double min, double max)
        {
            while (!Checks.isDouble(loanAmount))
            {
                Console.WriteLine("Please re-enter:");
                loanAmount = Console.ReadLine();
            }
            double loanAmountAsDouble = double.Parse(loanAmount);
            while (loanAmountAsDouble < min)
            {
                Console.WriteLine($"Loan Amount can't be less than {min}.\nPlease re-enter:");
                loanAmount = Console.ReadLine();
                loanAmountAsDouble= loanAmountCheck(loanAmount, min, max);
            }
            while (loanAmountAsDouble > max)
            {
                Console.WriteLine($"Loan Amount can't be more than {max}.\nPlease re-enter:");
                loanAmount = Console.ReadLine();
                loanAmountAsDouble = loanAmountCheck(loanAmount, min, max);
            }
            return loanAmountAsDouble;
        }

        public static double interestRateCheck(string interestRate)
        {
            while (!Checks.isDouble(interestRate))
            {
                Console.WriteLine("Please re-enter:");
                interestRate = Console.ReadLine();
            }
            double interestRateAsDouble = double.Parse(interestRate);
            while (!Checks.isPercentage(interestRateAsDouble))
            {
                Console.WriteLine($"Please re-enter:");
                interestRate = Console.ReadLine();
                interestRateAsDouble= interestRateCheck(interestRate);
            }
            return interestRateAsDouble;
        }
    }


}
