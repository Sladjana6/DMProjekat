using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class PoreskaStopa : OpstiDomenskiObjekat
    {

        int poreskaStopaID;
        string oznaka;
        int iznos;

        public int PoreskaStopaID { get => poreskaStopaID; set => poreskaStopaID = value; }
        public string Oznaka { get => oznaka; set => oznaka = value; }
        public int Iznos { get => iznos; set => iznos = value; }

        public string imeTabele => "PoreskaStopa";

        public string nazivPrimarnog => "PoreskaStopaID";

        public string vrednostPrimarnog => "PoreskaStopaID = " + poreskaStopaID;

        public string vrednostSpoljnog => null;

        public string vrednostAtributaIzTabele => null;

        public string upisivanje => null;

        public string azuriranje => null;

        

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            PoreskaStopa ps = new PoreskaStopa();

            ps.poreskaStopaID = Convert.ToInt32(red[0]);
            ps.oznaka = Convert.ToString(red[1]);
            ps.iznos = Convert.ToInt32(red[2]);

            return ps;
        }
    }
}
