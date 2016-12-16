using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mythras_Character_Generator.MythrasInfo;

namespace Mythras_Character_Generator
{
    public partial class BaseMythrasSkillsForm : Form
    {
        SettingInformationStore sis;
        string raceName;
        string civilisationTypeName;
        string professionName;
        int strength;
        int constitution;
        int size;
        int dexterity;
        int intelligence;
        int power;
        int charisma;
        public BaseMythrasSkillsForm(SettingInformationStore sis, string raceName,
            string civilisationTypeName, string professionName, int strength, int constitution,
            int size, int dexterity, int intelligence, int power, int charisma)
        {
            InitializeComponent();
            this.sis = sis;
            this.raceName = raceName;
            this.civilisationTypeName = civilisationTypeName;
            this.professionName = professionName;
            this.strength = strength;
            strValueLabel.Text = strength.ToString();
            this.constitution = constitution;
            conValueLabel.Text = constitution.ToString();
            this.size = size;
            sizValueLabel.Text = size.ToString();
            this.dexterity = dexterity;
            dexValueLabel.Text = dexterity.ToString();
            this.intelligence = intelligence;
            intValueLabel.Text = intelligence.ToString();
            this.power = power;
            powValueLabel.Text = power.ToString();
            this.charisma = charisma;
            chaValueLabel.Text = charisma.ToString();
        }

        public int getBaseSkillValue(string skillName)
        {
            Dictionary<int, string> skillStats = sis.getSkillStats(skillName);
            int baseSkillValue = 0;
            foreach (KeyValuePair<int, string> entry in skillStats)
            {
                baseSkillValue = baseSkillValue + getStatValue(entry.Value);
            }
            return baseSkillValue;
        }
        
        public int getStatValue(string stat)
        {
            stat = stat.ToUpper();
            switch (stat)
            {
                case "STRENGTH":
                    return strength;
                    break;
                case "STR":
                    return strength;
                    break;
                case "CONSTITUTION":
                    return constitution;
                    break;
                case "CON":
                    return constitution;
                    break;
                case "SIZE":
                    return size;
                    break;
                case "SIZ":
                    return size;
                    break;
                case "DEXTERITY":
                    return dexterity;
                    break;
                case "DEX":
                    return dexterity;
                    break;
                case "INTELLIGENCE":
                    return intelligence;
                    break;
                case "INT":
                    return intelligence;
                    break;
                case "POWER":
                    return power;
                    break;
                case "POW":
                    return power;
                    break;
                case "CHARISMA":
                    return charisma;
                    break;
                case "CHA":
                    return charisma;
                    break;
                default:
                    return 100;
                    break;
            }
        }

        private void BaseMythrasSkillsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
