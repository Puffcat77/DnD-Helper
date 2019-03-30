using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Stat
    {
        internal int Value { get; set; } // уровень навыка
        internal StringBuilder Description { get; set; } // описание навыка
        internal int creationLimit = 10; // предел значения навыка при создании
    }
}
