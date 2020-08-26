using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;
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

        public static void SaveHighScore()
        {
            var joueurs = Util.GetHighScoresFromTextFile(Constant.HIGH_SCORES_LIST_FILE_PATH);
            joueurs = joueurs.OrderBy(o => o.score).ToList();
            int indexJoeur = -1;
            bool wrtieNewHighScore = false;

            foreach (Joueur joueur in joueurs)
            {
                if ((joueurs.Count < 5 && Util.scoreGlobal > 0) || joueur.score < Util.scoreGlobal)
                {
                    if (joueur.score < Util.scoreGlobal)
                    {
                        indexJoeur = joueurs.IndexOf(joueur);
                    }
                    wrtieNewHighScore = true;
                    break;
                }
            }

            if (wrtieNewHighScore)
            {
                if (indexJoeur != -1)
                {
                    joueurs.RemoveAt(indexJoeur);
                }
                Joueur newTopPlayer = new Joueur();
                newTopPlayer.nom = Util.nomJoueur;
                newTopPlayer.score = Util.scoreGlobal;
                joueurs.Add(newTopPlayer);
                joueurs = joueurs.OrderByDescending(o => o.score).ToList();

                string highScoresData = "";
                foreach (Joueur joueur in joueurs)
                {
                    highScoresData += joueur.nom + "," + joueur.score + Environment.NewLine;
                }
                File.WriteAllText(Constant.HIGH_SCORES_LIST_FILE_PATH, highScoresData);
                File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\" + Constant.HIGH_SCORES_LIST_FILE_PATH, highScoresData);

                MessageBox.Show("Ouaissss !!! T'es le n° " + (joueurs.IndexOf(newTopPlayer) + 1).ToString() + " parmi les meilleurs !!!", "Nouveau score élevé :O");
            }
        }
    }
}
