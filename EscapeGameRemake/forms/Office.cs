using System;
using System.Windows.Forms;
using EscapeGameRemake.src;

namespace EscapeGameRemake.forms
{
    public partial class Office : Form
    {
        private static bool DoorOpened = false;
        private static readonly int DOORCODE = 8453;

        public Office()
        {
            InitializeComponent();
        }

        private void Office_Load(object sender, EventArgs e)
        {
            CheckDoor();
        }

        private void CheckDoor()
        {
            if (DoorOpened)
            {
                BackgroundImage = Properties.Resources.Office_ON_background;
                door_button.Visible = true;
                digicode_button.Visible = false;
            }
        }

        private void desk_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new OfficeDesk());
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new StartingMenu());
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
                if (Rand.Next(3) == 0)
                    Screamer.Run(this, Path.Name.OFFICE_JS);

                /*var screamer = this.axWindowsMediaPlayer1;
                screamer.URL = Path.Get(Path.Name.OFFICE_JS);*/

                /*var screamer = new AxWMPLib.AxWindowsMediaPlayer();
                Controls.Add(screamer);
                screamer.BringToFront();
                screamer.PlayStateChange += Screamer_PlayStateChange;
                screamer.CreateControl();
                screamer.Visible = false;
                screamer.URL = Path.Get(Path.Name.OFFICE_JS);*/
            }
        }

        /*private void Screamer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            var screamer = (AxWMPLib.AxWindowsMediaPlayer)sender;
            
            switch (e.newState)
            {
                case 1:
                    //screamer.fullScreen = false;
                    screamer.Visible = false;
                    break;
                case 3:
                    screamer.Location = new System.Drawing.Point(0, 0);
                    screamer.Width = Width;
                    screamer.Height = Height;
                    screamer.uiMode = "none";
                    //screamer.fullScreen = true;
                    screamer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    screamer.Visible = true;
                    break;
                default:
                    Console.WriteLine(screamer.playState);
                    break;
            }
        }*/
    }
}
