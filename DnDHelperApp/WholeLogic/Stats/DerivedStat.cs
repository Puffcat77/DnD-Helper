using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class DerivedStat:Stat
    {
        public DerivedStat(Stat influencingStat, double coefficient, string description)
        {
            Description = description;
            Value = influencingStat.Value * coefficient;
        }
    }
}
