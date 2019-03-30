using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class MagicSpell
    {
        internal string SpellName { get; set; }
        internal int ManaCost { get; set; } // Затраты маны
        internal int CastLimit { get; set; } // Порог каста
        internal StringBuilder Description { get; set; } // Описание

    }
}
