//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eNarudžba
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnik
    {
        public Korisnik()
        {
            this.Narudzba = new HashSet<Narudzba>();
        }
    
        public long OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public bool Student { get; set; }
        public int TipKorisnika { get; set; }
        public int status { get; set; }
    
        public virtual TipKorisnika TipKorisnika1 { get; set; }
        public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
