using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class BaseStats
    {
        static Dictionary<string, Stat> BaseStates { get; set; }

        public BaseStats(Stat[] stats, string[] names)
        {
            for (int i = 0; i < stats.Length; i++)
            {
                BaseStates.Add(names[i], stats[i]);
            }
        }
    }
}
