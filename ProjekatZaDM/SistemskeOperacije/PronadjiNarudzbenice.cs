using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class PronadjiNarudzbenice : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Broker.dajSesiju().vratiSveObjekteZaVrednostSpoljnog(odo).OfType<Narudzbenica>().ToList<Narudzbenica>();
        }
    }
}
