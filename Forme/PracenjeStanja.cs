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
    public partial class PracenjeStanja : Form
    {
        int idNarudzbe;

        /// <summary>
        /// Konstruktor, prilikom instanciranja pokreće se timer
        /// koji svakih 60 sekundi poziva metodu prikaziStatuse().
        /// </summary>
        /// <param name="id">ID narudžbe za koju se prate statusi</param>
        public PracenjeStanja(int id)
        {
            InitializeComponent();
            idNarudzbe = id;
            timer1.Start();
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            prikaziStatuse();
        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve statuse za određenu narudžbu iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void prikaziStatuse()
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from ns in db.NarudzbaStatus join n in db.Narudzba on ns.IDnarudzba equals n.IDnarudzba join s in db.Status on ns.IDstatus equals s.IDstatus where n.IDnarudzba == idNarudzbe select new { s.Naziv, ns.VrijemeKreiranjaStatusa }).ToList();

                    BindingSource bindingSourcePracenjeStanja = new BindingSource();
                    bindingSourcePracenjeStanja.DataSource = upit;
                    dgvPracenjeStanja.DataSource = bindingSourcePracenjeStanja;
                    dgvPracenjeStanja.Columns[0].HeaderText = "Status";
                    dgvPracenjeStanja.Columns[1].HeaderText = "Vrijeme kreiranja statusa";
                }
            }
            catch (Exception)
            {
                string naslov = "Upozorenje";
                string poruka = "Provjerite internetsku vezu";
                PorukeKomentiranje upozorenje = new PorukeKomentiranje(naslov, poruka);
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Na događaj load forme poziva se metoda prikaziStatuse()
        /// </summary>
        private void PracenjeStanja_Load(object sender, EventArgs e)
        {
            prikaziStatuse();
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
        private void PracenjeStanja_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne formu.
        /// </summary>
        private void PracenjeStanja_MouseMove(object sender, MouseEventArgs e)
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
