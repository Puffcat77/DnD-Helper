using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class CreatureInfo
    {
        public string Name { get; set; } // имя

        public string LastNameP { get; set; } // фамилия при знатном происхождении

        public string Race { get; set; } // раса

        public List<string> Classes { get; set; } // класс

        public char Gender { get; set; } // пол

        public int Age { get; set; } // возраст

        public void FillName(string name)=> Name = name; // заполнить имя

        public void ChangeName(string name) => Name = name; // изменить имя

        public void FillRace(string race) => Race = race; // заполнить расу

        public void AddNewClass(string className) => Classes.Add(className); // добавить новый класс

        public void FillGender(char gender) => Gender = gender; // заполнить пол

        public void Changegender(char gender) => Gender = gender; // поменять пол

        public void FillAge(int age) => Age = age; // заполнить возраст

        public void ChangeAge(int age) => Age = age; // поменять возраст
    }
}
