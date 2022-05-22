using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Dining : Form
    {
        public Dining()
        {
            InitializeComponent();
        }

        private void check_state()
        {
            if (Stage.freddy_enabled)
            {
                BackgroundImage = Properties.Resources.Dining_ON_background;
            }
        }

        private void Dining_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Coridoor());
        }

        private void nose_honk_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void piratecove_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new PirateCove());
        }

        private void backstage_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Backstage());
        }

        private void middledining_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new MiddleDining());
        }
    }
}
