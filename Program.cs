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


            CreateLoan[] loanArray = new CreateLoan[2];
            List<CreateLoan> loanList = new List<CreateLoan>();
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.Write($"Prime Interest Rate(%):\t{primeInterestRate}%\n");

                Console.Write("Enter Firstname:\t");
                string custFirstname = Console.ReadLine();

                Console.Write("Enter Lastname:\t");
                string custLastname = Console.ReadLine();

                CreateLoan newLoan = new CreateLoan(primeInterestRate, custFirstname, custLastname);
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

                Console.Write($"Loan term ({loanArray[i].shortTerm} for Short Term, {loanArray[i].mediumTerm} for Medium Term, {loanArray[i].longTerm} for Long Term):");
                loanArray[i].Term = int.Parse(Console.ReadLine());

                Console.Write("Personal(P) or Buisness(B) Loan:");
                char loanType = char.Parse(Console.ReadLine());
                if (loanType == 'P')
                {
                    PersonalLoan personal = (PersonalLoan)loanArray[i];
                }
                else
                {
                    BusinessLoan personal = (BusinessLoan)loanArray[i];
                }


            }

            foreach (CreateLoan loan in loanArray)
            {
                Console.WriteLine(loan.ToString());
            }



        }

        static double doubleCheck(Loan loan)
        {
            double loanAmount = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter loan amount:");
                    loanAmount = double.Parse(Console.ReadLine());
                    if (loan.overMaxLoan())
                    {
                        Console.WriteLine("Loan cannot be more than R100 000. Please re-enter loan amount.");
                    }
                    else if (loan.underMinLoan())
                    {
                        Console.WriteLine("Loan is too small. Please re-enter loan amount.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loan has invalid input. Please re-enter.");
                }
            } while (loan.overMaxLoan() || loan.underMinLoan());

            return loanAmount;
        }

    }
}
