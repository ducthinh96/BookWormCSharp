using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWorm
{
    public partial class PlateauJeu : Form
    {
        string motBonus;
        // Récupérer le dictionnaire des mots
        string[] wordList = Util.ReadTextFile(Constant.MAIN_WORD_LIST_FILE_PATH);
        int[] topRowButtonsIndexListe = { 0, 7, 15, 22, 30, 37, 45};

        public PlateauJeu()
        {
            InitializeComponent();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {
            // Init le mot courant
            currentWordLabel.Text = "";

            // Init le mot bonus :
            var motBonusListe = Util.ReadTextFile(Constant.MOT_BONUS_FILE_PATH);
            Random random = new Random();
            motBonus = motBonusListe[random.Next(0,motBonusListe.Length)];
            bonusWordLabel.Text = motBonus;

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
        }

        private void GenererNouveauPlateau()
        {
            // Générer un plateau de manière aléatoire
            Random random = new Random();
            foreach (Button caseLettre in plateauLettres.Controls.OfType<Button>())
            {
                caseLettre.Text = Constant.ALPHABET_SANS_ACCENT.ToCharArray()[random.Next(0, Constant.ALPHABET_SANS_ACCENT.Length)].ToString();
                caseLettre.Font = new Font(Font.FontFamily.Name, 20);
            }
        }

        string letter;
        int index_btn_depart;
        int posX_btnDepart;
        int posY_btnDepart;
        MouseEventArgs evnt;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            letter = btn.Text;
            index_btn_depart = plateauLettres.Controls.IndexOf(btn);
            posX_btnDepart = btn.Left + 44;
            posY_btnDepart = btn.Top + 44;

            // Si la lettre n'est pas encore sélectionnée
            // => Changer son état à SELECTED, sa couleur et faire le Drag&Drop
            // Uniquement pour la toute première lettre cliquée
            if (btn.Tag.ToString() == Constant.NOT_SELECTED)
            {
                currentWordLabel.Text += btn.Text;
                btn.BackColor = Color.BurlyWood;
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
            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                // Réinit l'état des boutons
                btn.BackColor = SystemColors.ButtonFace; // Default color
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
                    btn.BackColor = Color.BurlyWood;
                    btn.Tag = Constant.SELECTED;

                    // Maintenant le btnArrivee sera le btnDepart
                    button1_MouseDown(btn, evnt);
                }
            }
        }

        private void CheckMatchingWord(string mot)
        {
            mot = mot.ToLower();
            var isMatch = Array.Exists(wordList, s => s.Equals(mot));

            if(isMatch)
            {
                MessageBox.Show("Ok", "OK");
                ReplaceCharacters();
            }
        }

        private void ReplaceCharacters()
        {
            Random random = new Random();

            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                if (btn.Tag.ToString() == Constant.SELECTED)
                {
                    bool topRowReached = false;
                    int i = plateauLettres.Controls.IndexOf(btn);

                    while(!topRowReached)
                    {
                        if(topRowButtonsIndexListe.Contains(i))
                        {
                            plateauLettres.Controls[i].Text = Constant.ALPHABET_SANS_ACCENT.ToCharArray()[random.Next(0, Constant.ALPHABET_SANS_ACCENT.Length)].ToString();
                            topRowReached = true;
                        }
                        else
                        {
                            plateauLettres.Controls[i].Text = plateauLettres.Controls[i + 1].Text;
                        }

                        i++;
                    }
                }
            }
        }

        private void mixWordBoardButton_Click(object sender, EventArgs e)
        {
            GenererNouveauPlateau();
        }

        private void RevenirAuMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
