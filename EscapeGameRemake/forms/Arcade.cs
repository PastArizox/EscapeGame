using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Arcade : Form
    {
        public Arcade()
        {
            InitializeComponent();
        }

        private void check_state()
        {
            if (Kitchen.chica_enabled)
            {
                BackgroundImage = Properties.Resources.Arcade_ON_background;
            }
        }

        private void kitchen_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Kitchen());
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new MiddleDining());
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            if (!Player.key2)
            {
                MessageBox.Show("Vous venez de ramasser une clé.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Player.key2 = true;
            }
        }
    }
}
