using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal interface IItemType // Тип предмета (лечащий, наносящий урон или магический)
    {
        void Use();
    }
}
