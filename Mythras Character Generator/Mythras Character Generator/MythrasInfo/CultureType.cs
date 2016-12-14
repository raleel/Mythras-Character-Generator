using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.MythrasInfo
{
    /**
     * Class for culture types in the system.
     */
    public class CultureType
    {
        string cultureTypeName;
        Dictionary<string, Skill> cultureSkills;

        public CultureType(string cultureTypeName)
        {
            this.cultureTypeName = cultureTypeName;
            cultureSkills = new Dictionary<string, Skill>();
        }

        public string getCultureTypeName()
        {
            return cultureTypeName;
        }

        /**
         * Adds a skill to the culture skills dictionary.
         */
        public void addCultureTypeSkill(Skill skill)
        {
            cultureSkills.Add(skill.getSkillName(), skill);
        }

        public override string ToString()
        {
            string ToString = cultureTypeName;

            ToString += "\r\n<b>Skills</b>";
            foreach (KeyValuePair<string, Skill> entry in cultureSkills)
            {
                ToString += "\r\n" + entry.Key;
            }

            return ToString;
        }
    }
}
