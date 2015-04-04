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
    public partial class PrijavaForma : Form
    {
        private bool validacija=false;
        private int tipKorisnika;
        private Int64 oibKorisnika;
        PocetnaForma pocetna;

        public bool Validacija { get { return validacija; } set { validacija = value; } }

        public int TipKorisnika { get { return tipKorisnika; } set { tipKorisnika = value; } }

        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika = value; } }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="forma">Prethodna forma tj. početna forma aplikacije</param>
        public PrijavaForma(PocetnaForma forma)
        {
            InitializeComponent();
            pocetna = forma;
        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva metodu Prijava().
        /// </summary>
        private void btnPrijavaPrijava_Click(object sender, EventArgs e)
        {
            Prijava();
        }


        /// <summary>
        /// Metoda prijava služi za provjeru validnosti autentikacijskih podataka,
        /// za provjeru koristi metodu autentikacija
        /// </summary>
        public void Prijava ()
        {
            if (txtBoxKorisnickoIme.Text.Length > 0 && txtBoxLozinka.Text.Length > 0)
            {
                if (Autentikacija(txtBoxKorisnickoIme.Text, txtBoxLozinka.Text))
                {
                    Validacija = true;
                    if (TipKorisnika == 1)
                    {
                        GlavnaFormaDjelatnik glavnaFormaDjelatnik = new GlavnaFormaDjelatnik();
                        glavnaFormaDjelatnik.Show();
                        this.Close();
                    }
                    else
                    {
                        GlavnaFormaNarucitelj glavnaFormaNarucitelj = new GlavnaFormaNarucitelj(OibKorisnika);//makni this
                        glavnaFormaNarucitelj.Show();
                        this.Close();
                    }           
                }
                else 
                {
                    Validacija = false;
                    string poruka = "Pogrešno uneseni podaci ili nemate pravo pristupa";
                    poruke porukaUpozornja=new poruke(poruka);
                    porukaUpozornja.ShowDialog();                    
                }
            }
            else 
            {
                Validacija = false;
                string poruka2 = "Niste unijeli podatke za prijavu";
                poruke porukaUpozornja = new poruke(poruka2);
                porukaUpozornja.ShowDialog();
            }
        }

        /// <summary>
        /// Provjera ispravnosti korisničkih podataka potrebnih za uspješnu prijavu
        /// </summary>
        /// <param name="korIme">uneseno korisničko ime</param>
        /// <param name="password">unesena lozinka</param>
        /// <returns>True-kada su podaci pronadjeni u bazi (ispravni); False-kada podaci nisu pronadjeni u bazi (neispravni) </returns>
        private bool Autentikacija(string korIme, string password)
        {
            try
            {

                using (T34_DBEntities6 db = new T34_DBEntities6())
                {                                                             
                    var upit = (from k in db.Korisnik where k.Username == korIme && k.Lozinka == password select k).SingleOrDefault<Korisnik>();
                    OibKorisnika = upit.OIB;
                
                    if (upit.status == 0)
                    {
                        if (upit.Lozinka == password)
                        {
                            Validacija = true;
                            if (upit.TipKorisnika == 1)
                            {
                                TipKorisnika = 1;

                            }
                            else
                            {
                                TipKorisnika = 2;
                            }
                            return true;
                        }
                    }
                        

                }      
            }
            catch (Exception) 
            {
                Validacija = false;
                return false;
            }
            Validacija = false;
            return false;
        }

        /// <summary>
        /// Metoda koja klikom na link label instancira formu za registraciju, 
        /// te zatvara postojeću formu.
        /// </summary>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistracijaForma registracija = new RegistracijaForma(pocetna);
            registracija.Show();
            this.Close();

        }

        /// <summary>
        /// Metoda koja klikom na sliku prethodnu formu vraća iz minimiziranog stanja 
        /// u normalno stanje,te zatvara postojeću formu.
        /// </summary>
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pocetna.WindowState = FormWindowState.Normal;
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
        private void PrijavaForma_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void PrijavaForma_MouseMove(object sender, MouseEventArgs e)
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
