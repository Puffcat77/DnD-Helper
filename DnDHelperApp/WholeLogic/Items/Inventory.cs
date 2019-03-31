using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class Inventory
    {
        Dictionary<string,Item> items = new Dictionary<string, Item>();

        public void AddItem(string name, Item item)
        {
            items.Add(name, item);
        }
    }
}
