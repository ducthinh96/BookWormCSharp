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
            button1.Visible = false;
            button1.Enabled = false;

            button2.Visible = false;
            button2.Enabled = false;

            button3.Visible = false;
            button3.Enabled = false;

            button4.Visible = false;
            button4.Enabled = false;

            Form plateauJeu = new PlateauJeu
            {
                MdiParent = this,
                Visible = true
            };

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
