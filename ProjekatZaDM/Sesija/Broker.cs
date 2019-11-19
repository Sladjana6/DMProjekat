using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domen;
using System.Windows.Forms;
using Obavestenje;


namespace Sesija
{
    public class Broker
    {

        SqlConnection konekcija;
        SqlTransaction transakcija;

        public static Broker instanca;

        public static Broker dajSesiju()
        {
            if (instanca == null)
                instanca = new Broker();
            return instanca;
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija = new SqlConnection(@"Data Source=DESKTOP-29QKUJ7\SQLEXPRESS;Initial Catalog=dmBaza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                konekcija.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Konekcija sa bazom nije uspela!");
                
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Nije moguće zatvoriti konekciju!");
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {

                MessageBox.Show("Neuspešna transakcija!");
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešno poništavanje transakcije!");
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspešno potvrđivanje transakcije!");
            }
        }

        public OpstiDomenskiObjekat vratiObjekatZaVrednostPrimarnog(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.imeTabele + " where " + odo.vrednostPrimarnog;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;

                if(tabela.Rows.Count == 0)
                {
                    return null;
                }
                else    
                {
                    red = tabela.Rows[0];
                }

                return odo.napuni(red);
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!",Poruka.TipPoruke.neuspesno)); 
            }

            finally { if (citac != null) citac.Close(); }
        }


        public OpstiDomenskiObjekat vratiObjekatZaVrednostAtributaIzTabele(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.imeTabele + " where " + odo.vrednostAtributaIzTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                DataRow red;

                if (tabela.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    red = tabela.Rows[0];
                }

                return odo.napuni(red);
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
                
            }

            finally { if (citac != null) citac.Close(); }
        }

        public List<OpstiDomenskiObjekat> vratiSveObjekteZaDatuTabelu(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.imeTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();
                
                foreach(DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat o = odo.napuni(red);
                    lista.Add(o);
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }

            finally { if (citac != null) citac.Close(); }
        }

        public int vratiSifru(OpstiDomenskiObjekat odo)
        {
            string upit = "Select MAX("+odo.nazivPrimarnog+") from " + odo.imeTabele;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                try
                {
                    int sifra = Convert.ToInt32(komanda.ExecuteScalar());
                    return sifra + 1;
                }
                catch (Exception)
                {

                    return 1;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<OpstiDomenskiObjekat> vratiSveObjekteZaVrednostSpoljnog(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.imeTabele + " where " + odo.vrednostSpoljnog;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat o = odo.napuni(red);
                    lista.Add(o);
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }

            finally { if (citac != null) citac.Close(); }
        }

        public List<OpstiDomenskiObjekat> vratiSveObjekteZaVrednostAtributaIzTabele(OpstiDomenskiObjekat odo)
        {
            string upit = "Select * from " + odo.imeTabele + " where " + odo.vrednostAtributaIzTabele;
            SqlDataReader citac = null;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                citac = komanda.ExecuteReader();
                DataTable tabela = new DataTable();
                tabela.Load(citac);
                List<OpstiDomenskiObjekat> lista = new List<OpstiDomenskiObjekat>();

                foreach (DataRow red in tabela.Rows)
                {
                    OpstiDomenskiObjekat o = odo.napuni(red);
                    lista.Add(o);
                }

                return lista;
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }

            finally { if (citac != null) citac.Close(); }
        }

        public int sacuvaj(OpstiDomenskiObjekat odo)
        {
            string upit = "Insert into " + odo.imeTabele + " " + odo.upisivanje;
            SqlCommand komanda = new SqlCommand(upit,konekcija,transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno)); 
            }

        }

        public int izmeni(OpstiDomenskiObjekat odo)
        {
            string upit = "Update " + odo.imeTabele + " set " + odo.azuriranje + " where " + odo.vrednostPrimarnog;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }

        }


        public int obrisi(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.imeTabele + " where " + odo.vrednostPrimarnog;
            SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);

            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }

        }

        public int obrisiZaVrednostSpoljnog(OpstiDomenskiObjekat odo)
        {
            string upit = "Delete from " + odo.imeTabele + " WHERE " + odo.vrednostSpoljnog;
           SqlCommand komanda = new SqlCommand(upit, konekcija, transakcija);
            try
            {
                return komanda.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception(Poruka.prikaziPoruku("Greska u radu sa bazom!", Poruka.TipPoruke.neuspesno));
            }
        }



    }
}
