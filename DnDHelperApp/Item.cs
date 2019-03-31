using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Item
    {
        internal string Name { get; set; } // имя предмета

        internal int Weight { get; set; } // его вес

        internal int Ammount { get; set; } // количество данных предметов

        internal int Charges { get; set; } // количество зарядов в предмете

        internal int ChargeLimit { get; set; } // максимальное число зарядов
    }
}
