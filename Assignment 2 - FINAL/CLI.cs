using Sharprompt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
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
}
