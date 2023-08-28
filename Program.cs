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

            //this x3
            double primeInterestRate;

            CreateLoan[] loanArray = new CreateLoan[5];
            List<CreateLoan> loanList = new List<CreateLoan>();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Enter Prime Interest Rate:");
                double primeIntRate = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Loan Number:");
                string loanNumber = Console.ReadLine();

                Console.WriteLine("Enter Firstname:");
                string custFirstname = Console.ReadLine();

                Console.WriteLine("Enter Lastname:");
                string custLastname = Console.ReadLine();

                double loanAmount;
                do
                {
                    Console.WriteLine("Enter Loan Amount:");
                    loanAmount = float.Parse(Console.ReadLine());
                    //NEED TO CHANGE THIS TO METHOD FROM LOAN CLASS -> maxLoanAmount
                    if (loanAmount > 100000)
                    {
                        Console.WriteLine("Loan amount exceeds R100 000. Please re-enter the loan amount.");
                    }
                } while (loanAmount > 100000);

                Console.WriteLine("Enter Interest Rate:");
                double interestRate = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Term:");
                int term = int.Parse(Console.ReadLine());

                CreateLoan newLoan = new CreateLoan(primeIntRate, loanNumber, custLastname, custFirstname, loanAmount, interestRate, term);
                loanArray[i] = newLoan;
            }

            foreach (CreateLoan loan in loanArray)
            {
                Console.WriteLine(loan);
            }

            //Need interest rate and Loan Number -> probably random generated.



        }
    }
}
