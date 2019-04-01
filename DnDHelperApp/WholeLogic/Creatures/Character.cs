using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    public class Character:CreatureStats
    {
        CreatureStats stats = new CreatureStats(); // Характеристики персонажа
        Dictionary<string,Skill> skills = new Dictionary<string, Skill>(); // Список скиллов персонажа
        Dictionary<string, MagicSchool> spells = new Dictionary<string, MagicSchool>(); // список заклинаний персонажа
        public int Experience { get; set; }
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
        public Currency Money { get; set; } // Количество имеющихся денег
        public void AddMoney(int gold, int silver, int copper) // Заработок персонажа
        {
            Money.Gold += gold;
            Money.Silver += silver;
            Money.Copper += copper;
        }
        public int GetMoney() // Вывод количества денег у персонажа
        {
            return Money.Copper+Money.Gold*12+Money.Gold*20;
        }

        public void BuyItem(int cost, Item item)
        {
            int sum = GetMoney() - cost;
            Money.Gold = sum / 240;
            Money.Silver = sum % 240 / 12;
            Money.Copper = sum % 240 % 12;
        }

        public void LearnNewSkill(string skillName, Skill skill) // Изучение нового навыка
        {
            skills.Add(skillName,skill);
        }

        public void UpgradeSkill(string skill) // Прокачка имеющегося навыка
        {
            skills[skill].Level++;
        }
        public void LearnNewSpell(string magicSchoolName, MagicSpell spell) // Изучение нового заклинания
        {
            if (!spells.Keys.Contains(magicSchoolName))
            {
                spells.Add(magicSchoolName, new MagicSchool(spell) { SchoolLevel=1});
            }
            else
            {
                spells[magicSchoolName].LearnNewMagic(spell);
            }
        }

        public void UpgradeMagicSchool(string schoolName) // Прокачка школы магии
        {
            spells[schoolName].UpgradeSchool();
        }

        //public void Heal(Item item)
        //{
        //    CurrentHealth = (CurrentHealth + item.HealPoinnts) % MaxHealth;
        //}
    }
}
