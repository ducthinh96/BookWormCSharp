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
    public partial class MenuOptions : Form
    {
        public MenuOptions()
        {
            InitializeComponent();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            Util.backgroundMusic.Volume = volumeTrackBar.Value / 100.0f;
        }

        private void MenuOptions_Load(object sender, EventArgs e)
        {
            volumeTrackBar.Value = Convert.ToInt32(Util.backgroundMusic.Volume * 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
