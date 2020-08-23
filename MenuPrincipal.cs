using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace BookWorm
{


    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void buttonLancerPartie_Click(object sender, EventArgs e)
        {
            buttonClickSoundEffect();
            Form nouveauPlateauJeu = new PlateauJeu();
            nouveauPlateauJeu.Location = this.Location;
            nouveauPlateauJeu.StartPosition = FormStartPosition.Manual;
            nouveauPlateauJeu.FormClosing += delegate { this.Show(); };
            nouveauPlateauJeu.Show();
            this.Hide();

            nouveauPlateauJeu.FormClosing += delegate {
                this.Location = nouveauPlateauJeu.Location;
                this.Show();
            };

        }

        private void buttonClickSoundEffect()
        {
            SoundPlayer soundplayer1 = new SoundPlayer();
            soundplayer1.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\buttonclick.wav";
            soundplayer1.Play();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            buttonClickSoundEffect();
            Application.Exit();
        }

        private void backgroundMusic()
        {
            SoundPlayer soundplayer1 = new SoundPlayer();
            soundplayer1.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\menuBackgroundMusic.wav";
            soundplayer1.PlayLooping();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            backgroundMusic();
        }
    }
}
