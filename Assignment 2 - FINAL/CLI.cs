using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class CLI
    {

        static Library library = new Library("Mobi;e Library");
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n      Welcome to The World Wagon!");
            Console.WriteLine("\n-----------------------------------------------");

            string Manage = Prompt.Select($"Select your option", new[] { "Create new Loan", "View all Loans", "Delete Loan", "Exit" });

            switch (Manage)
            {
                case "Create new Loan":
                    Create_New_Loan();
                    break;
                case "View all Loans":
                    View_All_Loans();
                    break;
                case "Delete Loan":
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }

        }
        public static void Create_New_Loan()

        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n      Create a new Loan!");
            Console.WriteLine("\n-----------------------------------------------");

            string Name_User = Prompt.Input<string>("Enter your Name");//Get user Name
            string PhoneNumber_User = Prompt.Input<string>("Enter your Phone Number");//Get user Phone number
            string EmailAddress_User = Prompt.Input<string>("Enter your Email Address");//Get user Email address


            User User = new User(Name_User, PhoneNumber_User, EmailAddress_User);//Create user
            
            Console.WriteLine("\n-----------------------------------------------");

            string Name_Item = Prompt.Input<string>("Enter your item Name");//Get item name
            string Type_Item = Prompt.Input<string>("Enter the type of item");//Get item type

            Item Item = new Item(Name_Item, Type_Item);//Create item
            library.CurrentItemList.Add(Item);
            Console.WriteLine("\n-----------------------------------------------");

            int Loan_Duration = Prompt.Input<int>("Enter the loan duration");//Get Loan duration
            Loan Loan = new Loan(User, Item, Loan_Duration);//Create Loan

            Console.WriteLine($"This is the loan: {Loan}");
            library.CurrentLoanList.Add(Loan);


            Console.WriteLine("\nPress Enter key to return to main menu!");//Press any key
            Console.ReadLine();//Read the input
            MainMenu();//Return to Main menu

        }
        public static void View_All_Loans()
        {

            Console.Clear();
            Console.WriteLine("This are all the Loans: ");

            foreach (var Loan in library.CurrentLoanList)
            {
                Console.WriteLine(Loan);
            }

            Console.WriteLine("\nPress Enter key to return to main menu!");//Press any key
            Console.ReadLine();//Read the input
            MainMenu();//Return to Main menu


        }
    }
}
