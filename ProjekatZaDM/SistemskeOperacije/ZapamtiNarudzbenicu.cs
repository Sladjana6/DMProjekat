using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class ZapamtiNarudzbenicu : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            try
            {
                Narudzbenica n = odo as Narudzbenica;

                if(n.Status == Status.Ubaci)
                {
                    Broker.dajSesiju().sacuvaj(odo);
                    foreach (StavkaNarudzbenice sn in n.ListaStavki)
                    {
                        sn.NarudzbenicaID = n.NarudzbenicaID;
                        Broker.dajSesiju().sacuvaj(sn);
                    }
                }

                //status je izmeni

                else
                {
                    Broker.dajSesiju().izmeni(odo);

                    StavkaNarudzbenice snn = new StavkaNarudzbenice();
                    snn.NarudzbenicaID = n.NarudzbenicaID;
                    Broker.dajSesiju().obrisiZaVrednostSpoljnog(snn);

                    foreach(StavkaNarudzbenice stavka in n.ListaStavki)
                    {
                        stavka.NarudzbenicaID = n.NarudzbenicaID;
                        Broker.dajSesiju().sacuvaj(stavka);
                    }
                }

              
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
