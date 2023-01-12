using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thewordwagon;
using Sharprompt;

namespace Thewordwagon
{
    internal class Program
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to The Word Wagon!");
            Console.WriteLine("-----------------------------------------------------");
            string manage = Prompt.Select("Please select an option"), new[] { "Create a new loan", "Print all preexisting loans", "Delete a loan" });

            switch (manage)
            {
                case "Create a new loan":
                    Createnewloan();
                    break;
                case "Print all preexisting loans":
                    PrintCurrentLoans();
                    break;
            }
        }
        public static void Createnewloan(string[] args)
        {
            Console.WriteLine("Please fill in the new loan form below."); //Create CLI for this
            Console.WriteLine("-----------------------------------------------------");
            //Here, a new loan is being created, calling the user class for user info,
            //and the item class for the item info to complete the loan.
            Loan myLoan = new Loan(new User("Will", 07913902170, "willyoungslk@gmail.com"), new Item("Avatar", "DVD"), DateTime.Now, 30, DateTime.DueDate); //Need to figure out duedate syntax
            Library.CurrentLoanList.Add(myLoan);
        }

        }

        public static void PrintCurrentLoans() //Finish in a bit.
        {
            Console.WriteLine("What is the GUID of the Loan you wish to view?");
            String GUIDInput = Console.ReadLine(); //Here, the user is propmted for a GUID. If it corresponds with a loan
            foreach (var item in Library.CurrentLoanList)//in the CurrentLoanList within the Library class. If a loan is found,
            {                                           //it is printed in the console.
                if (GUIDInput == item.LoanID.ToString())
                {
                    foreach (var i in Library.CurrentLoanList)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("This Loan does not exist!");
                }
            }
        }
    }
}
