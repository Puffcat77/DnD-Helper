using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    interface MagicalItem:IItem // магический предмет с каким-то эффектом
    {
        string Effect { get; set; }

    }
}
