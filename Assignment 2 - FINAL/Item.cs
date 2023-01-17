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
    //This class is used alongside the User in the creation of a Loan. It is associated with the Loan class.
    {
        string name;
        string itemType;

        public Item(string name, string itemType)
        {
            this.name = name;
            this.itemType = itemType;
        }
        public override string ToString()
        {
            return 
                $"\n===============================================" +
                $"\nThis is the item name: {name}" +
                $"\nThis is the item type: {itemType}" +
                $"\n===============================================";

        }
    }
}
