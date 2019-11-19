using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
   public  interface OpstiDomenskiObjekat
    {
        string imeTabele { get; }

        string nazivPrimarnog { get; }

        string vrednostPrimarnog { get; }

        string vrednostSpoljnog { get; }

        string vrednostAtributaIzTabele { get; }

        string upisivanje { get; }

        string azuriranje { get; }

        OpstiDomenskiObjekat napuni(DataRow red);

    }
}
