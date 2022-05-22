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
    public partial class Stage : Form
    {
        public static bool freddy_enabled = false;

        public Stage()
        {
            InitializeComponent();
        }

        private void check_state()
        {
            if (freddy_enabled)
            {
                nose_honk_button1.Visible = true;
                nose_honk_button2.Visible = false;
                eye_button.Visible = true;
                BackgroundImage = Properties.Resources.Stage_ON_background;
            }
        }

        private void Stage_Load(object sender, EventArgs e)
        {
            check_state();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new MiddleDining());
        }

        private void nose_honk_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.NOSE_HONK);
        }

        private void eye_button_Click(object sender, EventArgs e)
        {
            Utility.AddEyetoForm(this, Properties.Resources.Freddy_Eye);
        }
    }
}
