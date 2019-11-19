using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class ZapamtiDobavljaca : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            try
            {
                Dobavljac d = odo as Dobavljac;
                if (d.Status == Status.Ubaci)
                    return Broker.dajSesiju().sacuvaj(odo);
                else if (d.Status == Status.Izmeni)
                    return Broker.dajSesiju().izmeni(odo);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
