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
    public partial class FinalDoor : Form
    {
        private static bool DoorOpened = false;
        private static readonly int DOORCODE = 9726;

        public FinalDoor()
        {
            InitializeComponent();
        }

        private void CheckDoor()
        {
            if (DoorOpened)
            {
                BackgroundImage = Properties.Resources.FinalDoor_ON_background;
                door_button.Visible = true;
                digicode_button.Visible = false;
            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new MiddleDining());
        }

        private void digicode_button_Click(object sender, EventArgs e)
        {
            Digicode digicode = new Digicode(this, DOORCODE);
            digicode.ShowDialog();
            if (digicode.getTypedCode() && digicode.check_code())
            {
                SoundController.Play(SoundType.DOOR);
                DoorOpened = true;
                CheckDoor();
            }
            else if (digicode.getTypedCode() && !digicode.check_code())
            {
                var Rand = new Random();
                if (Rand.Next(2) == 0)
                    Screamer.Run(this, Path.Name.OFFICE_JS, false);
            }
        }

        private void door_button_Click(object sender, EventArgs e)
        {
            SoundController.Play(SoundType.YAY_SOUND);
            Utility.OpenForm(this, new EndScreen());
        }
    }
}
