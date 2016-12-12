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
    public partial class AdventuresInGloranthaProfessionForm : Form
    {
        public AdventuresInGloranthaProfessionForm()
        {
            InitializeComponent();
        }

        private void AdventuresInGloranthaProfessionForm_Load(object sender, EventArgs e)
        {

        }

        // NAVIGATION

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdventuresInGloranthaForm frm = new AdventuresInGloranthaForm();
            frm.Show();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }

        private void civilisedButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void charUnButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
