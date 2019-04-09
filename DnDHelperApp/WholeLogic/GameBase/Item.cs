using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class Item
    {

        public int Weight { get; set; } // его вес

        public int Ammount { get; set; } // количество данных предметов

        public int Charges { get; set; } // количество зарядов в предмете

        public int ChargeLimit { get; set; } // максимальное число зарядов

        public int SalingCost { get; set; } // рыночная стоимость

        public int ActualCost { get; set; } // фактическая стоимость

        public Item(int weight, int ammount, int charges, int chargeLimit, int salingCost, int actualCost)
        {
            Weight = weight;
            Ammount = ammount;
            Charges = charges;
            ChargeLimit = chargeLimit;
            SalingCost = salingCost;
            ActualCost = actualCost;
        }

        public void AddCharges(int chargeAmmount) // добавить заряды предмету
        {
            Charges = (Charges + chargeAmmount) % (ChargeLimit + 1);
        }

        public void RechargeItem() // перезарядить предмет
        {
            Charges = ChargeLimit;
        }

        public void IncreaceChargeLimit(int additionalCharges) // увеличить максимум зарядов
        {
            ChargeLimit+=additionalCharges;
        }
    }
}
