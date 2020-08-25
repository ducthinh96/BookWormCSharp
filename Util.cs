using System;
using System.IO;
using System.Media;
using System.Windows.Media;

namespace BookWorm
{
    public static class Util
    {
        public static MediaPlayer buttonClickSoundEffect = new MediaPlayer();
        public static MediaPlayer backgroundMusic = new MediaPlayer();
        public static SoundPlayer selectLetterSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\buttonclick.wav");
        public static SoundPlayer wordCompleteSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\wordComplete.wav");
        public static int volume { get ; set; }

        public static string[] ReadTextFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public static void SelectLetterSoundEffect()
        {
            selectLetterSound.Play();
        }

        public static void MatchWordSoundEffect()
        {
            wordCompleteSound.Play();
        }
    }
}
