using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.Intefaces
{
    interface IMagical: IItemType
    {
        string Spell { get; set; }

        int SpellValue { get; set; }

    }
}
