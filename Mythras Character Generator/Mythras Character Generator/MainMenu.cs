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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void baseMythrasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseMythrasSelectForm frm = new BaseMythrasSelectForm();
            frm.Show();
            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
