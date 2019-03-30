using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    class MagicSchool:MagicSpell
    {
        internal int SchoolLevel { get; set; }
        internal List<MagicSpell> Spells { get; set; }

        public void LearnNewMagic(MagicSpell newSpell)
        {
            Spells.Add(newSpell);
        }

        public void UpgradeSchool()
        {
            SchoolLevel++;
        }
    }
}
