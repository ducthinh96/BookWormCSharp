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

    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            
        }

        private void buttonLancerPartie_Click(object sender, EventArgs e)
        {

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

        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
