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
        string[] wordList = Util.ReadTextFile(Constant.MAIN_WORD_LIST_FILE_PATH);

        public PlateauJeu()
        {
            InitializeComponent();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {
            // Init le mot bonus :
            var motBonusListe = Util.ReadTextFile(Constant.MOT_BONUS_FILE_PATH);
            Random random = new Random();
            motBonus = motBonusListe[random.Next(0,motBonusListe.Length)];
            bonusWordLabel.Text = motBonus;

            // Générer un nouveau plateau
            GenererNouveauPlateau();

            foreach (Button btn in plateauLettres.Controls.OfType<Button>())
            {
                btn.AllowDrop = true;
                btn.MouseDown += new MouseEventHandler(button1_MouseDown);
                btn.DragEnter += new DragEventHandler(button1_DragEnter);
                btn.DragDrop += new DragEventHandler(button1_DragDrop);
            }
        }

        private void GenererNouveauPlateau()
        {
            Random random = new Random();
            foreach (Button caseLettre in plateauLettres.Controls)
            {
                caseLettre.Text = Constant.ALPHABET_SANS_ACCENT.ToCharArray()[random.Next(0, Constant.ALPHABET_SANS_ACCENT.Length)].ToString();
                caseLettre.Font = new Font(Font.FontFamily.Name, 20);
            }
        }

        string letter;
        int index_btn_depart;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;

            letter = btn.Text;
            index_btn_depart = plateauLettres.Controls.IndexOf(btn);

            btn.DoDragDrop("bidon", DragDropEffects.Link);
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            Button btn = (Button)sender;

            if (index_btn_depart != plateauLettres.Controls.IndexOf(btn))
            {
                currentWordLabel.Text = currentWordLabel.Text + (string)btn.Tag;

                MessageBox.Show("Index bouton départ : " + index_btn_depart + "\n Index bouton arrivée : " + plateauLettres.Controls.IndexOf(btn).ToString());
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void mixWordBoardButton_Click(object sender, EventArgs e)
        {
            GenererNouveauPlateau();
        }
    }
}
