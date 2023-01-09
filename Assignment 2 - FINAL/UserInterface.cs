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
            Console.WriteLine("--------------------------------");

            string manage = Prompt.Select("Please select an option below", new[] { "Create new loan", "Manage preexisting loan" });

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
    }
}
