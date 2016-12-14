using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;

namespace Mythras_Character_Generator.GameClasses
{
    public class SettingInformationStore
    {
        Dictionary<string, CultureType> cultureTypes;
        Dictionary<string, Skill> skills;

        public SettingInformationStore()
        {
            cultureTypes = new Dictionary<string, CultureType>();
            skills = new Dictionary<string, Skill>();
            readSkillsFromXML("..\\..\\xmlStore\\BaseMythras\\Skills\\skills_default.xml");
            readCultureTypesFromXML("..\\..\\xmlStore\\BaseMythras\\Cultures\\culturetypes_default.xml");
        }

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

                            }
                        }
                        CultureType cultureType = new CultureType(cultureTypeName);
                        foreach (KeyValuePair<string, Skill> entry in cultureSkills)
                        {
                            cultureType.addCultureTypeSkill(entry.Value);
                        }
                        addCultureType(cultureType);                            
                    }
                }
            }
        }

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
                                        isProfessional = false;
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

        public void addSkills()
        {
            
        }

        public void addSkill(Skill skill)
        {
            skills.Add(skill.getSkillName(), skill);
        }

        public void addCultureType(CultureType cultureType)
        {
            cultureTypes.Add(cultureType.getCultureTypeName(), cultureType);
        }

    }
}
