using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public interface IStat
    {
        int Value { get; } // уровень характеристики

        StringBuilder Description { get; set; } // описание характеристики

        double CreationLimit { get; } // предел значения характеристики при создании
    }
}
