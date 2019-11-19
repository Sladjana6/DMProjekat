using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace SistemskeOperacije
{
    public class PronadjiDobavljace : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiSveObjekteZaVrednostAtributaIzTabele(odo).OfType<Dobavljac>().ToList<Dobavljac>();
        }
    }
}
