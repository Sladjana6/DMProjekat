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
    public class Dobavljac : OpstiDomenskiObjekat
    {

        int dobavljacID;
        string nazivDobavljaca;
        string telefon;
        string email;
        string adresa;
        Status status;

        [Browsable(false)]
        public int DobavljacID { get => dobavljacID; set => dobavljacID = value; }
        [DisplayName("Naziv dobavljaca")]
        public string NazivDobavljaca { get => nazivDobavljaca; set => nazivDobavljaca = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            return nazivDobavljaca;
        }



        [Browsable(false)]
        public string imeTabele => "Dobavljac";
        [Browsable(false)]
        public string nazivPrimarnog => "DobavljacID";
        [Browsable(false)]
        public string vrednostPrimarnog => "DobavljacID=" + dobavljacID;
        [Browsable(false)]
        public string vrednostSpoljnog => null;
        [Browsable(false)]
        public string vrednostAtributaIzTabele => "NazivDobavljaca like '%" + nazivDobavljaca + "%'";
        [Browsable(false)]
        public string upisivanje => " values("+dobavljacID+",'"+nazivDobavljaca+"','"+telefon+"','"+email+"','"+adresa+"')";
        [Browsable(false)]
        public string azuriranje => "NazivDobavljaca ='"+nazivDobavljaca+"',Telefon ='"+telefon+"', Email = '"+email+"', Adresa = '"+adresa+"'";
        [Browsable(false)]
        public Status Status { get => status; set => status = value; }

        public OpstiDomenskiObjekat napuni(DataRow red)
        {
            Dobavljac d = new Dobavljac();
            d.dobavljacID = Convert.ToInt32(red[0]);
            d.nazivDobavljaca = Convert.ToString(red[1]);
            d.telefon = Convert.ToString(red[2]);
            d.email = Convert.ToString(red[3]);
            d.adresa = Convert.ToString(red[4]);

            return d;
        }
    }
}
