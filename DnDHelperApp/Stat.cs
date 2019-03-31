using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class Stat // характеристика персонажа
    {
        public int Value { get; set; } // уровень навыка

        public StringBuilder Description { get; set; } // описание навыка

        public int CreationLimit { get { return 10; } } // предел значения навыка при создании
    }
}
