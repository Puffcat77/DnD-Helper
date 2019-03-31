using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    class MagicSchool:MagicSpell
    {
        internal int SchoolLevel { get; set; } // уровень школы магии
        internal List<MagicSpell> Spells { get; set; } // заклинания этой школы

        public MagicSchool(MagicSpell spell) // изучение новой школы с одним заклинанием
        {
            LearnNewMagic(spell);
        }

        public MagicSchool(MagicSpell[] spells) // изучение новой школы с несколькими зклинаниями
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
