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
    public partial class PorukeUpravljanje : Form
    {
        public PorukeUpravljanje()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(45, 165, 218);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
