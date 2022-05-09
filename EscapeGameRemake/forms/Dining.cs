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
    public partial class Dining : Form
    {
        public Dining()
        {
            InitializeComponent();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new Coridoor());
        }

        private void dining_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new PirateCove());
        }

        private void nose_honk_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }
    }
}
