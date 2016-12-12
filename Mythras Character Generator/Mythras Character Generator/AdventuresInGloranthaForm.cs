using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mythras_Character_Generator
{
    public partial class AdventuresInGloranthaForm : Form
    {
        private decimal statTotal;
        private String skillLevel = "Trained";

        public AdventuresInGloranthaForm()
        {
            InitializeComponent();
            totalNumLabelUpdate();
            raceInfoLabelUpdate("Humans are the averagest.");
            updateStats(3, 18, 3, 18, 8, 18, 8, 18, 3, 18, 3, 18, 3, 18);

        }

        private void AdventuresInGloranthaForm_Load(object sender, EventArgs e)
        {

        }

        // NAVIGATION

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdventuresInGloranthaProfessionForm frm = new AdventuresInGloranthaProfessionForm();
            frm.Show();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemSelectForm frm = new SystemSelectForm();
            frm.Show();
            frm.FormClosed += (s, args) => this.Close();
        }

        // RACE STUFF
        private void raceInfoLabelUpdate(String updateText)
        {
            raceInfoLabel.Text = updateText;
        }

        private void raceStatUpdate(int strMin, int strMax, int conMin, int conMax, int sizMin, int sizMax, int intMin, int intMax, int powMin, int powMax, int dexMin, int dexMax, int appMin, int appMax)
        {
            updateStats(strMin, strMax, conMin, conMax, sizMin, sizMax, intMin, intMax, powMin, powMax, dexMin, dexMax, appMin, appMax);
        }

        private void humanButton_CheckedChanged(object sender, EventArgs e)
        {
            raceInfoLabelUpdate("Humans are the averagest.");
            updateStats(3, 18, 3, 18, 8, 18, 8, 18, 3, 18, 3, 18, 3, 18);
        }

        // SKILL STUFF
        private void skillInfoLabelUpdate(String updateText)
        {
            skillInfoLabel.Text = updateText;
        }

        private void noviceButton_CheckedChanged(object sender, EventArgs e)
        {
            skillLevel = "Novice";
            skillInfoLabelUpdate("Such adventurers are typically 14-16 (13+1D3) years old. Their initial Magic, Wealth and Renown start one point lower than those of a Trained member of their profession. Novice adventurers do not even start with the basic skills of their profession. They start with only half the normal number of background choices, and may purchase basic skill of their profession at half the listed cost (the value in italic next to each basic skill), and can purchase the optional skills of their profession at the listed cost. This is the level of skill held by a new apprentice.");
        }

        private void trainedButton_CheckedChanged(object sender, EventArgs e)
        {
            skillLevel = "Trained";
            skillInfoLabelUpdate("Such adventurers are typically 16-21 (15+1D6) years old. They start with the listed number of background choices and the basic skills and initial Magic, Wealth and Renown of a Trained member of their profession. This is the level of skill held by a typical apprentice, age 16 - 25.");
        }

        private void skilledButton_CheckedChanged(object sender, EventArgs e)
        {
            skillLevel = "Skilled";
            skillInfoLabelUpdate("Such adventurers are typically 18-24 (16+2D4) years old. They start with the listed number of background choices and the basic skills and initial Magic, Wealth and Renown of a Skilled member of their profession. This is the level of skill held by an advanced apprentice, journeyman, or average member of a profession, age 18 and up.");
        }

        private void expertButton_CheckedChanged(object sender, EventArgs e)
        {
            skillLevel = "Expert";
            skillInfoLabelUpdate("Such adventurers are typically 23-33 (21+2D6) years old. They start with the listed number of background choices and the basic skills and initial Magic, Wealth and Renown of an Expert member of their profession. This represents the level of skill held by an advanced journeyman or an exceptional member of a profession, age 25 and up.");
        }

        private void masterButton_CheckedChanged(object sender, EventArgs e)
        {
            skillLevel = "Master";
            skillInfoLabelUpdate("Such adventurers are typically 25-39 (23+2D8) years old. They start with the listed number of background choices and the basic skills and initial Magic, Wealth and Renown of a Master member of their profession. A master adventurer represents the level of skill held by a master of a profession, age 25 and up.");
        }

        // STAT STUFF
        private void totalNumLabelUpdate()
        {
            updateStatTotal();
            totalNumLabel.Text = statTotal.ToString();
        }
        
        private void updateStatTotal()
        {
            statTotal = calcStatTotal();
        }

        private decimal calcStatTotal()
        {
            return strUpDown.Value + conUpDown.Value + sizUpDown.Value + intUpDown.Value + powUpDown.Value + dexUpDown.Value + appUpDown.Value;
        }
        
        private void strUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void conUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void sizUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void intUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void powUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void dexUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void appUpDown_ValueChanged(object sender, EventArgs e)
        {
            totalNumLabelUpdate();
        }

        private void updateStats(int strMin, int strMax, int conMin, int conMax, int sizMin, int sizMax, int intMin, int intMax, int powMin, int powMax, int dexMin, int dexMax, int appMin, int appMax)
        {
            updateStrMin(strMin);
            updateStrMax(strMax);
            updateConMin(conMin);
            updateConMax(conMax);
            updateSizMin(sizMin);
            updateSizMax(sizMax);
            updateIntMin(intMin);
            updateIntMax(intMax);
            updatePowMin(powMin);
            updatePowMax(powMax);
            updateDexMin(dexMin);
            updateDexMax(dexMax);
            updateAppMin(appMin);
            updateAppMax(appMax);
        }

        private void updateStrMin(int newMin)
        {
            strMinLabel.Text = newMin.ToString();
            strUpDown.Minimum = newMin;
        }

        private void updateStrMax(int newMax)
        {
            strMaxLabel.Text = newMax.ToString();
            strUpDown.Maximum = newMax;
        }

        private void updateConMin(int newMin)
        {
            conMinLabel.Text = newMin.ToString();
            conUpDown.Minimum = newMin;
        }

        private void updateConMax(int newMax)
        {
            conMaxLabel.Text = newMax.ToString();
            conUpDown.Maximum = newMax;
        }

        private void updateSizMin(int newMin)
        {
            sizMinLabel.Text = newMin.ToString();
            sizUpDown.Minimum = newMin;
        }

        private void updateSizMax(int newMax)
        {
            sizMaxLabel.Text = newMax.ToString();
            sizUpDown.Maximum = newMax;
        }

        private void updateIntMin(int newMin)
        {
            intMinLabel.Text = newMin.ToString();
            intUpDown.Minimum = newMin;
        }

        private void updateIntMax(int newMax)
        {
            intMaxLabel.Text = newMax.ToString();
            intUpDown.Maximum = newMax;
        }

        private void updatePowMin(int newMin)
        {
            powMinLabel.Text = newMin.ToString();
            powUpDown.Minimum = newMin;
        }

        private void updatePowMax(int newMax)
        {
            powMaxLabel.Text = newMax.ToString();
            powUpDown.Maximum = newMax;
        }

        private void updateDexMin(int newMin)
        {
            dexMinLabel.Text = newMin.ToString();
            dexUpDown.Minimum = newMin;
        }

        private void updateDexMax(int newMax)
        {
            dexMaxLabel.Text = newMax.ToString();
            dexUpDown.Maximum = newMax;
        }

        private void updateAppMin(int newMin)
        {
            appMinLabel.Text = newMin.ToString();
            appUpDown.Minimum = newMin;
        }

        private void updateAppMax(int newMax)
        {
            appMaxLabel.Text = newMax.ToString();
            appUpDown.Maximum = newMax;
        }

        

        
    }
}
