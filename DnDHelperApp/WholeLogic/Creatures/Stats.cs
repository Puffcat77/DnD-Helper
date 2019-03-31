using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class Stats: Stat // характеристики персонажа
    {
        public StringBuilder Name { get; set; } // имя

        public StringBuilder Race { get; set; } // раса

        public StringBuilder Class { get; set; } // класс

        public char Sex { get; set; } // пол

        public int Age { get; set; } // возраст

        public Stat Intelligence { get; set; } // интеллект

        public Stat Willpower { get; set; } // сила воли

        public Stat Reflexes { get; set; } // рефлексы

        public Stat Physique { get; set; } // телосложение

        public Stat Exterior { get; set; } // внешность

        public Stat Charisma { get; set; } // харизма

        public Stat Mobility { get; set; } // подвижность

        public Stat Luck { get; set; } // удача

        public Stat Magic { get; set; } // магия

        public int Sprint { get { return Mobility.Value * 3; } } // бег

        public int Jump { get { return (int)Math.Floor((double)(Sprint / 4)); } } // прыжок

        public int Throw { get { return Physique.Value * 3; } } // бросок

        public int Transfer { get { return Physique.Value * 5; } } // перенос

        public int Lift { get { return Transfer * 4; } } // подъем

        public int MentalState { get { return Willpower.Value * 10; } } // психическое состояние

        public int WearableWeight { get { return Physique.Value * 5; } } // переносимый вес

        public int CarryingWeight { get { return Physique.Value * 20; } } // поднимаемый вес

        public int Level { get; set; } // уровень

        static public int MaxHealth { get { return 50; } } // максимальное здоровье

        public int CurrentHealth { get; set; } // текущее здоровье

        public string God { get; set; } // имя божества
    }
}
