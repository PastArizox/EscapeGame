using System.Media;

namespace EscapeGameRemake.src
{
    public enum SoundType
    {
        NOSE_HONK, ROBOTVOICE, YAY_SOUND, CLICK, DOOR, PAPER, RIDEAU, ANIMATRONIC_ON, ERROR_SQL, SHREK, END
    }

    public class SoundController
    {
        private static AxWMPLib.AxWindowsMediaPlayer WMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
        private static SoundPlayer Player = new SoundPlayer();

        public static void PlayMainMusic()
        {
            WMPlayer.CreateControl();
            WMPlayer.settings.autoStart = true;
            WMPlayer.settings.setMode("loop", true);
            WMPlayer.URL = WMPlayer.URL = Path.Get(Path.Name.AMBIANCE);
        }

        public static void PlayMenuMusic()
        {
            WMPlayer.CreateControl();
            WMPlayer.settings.autoStart = true;
            WMPlayer.settings.setMode("loop", true);
            WMPlayer.URL = Path.Get(Path.Name.MENU_MUSIC);
        }

        public static void PlayEndScreenMusic()
        {
            WMPlayer.CreateControl();
            WMPlayer.settings.autoStart = true;
            WMPlayer.settings.setMode("loop", true);
            WMPlayer.URL = Path.Get(Path.Name.END);
        }

        public static void Play(SoundType Type)
        {
            switch (Type)
            {
                case SoundType.NOSE_HONK:
                    Player.SoundLocation = Path.Get(Path.Name.NOSE_HONK);
                    break;
                case SoundType.ROBOTVOICE:
                    Player.SoundLocation = Path.Get(Path.Name.ROBOTVOICE);
                    break;
                case SoundType.YAY_SOUND:
                    Player.SoundLocation = Path.Get(Path.Name.YAY);
                    break;
                case SoundType.CLICK:
                    Player.SoundLocation = Path.Get(Path.Name.CLICK);
                    break;
                case SoundType.DOOR:
                    Player.SoundLocation = Path.Get(Path.Name.DOOR);
                    break;
                case SoundType.PAPER:
                    Player.SoundLocation = Path.Get(Path.Name.PAPER);
                    break;
                case SoundType.RIDEAU:
                    Player.SoundLocation = Path.Get(Path.Name.RIDEAU);
                    break;
                case SoundType.ANIMATRONIC_ON:
                    Player.SoundLocation = Path.Get(Path.Name.ANIMATRONIC_ON);
                    break;
                case SoundType.ERROR_SQL:
                    Player.SoundLocation = Path.Get(Path.Name.ERROR_SQL);
                    break;
                case SoundType.SHREK:
                    Player.SoundLocation = Path.Get(Path.Name.SHREK);
                    break;
                case SoundType.END:
                    Player.SoundLocation = Path.Get(Path.Name.END);
                    break;
            }

            if (System.IO.File.Exists(Player.SoundLocation))
                Player.Play();
        }
    }
}
