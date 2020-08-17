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
    public partial class PlateauJeu : Form
    {
        string motBonus;
        public PlateauJeu()
        {
            InitializeComponent();
        }

        private void PlateauJeu_Load(object sender, EventArgs e)
        {
            // Init le mot bonus :
            var motBonusListe = new TextFileReader(Constant.MOT_BONUS_FILE_PATH);
            Random random = new Random();
            motBonus = motBonusListe.Content[random.Next(0,motBonusListe.Content.Length)];
            bonusWordLabel.Text = motBonus;

        }
    }
}
