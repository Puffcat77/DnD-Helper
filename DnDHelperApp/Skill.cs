using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp
{
    internal class Skill
    {
        internal int Level { get; set; }
        internal Damage Damage { get; set; }
        internal StringBuilder Description { get; set; }
        internal int CreationLimit { get; set; }
        internal string SkillType { get; set; }
        internal Stat InfluencingParameter { get; set; }
        internal int BaseSkillValue
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

        public void LevelUp()
        {
            Level++;
        }

        public int UseSkill(int diceValue)
        {
            return BaseSkillValue + diceValue;
        }
    }
}