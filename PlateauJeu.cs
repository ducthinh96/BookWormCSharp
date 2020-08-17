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
        public PlateauJeu()
        {
            InitializeComponent();
        }

        private void PlateauJeu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuPrincipal.Show();
        }
    }
}
