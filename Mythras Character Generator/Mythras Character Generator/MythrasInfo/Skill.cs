using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.MythrasInfo
{
    /**
     * Class for the skills in the system.
     */
    public class Skill
    {
        string skillName;
        string skillDescription;
        string firstStat;
        string secondStat;
        Boolean isProfessional;

        public Skill(string skillName, string skillDescription, string firstStat, string secondStat, Boolean isProfessional)
        {
            this.skillName = skillName;
            this.skillDescription = skillDescription;
            this.firstStat = firstStat;
            this.secondStat = secondStat;
            this.isProfessional = isProfessional;
        }

        public string getSkillName()
        {
            return skillName;
        }

        public Boolean isSkillProfessional()
        {
            return isProfessional;
        }
    }
}
