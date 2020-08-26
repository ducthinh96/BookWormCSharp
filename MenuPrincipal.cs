using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        System.Drawing.Color btnColor;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonLancerPartie_Click(object sender, EventArgs e)
        {
            Util.PlayButtonClickSound();

            Form nomJoueur = new NomJoueur
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            nomJoueur.FormClosing += delegate {
                Util.PlayButtonClickSound();
                this.Location = nomJoueur.Location;
                this.Show();
                Util.SaveHighScore();
                BackgroundMusic();
            };
            nomJoueur.Show();
            this.Hide();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Util.PlayButtonClickSound();
            Thread.Sleep(300);
            Application.Exit();
        }

        private void BackgroundMusic()
        {
            if(Util.backgroundMusic.Source == null)
            {
                Util.backgroundMusic.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Sound\\menuBackgroundMusic.wav"));
            }
            Util.backgroundMusic.Play();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            BackgroundMusic();
        }

        private void buttonOptions(object sender, EventArgs e)
        {
            Util.PlayButtonClickSound();
            BackgroundMusic();
            Form menuOptions = new MenuOptions();
            menuOptions.Location = this.Location;
            menuOptions.StartPosition = FormStartPosition.Manual;
            menuOptions.FormClosing += delegate {
                Util.PlayButtonClickSound();
                this.Location = menuOptions.Location;
                this.Show();
                BackgroundMusic();
            };
            menuOptions.Show();
            this.Hide();
        }

        private void buttonScoreBoard(object sender, EventArgs e)
        {
            Util.PlayButtonClickSound();
            BackgroundMusic();
            Form scoreBoard = new ScoreBoard();
            scoreBoard.Location = this.Location;
            scoreBoard.StartPosition = FormStartPosition.Manual;
            scoreBoard.FormClosing += delegate {
                Util.PlayButtonClickSound();
                this.Location = scoreBoard.Location;
                this.Show();
                BackgroundMusic();
            };
            scoreBoard.Show();
            this.Hide();
        }

        private void ButtonMouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btnColor = btn.ForeColor;
            btn.ForeColor = System.Drawing.Color.White;
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = btnColor;
        }
    }
}
