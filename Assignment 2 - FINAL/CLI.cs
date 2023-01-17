using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class CLI
        //Below, the main program with CLI are written, which call all classes and
        //process user inputs. It is accompanied by a CLI for user friendliness.
    {

        static Library library = new Library("Library"); //A new Library object is created from the Library class
                                                         //to store the objects created later in this program.
        public static void MainMenu()
        //Presents the user with a main menu heading and options to select. The cases below
        //represent the different methods linked to the options that the user may choose.
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n      Welcome to The World Wagon!");
            Console.WriteLine("\n-----------------------------------------------");

            string Manage = Prompt.Select($"Select your option", new[] { "Create new Loan", "View all Loans", "Delete Loan", "Exit" });

            switch (Manage)
            {
                case "Create new Loan": //Calls the Create_New_Loan method when selected.
                    Create_New_Loan();
                    break;
                case "View all Loans": //Calls the View_All_Loans method when selected.
                    View_All_Loans();
                    break;
                case "Delete Loan": //Calls the Delete_Loan method when selected.
                    Delete_Loan();
                    break;
                case "Exit": //Exits the program when selected.
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }

        }
        public static void Create_New_Loan() //A method to create a new loan.
            
        {
            Console.Clear(); //Console is cleared and a new heading is shown for creating a new loan.
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("\n      Create a new Loan!");
            Console.WriteLine("\n-----------------------------------------------");

            string Name_User = Prompt.Input<string>("Enter your Name");//The user is prompted to enter a name.
            string PhoneNumber_User = Prompt.Input<string>("Enter your Phone Number");//The user is prompted for a phone number.
            string EmailAddress_User = Prompt.Input<string>("Enter your Email Address");//The user is prompted for an email address.


            User User = new User(Name_User, PhoneNumber_User, EmailAddress_User);
            //A new user object is then created from the User class, and the data collected
            //from the user above is stored under this new object.

            library.CurrentUserList.Add(User); //The new User object is then stored in a list located in the Library class.
            Console.WriteLine("\n-----------------------------------------------");
            //Next, an Item obeject will be created.
            string Name_Item = Prompt.Input<string>("Enter your item Name");//The user is prompted for an item name e.g Star Wars
            string Type_Item = Prompt.Input<string>("Enter the type of item");//The user is promoted for the type of item e.g DVD, CD

            Item Item = new Item(Name_Item, Type_Item);//A new item object from the Item class
                                                       //is then created using the data collected above.
            library.CurrentItemList.Add(Item); //Once the Item object has been created with the data above,
                                               //it is then added to a list in the Library class where it can be called later.
            Console.WriteLine("\n-----------------------------------------------");

            //Finally, the Loan itself can be created.
            int Loan_Duration = Prompt.Input<int>("Enter the loan duration");//The user is prompted to input the loan duration (In days).
            Loan Loan = new Loan(User, Item, Loan_Duration);//The new User and Item objects are then added to a newly created
                                                            //Loan object, from the Loan class.

            Console.WriteLine($"This is the loan: {Loan}");
            library.CurrentLoanList.Add(Loan); //Once this is done, the new Loan object is stored in a list in the Library class.


            Console.WriteLine("\nPress Enter key to return to main menu!"); //This function prompts the user for any input, and
                                                                            //when inputted, it is read and the Main Menu method
                                                                            //is called to return the Main Menu CLI.
            Console.ReadLine();//Read the input.
            MainMenu();//Return to the Main Menu.

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
        public static void Delete_Loan() //Finish this
        {

        }
    }
}
