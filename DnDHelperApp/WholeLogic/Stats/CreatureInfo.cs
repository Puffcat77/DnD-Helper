using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class CreatureInfo
    {
        // Данные о существе
        #region
        public string Name { get; private set; } // имя существа

        public string Race { get; private set; } // раса существа

        public List<string> Classes { get; private set; } // классы у существа

        public char Gender { get; private set; } // пол существа

        public int Age { get; private set; } // возраст существа

        public int Level { get; private set; } // уровень существа

        public int Experience { get; private set; } // опыт существа
        #endregion

        // Взаимодействие с этими данными
        #region
        public void FillName(string name)=> Name = name; // заполнить имя

        public void ChangeName(string name) => Name = name; // изменить имя

        public void FillRace(string race) => Race = race; // заполнить расу

        public void AddNewClass(string className) => Classes.Add(className); // добавить новый класс

        public void FillGender(char gender) => Gender = gender; // заполнить пол

        public void Changegender(char gender) => Gender = gender; // поменять пол

        public void FillAge(int age) => Age = age; // заполнить возраст

        public void ChangeAge(int age) => Age = age; // поменять возраст

        public void SetBaseLevelValue() => Level = 1; // задать базовый уровень

        public void IncreaceLevel(int increacingValue) => Level += increacingValue; // увеличить уровень на несколько значений

        public void LevelUp() // повышение уровня
        {
            if ((Experience % (int)(1000 * Level + 0.001*Level)) == 0)
            {
                Level++;
            }
        }
        #endregion
    }
}
