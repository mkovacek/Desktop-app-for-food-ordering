using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace eNarudžba.Forme
{
    public partial class RegistracijaForma : Form
    {
        private bool validacija = false;
        private bool provjeraIme = false;
        private bool provjeraPrezime = false;
        private bool provjeraOIB = false;
        private bool provjeraKorIme = false;
        private bool provjeraLozinka = false;
        private bool provjeraPotLozinke = false;
        private bool provjeraEmail = false;
        private bool provjeraAdresa = false;

        PocetnaForma pocetna;

        public bool Validacija { get { return validacija; } set { validacija = value; } }
        public bool ProvjeraIme { get { return  provjeraIme; } set { provjeraIme = value; } }
        public bool ProvjeraPrezime { get { return provjeraPrezime; } set { provjeraPrezime = value; } }
        public bool ProvjeraOIB { get { return provjeraOIB; } set { provjeraOIB = value; } }
        public bool ProvjeraKorIme { get { return provjeraKorIme; } set { provjeraKorIme = value; } }
        public bool ProvjeraLozinka { get { return provjeraLozinka; } set { provjeraLozinka = value; } }
        public bool ProvjeraPotLozinke { get { return provjeraPotLozinke; } set { provjeraPotLozinke = value; } }
        public bool ProvjeraEmail { get { return provjeraEmail; } set { provjeraEmail = value; } }
        public bool ProvjeraAdresa { get { return provjeraAdresa; } set { provjeraAdresa = value; } }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="forma">Prethodna forma tj. početna forma aplikacije</param>
        public RegistracijaForma(PocetnaForma forma)
        {
            InitializeComponent();
            pocetna = forma;
        }

        /// <summary>
        /// Metoda koja u slučaju ispravno unesenih svih podataka pohranjuje naručitelja u DB,
        /// odnosno registrira ga.
        /// </summary>
        private void Registracija() 
        {
            bool radbtn=false;
            if (txtBoxIme.Text.Length > 0 && txtBoxPrezime.Text.Length > 0 && txtBoxOIB.Text.Length>0 && txtBoxRegKorIme.Text.Length > 0 && txtBoxRegLozinka.Text.Length > 0 && txtBoxPotvrdaLozinke.Text.Length > 0 && txtBoxEmail.Text.Length > 0 && txtBoxAdresa.Text.Length > 0 && (radioBtnDa.Checked || radioBtnNe.Checked) && ProvjeraIme && ProvjeraPrezime && ProvjeraOIB && ProvjeraKorIme && ProvjeraLozinka && ProvjeraPotLozinke && ProvjeraEmail && ProvjeraAdresa )
            {  

                if(radioBtnDa.Checked)  
                {
                    radbtn = true;
                }

                try
                {
                    using (var db = new T34_DBEntities6())
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            Ime = txtBoxIme.Text,
                            Prezime = txtBoxPrezime.Text,
                            OIB = Int64.Parse(txtBoxOIB.Text),
                            Username = txtBoxRegKorIme.Text,
                            Lozinka = txtBoxRegLozinka.Text,
                            Email = txtBoxEmail.Text,
                            Adresa = txtBoxAdresa.Text,
                            Student = radbtn,
                            TipKorisnika = 2
                        };
                        db.Korisnik.Add(korisnik);
                        db.SaveChanges();
                    }

                    Validacija = true;
                    string naslov = "Obavijest";
                    string poruka = "Uspješno ste se registrirali";
                    PorukeRegistracija poruke = new PorukeRegistracija(naslov, poruka);
                    poruke.ShowDialog();
                    this.Close();
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
                Validacija = false;
                string naslov2 = "Upozorenje";
                string poruka2 = "Niste unijeli podatke za registraciju ili krivi podaci";
                PorukeRegistracija poruke2 = new PorukeRegistracija(naslov2, poruka2);
                poruke2.ShowDialog();
            }
        }

        /// <summary>
        /// Metoda koja klikom na gumb poziva metodu Registracija
        /// </summary>
        private void btnRegRegistracija_Click(object sender, EventArgs e)
        {
            Registracija();
        }

        /// <summary>
        /// Metoda kojom pomoću regularnih izraza provjeravamo 
        /// da li vrijednost varijable sadrži samo slova.
        /// </summary>
        /// <param name="tekst">varijabla koju provjeravamo (tekst txtboxa)</param>
        /// <returns>vraća false u slučaju kada sadržaj varijable neodgovara uzorku</returns>
        private bool SamoSlova(string tekst)
        {
            Regex samoSlova = new Regex("[^a-zA-ZćčšžĆČĐŠŽ]");
            return !samoSlova.IsMatch(tekst);
        }

        /// <summary>
        /// Metoda kojom pomoću regularnih izraza provjeravamo 
        /// ispravnost email adrese.
        /// </summary>
        /// <param name="email">varijabla koju provjeravamo (tekst txtboxa)</param>
        /// <returns>vraća false u slučaju kada sadržaj varijable neodgovara uzorku</returns>
        private bool Emailprovjera(string email)
        {
            Regex provEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return provEmail.IsMatch(email);
        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio svoje ime i
        /// dal sadrži samo slova.
        /// </summary>
        private void txtBoxIme_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeIme.Text = "";
            lblUpozorenjeIme.Visible = false;

            if (txtBoxIme.Text.Length == 0)
            {
                lblUpozorenjeIme.Text = "Niste unijeli ime.";
                lblUpozorenjeIme.Visible = true;
                ProvjeraIme = false;
            }
            else 
            {
                if (!SamoSlova(txtBoxIme.Text))
                {
                    lblUpozorenjeIme.Text = "Ime mora sadržavati samo slova.";
                    lblUpozorenjeIme.Visible = true;
                    ProvjeraIme = false;
                }
                else 
                {
                    ProvjeraIme = true;
                }
                
            } 

        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio svoje prezime i
        /// dal sadrži samo slova.
        /// </summary>
        private void txtBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjePrezime.Text = "";
            lblUpozorenjePrezime.Visible = false;

            if (txtBoxPrezime.Text.Length == 0)
            {
                lblUpozorenjePrezime.Text = "Niste unijeli prezime.";
                lblUpozorenjePrezime.Visible = true;
                ProvjeraPrezime = false;
            }
            else
            {
                if (!SamoSlova(txtBoxPrezime.Text))
                {
                    lblUpozorenjePrezime.Text = "Prezime mora sadržavati samo slova.";
                    lblUpozorenjePrezime.Visible = true;
                    ProvjeraPrezime = false;
                }
                else 
                {
                    ProvjeraPrezime = true;
                }
                
            }
                
        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio svoj OIB i 
        /// dal sadrži 11 znamenki. Te ako su prethodne provjere u redu, provjerava se
        /// dal ne postoji naručitelj s unesenim OIB-om u BP.
        /// </summary>
        private void txtBoxOIB_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeOib.Text = "";
            lblUpozorenjeOib.Visible = false;


            if (txtBoxOIB.Text.Length == 0)
            {
                lblUpozorenjeOib.Text = "Niste unijeli OIB.";
                lblUpozorenjeOib.Visible = true;
                ProvjeraOIB = false;
            }
            else
            {
                Int64 number;
                bool result = Int64.TryParse(txtBoxOIB.Text, out number);

                if (!result)
                {
                    lblUpozorenjeOib.Text = "OIB sadrži samo znamenke.";
                    lblUpozorenjeOib.Visible = true;
                    ProvjeraOIB = false;
                }
                else if (txtBoxOIB.Text.Length != 11)
                {
                    lblUpozorenjeOib.Text = "OIB sadrži 11 znamenki.";
                    lblUpozorenjeOib.Visible = true;
                    ProvjeraOIB = false;
                }
                else
                {
                    try
                    {
                        using (var db = new T34_DBEntities6())
                        {
                            Int64 provjeraOib = Int64.Parse(txtBoxOIB.Text);
                            var upitOIB = (from k in db.Korisnik where k.OIB == provjeraOib select k).FirstOrDefault<Korisnik>();

                            if (upitOIB != null)
                            {
                                lblUpozorenjeOib.Text = "OIB je već registriran.";
                                lblUpozorenjeOib.Visible = true;
                                ProvjeraOIB = false;
                            }
                            else
                            {
                                ProvjeraOIB = true;
                            }

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
                
            }
 
          }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio korisničko ime koje
        /// mora sadržavati samo slova.Ukoliko je prethodni uvjet ispunjen provjerava se zauzetost
        /// korisničkog imena.
        /// </summary>
        private void txtBoxRegKorIme_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeKorIme.Text = "";
            lblUpozorenjeKorIme.Visible = false;

            if (txtBoxRegKorIme.Text.Length == 0)
            {
                lblUpozorenjeKorIme.Text = "Niste unijeli korisničko ime.";
                lblUpozorenjeKorIme.Visible = true;
                ProvjeraKorIme = false;
            }
            else 
            {
                if (!SamoSlova(txtBoxRegKorIme.Text))
                {
                    lblUpozorenjeKorIme.Text = "Korisničko ime mora sadržavati samo slova.";
                    lblUpozorenjeKorIme.Visible = true;
                    ProvjeraKorIme = false;
                }
                else
                {
                    try
                    {
                        using (var db = new T34_DBEntities6())
                        {

                            var upitKorIme = (from k in db.Korisnik where k.Username == txtBoxRegKorIme.Text select k).FirstOrDefault<Korisnik>();
                            if (upitKorIme != null)
                            {
                                lblUpozorenjeKorIme.Text = "Korisničko ime je zauzeto.";
                                lblUpozorenjeKorIme.Visible = true;
                                ProvjeraKorIme = false;
                            }
                            else
                            {
                                ProvjeraKorIme = true;
                            }

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
            }           
        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio lozinku i
        /// dal se sastoji od minimalno 6 znakova.
        /// </summary>
        private void txtBoxRegLozinka_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeLozinka.Text = "";
            lblUpozorenjeLozinka.Visible = false;

            if (txtBoxRegLozinka.Text.Length == 0)
            {
                lblUpozorenjeLozinka.Text = "Niste unijeli lozinku.";
                lblUpozorenjeLozinka.Visible = true;
                ProvjeraLozinka = false;
            }
            else 
            {
                if (txtBoxRegLozinka.Text.Length < 6)
                {
                    lblUpozorenjeLozinka.Text = "Lozinka mora sadržavati minimalno 6 znakova.";
                    lblUpozorenjeLozinka.Visible = true;
                    ProvjeraLozinka = false;
                }
                else 
                {
                    ProvjeraLozinka = true;
                }              
            }      
        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio potvrdu lozinke i
        /// dali su lozinka i potvrda lozinke jednake.
        /// </summary>
        private void txtBoxPotvrdaLozinke_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeLozinka2.Text = "";
            lblUpozorenjeLozinka2.Visible = false;

            if (txtBoxPotvrdaLozinke.Text.Length == 0)
            {
                lblUpozorenjeLozinka2.Text = "Niste unijeli lozinku.";
                lblUpozorenjeLozinka2.Visible = true;
                ProvjeraPotLozinke = false;
            }
            else
            {
                if (txtBoxRegLozinka.Text != txtBoxPotvrdaLozinke.Text)
                {
                    lblUpozorenjeLozinka2.Text = "Lozinke nisu jednake.";
                    lblUpozorenjeLozinka2.Visible = true;
                    ProvjeraPotLozinke = false;
                }
                else
                {
                    ProvjeraPotLozinke = true;
                }             
            }
        }

        /// <summary>
        /// Na događaj textChanged metoda provjera dal je naručitelj unio email adresu,
        /// provjerava se ispravnost unesene email adrese, te na kraju se provjerava dal je
        /// ta email adresa registrirana.
        /// </summary>
        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            lblUpozorenjeEmail.Text = "";
            lblUpozorenjeEmail.Visible = false;

            if (txtBoxEmail.Text.Length == 0)
            {
                lblUpozorenjeEmail.Text = "Niste unijeli e-mail adresu.";
                lblUpozorenjeEmail.Visible = true;
                ProvjeraEmail = false;
            }
            else
            {
                if (!Emailprovjera(txtBoxEmail.Text))
                {
                    lblUpozorenjeEmail.Text = "Krivo strukturirana e-mail adresa.";
                    lblUpozorenjeEmail.Visible = true;
                    ProvjeraEmail = false;
                }
                else
                {
                    try
                    {
                        using (var db = new T34_DBEntities6())
                        {

                            var upitEmail = (from k in db.Korisnik where k.Email == txtBoxEmail.Text select k).FirstOrDefault<Korisnik>();

                            if (upitEmail != null)
                            {
                                lblUpozorenjeEmail.Text = "E-mail je već registriran.";
                                lblUpozorenjeEmail.Visible = true;
                                ProvjeraEmail = false;
                            }
                            else
                            {
                                ProvjeraEmail = true;
                            }

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
            }            
        }

        /// <summary>
        /// Na događaj Leave metoda provjera dal je naručitelj unio svoju adresu.
        /// </summary>
        private void txtBoxAdresa_Leave(object sender, EventArgs e)
        {
            lblUpozorenjeAdresa.Text = "";
            lblUpozorenjeAdresa.Visible = false;

            if (txtBoxAdresa.Text.Length == 0)
            {
                lblUpozorenjeAdresa.Text = "Niste unijeli adresu.";
                lblUpozorenjeAdresa.Visible = true;
                ProvjeraAdresa = false;
            }
            else
            {
                ProvjeraAdresa = true;
            }
            
        }

        /// <summary>
        /// Metoda koja klikom na sliku prethodnu formu vraća iz minimiziranog stanja 
        /// u normalno stanje, te zatvara postojeću formu.
        /// </summary>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pocetna.WindowState = FormWindowState.Normal;
            this.Close();
        }

        /// <summary>
        /// Metoda koja klikom na sliku zatvara trenutnu formu.
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja klikom na sliku minimizira trenutnu formu.
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point mouse_offset;

        /// <summary>
        /// Metoda pomoću koje saznajemo kordinate kursora miša kad je on pritisnut.
        /// </summary>
        private void RegistracijaForma_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        /// <summary>
        /// Metoda pomoću koje mijenjamo kordinate trenutne forme.
        /// </summary>
        private void RegistracijaForma_MouseMove(object sender, MouseEventArgs e)
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
