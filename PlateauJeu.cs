using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookWorm
{
    public partial class PlateauJeu : Form
    {
        // Le mot bonus
        string motBonus;
        // Récupérer le dictionnaire des mots
        string[] wordList = Util.ReadTextFile(Constant.MAIN_WORD_LIST_FILE_PATH);
        // Index des cases du premier rang (au plus haut)
        int[] topRowButtonsIndexListe = { 6, 14, 21, 29, 36, 44, 51};
        // Index des cases du premier rang (au plus bas)
        int[] bottomRowButtonsIndexListe = { 45, 37, 30, 22, 15, 7, 0 };
        // La liste qui contient l'index des cases en feu
        List<int> caseLettreEnFeuListe = new List<int>();
        // Init du chrono pour faire descendre les cases en feu toutes les 6000 milliscondes
        Timer chrono = new Timer
        {
            Interval = 10000
        };
        int index_btn_depart;
        int posX_btnDepart;
        int posY_btnDepart;
        int scoreTotalPartie = 0;
        int niveau = 1;
        // barème pour le prochain niveau
        int pointParNiveau = 50;
        MouseEventArgs evnt;
        struct nbOccurLettres
        {
            // Structure de donnée pour garder le compte du nombre d'occurence actuel de chaque lettre dans le tableau afin de s'arranger pour sortir plus au moins les lettres selon leurs fréquences d'utilisationrs dans la langue française
            public char lettre;
            public int nbOccurMax;
            public int nbOccurPlateau;
        }
        nbOccurLettres[] structTest = new nbOccurLettres[26];
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random random = new Random();

        public PlateauJeu()
        {
            InitializeComponent();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {
            // Init le mot courant
            currentWordLabel.Text = "";

            // Init le score du mot courant
            scoreOfWordLabel.Text = "";

            // Init le mot bonus :
            var motBonusListe = Util.ReadTextFile(Constant.MOT_BONUS_FILE_PATH);
            Random random = new Random();
            motBonus = motBonusListe[random.Next(0,motBonusListe.Length)];
            bonusWordLabel.Text = motBonus;

            // Initialisation du label qui contient le niveau du joueur
            levelLabel.Text = "Niveau " + niveau.ToString();

            // Initialisation du dictionnaire qui contient la valeur de chaque lettre
            int[] arrayValeurLettres = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 10, 1, 2, 1, 1, 3, 8, 1, 1, 1, 1, 4, 10, 10, 10, 10 };

            for (int i = 0; i < 26; i++)
            {
                valeurLettres.Add(alphabet[i], arrayValeurLettres[i]);
            }

            // Générer un nouveau plateau
            GenererNouveauPlateau();

            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                // Brancher les événements pour le Drag and Drop
                btn.AllowDrop = true;
                btn.MouseDown += new MouseEventHandler(button1_MouseDown);
                btn.DragEnter += new DragEventHandler(button1_DragEnter);
                btn.DragDrop += new DragEventHandler(button1_DragDrop);

                // Init l'état des buttons
                btn.BackColor = SystemColors.ButtonFace; // Default color
                btn.Tag = Constant.NOT_SELECTED; // Etat = non sélectionné
            }

            // Brancher l'événement Tick du chrono à la méthode OnTickEvent
            chrono.Tick += OnTickEvent;
        }

        private void ResetJeu()
        {
            // Init le score dans la variable globale
            Util.scoreGlobal = -1;

            // Init le mot courant
            currentWordLabel.Text = "";

            // Init le score du mot courant
            scoreOfWordLabel.Text = "";

            // Init le mot bonus :
            var motBonusListe = Util.ReadTextFile(Constant.MOT_BONUS_FILE_PATH);
            Random random = new Random();
            motBonus = motBonusListe[random.Next(0, motBonusListe.Length)];
            bonusWordLabel.Text = motBonus;

            // Initialisation du label qui contient le niveau du joueur
            levelLabel.Text = "Niveau " + niveau.ToString();

            // Vider la liste des cases en feu
            caseLettreEnFeuListe.Clear();

            // Initialiser la couleur des cases
            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                btn.BackColor = SystemColors.ButtonFace; // Default color
                btn.Tag = Constant.NOT_SELECTED; // Etat = non sélectionné
            }
        }

        private string GenererNouvelleLettre()
        {
            int randConst = 0;
            bool relancerRandom = true;
            

            string tempLettre;


            while (relancerRandom)
            {
                // random pour obtenir un int qui va correspondre à une lettre de l'alphabet
                randConst = random.Next(0, Constant.ALPHABET_SANS_ACCENT.Length);

                // test si la lettre tirée a déjà excédé son quota d'apparition
                if (structTest[randConst].nbOccurPlateau < structTest[randConst].nbOccurMax)
                {

                    // si elle ne l'a pas excédé, on incrémente le compteur d'apparition de cette lettre et on sort de la boucle
                    structTest[randConst].nbOccurPlateau++;

                    relancerRandom = false;
                }
            }

            // on récupère la lettre qui correspond à ce numéro dans l'alphabet
            tempLettre = Constant.ALPHABET_SANS_ACCENT.ToCharArray()[randConst].ToString();

            return tempLettre;
        }

        Dictionary<char, int> valeurLettres = new Dictionary<char, int>();

        private void GenererNouveauPlateau()
        {
            // array qui contient les quotas d'apparition de chaque lettre
            int[] maxOccurLettres = { 6, 1, 2, 2, 11, 1, 1, 1, 5, 1, 1, 3, 2, 4, 3, 2, 1, 4, 5, 4, 4, 1, 1, 1, 1, 1 };

            // Initialisation de la variable structurée
            for (int i = 0; i < 26; i++)
            {
                structTest[i].lettre = alphabet[i];
                structTest[i].nbOccurMax = maxOccurLettres[i];
                structTest[i].nbOccurPlateau = 0;
            }


            foreach (Button caseLettre in plateauLettres.Controls.OfType<Button>())
            {

                // on remplace le texte du bouton par la lettre
                caseLettre.Text = GenererNouvelleLettre();

                caseLettre.Font = new Font(Font.FontFamily.Name, 20);
            }

            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            // Jouer l'effet sonore
            Util.SelectLetterSoundEffect();

            index_btn_depart = plateauLettres.Controls.IndexOf(btn);

            // on stock la position du bouton de départ et on y rajoute 44 pour l'abcisse et l'ordonnée pour recentrer le marqueur de position dans l'axe
            posX_btnDepart = btn.Left + 44;
            posY_btnDepart = btn.Top + 44;

            // Si la lettre n'est pas encore sélectionnée
            // => Changer son état à SELECTED, sa couleur et faire le Drag&Drop
            // Uniquement pour la toute première lettre cliquée
            if (btn.Tag.ToString() == Constant.NOT_SELECTED)
            {
                currentWordLabel.Text += btn.Text;
                if(btn.BackColor == Color.Red)
                {
                    btn.BackColor = Color.OrangeRed; // Couleur quand une case en feu est sélectionnée
                }
                else
                {
                    btn.BackColor = Color.BurlyWood; // Couleur quand une case normale est sélectionnée
                }
                btn.Tag = Constant.SELECTED;
                evnt = e;

                btn.DoDragDrop("bidon", DragDropEffects.Link);
            }
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            /*
             * Quand le joueur relâche le souris
             */

            // Vérifier si le mot sélectionné existe dans le dictionnaire
            CheckMatchingWord(currentWordLabel.Text);

            // Réinitialiser le plateau après que le souris est relâché
            currentWordLabel.Text = ""; // Réinit le mot courant
            scoreOfWordLabel.Text = ""; // Réinit le score du mot courant
            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                // Réinit l'état des boutons
                if (btn.BackColor != Color.Red && btn.BackColor != Color.OrangeRed)
                {
                    btn.BackColor = SystemColors.ButtonFace; // Default color
                }
                else if (btn.BackColor == Color.OrangeRed)
                {
                    btn.BackColor = Color.Red; // Reinit la couleur de la case en feu
                }
                btn.Tag = Constant.NOT_SELECTED; // Etat = non sélectionné
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;

            Button btn = (Button)sender;

            int posX_btnArrivee = btn.Left + 44;
            int posY_btnArrivee = btn.Top + 44;

            // Vérifier que ce n'est pas la même lettre
            if (plateauLettres.Controls.IndexOf(btn) != index_btn_depart)
            {
                // Vérifier :
                // => si le btnArrivee est le voisin du btnDepart
                // => si le btnArrivee n'est pas sélectionné
                if (posX_btnArrivee - posX_btnDepart <= 100 && posX_btnArrivee - posX_btnDepart >= -100 && posY_btnArrivee - posY_btnDepart <= 100 && posY_btnArrivee - posY_btnDepart >= -100 && btn.Tag.ToString() == Constant.NOT_SELECTED)
                {
                    // Ajouter la lettre à la fin du mot courant
                    currentWordLabel.Text += btn.Text;

                    // Changer l'état du bouton à SELECTED
                    if(btn.BackColor == Color.Red)
                    {
                        btn.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        btn.BackColor = Color.BurlyWood;
                    }
                    
                    btn.Tag = Constant.SELECTED;

                    // Estimer le score du mot courant
                    ScoreOfCurrentWord();

                    // Maintenant le btnArrivee sera le btnDepart
                    button1_MouseDown(btn, evnt);
                }
            }
        }

        private void CheckMatchingWord(string mot)
        {
            mot = mot.ToLower();
            var isMatch = Array.Exists(wordList, s => s.Equals(mot));

            if (isMatch)
            {
                // Jouer l'effet sonore
                Util.MatchWordSoundEffect();

                // conversion du mot validé en majuscules pour pouvoir être comparé au dictionnaire
                string motMajuscules = mot.ToUpper();

                // on recherche la valeur de chaque lettres du mot trouvé
                foreach (char letter in motMajuscules)
                {
                    // on décrémente le nombre d'occurence actuelle de cette lettre
                    decrementerNbOccurLettre(letter);

                    // on rajoute les points de chaque lettre au score total de la partie
                    scoreTotalPartie += valeurLettres[letter];

                    // Enregistrer le score de la partie dans une variable globale
                    Util.scoreGlobal = scoreTotalPartie;
                }

                // vérification si après le dernier mot trouvé, le score dépasse le prochain barème de niveau
                if (scoreTotalPartie >= pointParNiveau)
                {
                    // incrémentation du niveau
                    niveau++;
                    // augmentation du barème pour le prochain niveau de 100
                    pointParNiveau += 100;
                    // affichage du nouveau niveau du joueur
                    levelLabel.Text = "Niveau " + niveau.ToString();
                    // réduction du temps entre deux descente de case en feu dans une limite de 1 seconde au minimum
                    if (chrono.Interval > 1000)
                    {
                        chrono.Interval -= 250;
                    }
                    
                }

                scoreLabel.Text = scoreTotalPartie.ToString();
                ReplaceCharacters();
            }
        }

        private void ScoreOfCurrentWord()
        {
            string mot = currentWordLabel.Text.ToLower();
            var isMatch = Array.Exists(wordList, s => s.Equals(mot));
            int score = 0;

            if (isMatch)
            {
                // conversion du mot validé en majuscules pour pouvoir être comparé au dictionnaire
                string motMajuscules = mot.ToUpper();

                // on recherche la valeur de chaque lettres du mot trouvé
                foreach (char letter in motMajuscules)
                {
                    // on rajoute les points de chaque lettre au score total de la partie
                    score += valeurLettres[letter];
                }

                scoreOfWordLabel.Text = "+" + score.ToString();
            }
            else
            {
                scoreOfWordLabel.Text = "";
            }
        }

        private void decrementerNbOccurLettre(char lettre)
        {
            bool match = false;
            int i = 0;

            while (!match && i < 26)
            {
                if (lettre == structTest[i].lettre)
                {
                    structTest[i].nbOccurPlateau--;
                    match = true;
                }

                i++;
            }
        }

        private void ReplaceCharacters()
        {

            var btnArray = plateauLettres.Controls.OfType<Button>();
            for (int k = btnArray.Count() -1; k >= 0; k--)
            {
                Button btn = btnArray.ElementAt(k);

                if (btn.Tag.ToString() == Constant.SELECTED)
                {
                    bool topRowReached = false;
                    int i = plateauLettres.Controls.IndexOf(btn);

                    // Si la case est une case en feu
                    // Il faut retirer l'effet "feu" une fois que le joueur arrive à matcher la lettre
                    if (caseLettreEnFeuListe.Contains(i))
                    {
                        caseLettreEnFeuListe.Remove(i);
                        btn.BackColor = SystemColors.ButtonFace; // Réinitialisé la couleur du bouton
                    }

                    while (!topRowReached)
                    {
                        if(topRowButtonsIndexListe.Contains(i))
                        {
                            // générer une nouvelle lettre
                            plateauLettres.Controls[i].Text = GenererNouvelleLettre();

                            topRowReached = true;
                        }
                        else
                        {
                            plateauLettres.Controls[i].Text = plateauLettres.Controls[i + 1].Text;
                        }

                        // Si la case est une case en feu
                        // Il faut faire descendre aussi l'effet "feu"
                        if (caseLettreEnFeuListe.Contains(i))
                        {
                            plateauLettres.Controls[i-1].BackColor = plateauLettres.Controls[i].BackColor;
                            plateauLettres.Controls[i].BackColor = SystemColors.ButtonFace;
                            int indexDansListeCaseEnFeu = caseLettreEnFeuListe.IndexOf(i);
                            caseLettreEnFeuListe[indexDansListeCaseEnFeu] -= 1;
                            if(bottomRowButtonsIndexListe.Contains(caseLettreEnFeuListe[indexDansListeCaseEnFeu]))
                            {
                                // Si la nouvelle case en feu est dans le rang au plus bas
                                // Game over
                                GameOver();
                            }
                        }

                        i++;
                    }
                }
            }
        }

        private void mixWordBoardButton_Click(object sender, EventArgs e)
        {
            GenererNouveauPlateau();

            bool nouvelleCaseEnFeu = true;
            int caseEnFeuIndex = 0;

            while (nouvelleCaseEnFeu)
            {
                // tirage au sort d'une case qui va être en feu
                int randConst = random.Next(0, topRowButtonsIndexListe.Length-1);
                caseEnFeuIndex = topRowButtonsIndexListe[randConst];

                if (plateauLettres.Controls[caseEnFeuIndex].BackColor != Color.Red)
                {
                    nouvelleCaseEnFeu = false;
                }
            }

            caseLettreEnFeuListe.Add(caseEnFeuIndex);

            plateauLettres.Controls[caseEnFeuIndex].BackColor = Color.Red;

            if (chrono.Enabled == false)
            {
                // Activer le chrono si il n'était pas activé
                chrono.Enabled = true;
            }
        }

        private void OnTickEvent(Object source, EventArgs e)
        {
            // parcourir l'array qui contient l'index de toutes les cases en feu
            for (int i = 0; i < caseLettreEnFeuListe.Count; i++)
            {
                // on remet la couleur du bouton par défaut
                plateauLettres.Controls[caseLettreEnFeuListe[i]].BackColor = Color.WhiteSmoke;

                // faire descenre les cases au-dessus
                bool topRowReached = false;
                int j = caseLettreEnFeuListe[i] - 1;

                while (!topRowReached)
                {
                    if (topRowButtonsIndexListe.Contains(j))
                    {
                        // générer une nouvelle lettre
                        plateauLettres.Controls[j].Text = GenererNouvelleLettre();

                        topRowReached = true;
                    }
                    else
                    {
                        plateauLettres.Controls[j].Text = plateauLettres.Controls[j + 1].Text;
                    }

                    j++;
                }

                // on décrémente de 1 l'index des cases en feu contenues dans l'array "caseLettreEnFeuListe"
                caseLettreEnFeuListe[i] = caseLettreEnFeuListe[i] - 1;

                // on colorie en rouge le bouton d'index -1 (on fait descendre la case en feu)
                plateauLettres.Controls[caseLettreEnFeuListe[i]].BackColor = Color.Red;

                // Vérification si une case en feu qui descend atteint le bas du tableau (défaite)
                if (bottomRowButtonsIndexListe.Contains(caseLettreEnFeuListe[i]))
                {
                    GameOver();
                }
                
            }
        }

        private void RevenirAuMenu(object sender, EventArgs e)
        {
            if (chrono.Enabled == true)
            {
                chrono.Enabled = false;
            }
            

            this.Close();
        }

        private void GameOver()
        {
            // désactivation du chronomètre car fin de la partie
            chrono.Enabled = false;

            MessageBox.Show("Perdu !");
            Util.SaveHighScore();
            var reponse = MessageBox.Show("Recommencer ?", "Que veux-tu ?", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                ResetJeu();
            }
            else
            {
                this.Close();
            }
        }
    }
}
