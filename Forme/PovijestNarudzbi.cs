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
    

    public partial class PovijestNarudzbi : Form
    {

        private Int64 oibKorisnika;
        private int idNarudzbe;
        private int idHrane;
        private bool provjera=false;

        public bool Provjera { get { return provjera; } set { provjera = value; } }

        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika= value; } }

        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }

        public int IdHrane { get { return idHrane; } set { idHrane = value; } }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="oib">OIB(id) korisnika koji je prijavljen.</param>
        public PovijestNarudzbi(Int64 oib)
        {
            InitializeComponent();
            OibKorisnika = oib;
        }

        /// <summary>
        /// Na događaj load forme poziva se metoda
        /// PrikaziPovijestNarudzbi()
        /// </summary>
        private void PovijestNarudzbi_Load(object sender, EventArgs e)
        {
            PrikaziPovijestNarudzbi();
        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve narudžbe prijavljenog korisnika iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void PrikaziPovijestNarudzbi()
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana where n.IDnarucitelj == OibKorisnika group new { n, nh, h } by new { n.IDnarudzba, n.DatumVrijemeZaprimanja } into grup select new { grup.Key.IDnarudzba, grup.Key.DatumVrijemeZaprimanja, Cijena = grup.Sum(h => h.h.Cijena) }).OrderByDescending(n => n.IDnarudzba).ToList();

                    BindingSource bindingSourcePovijestNarudzbi = new BindingSource();
                    bindingSourcePovijestNarudzbi.DataSource = upit;
                    dgwPovijestNarudzbi.DataSource = bindingSourcePovijestNarudzbi;
                    dgwPovijestNarudzbi.Columns[0].HeaderText = "Br. narudžbe";
                    dgwPovijestNarudzbi.Columns[1].HeaderText = "Datum i vrijeme naručivanja";
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
        /// Metoda kojom dohvaćamo sve detalje određene narudžbe iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        /// <param name="id">ID narudžbe za koju se prikazuju detalji</param>
        private void PrikaziDetaljeNarudzbe(int id) 
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB join vh in db.VelicinaHrane on h.IDvelicinaHrane equals vh.IDvelicinaHrane where n.IDnarudzba == id select new { h.IDhrana, h.Naziv, vh.Opis, h.Cijena }).ToList();
                    BindingSource bindingSourceDetalji = new BindingSource();
                    bindingSourceDetalji.DataSource = upit;
                    dgwPovijestNarudzbiDetalji.DataSource = bindingSourceDetalji;
                    dgwPovijestNarudzbiDetalji.Columns[0].HeaderText = "Br. hrane";
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
        /// Metoda kojom klikom na gumb otvaramo formu PracenjeStanja, kojoj prilikom instanciranja
        /// prosljeđujemo ID narudžbe.
        /// </summary>
        private void btnPracenjeStanjaNarudzbe_Click(object sender, EventArgs e)
        {
            PracenjeStanja pracenjeStanja = new PracenjeStanja(IdNarudzbe);
            pracenjeStanja.Show();
        }

        /// <summary>
        /// Metoda kojom klikom na gumb otvaramo formu KomentiranjeHrane, kojoj prilikom instanciranja
        /// prosljeđujemo ID hrane.
        /// </summary>
        private void btnKomentiranje_Click(object sender, EventArgs e)
        {
            if (Provjera)
            {
                KomentiranjeHrane komentiranjeHrane = new KomentiranjeHrane(IdHrane);
                komentiranjeHrane.Show();
            }
            else
            {
                string naslov = "Upozorenje";
                string poruka = "Morate odabrati hranu";
                PorukeKomentiranje upozorenje = new PorukeKomentiranje(naslov, poruka);
                upozorenje.ShowDialog();
            }
            
        }


        /// <summary>
        /// Na događaj CellClick datagridview kontrole pohranjujemo u varijablu, ID narudžbe koja 
        /// se nalazi u onom redu gdje se kliknulo i pozivamo metode za prikaz detalja narudžbe za
        /// određeni ID narudžbe.
        /// </summary>
        private void dgwPovijestNarudzbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgwPovijestNarudzbi.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
                IdNarudzbe = int.Parse(dgwPovijestNarudzbi.SelectedCells[0].Value.ToString());
                PrikaziDetaljeNarudzbe(IdNarudzbe);
            }

        }

        /// <summary>
        /// Na događaj CellClick datagridview kontrole pohranjujemo u varijablu, ID hrane koja 
        /// se nalazi u onom redu gdje se kliknulo. ID hrane nam je kasnije potreban za komentiranje hrane.
        /// </summary>
        private void dgwPovijestNarudzbiDetalji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed2 = dgwPovijestNarudzbiDetalji.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed2 > 0)
            {
                IdHrane = int.Parse(dgwPovijestNarudzbiDetalji.SelectedCells[0].Value.ToString());
                Provjera = true;
            }
            
        }

        /// <summary>
        /// Metoda koja klikom na sliku instancira prethodnu formu,te
        /// zatvara postojeću.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlavnaFormaNarucitelj glavnaFormaNarucitelj = new GlavnaFormaNarucitelj(OibKorisnika);
            glavnaFormaNarucitelj.Show();
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
        private void PovijestNarudzbi_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void PovijestNarudzbi_MouseMove(object sender, MouseEventArgs e)
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
