using System.IO;
using System.Windows.Media;

namespace BookWorm
{
    public class Util
    {
        public static MediaPlayer buttonClickSoundEffect = new MediaPlayer();
        public static MediaPlayer backgroundMusic = new MediaPlayer();
        public static int volume { get ; set; }

        public static string[] ReadTextFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }
    }
}
