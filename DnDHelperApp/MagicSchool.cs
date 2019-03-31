using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    class MagicSchool:MagicSpell
    {
        internal int SchoolLevel { get; set; } // Уровень школы магии
        internal List<MagicSpell> Spells { get; set; } // Заклинания этой школы

        public MagicSchool(MagicSpell spell)
        {
            LearnNewMagic(spell);
        }

        public MagicSchool(MagicSpell[] spells)
        {
            foreach (var spell in spells)
            {
                LearnNewMagic(spell);
            }
        }

        public void LearnNewMagic(MagicSpell newSpell) // Выучить новое заклинание этой же школы
        {
            Spells.Add(newSpell);
        }

        public void UpgradeSchool() // Увеличить уровень этой школы магии
        {
            SchoolLevel++;
        }
    }
}
