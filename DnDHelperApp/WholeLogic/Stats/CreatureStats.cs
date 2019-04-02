using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic
{
    public class CreatureStats // характеристики персонажа
    {
        public CreatureInfo InfoStats { get; set; }
        public Dictionary<string, Stat> BaseStats { get; set; }
        public Dictionary<string, Stat> DerivedStats { get; set; }

        public void FillBaseInfo(string name, string lastName, string race, string firstClass, char gender, int age)
        {
            InfoStats.FillName(name);
            InfoStats.FillRace(race);
            InfoStats.AddNewClass(firstClass);
            InfoStats.FillGender(gender);
            InfoStats.FillAge(age);
            InfoStats.SetBaseLevelValue();
        }

        public void AddBaseStat(string statName, Stat newBaseStat)
        {
            BaseStats.Add(statName, newBaseStat);
        }

        public void AddDerivedStat(string statName, Stat influencingStat, double coefficient)
        {
            Stat newStat = new Stat();
            newStat.Value = influencingStat.Value * coefficient;
            DerivedStats.Add(statName, newStat);
        }
    }
}