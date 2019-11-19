using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zaposleni : OpstiDomenskiObjekat
    {

        int zaposleniID;
        string ime;
        string prezime;
        string korisnickoIme;
        string korisnickaSifra;

        public override string ToString()
        {
            return ime + " " + prezime; 
        }

        public int ZaposleniID { get => zaposleniID; set => zaposleniID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string KorisnickaSifra { get => korisnickaSifra; set => korisnickaSifra = value; }


        public string imeTabele => "Zaposleni";

        public string nazivPrimarnog => "ZaposleniID";

        public string vrednostPrimarnog => " ZaposleniID = " + zaposleniID;

        public string vrednostSpoljnog => null;

        public string vrednostAtributaIzTabele => " KorisnickoIme = '" + korisnickoIme + "' and KorisnickaSifra = '" + korisnickaSifra + "'";

        public string upisivanje => null;

        public string azuriranje => null;

        

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Zaposleni z = new Zaposleni();
            z.zaposleniID = Convert.ToInt32(red[0]);
            z.ime = Convert.ToString(red[1]);
            z.prezime = Convert.ToString(red[2]);
            z.korisnickoIme = Convert.ToString(red[3]);
            z.korisnickaSifra = Convert.ToString(red[4]);

            return z;
        }
    }
}
