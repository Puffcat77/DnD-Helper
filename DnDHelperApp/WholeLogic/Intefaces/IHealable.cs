using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public interface IHealable: IItemType
    {
        int HealPoints { get; set; } // количество восстанавливаемых очков

        int HealingTime { get; set; } // время восстановления

        int Heal(); // полечиться предметом
    }
}
