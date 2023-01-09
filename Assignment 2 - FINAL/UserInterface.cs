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
            Console.WriteLine("Welcome to the { bookstore.Name }!");
            Console.WriteLine("-------------------------------------------------------------");

            string manage = Prompt.Select("Please select an option below", new[] { "Create new loan", "Manage preexisting loan" }); //Need to make prompt later

            switch (manage)
            {
                case "Create new loan":
                    Createnewloan();
                    break;
                case "Manage preexisting loan":
                    Managepreexistingloan();
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
            Console.WriteLine("                                                             ");
            Console.WriteLine("What is the name of the customer? Please note that a customer may only borrow one item at a time.");
            string customername = Console.ReadLine();
            Customers? Existingloan = bookstore.GetLoan(customername); //Create class for this

            if (Existingloan != null)
            {
                Console.WriteLine("What type of item is the customer borrowing?");
                string type = Console.ReadLine();
                Console.WriteLine("")
            }
        }
    }
}
