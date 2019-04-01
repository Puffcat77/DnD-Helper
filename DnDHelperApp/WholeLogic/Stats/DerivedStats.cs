using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class DerivedStats
    {
        Dictionary<string, DerivedStat> derStats = new Dictionary<string, DerivedStat>();

        public DerivedStats(string[] names, DerivedStat[] stats)
        {
            for (int i = 0; i < stats.Length; i++)
            {
                derStats.Add(names[i], stats[i]);
            }
        }
    }
}
