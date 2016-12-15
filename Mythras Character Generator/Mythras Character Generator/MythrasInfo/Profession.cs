using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.MythrasInfo
{
    public class Profession
    {
        string professionName;
        string professionDescription;
        Dictionary<string, Skill> professionSkills;

        public Profession(string professionName, string professionDescription)
        {
            this.professionName = professionName;
            this.professionDescription = professionDescription;
            professionSkills = new Dictionary<string, Skill>();
        }

        public string getProfessionName()
        {
            return professionName;
        }

        public string getProfessionDescription()
        {
            return professionDescription;
        }

        public void addSkill(Skill skill)
        {
            professionSkills.Add(skill.getSkillName(), skill);
        }
    }
}
