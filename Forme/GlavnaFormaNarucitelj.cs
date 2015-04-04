using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eNarudžba.Forme;

namespace eNarudžba.Forme
{
    public partial class GlavnaFormaNarucitelj : Form
    {
        private Int64 oib;

        public Int64 Oib
        {
            get { return oib; }
            set { oib = value; }
        }
        

        /// <summary>
        /// Konstruktor forme 
        /// </summary>
        /// <param name="prijava">OIB(id) korisnika koji je prijavljen.</param>
        public GlavnaFormaNarucitelj(Int64 prijava)
        {
            InitializeComponent();
            Oib = prijava;
        }

        /// <summary>
        /// Metoda klikom na gumb otvara novu formu Povijest narudžbi,
        /// trenutnu formu zatvara.
        /// </summary>
        private void btnPovijestNarudžbi_Click(object sender, EventArgs e)
        {
            PovijestNarudzbi povijestNarudzbi = new PovijestNarudzbi(Oib);
            povijestNarudzbi.Show();
            this.Close();
        }

        /// <summary>
        /// Metoda klikom na gumb otvara novu formu Ponuda jelovnika,
        /// trenutnu formu zatvara.
        /// </summary>
        private void btnPonudaJelovnika_Click(object sender, EventArgs e)
        {
            PonudaJelovnika ponudaJelovnika = new PonudaJelovnika(Oib);
            ponudaJelovnika.Show();
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
        private void GlavnaFormaNarucitelj_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void GlavnaFormaNarucitelj_MouseMove(object sender, MouseEventArgs e)
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
