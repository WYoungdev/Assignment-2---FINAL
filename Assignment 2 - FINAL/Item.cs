using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Item
    //Here, an Item class has been created to specify information regarding the item that is added to the loan.
    //This class is used alongside the User in the creation of a Loan.
    {
        string name; //Here, attributes are set out based on what information is required to identify the item.
        string itemType;

        public Item(string name, string itemType) //Here, the attributes set out above are actually created.
        {
            this.name = name;
            this.itemType = itemType;
        }
        public override string ToString() //This prints the information regarding the Item that the User created.
        {
            return 
                $"\n===============================================" +
                $"\nThis is the item name: {name}" +
                $"\nThis is the item type: {itemType}" +
                $"\n===============================================";

        }
    }
}
