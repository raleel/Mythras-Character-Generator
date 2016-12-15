using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.MythrasInfo
{
    public class SettingInformationStore
    {
        Dictionary<string, CultureType> cultureTypes;
        Dictionary<string, Skill> skills;
        Dictionary<string, Race> races;
        Dictionary<string, Profession> professions;

        public SettingInformationStore()
        {
            cultureTypes = new Dictionary<string, CultureType>();
            skills = new Dictionary<string, Skill>();
            races = new Dictionary<string, Race>();
            professions = new Dictionary<string, Profession>();
            addRaces();
            readSkillsFromXML("..\\..\\xmlStore\\BaseMythras\\Skills\\skills_default.xml");
            readProfessionsFromXML("..\\..\\xmlStore\\BaseMythras\\Professions\\professions_default.xml");
            readCultureTypesFromXML("..\\..\\xmlStore\\BaseMythras\\Cultures\\culturetypes_default.xml");
        }

        public Dictionary<int, string> getCultureTypeProfessions(string cultureTypeName)
        {
            return cultureTypes[cultureTypeName].getCultureTypeProfessions();
        }

        /**
         * Reads culture types from a given XML file.
         */
        public void readProfessionsFromXML(string fileName)
        {
            // reader creation
            XmlTextReader reader = new XmlTextReader(fileName);

            // whilst we read the file
            while (reader.Read())
            {
                // 
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "profession")
                    {
                        string professionName = "";
                        string professionDescription = "";
                        Dictionary<string, Skill> professionSkills = new Dictionary<string, Skill>();
                        while (reader.Read() && reader.Name != "profession")
                        {
                            switch (reader.Name)
                            {
                                case "profession_name":
                                    reader.Read();
                                    professionName = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "profession_description":
                                    reader.Read();
                                    professionDescription = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill":
                                    reader.Read();
                                    try
                                    {
                                        professionSkills.Add(skills[reader.Value].getSkillName(), skills[reader.Value]);
                                    }
                                    catch (KeyNotFoundException ke)
                                    {
                                        Console.WriteLine("No skill of name " + reader.Value + " found whilst parsing profession " + professionName + ".");
                                    }
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;

                            }
                        }
                        Profession profession = new Profession(professionName, professionDescription);
                        foreach (KeyValuePair<string, Skill> entry in professionSkills)
                        {
                            profession.addSkill(entry.Value);
                        }
                        addProfession(profession);
                    }
                }
            }
        }

        /**
         * Reads culture types from a given XML file.
         */
        public void readCultureTypesFromXML(string fileName)
        {
            // reader creation
            XmlTextReader reader = new XmlTextReader(fileName);

            // whilst we read the file
            while (reader.Read())
            {
                // 
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "culture_type")
                    {
                        string cultureTypeName = "";
                        Dictionary<string, Skill> cultureSkills = new Dictionary<string, Skill>();
                        Dictionary<string, Profession> cultureProfessions = new Dictionary<string, Profession>();
                        while (reader.Read() && reader.Name != "culture_type")
                        {
                            switch (reader.Name)
                            {
                                case "culture_type_name":
                                    reader.Read();
                                    cultureTypeName = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill":
                                    reader.Read();
                                    try {
                                        cultureSkills.Add(skills[reader.Value].getSkillName(), skills[reader.Value]);
                                    }
                                    catch (KeyNotFoundException ke) {
                                        Console.WriteLine("No skill of name " + reader.Value +" found whilst parsing culture type " + cultureTypeName + ".");
                                    }
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "profession":
                                    reader.Read();
                                    try
                                    {
                                        cultureProfessions.Add(professions[reader.Value].getProfessionName(), professions[reader.Value]);
                                    }
                                    catch (KeyNotFoundException ke)
                                    {
                                        Console.WriteLine("No profession of name " + reader.Value + " found whilst parsing culture type " + cultureTypeName + ".");
                                    }
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;

                            }
                        }
                        CultureType cultureType = new CultureType(cultureTypeName);
                        foreach (KeyValuePair<string, Skill> entry in cultureSkills)
                        {
                            cultureType.addCultureTypeSkill(entry.Value);
                        }
                        foreach (KeyValuePair<string, Profession> entry in cultureProfessions)
                        {
                            cultureType.addCultureTypeProfession(entry.Value);
                        }
                        addCultureType(cultureType);                            
                    }
                }
            }
        }

        /**
         * Reads skills from a given xml file.
         */
        public void readSkillsFromXML(string fileName)
        {
            // reader creation
            XmlTextReader reader = new XmlTextReader(fileName);

            // whilst we read the file
            while (reader.Read())
            {
                // 
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "skill")
                    {
                        string skillName = "";
                        string skillDescription = "";
                        string firstStat = "";
                        string secondStat = "";
                        Boolean isProfessional = false;
                        while (reader.Read() && reader.Name != "skill")
                        {
                            switch (reader.Name)
                            {
                                case "skill_name":
                                    reader.Read();
                                    skillName = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill_type":
                                    reader.Read();
                                    if (reader.Value == "Standard")
                                    {
                                        isProfessional = false;
                                    } else if (reader.Value == "Professional")
                                    {
                                        isProfessional = true;
                                    }
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill_first_stat":
                                    reader.Read();
                                    firstStat = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill_second_stat":
                                    reader.Read();
                                    secondStat = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                                case "skill_description":
                                    reader.Read();
                                    skillDescription = reader.Value;
                                    while (reader.Read() && reader.NodeType != XmlNodeType.EndElement) ;
                                    break;
                            }
                        }
                        Skill skill = new Skill(skillName, skillDescription, firstStat, secondStat, isProfessional);
                        addSkill(skill);
                    }
                }
            }
        }

        public void addProfession(Profession profession)
        {
            professions.Add(profession.getProfessionName(), profession);
        }

        /**
         * Adds a given skill to the skill list.
         */
        public void addSkill(Skill skill)
        {
            skills.Add(skill.getSkillName(), skill);
        }

        /**
         * Adds a given culture type to the culture type list.
         */
        public void addCultureType(CultureType cultureType)
        {
            cultureTypes.Add(cultureType.getCultureTypeName(), cultureType);
        }

        /**
         * Gets culture type information from a given culture name.
         */
        public string getCultureTypeInformation(string cultureName)
        {
            return cultureTypes[cultureName].ToString();
        }

        /**
         * Returns a dictionary of culture names under a numerical system.
         */
        public Dictionary<int, string> getAllCultureNames()
        {
            Dictionary<int, string> cultureNames = new Dictionary<int, string>();
            int i = 1;
            foreach (KeyValuePair<string, CultureType> entry in cultureTypes)
            {
                cultureNames.Add(i, entry.Key);
                i++;
            }
            return cultureNames;
        }

        /**
         * Returns a dictionary of culture names under a numerical system.
         */
        public Dictionary<int, string> getAllProfessionNames()
        {
            Dictionary<int, string> professionNames = new Dictionary<int, string>();
            int i = 1;
            foreach (KeyValuePair<string, Profession> entry in professions)
            {
                professionNames.Add(i, entry.Key);
                i++;
            }
            return professionNames;
        }

        public string getProfessionInformation(string professionName)
        {
            return professions[professionName].getProfessionDescription();
        }

        /**
         * Returns a dictionary of race names under a numerical system.
         */
        public Dictionary<int, string> getAllRaceNames()
        {
            Dictionary<int, string> raceNames = new Dictionary<int, string>();
            int i = 1;
            foreach (KeyValuePair<string, Race> entry in races)
            {
                raceNames.Add(i, entry.Key);
                i++;
            }
            return raceNames;
        }

        /**
         * Test method for adding races.
         */
        public void addRaces()
        {
            Race race = new Race();
            races.Add(race.getName(), race);
        }
    }
}
