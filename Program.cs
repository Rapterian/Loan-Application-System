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
            CreateLoan[] loanArray = new CreateLoan[1];
            List<CreateLoan> loanList = new List<CreateLoan>();
            Console.Clear();
            Console.WriteLine("Enter Prime Interest Rate:");
            double primeIntRate = double.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                Console.Clear();
                Console.WriteLine($"Current Prime interest rate: {primeIntRate/100d}%");
                Console.WriteLine("Enter Loan Number:");
                string loanNumber = Console.ReadLine();

                Console.WriteLine("Enter Firstname:");
                string custFirstname = Console.ReadLine();

                Console.WriteLine("Enter Lastname:");
                string custLastname = Console.ReadLine();

                double loanAmount = doubleCheck();

                Console.WriteLine("Enter Interest Rate:");
                double interestRate = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Term:");
                int term = int.Parse(Console.ReadLine());

                CreateLoan newLoan = new CreateLoan(primeIntRate, loanNumber, custLastname, custFirstname, loanAmount, interestRate, term);
                loanArray[i] = newLoan;
            }
            Console.Clear();    
            foreach (CreateLoan loan in loanArray)
            {
                Console.WriteLine(loan);
                Console.WriteLine(" ");
            }

            //Need interest rate and Loan Number -> probably random generated.
        }
        static double doubleCheck()
        {
            double loanAmount = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter loan amount: Please use a ',' for decimals.");
                    loanAmount = double.Parse(Console.ReadLine());
                    if (loanAmount > 100000)
                    {
                        Console.WriteLine("Loan cannot be more than R100 000. Please re-enter loan amount.");
                    } else if (loanAmount < 5000)
                    {
                        Console.WriteLine("Loan is too small. Please re-enter loan amount.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loan has invalid input. Please re-enter.");
                }
            } while (loanAmount > 100000 || loanAmount < 5000);
            return loanAmount;
        }
    }
}
