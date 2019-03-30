using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Character:Stats
    {
        Stats stats = new Stats();
        Dictionary<string,Skill> skills = new Dictionary<string, Skill>();
        Dictionary<string, MagicSchool> spells = new Dictionary<string, MagicSchool>();
        public Character(string name, string race, char sex, string characterClass,
            int age, int intelligence, int willpower, int reflexes, int physique, 
            int exterior, int charisma, int mobility, int luck, int magic)
        {
            stats.Name = new StringBuilder(name);
            stats.Race = new StringBuilder(race);
            stats.Sex = sex;
            stats.Class = new StringBuilder(characterClass);
            stats.Age = age;
            stats.Intelligence.Value = intelligence;
            stats.Willpower.Value = willpower;
            stats.Reflexes.Value = reflexes;
            stats.Physique.Value = physique;
            stats.Exterior.Value = exterior;
            stats.Charisma.Value = charisma;
            stats.Mobility.Value = mobility;
            stats.Luck.Value = luck;
            stats.Magic.Value = magic;
        }
        internal Currency Money { get; set; }
        public void AddMoney(int gold, int silver, int copper)
        {
            Money.Gold += gold;
            Money.Silver += silver;
            Money.Copper += copper;
        }
        public int GetMoney()
        {
            return Money.Copper+Money.Gold*12+Money.Gold*20;
        }

        public void LearnNewSkill(string skillName, Skill skill)
        {
            this.skills.Add(skillName,skill);
        }

        public void UpgradeSkill(string skill)
        {
            skills[skill].Level++;
        }
        public void LearnNewSpell(string spellName, MagicSchool spell)
        {
            this.spells.Add(spellName, spell);
        }

        public void UpgradeSpell(string spell)
        {
            spells[spell].UpgradeSchool();
        }

        //public void Heal(Item item)
        //{
        //    CurrentHealth = (CurrentHealth + item.HealPoinnts) % MaxHealth;
        //}
    }
}
