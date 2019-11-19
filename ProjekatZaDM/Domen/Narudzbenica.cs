using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Domen
{
    [Serializable]
    public class Narudzbenica : OpstiDomenskiObjekat
    {
        int narudzbenicaID;
        DateTime datum;
        double ukupanIznosBezPDV;
        double ukupanPDV;
        double ukupanIznosSaPDV;
        BindingList<StavkaNarudzbenice> listaStavki;
        Zaposleni zaposleni;
        Dobavljac dobavljac;
        Status status;

        [Browsable(false)]
        public int NarudzbenicaID { get => narudzbenicaID; set => narudzbenicaID = value; }

        public DateTime Datum { get => datum; set => datum = value; }
        [DisplayName("Ukupan iznos bez PDV-a")]
        public double UkupanIznosBezPDV { get => ukupanIznosBezPDV; set => ukupanIznosBezPDV = value; }
        [DisplayName("Ukupan PDV")]
        public double UkupanPDV { get => ukupanPDV; set => ukupanPDV = value; }
        [DisplayName("Ukupan iznos sa PDV-om")]
        public double UkupanIznosSaPDV { get => ukupanIznosSaPDV; set => ukupanIznosSaPDV = value; }
        public BindingList<StavkaNarudzbenice> ListaStavki { get => listaStavki; set => listaStavki = value; }
        [Browsable(false)]
        public Zaposleni Zaposleni { get => zaposleni; set => zaposleni = value; }
        [Browsable(false)]
        public Dobavljac Dobavljac { get => dobavljac; set => dobavljac = value; }

        public Narudzbenica()
        {
            listaStavki = new BindingList<StavkaNarudzbenice>();
        }

        [Browsable(false)]
        public string imeTabele => "Narudzbenica";
        [Browsable(false)]
        public string nazivPrimarnog => "NarudzbenicaID";
        [Browsable(false)]
        public string vrednostPrimarnog => "NarudzbenicaID = " + narudzbenicaID;
        [Browsable(false)]
        public string vrednostSpoljnog => "DobavljacID = " + dobavljac.DobavljacID;
        [Browsable(false)]
        public string vrednostAtributaIzTabele => null;
        [Browsable(false)]
        public string upisivanje => " values ("+narudzbenicaID+", '"+datum.ToShortDateString()+"',"+ukupanIznosBezPDV+","+ukupanPDV+","+UkupanIznosSaPDV+","+zaposleni.ZaposleniID+","+dobavljac.DobavljacID+")";
        [Browsable(false)]
        public string azuriranje => "Datum = '" + datum.ToShortDateString() + "', UkupanIznosBezPDV = "+UkupanIznosBezPDV+", UkupanPDV = "+ukupanPDV+", UkupanIznosSaPDV = " +ukupanIznosSaPDV+", ZaposleniID = "+zaposleni.ZaposleniID+", DobavljacID = "+dobavljac.DobavljacID+"";
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Narudzbenica n = new Narudzbenica();
            n.narudzbenicaID = Convert.ToInt32(red[0]);
            n.datum = Convert.ToDateTime(red[1]);
            n.ukupanIznosBezPDV = Convert.ToDouble(red[2]);
            n.ukupanPDV = Convert.ToDouble(red[3]);
            n.UkupanIznosSaPDV = Convert.ToDouble(red[4]);

            n.zaposleni = new Zaposleni();
            n.zaposleni.ZaposleniID = Convert.ToInt32(red[5]);

            n.dobavljac = new Dobavljac();
            n.dobavljac.DobavljacID = Convert.ToInt32(red[6]);
            return n;
        }
    }
}
