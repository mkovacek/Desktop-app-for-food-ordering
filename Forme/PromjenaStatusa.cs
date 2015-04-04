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
    public partial class PromjenaStatusa : Form
    {
        int idNarudzbe;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="id">ID narudžbe</param>
        public PromjenaStatusa(int id)
        {
            InitializeComponent();
            idNarudzbe = id;
        }

        /// <summary>
        /// Metoda kojom provjeravamo iz DB koje status određena narudžba sadrži i
        /// reultat upita prikazujemo ili ne prikazujemo radio button kontrole
        /// </summary>
        public void PrikaziStatuse()
        {
            try
            {
                using (var db = new T34_DBEntities6())
                {

                    var upit = (from n in db.Narudzba join ns in db.NarudzbaStatus on n.IDnarudzba equals ns.IDnarudzba join s in db.Status on ns.IDstatus equals s.IDstatus where n.IDnarudzba == idNarudzbe select s.IDstatus).ToList();
                    foreach (var status in upit)
                    {
                        if (status == 1)
                        {
                            rdbNarudzbaZaprimljena.Visible = false;
                        }
                        else if (status == 2)
                        {
                            rdbNarudzbaNaRedu.Visible = false;
                        }
                        else if (status == 3)
                        {
                            rdbNarudzbaGotova.Visible = false;
                        }
                        else if (status == 4)
                        {
                            rdbDostavljaSe.Visible = false;
                        }
                        else if (status == 5)
                        {
                            rdbDostavljena.Visible = false;
                            lblNarudzbaDOstavljena.Visible = true;
                            btnPromijeniStatus.Visible = false;
                        }
                    }
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
        /// Metoda pomoću koje se provjerava koji radio button je odabran i
        /// na temelju toga se u BP pohranjuje odgovarajući status narudžbe.
        /// U slučaju da je odabran zadnji status, "narudžba je dostavljena"
        /// ažurira se narudžba, odnosno mijenja joj se status u završeno
        /// kako se kasnije djelatniku ta narudžba nebi prikazivala.
        /// </summary>
        public void PromijeniStatus()
        {
            try
            {
                using (var db = new T34_DBEntities6())
                {
                    if (rdbNarudzbaZaprimljena.Checked == true)
                    {
                        NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                        {
                            IDnarudzba = idNarudzbe,
                            IDstatus = 1,
                            VrijemeKreiranjaStatusa = DateTime.Now
                        };
                        db.NarudzbaStatus.Add(narudzbaStatus);
                        db.SaveChanges();

                    }
                    else if (rdbNarudzbaNaRedu.Checked == true)
                    {
                        NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                        {
                            IDnarudzba = idNarudzbe,
                            IDstatus = 2,
                            VrijemeKreiranjaStatusa = DateTime.Now
                        };
                        db.NarudzbaStatus.Add(narudzbaStatus);
                        db.SaveChanges();
                    }
                    else if (rdbNarudzbaGotova.Checked == true)
                    {
                        NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                        {
                            IDnarudzba = idNarudzbe,
                            IDstatus = 3,
                            VrijemeKreiranjaStatusa = DateTime.Now
                        };
                        db.NarudzbaStatus.Add(narudzbaStatus);
                        db.SaveChanges();
                    }
                    else if (rdbDostavljaSe.Checked == true)
                    {
                        NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                        {
                            IDnarudzba = idNarudzbe,
                            IDstatus = 4,
                            VrijemeKreiranjaStatusa = DateTime.Now
                        };
                        db.NarudzbaStatus.Add(narudzbaStatus);
                        db.SaveChanges();
                    }
                    else if (rdbDostavljena.Checked == true)
                    {
                        NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                        {
                            IDnarudzba = idNarudzbe,
                            IDstatus = 5,
                            VrijemeKreiranjaStatusa = DateTime.Now
                        };
                        db.NarudzbaStatus.Add(narudzbaStatus);
                        db.SaveChanges();

                        Narudzba narudzba;
                        using (var dbS = new T34_DBEntities6())
                        {
                            narudzba = dbS.Narudzba.Where(n => n.IDnarudzba == idNarudzbe).FirstOrDefault<Narudzba>();
                        }
                        if (narudzba != null)
                        {
                            narudzba.Zavrseno = 1;
                        }
                        using (var dbU = new T34_DBEntities6())
                        {

                            dbU.Entry(narudzba).State = System.Data.Entity.EntityState.Modified;
                            dbU.SaveChanges();
                        }

                    }
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
        /// Na događaj load forme poziva se metoda PrikaziStatuse()
        /// </summary>
        private void PromjenaStatusa_Load(object sender, EventArgs e)
        {
            PrikaziStatuse();
        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva metodu PromijeniStatus, te se
        /// trenutna forma zatvara.
        /// </summary>

        private void btnPromijeniStatus_Click(object sender, EventArgs e)
        {
            PromijeniStatus();
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
        private void PromjenaStatusa_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void PromjenaStatusa_MouseMove(object sender, MouseEventArgs e)
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
