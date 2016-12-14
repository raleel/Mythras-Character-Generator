using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mythras_Character_Generator.GameClasses;

namespace Mythras_Character_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SettingInformationStore sis = new SettingInformationStore();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
