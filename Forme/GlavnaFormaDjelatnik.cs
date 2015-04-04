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
    public partial class GlavnaFormaDjelatnik : Form
    {
        public GlavnaFormaDjelatnik()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda klikom na gumb otvara novu formu Zaprimljene narudžbe,
        /// trenutnu formu zatvara.
        /// </summary>
        private void btnPregledZaprimljenihNarudzbi_Click(object sender, EventArgs e)
        {
            ZaprimljeneNarudzbe zaprimljeneNarudzbe = new ZaprimljeneNarudzbe();
            zaprimljeneNarudzbe.Show();
            this.Close();
        }

        /// <summary>
        /// Metoda klikom na gumb otvara novu formu Upravljanje korisnikom,
        /// trenutnu formu zatvara.
        /// </summary>
        private void btnUpravljanjeKorisnikom_Click(object sender, EventArgs e)
        {
            UpravljanjeKorisnikom upravljanjeKorisnikom = new UpravljanjeKorisnikom();
            upravljanjeKorisnikom.Show();
            this.Close();
        }

        /// <summary>
        /// Metoda koja klikom na sliku minimizira trenutnu formu.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Metoda koja klikom na sliku zatvara trenutnu formu.
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point mouse_offset;

        /// <summary>
        /// Metoda pomoću koje saznajemo kordinate kursora miša kad je on pritisnut.
        /// </summary>
        private void GlavnaFormaDjelatnik_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne formu.
        /// </summary>
        private void GlavnaFormaDjelatnik_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos;
            }
        }





    }
}
