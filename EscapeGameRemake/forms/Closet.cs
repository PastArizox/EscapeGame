using EscapeGameRemake.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EscapeGameRemake.forms
{
    public partial class Closet : Form
    {
        public Closet()
        {
            InitializeComponent();
        }

        private void Closet_Load(object sender, EventArgs e)
        {

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Coridoor());
        }

        private void map_button_Click(object sender, EventArgs e)
        {
            Utility.AddMapToForm(this);
        }

        private void key_button_Click(object sender, EventArgs e)
        {
            if (!Player.key1)
            {
                MessageBox.Show("Vous venez de ramasser une clé.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Player.key1 = true;
            }
        }
    }
}
