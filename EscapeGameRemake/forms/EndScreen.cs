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
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void EndScreen_background_Load(object sender, EventArgs e)
        {
            SoundController.PlayEndScreenMusic();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new StartingMenu());
        }

        private void nose_honk_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }
    }
}
