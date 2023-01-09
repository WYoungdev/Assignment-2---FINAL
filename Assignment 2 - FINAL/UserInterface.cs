using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal static class UserInterface
    {
        public static Bookstore bookstore {  get; set; } //Need to create Bookstore class later
        public static void MainMenu()
        {
            Console.Clear(); //Here, the console is cleared and the store name is printed in a format that is easy to view.
            Console.WriteLine("Welcome to the The Word Wagon!");
            Console.WriteLine("-------------------------------------------------------------");

            string manage = Prompt.Select("Please select an option below", new[] { "Create new loan", "Manage preexisting loan" }); //Need to make prompt later

            switch (manage)
            {
                case "Create new loan":
                    Createnewloan();
                    break;
                case "Manage preexisting loan":
                    Managepreexistingloans();
                    break;
                default:
                    break;
            }
        }

        private static void Createnewloan()
        {
            Console.Clear();
            Console.WriteLine("Create new loan:");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("What is the name of the customer? Please note that a customer may only borrow one item at a time.");
            string customername = Console.ReadLine();
            Customers? Existingloan = bookstore.GetLoan(customername); //Create a class for this

            if (Existingloan != null) //Checking Existingloan for if the loan already exist. If it does not, Attributes are then added to it.
            {
                Console.WriteLine("What type of item is the customer borrowing?");
                string type = Console.ReadLine();

                Console.WriteLine("What is the date that this item will be taken out on? E.g 24-2-22");
                string itemdate = Console.ReadLine();

                Console.WriteLine("What time will the item taken out at? E.g 12:45pm");
                string itemtime = Console.ReadLine();

                Console.WriteLine("How many days will the item be borrowed for?");
                int itemduration = Convert.ToInt32(Console.ReadLine());

                Guid id = Guid.NewGuid(); //This line creates a new unique GUID for every new loan created.

                Loan loan = new Loan(Existingloan, type, itemdate, itemtime, itemduration);
                Console.WriteLine("New loan has been successfully created.");
            }
            else
            {
                Console.WriteLine("Customer has already borrowed an item and cannot borrow another.");
            }
            Console.WriteLine("Please press any key to return to the main menu.");
            Console.ReadLine();
            MainMenu();
        }

        public static void Managepreexistingloans()
        {
            Console.Clear();
            Console.WriteLine("Manage pre-existing loans");
            Console.WriteLine("-------------------------------------------------------------");

            string manage = Prompt.Select("Please select an option below", new[] { "View outstanding loans", "Delete loan" });

            switch (manage)
            {
                case "View outstanding loans":
                    Console.Clear();
                    foreach (var item in bookstore.outstandingloans)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadLine();
                    MainMenu();
                    break;

                case "Delete loan":
                    Console.Clear();
                    string customername = Prompt.Input<int>("Please enter a customer name:");
                    Loan? current = bookstore.GetLoan(customername); //Is this going to work?

                    if (current != null)
                    {
                        bookstore.GetLoan.Remove(current);
                        Console.WriteLine("Loan has been deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Loan not found. Was the customer name correct?");
                    }
                    Console.WriteLine("Press any key to return to the main menu.");
                    Console.ReadLine();
                    MainMenu();
                    break;
            }
        }
    }
}
