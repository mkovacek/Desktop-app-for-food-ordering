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
    public partial class ZaprimljeneNarudzbe : Form
    {
        private int idNarudzbe;
        private bool provjera = false;

        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }
        public bool Provjera { get { return provjera; } set { provjera = value; } }

        /// <summary>
        /// Konstruktor, prilikom instanciranja pokreće se timer
        /// koji svakih 60 sekundi poziva metodu PrikaziZaprimljeneNarudzbe().
        /// </summary>
        public ZaprimljeneNarudzbe()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            PrikaziZaprimljeneNarudzbe();
        }

        /// <summary>
        /// Na događaj load forme poziva se metoda PrikaziZaprimljeneNarudzbe()
        /// </summary>
        private void ZaprimljeneNarudzbe_Load(object sender, EventArgs e)
        {
            PrikaziZaprimljeneNarudzbe();
        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve narudžbe iz DB koje nisu dostavljene
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void PrikaziZaprimljeneNarudzbe() 
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {

                    var upit = (from n in db.Narudzba
                                join k in db.Korisnik on n.IDnarucitelj equals k.OIB
                                join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba
                                join h in db.Hrana on nh.IDhrana equals h.IDhrana
                                where n.Zavrseno != 1
                                group new { n, k, nh, h } by new { n.IDnarudzba, n.DatumVrijemeZaprimanja, k.Ime, k.Prezime, k.Adresa }
                                    into grup
                                    select new { grup.Key.IDnarudzba, grup.Key.DatumVrijemeZaprimanja, Cijena = grup.Sum(h => h.h.Cijena), grup.Key.Ime, grup.Key.Prezime, grup.Key.Adresa }).OrderByDescending(n => n.IDnarudzba).ToList();

                    BindingSource bindingSourceZaprimljeneNarudzbe = new BindingSource();
                    bindingSourceZaprimljeneNarudzbe.DataSource = upit;
                    dgvZaprimljeneNarudzbe.DataSource = bindingSourceZaprimljeneNarudzbe;
                }
            }
            catch (Exception)
            {
                string naslov = "Upozorenje";
                string poruka = "Provjerite internetsku vezu";
                PorukeStatus upozorenje = new PorukeStatus(naslov, poruka);
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda kojom dohvaćamo detalje za određenu narudžbu iz DB,
        /// rezultat upita je izvor podataka za datagridview kontrolu. 
        /// </summary>
        /// <param name="id">ID narudžbe za koju se prikazuju detalji</param>
        private void PrikaziZaprimljeneNarudzbeDetalji(int id)
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB join vh in db.VelicinaHrane on h.IDvelicinaHrane equals vh.IDvelicinaHrane where n.IDnarudzba == id select new { h.IDhrana, Hrana = h.Naziv, CijenaHrane = h.Cijena }).ToList();
                    BindingSource bindingSourceZaprimljeneNarudzbeDetalji = new BindingSource();
                    bindingSourceZaprimljeneNarudzbeDetalji.DataSource = upit;
                    dgvZaprimljeneNarudzbeDetalji.DataSource = bindingSourceZaprimljeneNarudzbeDetalji;

                }
            }
            catch (Exception)
            {
                string naslov = "Upozorenje";
                string poruka = "Provjerite internetsku vezu";
                PorukeStatus upozorenje = new PorukeStatus(naslov, poruka);
                upozorenje.ShowDialog();
            }

 
        }

        /// <summary>
        /// Metoda koja klikom na gumb instancira formu za promjenu statusa odabrane narudžbe.
        /// </summary>
        private void btnPromijenaStatusa_Click(object sender, EventArgs e)
        {
            if (Provjera)
            {
                PromjenaStatusa promjenaStatusa = new PromjenaStatusa(IdNarudzbe);
                promjenaStatusa.Show();
            }
            else
            {
                string naslov = "Upozorenje";
                string poruka = "Morate odabrati narudžbu";
                PorukeStatus upozorenje = new PorukeStatus(naslov, poruka);
                upozorenje.ShowDialog();
            }
            
        }
        /// <summary>
        /// Na događaj CellClick datagridview kontrole pohranjujemo u varijablu, ID narudžbe koja 
        /// se nalazi u onom redu gdje se kliknulo.Zatim se poziva metoda PrikaziZaprimljeneNArudzbeDetalji kojoj
        /// kao parametar stavimo ID odabrane narudžbe.
        /// </summary>
        private void dgvZaprimljeneNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgvZaprimljeneNarudzbe.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
                IdNarudzbe = int.Parse(dgvZaprimljeneNarudzbe.SelectedCells[0].Value.ToString());
                PrikaziZaprimljeneNarudzbeDetalji(IdNarudzbe);
                Provjera = true;
            }
        }

        /// <summary>
        /// Metoda koja klikom na sliku instancira prethodnu formu,te
        /// zatvara postojeću.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlavnaFormaDjelatnik glavnaFormaDjelatnik = new GlavnaFormaDjelatnik();
            glavnaFormaDjelatnik.Show();
            this.Close();
        }

        /// <summary>
        /// Metoda koja klikom na sliku minimizira trenutnu formu.
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Metoda koja klikom na sliku zatvara trenutnu formu.
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point mouse_offset;

        /// <summary>
        /// Metoda pomoću koje saznajemo kordinate kursora miša kad je on pritisnut.
        /// </summary>
        private void ZaprimljeneNarudzbe_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void ZaprimljeneNarudzbe_MouseMove(object sender, MouseEventArgs e)
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
