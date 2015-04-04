using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNarudžba.Forme
{
    public partial class PorukeRegistracija : Form
    {
        public PorukeRegistracija(string naslov,string poruka)
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(45, 165, 218);
            label1.Text = naslov;
            label2.Text = poruka;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
