using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class CreatureStats // характеристики персонажа
    {
        public CreatureInfo Info { get; set; }
        public BaseStats BaseStates { get; set; }
        public DerivedStats DerivedStats { get; set; }

        public CreatureStats(string name, string lastName, string race, string )
        { }
    }
}