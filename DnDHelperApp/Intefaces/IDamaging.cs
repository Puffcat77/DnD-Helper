using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public interface IDamaging: IItemType
    {
        Damage Damage { get; set; } // урон предмета

        int DoDamage(); // нанести урон предметом
    }
}
