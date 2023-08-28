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

            CreateLoan[] loanArray = new CreateLoan[5];
            List<CreateLoan> loanList = new List<CreateLoan>();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("Enter Prime Interest Rate:\t");
                double primeInterestRate = double.Parse(Console.ReadLine());

                Console.Write("Enter Loan Number:        \t");
                string loanNumber = Console.ReadLine();

                Console.Write("Enter Firstname:           \t");
                string custFirstname = Console.ReadLine();

                Console.Write("Enter Lastname:            \t");
                string custLastname = Console.ReadLine();

                double loanAmount;
                do
                {
                    Console.Write("Enter Loan Amount:      \t");
                    loanAmount = float.Parse(Console.ReadLine());
                    //NEED TO CHANGE THIS TO METHOD FROM LOAN CLASS -> maxLoanAmount
                    if (loanArray[i].overMaxLoan(loanAmount))
                    {
                        Console.WriteLine("Loan amount exceeds R100 000. Please re-enter the loan amount.");
                    }
                } while (loanArray[i].overMaxLoan(loanAmount));

                Console.Write("Enter Interest Rate:     \t");
                double interestRate = double.Parse(Console.ReadLine());

                Console.Write($"Terms:" +
                    $"short-term:{loanArray[i].shortTerm}" +
                    $"medium-term:{loanArray[i].mediumTerm}" +
                    $"long-term:{loanArray[i].longTerm}" +
                    $"Enter Term:                       \t");
                int term = int.Parse(Console.ReadLine());

                CreateLoan newLoan = new CreateLoan(primeInterestRate, loanNumber, custLastname, custFirstname, loanAmount, interestRate, term);
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
