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
    public partial class PonudaJelovnika : Form
    {

        private int idHrane;
        private Int64 oibKorisnika;
        private int idNarudzbe;
        private List<int> idHrana = new List<int>();

        public List<int> IdHrana { get { return idHrana; } set { idHrana = value; } }
        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika = value; } }
        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }
        public int IdHrane { get { return idHrane; } set { idHrane = value; } }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="oib">OIB(id) korisnika koji je prijavljen.</param>
        public PonudaJelovnika(Int64 oib)
        {
            InitializeComponent();
            OibKorisnika = oib;
        }

        /// <summary>
        /// Metoda kojom dohvaćamo svu ponudu hrane iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void PonudaHrane()
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from h in db.Hrana join v in db.VelicinaHrane on h.IDvelicinaHrane equals v.IDvelicinaHrane select new { h.IDhrana, h.Naziv, h.Cijena, v.Opis }).ToList();

                    BindingSource bindingSourcePonudaJelovnika = new BindingSource();
                    bindingSourcePonudaJelovnika.DataSource = upit;
                    dgvPonudaJelovnika.DataSource = bindingSourcePonudaJelovnika;
                    dgvPonudaJelovnika.Columns[0].HeaderText = "R.broj";
                }
            }
            catch (Exception)
            {
                string poruka = "Provjerite internetsku vezu";
                string naslov = "Obavijest";
                PorukePonuda upozorenje = new PorukePonuda(naslov, poruka);
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Na događaj load forme poziva se metoda ponudaHrane()
        /// </summary>
        private void PonudaJelovnika_Load(object sender, EventArgs e)
        {
            PonudaHrane();
        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve komentare za određenu hranu iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        /// <param name="id">ID hrane za koju se prikazuju komentari</param>
        private void PrikaziKomentare(int id)
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from k in db.komentariHrana join h in db.Hrana on k.hranaID equals h.IDhrana where h.IDhrana == id select new { Komentar = k.komentarHrana }).ToList();
                    BindingSource bindingSourceKomentari = new BindingSource();
                    bindingSourceKomentari.DataSource = upit;
                    dgvKomentari.DataSource = bindingSourceKomentari;
                }
            }
            catch (Exception)
            {
                string poruka = "Provjerite internetsku vezu";
                string naslov = "Obavijest";
                PorukePonuda upozorenje = new PorukePonuda(naslov, poruka);
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve sastojke za određenu hranu iz DB i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        /// <param name="id">ID hrane za koju se prikazuju sastojci</param>
        private void PrikaziSastojke(int id)
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from s in db.Sastojci join hs in db.HranaSastojci on s.IDsastojci equals hs.IDsastojci join h in db.Hrana on hs.IDhrana equals h.IDhrana where hs.IDhrana == id select new { s.Naziv }).ToList();
                    BindingSource bindingSourceSastojci = new BindingSource();
                    bindingSourceSastojci.DataSource = upit;
                    dgvSastojci.DataSource = bindingSourceSastojci;
                    dgvSastojci.Columns[0].HeaderText = "Naziv sastojka";
                }
            }
            catch (Exception)
            {
                string poruka = "Provjerite internetsku vezu";
                string naslov = "Obavijest";
                PorukePonuda upozorenje = new PorukePonuda(naslov, poruka);
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Na događaj RowHeaderMouseClick datagridview kontrole pohranjujemo u listu
        /// vrijednost 1. čelije (ID hrane) koju ćemo naručiti.
        /// </summary>
        private void dgvPonudaJelovnika_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selektiraniRed = dgvPonudaJelovnika.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selektiraniRed > 0)
            {
                IdHrana.Add(int.Parse(dgvPonudaJelovnika.SelectedCells[0].Value.ToString()));
            }
        } 

        /// <summary>
        /// Na događaj CellClick datagridview kontrole pohranjujemo u varijablu, ID hrane koja 
        /// se nalazi u onom redu gdje se kliknulo i pozivamo metode za prikaz komentara i sastojaka za 
        /// za određenu hranu (ID hrane)
        /// </summary>
        private void dgvPonudaJelovnika_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgvPonudaJelovnika.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selektiraniRed > 0)
            {
                IdHrane = int.Parse(dgvPonudaJelovnika.SelectedCells[0].Value.ToString());
                PrikaziKomentare(IdHrane);
                PrikaziSastojke(IdHrane);
            }
        }

        /// <summary>
        /// Metoda pomoću koje pohranjujemo u DB svu hranu koju je korisnik odabrao.
        /// </summary>
        private void PohraniNarudzbu()
        {

            if (IdHrana.Count > 0)
            {
                try
                {
                    //pohranjujemo narudžbu
                    using (var db = new T34_DBEntities6())
                    {
                        DateTime vrijemeNarudzbe = DateTime.Now;

                        Narudzba narudzba = new Narudzba
                        {
                            DatumVrijemeZaprimanja = vrijemeNarudzbe,
                            IDnarucitelj = oibKorisnika
                        };
                        db.Narudzba.Add(narudzba);
                        db.SaveChanges();


                        //dohvaćamo ID te narudžbe
                        var upitID = (from n in db.Narudzba where n.IDnarucitelj == OibKorisnika select n).OrderByDescending(n => n.DatumVrijemeZaprimanja).FirstOrDefault();
                        IdNarudzbe = upitID.IDnarudzba;


                        //pohranjujem naručenu hranu za tu narudžbu

                        foreach (var item in IdHrana)
                        {
                            NarudzbaHrana narudzbaHrana = new NarudzbaHrana
                            {
                                IDnarudzba = IdNarudzbe,
                                IDhrana = item
                            };
                            db.NarudzbaHrana.Add(narudzbaHrana);
                            db.SaveChanges();
                        }
                    }
                    string poruka = "Uspješno ste naručili hranu";
                    string naslov = "Obavijest";
                    PorukePonuda upozorenje = new PorukePonuda(naslov, poruka);
                    upozorenje.ShowDialog();
                }
                catch (Exception)
                {
                    string poruka = "Provjerite internetsku vezu";
                    string naslov = "Obavijest";
                    PorukePonuda upozorenje = new PorukePonuda(naslov, poruka);
                    upozorenje.ShowDialog();
                }  
            }
            else
            {
                string poruka2 = "Morate odabrati hranu";
                string naslov2 = "Upozorenje";
                PorukePonuda upozorenje2 = new PorukePonuda(naslov2, poruka2);
                upozorenje2.ShowDialog();
                
            }
           
        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva metodu PohraniNarudzbu()
        /// </summary>
        private void btnNaruci_Click(object sender, EventArgs e)
        {
            PohraniNarudzbu();
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
        private void PonudaJelovnika_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void PonudaJelovnika_MouseMove(object sender, MouseEventArgs e)
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
