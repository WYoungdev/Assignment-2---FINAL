using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thewordwagon
{
    internal class Item
    {
        string name;
        string itemType;

        public Item(string name, string itemType)
        {
            this.name = name;
            this.itemType = itemType;
        }
    }
}
