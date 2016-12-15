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
        Dictionary<int, string> raceNames;
        public BaseMythrasSelectForm()
        {
            InitializeComponent();
            sis = new SettingInformationStore();
            initialiseRaces();
            initialiseCultures();
            initialiseProfessions();
        }

        public void initialiseRaces()
        {
            raceNames = sis.getAllRaceNames();
            List<RadioButton> raceButtons = new List<RadioButton>();
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

            List<RadioButton> cultureButtons = new List<RadioButton>();
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
                }
            }
        }

        public void initialiseProfessions()
        {
            Dictionary<int, string> professionNames = sis.getAllProfessionNames();

            List<RadioButton> professionButtons = new List<RadioButton>();
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
