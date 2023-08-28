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


            Console.Write("Enter Prime Interest Rate:\t");
            double primeInterestRate = double.Parse(Console.ReadLine());

            CreateLoan[] loanArray = new CreateLoan[5];
            List<CreateLoan> loanList = new List<CreateLoan>();
            for (int i = 0; i < 1; i++)
            {
                Console.Clear();
                Console.Write($"Prime Interest Rate:\t{primeInterestRate}%");

                Console.Write("Enter Loan Number:\t");
                string loanNumber = Console.ReadLine();

                Console.Write("Enter Firstname:\t");
                string custFirstname = Console.ReadLine();

                Console.Write("Enter Lastname:\t");
                string custLastname = Console.ReadLine();


                CreateLoan newLoan = new CreateLoan(primeInterestRate, custLastname, custFirstname);
                loanArray[i] = newLoan;

                do
                {
                    Console.Write("Enter Loan Amount:\t");
                    loanArray[i].LoanAmount = float.Parse(Console.ReadLine());
                    if (loanArray[i].overMaxLoan())
                    {
                        Console.WriteLine("Loan amount exceeds R100 000. Please re-enter the loan amount.");
                    }
                } while (loanArray[i].overMaxLoan());


                Console.Write("Enter Interest Rate:\t");
                loanArray[i].InterestRate = double.Parse(Console.ReadLine());

                Console.Write($"Loan term ({loanArray[i].shortTerm} for Short Term, {loanArray[i].mediumTerm} for Medium Term, {loanArray[i].longTerm} for Long Term):");
                loanArray[i].Term = int.Parse(Console.ReadLine());

                
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
