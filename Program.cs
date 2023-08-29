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
            Console.Clear();
            foreach (CreateLoan loan in loanArray)
            {



            }


        }
        /// <summary>
        /// Checks if input value is of type double.
        /// </summary>
        /// <returns></returns>
        static double doubleCheck()
        {
            double loanAmount = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter loan amount:");
                    loanAmount = double.Parse(Console.ReadLine());
                    if (loanAmount > 100000)
                    {
                        Console.WriteLine("Loan cannot be more than R100 000. Please re-enter loan amount.");
                    }
                    else if (loanAmount < 5000)
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
        /// <summary>
        /// Checks if user name or surname has special characters or numbers.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        static string specialCharCheck(string inputText)
        {
            int counter = 0;
            string[] numbersArray = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] specialArray = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "=", "`", "~", ",", "<", ">", ".", "/", "?", "|", ";", ":", "'", "", "[", "]", " " };

            for (int i = 0; i < inputText.Length; i++)
            {
                counter++;
                while (numbersArray.Contains(inputText[i].ToString()) || specialArray.Contains(inputText[i].ToString()) || counter > 13)
                {
                    Console.WriteLine("There is an invalid character or name is too long. Please re-enter:");
                    inputText = Console.ReadLine();
                }

            }
            return inputText;

        }
        /// <summary>
        /// Checks if term duration is either 1, 3, or 5. If it is neither, it is automatically set to 1. If it is a letter or special character, a exception will be called.
        /// </summary>
        /// <returns></returns>
        static int intCheck()
        {
            int termDuration = 1;
            do
            {
                try
                {
                    Console.WriteLine("Enter Term duration:");
                    termDuration = int.Parse(Console.ReadLine());
                    if (termDuration != 1 || termDuration != 3 || termDuration != 5)
                    {
                        termDuration = 1;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Term duration has invalid input. Please re-enter.");
                }
            } while (termDuration != 1 || termDuration != 3 || termDuration != 5);
            return termDuration;
        }
        /// <summary>
        /// Checks whether the Prime Interest Rate is more than 100% or lower than 1%.
        /// </summary>
        /// <returns></returns>
        static double primeInterestCheck()
        {
            double primeInterest = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter Prime interest rate:\t");
                    primeInterest = double.Parse(Console.ReadLine());
                    if (primeInterest > 100)
                    {
                        Console.WriteLine("Prime interest rate cannot be more than 100%. Please re-enter interest rate.");
                    }
                    else if (primeInterest < 1)
                    {
                        Console.WriteLine("Prime interest rate is too small. Please re-enter interest rate.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Prime interest rate has invalid input. Please re-enter.");
                }
            } while (primeInterest > 100 || primeInterest < 1);
            return primeInterest;
        }
        /// <summary>
        /// Checks if loan type is either 'P' for personal loans, or 'B' for business loans.
        /// </summary>
        /// <returns></returns>
        static string checkLoanType()
        {
            bool validInput = false;
            char inputText;
            do
            {
                Console.WriteLine("Enter loan type: Please type 'P' for personal or 'B' business.");
                inputText = Console.ReadKey().KeyChar;
                if (inputText == 'P' || inputText == 'p' || inputText == 'B' || inputText == 'b')
                {
                    validInput = true;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Invalid Loan type. Please re-enter.");
                    validInput = false;
                }
            } while (!validInput);
            return inputText.ToString().ToUpper();
        }

    }
}
