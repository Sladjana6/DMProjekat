using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domen
{
    public enum Status { Nista, Ubaci, Izmeni, Obrisi }
    [Serializable]
    public class StavkaNarudzbenice : OpstiDomenskiObjekat
    {

        int narudzbenicaID;
        int redniBroj;
        int kolicina;
        double iznosBezPDV;
        double PDV;
        double iznosSaPDV;
        Proizvod proizvod;
        Status status;
        string nazivProizvoda;

        [Browsable(false)]
        public int NarudzbenicaID { get => narudzbenicaID; set => narudzbenicaID = value; }
        [DisplayName("Redni broj")]
        public int RedniBroj { get => redniBroj; set => redniBroj = value; }
        [DisplayName("Naziv proizvoda")]
        public string NazivProizvoda { get => proizvod.NazivProizvoda; set => nazivProizvoda = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        [DisplayName("Iznos bez PDV-a")]
        public double IznosBezPDV { get => iznosBezPDV; set => iznosBezPDV = value; }
        [DisplayName("PDV")]
        public double PDV1 { get => PDV; set => PDV = value; }
        [DisplayName("Iznos sa PDV-om")]
        public double IznosSaPDV { get => iznosSaPDV; set => iznosSaPDV = value; }
        [Browsable(false)]
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }

        [Browsable(false)]
        public string imeTabele => "StavkaNarudzbenice";
        [Browsable(false)]
        public string nazivPrimarnog => null;
        [Browsable(false)]
        public string vrednostPrimarnog => "NarudzbenicaID = "+narudzbenicaID+" and RedniBroj = "+ redniBroj+"";
        [Browsable(false)]
        public string vrednostSpoljnog => "NarudzbenicaID = " + narudzbenicaID;
        [Browsable(false)]
        public string vrednostAtributaIzTabele => null;
        [Browsable(false)]
        public string upisivanje => " values ("+narudzbenicaID+"," +redniBroj+ "," +kolicina+ "," +iznosBezPDV+ "," +PDV+ "," +iznosSaPDV+ ", "+proizvod.ProizvodID+")";
        [Browsable(false)]
        public string azuriranje => "Kolicina = " + kolicina + ", IznosBezPDV = "+iznosBezPDV+", PDV = "+PDV+", IznosSaPDV = "+iznosSaPDV+", ProizvodID = "+proizvod.ProizvodID;
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }
        

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            StavkaNarudzbenice sn = new StavkaNarudzbenice();

            sn.narudzbenicaID = Convert.ToInt32(red[0]);
            sn.redniBroj = Convert.ToInt32(red[1]);
            sn.kolicina = Convert.ToInt32(red[2]);
            sn.iznosBezPDV = Convert.ToDouble(red[3]);
            sn.PDV = Convert.ToDouble(red[4]);
            sn.iznosSaPDV = Convert.ToDouble(red[5]);

            sn.Proizvod = new Proizvod();
            sn.proizvod.ProizvodID = Convert.ToInt32(red[6]);

            return sn;
        }
    }
}
