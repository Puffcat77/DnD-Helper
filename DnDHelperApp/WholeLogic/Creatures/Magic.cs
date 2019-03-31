using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class MagicSpell
    {
        public string SpellName { get; set; } // Название заклинания

        public int ManaCost { get; set; } // Затраты маны

        public int CastLimit { get; set; } // Порог каста

        public StringBuilder Description { get; set; } // Описание

    }
}
