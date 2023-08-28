using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    /// <summary>
    /// Abstract class implementing the LoanConstants Interface. 
    /// This base class stores all necesary info about a loan in one object
    /// as well as have some useful functions.
    /// </summary>
    abstract class Loan:LoanConstants
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
        /// Constructor for a Loan that generates a random loan number
        /// </summary>
        /// <param name="custLastname">Customers Last Name</param>
        /// <param name="custFirstname">Customers First Name</param>
        public Loan( string custLastname, string custFirstname)
        {
            LoanNumber = randomInteger();
            CustLastname = custLastname;
            CustFirstname = custFirstname;
        }
        /// <summary>
        /// Loan number is randomly generated thus it only gets a get function
        /// </summary>
        public int LoanNumber { get;}
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
        /// Checks wether loan amount is more than max amount permitted
        /// </summary>
        /// <returns>boolean</returns>
        public bool overMaxLoan()
        {
            if (LoanAmount > maxLoanAmount)
            {
                return true;
            }
            else { return false; }
        }
        /// <summary>
        /// Checks wether the amount of years are one of the choices given
        /// </summary>
        /// <returns>boolean</returns>
        public bool loanTermValid()
        {
            if (Term != shortTerm || Term != mediumTerm || Term != longTerm)
            {
                return false;
            }
            else { return true; }
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
    }


}
