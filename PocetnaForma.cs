using eNarudžba.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNarudžba
{
    public partial class PocetnaForma : Form
    {
        
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijavaForma prijavaForma = new PrijavaForma(this);
            prijavaForma.Show();
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaForma registracijaForma = new RegistracijaForma(this);
            registracijaForma.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private Point mouse_offset;
        private void PocetnaForma_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void PocetnaForma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }




    }
}
