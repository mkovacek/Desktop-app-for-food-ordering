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
    public partial class KomentiranjeHrane : Form
    {
        private int idHrane;

        public int IdHrane
        {
            get { return idHrane; }
            set { idHrane = value; }
        }
        
        /// <summary>
        /// Konstruktor forme 
        /// </summary>
        /// <param name="id">ID hrane koja se komentira</param>
        public KomentiranjeHrane(int id)
        {
            InitializeComponent();
            IdHrane = id;
        }

        /// <summary>
        /// Metoda pomoću koje pohranjujemo komentar u BP 
        /// za određenu hranu(onu koja je prosljeđena kod instanciranja).
        /// </summary>
        private void PohraniKomentar() 
        {
            using (var db = new T34_DBEntities6())
            {
                komentariHrana komentarHrane = new komentariHrana
                {
                    komentarHrana=txtKomentari.Text,
                    hranaID=IdHrane
                };
                db.komentariHrana.Add(komentarHrane);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva metodu PohranaKomentara(),
        /// trenutnu formu zatvara.
        /// </summary>
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            PohraniKomentar();
            this.Close();
        }

        private Point mouse_offset;

        /// <summary>
        /// Metoda pomoću koje saznajemo kordinate kursora miša kad je on pritisnut.
        /// </summary>
        private void KomentiranjeHrane_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void KomentiranjeHrane_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos;
            }
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
    }
}
