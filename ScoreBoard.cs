using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorm
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            var joueurs = Util.GetHighScoresFromTextFile(Constant.HIGH_SCORES_LIST_FILE_PATH);
            int compteur = 1;

            foreach(Joueur joueur in joueurs)
            {
                string tagJoueur = "joueur" + compteur;

                for (int i = topPlayerNamePanel.Controls.Count - 1; i >= 0; i--)
                {
                    if (topPlayerNamePanel.Controls[i].Tag.ToString() == tagJoueur)
                    {
                        topPlayerNamePanel.Controls[i].Text = joueur.nom;
                    }
                }

                for (int i = topPlayerScorePanel.Controls.Count - 1; i >= 0; i--)
                {
                    if (topPlayerScorePanel.Controls[i].Tag.ToString() == tagJoueur)
                    {
                        topPlayerScorePanel.Controls[i].Text = joueur.score.ToString();
                    }
                }

                compteur++;
            }
        }

        private void RetourAuMenuButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
