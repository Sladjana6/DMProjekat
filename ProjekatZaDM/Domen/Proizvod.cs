using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Proizvod:OpstiDomenskiObjekat
    {
        int proizvodID;
        string nazivProizvoda;
        double cena;
        string jedinicaMere;
        PoreskaStopa poreskaStopa;
        Dobavljac dobavljac;

        public override string ToString()
        {
            return nazivProizvoda;
        }

        public string imeTabele => "Proizvod";

        public string nazivPrimarnog => "ProizvodID";

        public string vrednostPrimarnog => "ProizvodID = " + proizvodID;

        public string vrednostSpoljnog => "DobavljacID = " + dobavljac.DobavljacID;

        public string vrednostAtributaIzTabele => null;

        public string upisivanje => null;

        public string azuriranje => null;

        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        public string NazivProizvoda { get => nazivProizvoda; set => nazivProizvoda = value; }
        public double Cena { get => cena; set => cena = value; }
        public string JedinicaMere { get => jedinicaMere; set => jedinicaMere = value; }
        public PoreskaStopa PoreskaStopa { get => poreskaStopa; set => poreskaStopa = value; }
        public Dobavljac Dobavljac { get => dobavljac; set => dobavljac = value; }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Proizvod p = new Proizvod();

            p.proizvodID = Convert.ToInt32(red[0]);
            p.NazivProizvoda = Convert.ToString(red[1]);
            p.cena = Convert.ToDouble(red[2]);
            p.jedinicaMere = Convert.ToString(red[3]);

            p.poreskaStopa = new PoreskaStopa();
            p.poreskaStopa.PoreskaStopaID = Convert.ToInt32(red[4]);

            p.dobavljac = new Dobavljac();
            p.dobavljac.DobavljacID = Convert.ToInt32(red[5]);

            return p;
        }
    }
}
