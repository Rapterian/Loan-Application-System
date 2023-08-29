using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string input;
            Console.Write($"Enter Prime Interest Rate(%):");

            //stores the prime interest rate given as well as checking to make sure the
            //value given is valid
            double primeInterestRate = Loan.interestRateCheck(Console.ReadLine());

            //A list of loans to store the loans created 
            //The list was made of the base class loan so that we can use Loan,CreateLoan,PersonalLoan and BusinessLoan
            //since they all are derived form loan
            List<Loan> loanList = new List<Loan>();

            //the for loop will determine how many loans are created
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.Write($"Prime Interest Rate(%):\t{primeInterestRate}%\n");

                Console.Write("Enter Firstname:\t");
                input= Console.ReadLine();
                string custFirstname = Loan.nameCheck(input);

                Console.Write("Enter Lastname:\t");
                input = Console.ReadLine();
                string custLastname = Loan.nameCheck(input);


                CreateLoan newLoan = new CreateLoan(primeInterestRate, custFirstname, custLastname);

                loanList.Add(newLoan);

                Console.Write("Enter Loan Amount:\t");
                input = Console.ReadLine();
                loanList[i].LoanAmount = Loan.loanAmountCheck(input, loanList[i].minLoanAmount, loanList[i].maxLoanAmount); ;

                Console.Write($"Loan term ({loanList[i].shortTerm} for Short Term, {loanList[i].mediumTerm} for Medium Term, {loanList[i].longTerm} for Long Term):");
                string loanTerm=Console.ReadLine();
                while (!Checks.isInt(loanTerm))
                {
                    Console.WriteLine("Please Re-enter:");
                    loanTerm = Console.ReadLine();
                }
                loanList[i].Term = int.Parse(loanTerm);

                Console.Write("Personal(P) or Buisness(B) Loan:");
                char loanType = char.Parse(Console.ReadLine());
                if (loanType == 'P')
                {
                    PersonalLoan personal = (PersonalLoan)loanList[i];
                }
                else
                {
                    BusinessLoan personal = (BusinessLoan)loanList[i];
                }


            }
            Console.Clear();
            foreach (CreateLoan loan in loanList)
            {
                Console.WriteLine(loan.ToString());
            }


        }


    }
}
