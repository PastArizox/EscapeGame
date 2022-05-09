using System;
using System.Windows.Forms;

namespace EscapeGameRemake.src
{
    public class Screamer
    {
        private static Form mainForm;
        private static bool fullscreen;

        public static void Run(Form mainForm, Path.Name name, bool fullscreen)
        {
            Screamer.mainForm = mainForm;
            Screamer.fullscreen = fullscreen;
            var screamer = new AxWMPLib.AxWindowsMediaPlayer();
            mainForm.Controls.Add(screamer);
            screamer.BringToFront();
            screamer.PlayStateChange += Screamer_PlayStateChange;
            screamer.CreateControl();
            screamer.Visible = false;
            screamer.enableContextMenu = false;
            screamer.Ctlenabled = false;
            screamer.URL = Path.Get(name);
        }

        private static void Screamer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            var screamer = (AxWMPLib.AxWindowsMediaPlayer)sender;

            switch (e.newState)
            {
                case 1:
                    if (fullscreen) screamer.fullScreen = false;
                    screamer.Visible = false;
                    break;
                case 3:
                    screamer.Location = new System.Drawing.Point(0, 0);
                    screamer.Width = mainForm.Width;
                    screamer.Height = mainForm.Height;
                    screamer.uiMode = "none";
                    if (fullscreen) screamer.fullScreen = true;
                    screamer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    screamer.Visible = true;
                    break;
                /*default:
                    Console.WriteLine(screamer.playState);
                    break;*/
            }
        }
    }
}
