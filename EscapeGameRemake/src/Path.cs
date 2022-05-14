namespace EscapeGameRemake.src
{
    public static class Path
    {
        private static readonly string StartupPath = System.Windows.Forms.Application.StartupPath;
        private static readonly string SoundsPath = StartupPath + "\\sounds\\";
        private static readonly string VidsPath = StartupPath + "\\vids\\";
        private static readonly string SoundExtension = ".wav";
        private static readonly string VidExtension = ".mp4";

        public enum Name
        {
            AMBIANCE, CLICK, DOOR, MENU_MUSIC, NOSE_HONK, PAPER, ROBOTVOICE, YAY, OFFICE_JS, BACKSTAGE_JS
        }

        public static string Get(Name name)
        {
            switch (name)
            {
                case Name.AMBIANCE:
                    return Sound("ambiance");
                case Name.CLICK:
                    return Sound("click");
                case Name.DOOR:
                    return Sound("door");
                case Name.MENU_MUSIC:
                    return Sound("menu_music");
                case Name.NOSE_HONK:
                    return Sound("nose_honk");
                case Name.PAPER:
                    return Sound("paper");
                case Name.ROBOTVOICE:
                    return Sound("robotvoice");
                case Name.YAY:
                    return Sound("yay_sound");
                case Name.OFFICE_JS:
                    return Vid("officejumpscare");
                case Name.BACKSTAGE_JS:
                    return Vid("backstagejumpscare");
                default:
                    return null;
            }
        }

        private static string Sound(string name) { return SoundsPath + name + SoundExtension; }

        private static string Vid(string name) { return VidsPath + name + VidExtension; }
    }
}
