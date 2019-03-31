using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class DamagingItem:Item, IDamaging // предмет наносящий урон
    {
        public Damage Damage { get; set; }

        public DamagingItem(string name, int weight, int ammount, int charges, int chargeLimit, Damage damage)
        {
            Name = name;
            Weight = weight;
            Ammount = ammount;
            Charges = charges;
            ChargeLimit = ChargeLimit;
            Damage = damage;
        }

        public int DoDamage()
        {
            int sum = 0;
            Random r = new Random(0);
            for (int i = 0; i < Damage.DiceAmmount; i++)
            {
                sum += r.Next(Damage.DiceType);
            }
            return sum;
        }

    }
}
