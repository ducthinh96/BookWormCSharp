using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Media;

namespace BookWorm
{
    public static class Util
    {
        public static MediaPlayer backgroundMusic = new MediaPlayer();
        public static SoundPlayer buttonClickSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Sound\\buttonclick.wav");
        public static SoundPlayer selectLetterSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Sound\\buttonclick.wav");
        public static SoundPlayer wordCompleteSound = new SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + "\\Sound\\wordComplete.wav");
        public static int volume { get ; set; }
        public static int scoreGlobal { get; set; }
        public static string nomJoueur { get; set; }

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

        public static void PlayButtonClickSound()
        {
            buttonClickSound.Play();
        }

        public static List<Joueur> GetHighScoresFromTextFile(string filePath)
        {
            List<Joueur> joueurs = new List<Joueur>();

            var lines = File.ReadAllLines(filePath);
            foreach(string line in lines)
            {
                var values = line.Split(',');
                var joueur = new Joueur();
                joueur.nom = values[0];
                joueur.score = Convert.ToInt32(values[1]);
                joueurs.Add(joueur);
            }

            return joueurs;
        }
    }
}
