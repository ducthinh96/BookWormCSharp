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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonLancerPartie_Click(object sender, EventArgs e)
        {
            Form plateauJeu = new PlateauJeu
            {
                MdiParent = this,
                Visible = true
            };

            panel1.Visible = false;


        }
    }
}
