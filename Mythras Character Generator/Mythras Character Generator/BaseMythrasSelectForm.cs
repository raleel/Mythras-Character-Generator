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
    public partial class BaseMythrasSelectForm : Form
    {
        SettingInformationStore sis;
        List<RadioButton> raceButtons;
        List<RadioButton> professionButtons;
        List<RadioButton> cultureButtons;
        
        public BaseMythrasSelectForm()
        {
            InitializeComponent();
            sis = new SettingInformationStore();

            raceButtons = new List<RadioButton>();
            professionButtons = new List<RadioButton>();
            cultureButtons = new List<RadioButton>();
            
            initialiseRaces();
            initialiseProfessions();
            initialiseCultures();
        }

        public void getVisibleProfessions()
        {
            string cultureName = this.cultureTypeLayoutPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            Dictionary<int, string> professionNames = sis.getCultureTypeProfessions(cultureName);
            foreach (RadioButton button in professionButtons)
            {
                button.Visible = false;
            }
            foreach (RadioButton button in professionButtons)
            {
                foreach (KeyValuePair<int, string> entry in professionNames)
                {
                    if (entry.Key == 1)
                    {
                        button.Checked = true;
                    }
                    if (button.Text == entry.Value)
                    {
                        button.Visible = true;
                    }
                }
            }

        }

        public void initialiseRaces()
        {
            Dictionary<int, string> raceNames = sis.getAllRaceNames();
            for (int i = 1; i < raceNames.Count + 1; i++)
            {
                RadioButton newButton = new RadioButton();
                newButton.Text = raceNames[i];
                newButton.Click += new EventHandler(raceButtonClick);
                raceButtons.Add(newButton);
                this.raceLayoutPanel.Controls.Add(newButton);
                if (i == 1)
                {
                    newButton.Checked = true;
                }
            }
        }

        public void initialiseCultures()
        {
            Dictionary<int, string> cultureNames = sis.getAllCultureNames();
            for (int i = 1; i < cultureNames.Count + 1; i++)
            {
                RadioButton newButton = new RadioButton();
                newButton.Text = cultureNames[i];
                newButton.Click += new EventHandler(cultureButtonClick);
                cultureButtons.Add(newButton);
                this.cultureTypeLayoutPanel.Controls.Add(newButton);
                if (i == 1)
                {
                    newButton.Checked = true;
                    cultureTypeInfoText.Text = sis.getCultureTypeInformation(cultureNames[i]);
                    getVisibleProfessions();
                }
            }
        }

        public void initialiseProfessions()
        {
            Dictionary<int, string> professionNames = sis.getAllProfessionNames();
            for (int i = 1; i < professionNames.Count + 1; i++)
            {
                RadioButton newButton = new RadioButton();
                newButton.Text = professionNames[i];
                newButton.Click += new EventHandler(professionButtonClick);
                professionButtons.Add(newButton);
                this.professionLayoutPanel.Controls.Add(newButton);
                if (i == 1)
                {
                    newButton.Checked = true;
                    professionInfoText.Text = sis.getProfessionInformation(professionNames[i]);
                }
            }
        }

        public void raceButtonClick(object Sender, EventArgs e)
        {
            string raceName = this.raceLayoutPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }

        public void cultureButtonClick(object sender, EventArgs e)
        {
            string cultureName = this.cultureTypeLayoutPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            cultureTypeInfoText.Text = sis.getCultureTypeInformation(cultureName);
            getVisibleProfessions();
        }

        public void professionButtonClick(object sender, EventArgs e)
        {
            string professionName = this.professionLayoutPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            professionInfoText.Text = sis.getProfessionInformation(professionName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recalculateTotal()
        {
            decimal total = strUpDown.Value + conUpDown.Value + sizUpDown.Value + dexUpDown.Value + intUpDown.Value + powUpDown.Value + chaUpDown.Value;
            totalNum.Text = total.ToString();
        }

        private void strUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void conUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void sizUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void dexUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void intUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void powUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }

        private void chaUpDown_ValueChanged(object sender, EventArgs e)
        {
            recalculateTotal();
        }
    }
}
