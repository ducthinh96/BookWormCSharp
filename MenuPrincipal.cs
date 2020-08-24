using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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
            ButtonClickSoundEffect();
            Form nouveauPlateauJeu = new PlateauJeu();
            nouveauPlateauJeu.Location = this.Location;
            nouveauPlateauJeu.StartPosition = FormStartPosition.Manual;
            nouveauPlateauJeu.FormClosing += delegate {
                ButtonClickSoundEffect();
                this.Location = nouveauPlateauJeu.Location;
                this.Show();
                BackgroundMusic();
            };
            nouveauPlateauJeu.Show();
            this.Hide();
        }

        private void ButtonClickSoundEffect()
        {
            Util.backgroundMusic.Pause();
            if(Util.buttonClickSoundEffect.Source == null)
            {
                Util.buttonClickSoundEffect.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\buttonclick.wav"));
            }
            Util.buttonClickSoundEffect.Play();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            ButtonClickSoundEffect();
            Thread.Sleep(300);
            Application.Exit();
        }

        private void BackgroundMusic()
        {
            if(Util.backgroundMusic.Source == null)
            {
                Util.backgroundMusic.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\menuBackgroundMusic.wav"));
            }
            Util.backgroundMusic.Play();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            BackgroundMusic();
        }

        private void buttonOptions(object sender, EventArgs e)
        {
            ButtonClickSoundEffect();
            BackgroundMusic();
            Form menuOptions = new MenuOptions();
            menuOptions.Location = this.Location;
            menuOptions.StartPosition = FormStartPosition.Manual;
            menuOptions.FormClosing += delegate {
                ButtonClickSoundEffect();
                this.Location = menuOptions.Location;
                this.Show();
                BackgroundMusic();
            };
            menuOptions.Show();
            this.Hide();
        }
    }
}
