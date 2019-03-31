using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class HealingItem : Item, IHealable // лечащий предмет
    {
        public int HealPoints { get; set; }
        public int HealingTime { get; set; }

        public HealingItem(string name, int itemWeight, int charges, int chargeLimit, int healPoints, int healingTime) 
        {
            Name = name;
            Weight = itemWeight;
            ChargeLimit = chargeLimit;
            Charges = charges;
            HealPoints = healPoints;
            HealingTime = healingTime;
        }

        public int Heal()
        {
            if (Charges > 0)
            {
                Charges--;
                return HealPoints * HealingTime;
            }
            else
            { return 0; }
        }
    }
}
