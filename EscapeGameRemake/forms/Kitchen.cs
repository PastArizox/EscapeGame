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
    public partial class Kitchen : Form
    {
        public static bool chica_enabled = false;

        public Kitchen()
        {
            InitializeComponent();
        }

        private void check_state()
        {
            if (chica_enabled)
            {
                BackgroundImage = Properties.Resources.Kitchen_ON_background;
                eye_button.Visible = true;
                screamer_button.Visible = true;
            }
        }

        private void Kitchen_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Arcade());
        }

        private void nose_honk_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void eye_button_Click(object sender, EventArgs e)
        {
            Utility.AddEyetoForm(this, Properties.Resources.Chica_Eye);
        }

        private void screamer_button_Click(object sender, EventArgs e)
        {
            var Rand = new Random();
            if (Rand.Next(2) == 0)
                Screamer.Run(this, Path.Name.KITCHEN_JS, false);
        }
    }
}
