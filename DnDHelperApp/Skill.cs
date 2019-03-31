using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Skill
    {
        internal int Level { get; set; } // Уровень скилла
        internal Damage Damage { get; set; } // Урон навыка, если он принадлежит к боевым
        internal StringBuilder Description { get; set; } // Его описание
        internal int CreationLimit { get; set; } // Предел уровня этого навыка при создании персонажа
        internal string SkillType { get; set; } // Тип навыка (карьерный, жизненный или из школы фехтования)
        internal Stat InfluencingParameter { get; set; } // Параметр, от которого зависит навык
        internal int BaseSkillValue // Базовое значение навыка без броска кубика
        {
            get
            {
                int sum = 0;
                sum += InfluencingParameter.Value;
                if (SkillType == "Боевой")
                {
                    Random r = new Random(0);
                    for (int i = 0; i < Damage.DiceAmmount; i++)
                    {
                        sum += r.Next(Damage.DiceType);
                    }
                    return sum;
                }
                else { return sum; }
            }    
        }

        public Skill(int level, int diceType, int diceAmmont, StringBuilder description, int creationLimit, Stat stat)
        {
            Level = level;
            Damage.DiceType = diceType;
            Damage.DiceAmmount = diceAmmont;
            Description = description;
            CreationLimit = creationLimit;
            InfluencingParameter = stat;
        }

        public void LevelUp() // Поднятие уровня навыка
        {
            Level++;
        }

        public int UseSkill(int diceValue) // Подсчет значения навыка с броском кубика при использовании самого навыка
        {
            return BaseSkillValue + diceValue;
        }
    }
}