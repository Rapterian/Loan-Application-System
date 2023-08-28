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
            for (int i = 0; i < 1; i++)
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
                    if (loanAmount>100000)
                    {
                        Console.WriteLine("Loan amount exceeds R100 000. Please re-enter the loan amount.");
                    }
                } while (loanAmount > 100000);

                Console.Write("Enter Interest Rate:     \t");
                double interestRate = double.Parse(Console.ReadLine());

                Console.Write($"Terms:\n" +
                    $"short-term:1\n" +
                    $"medium-term:3\n" +
                    $"long-term:5\n2" +
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
