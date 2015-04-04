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
    public partial class poruke : Form
    {
        public poruke(string poruka)
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(45, 165, 218);
            label2.Text = poruka;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
