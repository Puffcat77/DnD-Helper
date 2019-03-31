using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Stats:Stat
    {
        internal StringBuilder Name { get; set; } // имя

        internal StringBuilder Race { get; set; } // раса

        internal StringBuilder Class { get; set; } // класс

        internal char Sex { get; set; } // пол

        internal int Age { get; set; } // возраст

        internal Stat Intelligence { get; set; } // интеллект

        internal Stat Willpower { get; set; } // сила воли

        internal Stat Reflexes { get; set; } // рефлексы

        internal Stat Physique { get; set; } // телосложение

        internal Stat Exterior { get; set; } // внешность

        internal Stat Charisma { get; set; } // харизма

        internal Stat Mobility { get; set; } // подвижность

        internal Stat Luck { get; set; } // удача

        internal Stat Magic { get; set; } // магия

        internal int Sprint { get { return Mobility.Value * 3; } } // бег

        internal int Jump { get { return (int)Math.Floor((double)(Sprint / 4)); } } // прыжок

        internal int Throw { get { return Physique.Value * 3; } } // бросок

        internal int Transfer { get { return Physique.Value * 5; } } // перенос

        internal int Lift { get { return Transfer * 4; } } // подъем

        internal int MentalState { get { return Willpower.Value * 10; } } // психическое состояние

        internal int WearableWeight { get { return Physique.Value * 5; } } // переносимый вес

        internal int CarryingWeight { get { return Physique.Value * 20; } } // поднимаемый вес

        internal int Level { get; set; } // уровень

        static internal int MaxHealth { get { return 50; } } // максимальное здоровье

        internal int CurrentHealth { get; set; } // текущее здоровье

        internal string God { get; set; } // имя божества
    }
}
