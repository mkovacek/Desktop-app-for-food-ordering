using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace eNarudžba.Forme
{
    public partial class UpravljanjeKorisnikom : Form
    {
        private Int64 idPasivni;
        private Int64 idAktivni;
        private bool provjeraP = false;
        private bool provjeraA = false;

        public Int64 IdPasivni { get { return idPasivni; } set { idPasivni = value; } }
        public Int64 IdAktivni { get { return idAktivni; } set { idAktivni = value; } }
        public bool ProvjeraA { get { return provjeraA; } set { provjeraA = value; } }
        public bool ProvjeraP { get { return provjeraP; } set { provjeraP = value; } }
        public UpravljanjeKorisnikom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Na događaj load forme poziva se metoda
        /// PrikaziPasivne() i PrikaziAktivne().
        /// </summary>
        private void UpravljanjeKorisnikom_Load(object sender, EventArgs e)
        {
            PrikaziPasivne();
            PrikaziAktivne();
        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve naručitelje iz DB koji su blokirani i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void PrikaziPasivne()
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from k in db.Korisnik where k.status == 1 && k.TipKorisnika == 2 select new { OIB = k.OIB, Ime = k.Ime, Prezime = k.Prezime, KorisnickoIme = k.Username }).ToList();
                    BindingSource bindingSourcePasivni = new BindingSource();
                    bindingSourcePasivni.DataSource = upit;
                    dgvPasivni.DataSource = bindingSourcePasivni;
                    dgvPasivni.Columns[3].HeaderText = "Korisničko ime";
                }
            }
            catch (Exception)
            {
                string naslov1 = "Upozorenje";
                string poruka1 = "Provjerite internetsku vezu";
                PorukeRegistracija poruke1 = new PorukeRegistracija(naslov1, poruka1);
                poruke1.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda kojom dohvaćamo sve naručitelje iz DB koji su nisu blokirani i
        /// rezultat upita je izvor podataka za datagridview kontrolu.
        /// </summary>
        private void PrikaziAktivne()
        {
            try
            {
                using (T34_DBEntities6 db = new T34_DBEntities6())
                {
                    var upit = (from k in db.Korisnik where k.status == 0 && k.TipKorisnika == 2 select new { OIB = k.OIB, Ime = k.Ime, Prezime = k.Prezime, KorisnickoIme = k.Username }).ToList();
                    BindingSource bindingSourceAktivni = new BindingSource();
                    bindingSourceAktivni.DataSource = upit;
                    dgvAktivni.DataSource = bindingSourceAktivni;
                    dgvAktivni.Columns[3].HeaderText = "Korisničko ime";
                }
            }
            catch (Exception)
            {
                string naslov1 = "Upozorenje";
                string poruka1 = "Provjerite internetsku vezu";
                PorukeRegistracija poruke1 = new PorukeRegistracija(naslov1, poruka1);
                poruke1.ShowDialog();
            }

        }

        /// <summary>
        /// Na događaj RowHeaderMouseClick datagridview kontrole pohranjujemo u varijablu, 
        /// ID blokiranog naručitelja.
        /// </summary>
        private void dgvPasivni_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selektiraniRed = dgvPasivni.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
                IdPasivni = Int64.Parse(dgvPasivni.SelectedCells[0].Value.ToString());
                ProvjeraP = true;
            }
        }

        /// <summary>
        /// Na događaj RowHeaderMouseClick datagridview kontrole pohranjujemo u varijablu, 
        /// ID ne blokiranog naručitelja.
        /// </summary>
        private void dgvAktivni_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selektiraniRed2 = dgvAktivni.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed2 > 0)
            {
                IdAktivni = Int64.Parse(dgvAktivni.SelectedCells[0].Value.ToString());
                ProvjeraA = true;
            }
        }

        /// <summary>
        /// Metoda kojom aktiviramo blokiranog naručitelja.
        /// Prije same aktivacije provjerava se da li je varijabla ProvjeraP true
        /// odsnosno da li je odabran naručitelj za aktivaciju.
        /// </summary>
        private void Aktiviraj()
        {
            if (ProvjeraP)
            {
                try
                {
                    Korisnik korisnik;
                    using (var dbSA = new T34_DBEntities6())
                    {
                        korisnik = dbSA.Korisnik.Where(k => k.OIB == IdPasivni).FirstOrDefault<Korisnik>();
                    }
                    if (korisnik != null)
                    {
                        korisnik.status = 0;
                    }
                    using (var dbUA = new T34_DBEntities6())
                    {

                        dbUA.Entry(korisnik).State = System.Data.Entity.EntityState.Modified;
                        dbUA.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    string naslov1 = "Upozorenje";
                    string poruka1 = "Provjerite internetsku vezu";
                    PorukeRegistracija poruke1 = new PorukeRegistracija(naslov1, poruka1);
                    poruke1.ShowDialog();
                }

            }
            else
            {
                PorukeUpravljanje upozorenje = new PorukeUpravljanje();
                upozorenje.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva load događaj forme UpravljanjeKorisnikom
        /// </summary>
        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            Aktiviraj();
            UpravljanjeKorisnikom_Load(this,null);
        }

        /// <summary>
        /// Metoda kojom blokiramo/deaktiviramo aktivnog naručitelja.
        /// Prije same deaktivacije provjerava se da li je varijabla ProvjeraA true
        /// odsnosno da li je odabran naručitelj za blokiranje.
        /// </summary>
        private void Deaktiviraj() 
        {
            if (ProvjeraA)
            {
                try
                {
                    Korisnik korisnik2;
                    using (var dbSD = new T34_DBEntities6())
                    {
                        korisnik2 = dbSD.Korisnik.Where(k => k.OIB == IdAktivni).FirstOrDefault<Korisnik>();
                    }
                    if (korisnik2 != null)
                    {
                        korisnik2.status = 1;
                    }
                    using (var dbUD = new T34_DBEntities6())
                    {

                        dbUD.Entry(korisnik2).State = System.Data.Entity.EntityState.Modified;
                        dbUD.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    string naslov1 = "Upozorenje";
                    string poruka1 = "Provjerite internetsku vezu";
                    PorukeRegistracija poruke1 = new PorukeRegistracija(naslov1, poruka1);
                    poruke1.ShowDialog();
                }
                
            }
            else
            {
                PorukeUpravljanje upozorenje2 = new PorukeUpravljanje();
                upozorenje2.ShowDialog();
            }

        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva load događaj forme UpravljanjeKorisnikom
        /// </summary>
        private void btnBlokiraj_Click(object sender, EventArgs e)
        {
            Deaktiviraj();
            UpravljanjeKorisnikom_Load(this, null);
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
        private void UpravljanjeKorisnikom_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void UpravljanjeKorisnikom_MouseMove(object sender, MouseEventArgs e)
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
