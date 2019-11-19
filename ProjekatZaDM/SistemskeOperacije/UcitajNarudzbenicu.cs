using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class UcitajNarudzbenicu : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Narudzbenica n = Broker.dajSesiju().vratiObjekatZaVrednostPrimarnog(odo) as Narudzbenica;

            Zaposleni z = new Zaposleni();
            z.ZaposleniID = n.Zaposleni.ZaposleniID;
            z = Broker.dajSesiju().vratiObjekatZaVrednostPrimarnog(z) as Zaposleni;
            n.Zaposleni = z;


            Dobavljac d = new Dobavljac();
            d.DobavljacID = n.Dobavljac.DobavljacID;
            d = Broker.dajSesiju().vratiObjekatZaVrednostPrimarnog(d) as Dobavljac;
            n.Dobavljac = d;

            StavkaNarudzbenice sn = new StavkaNarudzbenice();
            sn.NarudzbenicaID = n.NarudzbenicaID;
            List<StavkaNarudzbenice> listaStavki = Broker.dajSesiju().vratiSveObjekteZaVrednostSpoljnog(sn).OfType<StavkaNarudzbenice>().ToList<StavkaNarudzbenice>();


            foreach (StavkaNarudzbenice snn in listaStavki)
            {
                Proizvod p = new Proizvod();
                p.ProizvodID = snn.Proizvod.ProizvodID;
                p = Broker.dajSesiju().vratiObjekatZaVrednostPrimarnog(p) as Proizvod;
                snn.Proizvod = p;
                n.ListaStavki.Add(snn);
            }

            //foreach (StavkaNarudzbenice snn in listaStavki)
            //{
            //    n.ListaStavki.Add(snn);
            //}

           

            return n;
        }
    }
}
