using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class Stat // характеристика персонажа
    {
        public double Value { get; set; } // значение характеристики

        public int CreationLimit { get; set; } // предел значения при создании персонажа

        public string Description { get; set; } // описание характеристики

        public bool HaveLimit { get; set; } // существует ли лимит при создании
    }
}
