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
        Dictionary<string, Profession> cultureProfessions;

        public CultureType(string cultureTypeName)
        {
            this.cultureTypeName = cultureTypeName;
            cultureSkills = new Dictionary<string, Skill>();
            cultureProfessions = new Dictionary<string, Profession>();
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

        public void addCultureTypeProfession(Profession profession)
        {
            cultureProfessions.Add(profession.getProfessionName(), profession);
        }

        public Dictionary<int, string> getCultureTypeProfessions()
        {
            Dictionary<int, string> professionNames = new Dictionary<int, string>();
            int i = 1;
            foreach (KeyValuePair<string, Profession> entry in cultureProfessions)
            {
                professionNames.Add(i, entry.Key);
                i++;
            }

            return professionNames;
        }

        public override string ToString()
        {
            string ToString = cultureTypeName;

            ToString += "\r\n\r\nSkills";
            string standardString = "\r\nStandard";
            string profString = "\r\nProfessional";
            foreach (KeyValuePair<string, Skill> entry in cultureSkills)
            {
                if (entry.Value.isSkillProfessional() == true)
                {
                    profString += "\r\n" + entry.Key;
                } else
                {
                    standardString += "\r\n" + entry.Key;
                }
                
            }
            ToString += "\r\n" + standardString;
            ToString += "\r\n" + profString;

            return ToString;
        }
    }
}
