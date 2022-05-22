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
    public partial class MiddleDining : Form
    {
        public MiddleDining()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Dining());
        }

        private void check_state()
        {
            if (Stage.freddy_enabled)
            {
                BackgroundImage = Properties.Resources.MiddleDining_ON_background;
            }
        }

        private void MiddleDining_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void finaldoor_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new FinalDoor());
        }

        private void stage_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Stage());
        }

        private void arcade_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Arcade());
        }
    }
}
