using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class HealingItem : Item // лечащий предмет
    {
        internal int HealPoints { get; set; } // количество восстанавливаемых очков
        internal int HealingTime { get; set; } // время восстановления

        public HealingItem(string name, int itemWeight, int charges, int chargeLimit, int healPoints, int healingTime) 
        {
            Name = name;
            Weight = itemWeight;
            ChargeLimit = chargeLimit;
            Charges = charges;
            HealPoints = healPoints;
            HealingTime = healingTime;
        }

        public int Heal() // использовать предмет
        {
            if (Charges > 0)
            {
                Charges--;
                return HealPoints * HealingTime;
            }
            else
            { return 0; }
        }

        public void AddCharges(int chargeAmmount) // добавить заряды предмету
        {
            Charges = (Charges + chargeAmmount) % (ChargeLimit + 1);
        }
    }
}
