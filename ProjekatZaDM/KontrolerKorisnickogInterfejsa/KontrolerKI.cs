using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KontolerAplikacioneLogike;
using Domen;
using System.Windows.Forms;
using Obavestenje;
using Bunifu.Framework.UI;
using System.ComponentModel;
using MetroFramework.Controls;

namespace KontrolerKorisnickogInterfejsa
{
    public class KontrolerKI
    {
        public static KontrolerAL kal;
        public static Zaposleni zaposleni;
        public static Dobavljac dobavljac;
        public static Narudzbenica narudzbenica;

        BindingList<Dobavljac> listaDobavljaca = new BindingList<Dobavljac>();
      

        public void popuniPoljaNarudzbenice(Label lblDobavljac, DateTimePicker dtpDatum, ComboBox cmbProizvod, DataGridView dgvStavke, TextBox txtUkupnoBezPDV, TextBox txtUkupanPDV, TextBox txtUkupanIznosSaPDV)
        {
            lblDobavljac.Text = narudzbenica.Dobavljac.NazivDobavljaca;
            dgvStavke.DataSource = narudzbenica.ListaStavki;
            txtUkupnoBezPDV.Text = narudzbenica.UkupanIznosBezPDV.ToString();
            txtUkupanPDV.Text = narudzbenica.UkupanPDV.ToString();
            txtUkupanIznosSaPDV.Text = narudzbenica.UkupanIznosSaPDV.ToString();
            dtpDatum.Value = narudzbenica.Datum;
            Proizvod p = new Proizvod();
            p.Dobavljac = narudzbenica.Dobavljac;
            cmbProizvod.Text = "Odaberite proizvod!";
           // cmbProizvod.DataSource = kal.ucitajListuProizvoda(p);

            foreach(Proizvod pr in kal.ucitajListuProizvoda(p))
            {
                cmbProizvod.Items.Add(pr);
            }


        }

        public bool obrisiNarudzbenicu()
        {
            try
            {
                object o = kal.obrisiNarudzbenicu(narudzbenica);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je obrisao narudžbenicu.", Poruka.TipPoruke.uspesno);

                    return true;
                }
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da obriše narudžbenicu.",Poruka.TipPoruke.neuspesno);
                return false;
            }
        }

        public void osveziGridNarudzbenice(ComboBox cmbDobavljac, DataGridView dgvNarudzbenice)
        {
            narudzbenica = new Narudzbenica();
            narudzbenica.Dobavljac = cmbDobavljac.SelectedItem as Dobavljac;

            List<Narudzbenica> lista = kal.pronadjiNarudzbenice(narudzbenica);

            listaNarudzbenica = new BindingList<Narudzbenica>(lista);
            dgvNarudzbenice.DataSource = listaNarudzbenica;

            
        }

        public bool izmeniNarudzbenicu(DateTimePicker dtpDatum)
        {
            try
            {
                narudzbenica.Datum = dtpDatum.Value;


                object o = kal.izmeniNarudzbenicu(narudzbenica);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je zapamtio  narudžbenicu.", Poruka.TipPoruke.uspesno);
                    return true;
                }

            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da zapamti narudžbenicu.", Poruka.TipPoruke.neuspesno);
                return false;
            }
        }

        BindingList<Narudzbenica> listaNarudzbenica = new BindingList<Narudzbenica>();

        public void popuniComboDobavljac(ComboBox cmbDobavljac)
        {

            cmbDobavljac.Text = "Odaberite dobavljača!";

            foreach(Dobavljac d in kal.ucitajListuDobavljaca())
            {
                cmbDobavljac.Items.Add(d);
            }
        }

        public bool ucitajNarudzbenicu(DataGridView dgvNarudzbenice)
        {
            try
            {
                narudzbenica = dgvNarudzbenice.CurrentRow.DataBoundItem as Narudzbenica;
                narudzbenica = kal.ucitajNarudzbenicu(narudzbenica);

                if(narudzbenica == null)
                {
                    Poruka.prikaziPoruku("Sistem ne može da prikaže podatke o \n izabranoj narudžbenici.", Poruka.TipPoruke.neuspesno);
                    return false;
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je pronašao podatke o traženoj  \n narudžbenici.", Poruka.TipPoruke.uspesno);
                    return true;
                }
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Niste odabrali narudžbenicu za prikaz.",Poruka.TipPoruke.neuspesno);
                return false;
            }

        }

      

        public static bool poveziSeNaServer()
        {
            kal = new KontrolerAL();
            return kal.poveziSeNaServer();
        }

        

        public void popuniPoljaZaClana(TextBox txtNazivDobavljaca, TextBox txtTelefon, TextBox txtEmail, TextBox txtAdresa)
        {
            txtNazivDobavljaca.Text = dobavljac.NazivDobavljaca;
            txtTelefon.Text = dobavljac.Telefon;
            txtAdresa.Text =  dobavljac.Adresa;
            txtEmail.Text = dobavljac.Email;
            
        }

        public void pronadjiNarudzbenice(ComboBox cmbDobavljac, DataGridView dgvNarudzbenice)
        {
            narudzbenica = new Narudzbenica();
            narudzbenica.Dobavljac = cmbDobavljac.SelectedItem as Dobavljac;

            List<Narudzbenica> lista = kal.pronadjiNarudzbenice(narudzbenica);

            if (lista == null || lista.Count == 0)
            {
                Poruka.prikaziPoruku("Sistem ne može da pronađe narudžbenice \n po zadatoj vrednosti.", Poruka.TipPoruke.neuspesno);
                return;
            }
            else
            {
                Poruka.prikaziPoruku("Sistem je našao narudžbenice \n po zadatoj vrednosti.", Poruka.TipPoruke.uspesno);
                listaNarudzbenica = new BindingList<Narudzbenica>(lista);
                dgvNarudzbenice.DataSource = listaNarudzbenica;
            }
        }

        public void dodajStavku(ComboBox cmbProizvod, TextBox txtKolicina, TextBox txtUkupnoBezPDV, TextBox txtUkupanPDV, TextBox txtUkupanIznosSaPDV)
        {
            StavkaNarudzbenice sn = new StavkaNarudzbenice();
            sn.RedniBroj = narudzbenica.ListaStavki.Count + 1;
            sn.NarudzbenicaID = narudzbenica.NarudzbenicaID;
            sn.Status = Status.Ubaci;

            try
            {
                sn.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Niste dobro uneli količinu!",Poruka.TipPoruke.neuspesno);
                return;
            }

            Proizvod p = cmbProizvod.SelectedItem as Proizvod;

            if(p == null)
            {
                Poruka.prikaziPoruku("Niste odabrali prozivod!", Poruka.TipPoruke.neuspesno);
            }

            if (p.PoreskaStopa.PoreskaStopaID == 1) p.PoreskaStopa.Iznos = 20;
            else if (p.PoreskaStopa.PoreskaStopaID == 2) p.PoreskaStopa.Iznos = 8;
            else p.PoreskaStopa.Iznos = 0;


            sn.Proizvod = p;

            sn.IznosBezPDV = sn.Proizvod.Cena * sn.Kolicina;
            sn.PDV1 = sn.IznosBezPDV * ((double)sn.Proizvod.PoreskaStopa.Iznos / 100);
            sn.IznosSaPDV = sn.IznosBezPDV + sn.PDV1;

            narudzbenica.UkupanIznosBezPDV += sn.IznosBezPDV;
            narudzbenica.UkupanPDV += sn.PDV1;
            narudzbenica.UkupanIznosSaPDV = narudzbenica.UkupanIznosBezPDV + narudzbenica.UkupanPDV;

            txtUkupnoBezPDV.Text = narudzbenica.UkupanIznosBezPDV.ToString();
            txtUkupanPDV.Text = narudzbenica.UkupanPDV.ToString();
            txtUkupanIznosSaPDV.Text = narudzbenica.UkupanIznosSaPDV.ToString();

            narudzbenica.ListaStavki.Add(sn);

           

        }

        public bool sacuvajNarudzbenicu(DateTimePicker dtpDatum)
        {
            try
            {
                narudzbenica.Datum = dtpDatum.Value;

                object o = kal.zapamtiNarudzbenicu(narudzbenica);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je zapamtio novu narudžbenicu.", Poruka.TipPoruke.uspesno);
                    return true;
                }

            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da zapamti novu narudžbenicu.",Poruka.TipPoruke.neuspesno);
                return false;
            }
        }

        public void obrisiStavku(DataGridView dgvStavke, TextBox txtUkupnoBezPDV, TextBox txtUkupanPDV, TextBox txtUkupanIznosSaPDV)
        {
            try
            {
                StavkaNarudzbenice sn = dgvStavke.CurrentRow.DataBoundItem as StavkaNarudzbenice;
                narudzbenica.ListaStavki.Remove(sn);

                narudzbenica.UkupanIznosBezPDV -= sn.IznosBezPDV;
                narudzbenica.UkupanPDV -= sn.PDV1;
                narudzbenica.UkupanIznosSaPDV = narudzbenica.UkupanIznosBezPDV + narudzbenica.UkupanPDV;

               
                

                int rb = 1;
                foreach(StavkaNarudzbenice snar in narudzbenica.ListaStavki)
                {
                    snar.RedniBroj = rb;
                    rb++;
               
                }

               

                txtUkupnoBezPDV.Text = narudzbenica.UkupanIznosBezPDV.ToString();
                txtUkupanPDV.Text = narudzbenica.UkupanPDV.ToString();
                txtUkupanIznosSaPDV.Text = narudzbenica.UkupanIznosSaPDV.ToString();
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Niste odabrali stavku!", Poruka.TipPoruke.neuspesno);
            }
        }

        public void kreirajNovuNarudzbenicu(TextBox txtNarudzbenicaID, GroupBox groupBox1, ComboBox cmbDobavljac, DataGridView dgvStavke, Button btnKreirajNarudzbenicu, ComboBox cmbProizvod)
        {
            try
            {
                object o = kal.kreirajNarudzbenicu();

                if (o == null)
                {
                    throw new Exception();
                }

                else
                {
                    narudzbenica = new Narudzbenica();
                    narudzbenica.NarudzbenicaID = Convert.ToInt32(o);
                    narudzbenica.Zaposleni = zaposleni;
                    narudzbenica.Dobavljac = cmbDobavljac.SelectedItem as Dobavljac;

                    if (cmbDobavljac.SelectedItem == null)
                    {
                        Poruka.prikaziPoruku("Morate odabrati dobavljača!", Poruka.TipPoruke.neuspesno);
                        return;
                    }

                    Proizvod p = new Proizvod();
                    p.Dobavljac = cmbDobavljac.SelectedItem as Dobavljac;
                    foreach (Proizvod pr in kal.ucitajListuProizvoda(p))
                    {
                        cmbProizvod.Items.Add(pr);
                    }
                    cmbProizvod.Text = "Odaberite proizvod!";

                    txtNarudzbenicaID.Text = narudzbenica.NarudzbenicaID.ToString();
                    btnKreirajNarudzbenicu.Enabled = false;
                    dgvStavke.DataSource = narudzbenica.ListaStavki;
                    groupBox1.Enabled = true;
                    cmbDobavljac.Enabled = false;

                    

                    Poruka.prikaziPoruku("Sistem je kreirao novu narudžbenicu.", Poruka.TipPoruke.uspesno);


                }
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da kreira \n novu narudžbenicu.", Poruka.TipPoruke.neuspesno);
            }
        }

      

            public bool obrisiDobavljaca()
        {
            try
            {
                Dobavljac d = new Dobavljac();
                d.DobavljacID = dobavljac.DobavljacID;

                object o = kal.obrisiDobavljaca(d);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je obrisao dobavljača.", Poruka.TipPoruke.uspesno);

                    return true;
                }


            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da obriše dobavljača.", Poruka.TipPoruke.neuspesno);
                return false;
            }


        }

        public bool izmeniDobavljaca(TextBox txtNazivDobavljaca, TextBox txtTelefon, TextBox txtEmail, TextBox txtAdresa)
        {
            try
            {
                 Dobavljac d = new Dobavljac();

                d.DobavljacID = dobavljac.DobavljacID;
     
                d.NazivDobavljaca = txtNazivDobavljaca.Text;
                if (d.NazivDobavljaca == "")
                {
                    Poruka.prikaziPoruku("Niste uneli naziv dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Telefon = txtTelefon.Text;
                if (d.Telefon == "")
                {
                    Poruka.prikaziPoruku("Niste uneli telefon dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                bool proveraTelefona = false;

                foreach (Char c in d.Telefon)
                {
                    if (char.IsLetter(c))
                    {
                        proveraTelefona = true;
                        break;
                    }
                }

                if (proveraTelefona)
                {
                    Poruka.prikaziPoruku("Broj telefona ne sme sadržati slova!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Adresa = txtAdresa.Text;
                if (d.Adresa == "")
                {
                    Poruka.prikaziPoruku("Niste uneli adresu dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Email = txtEmail.Text;
                if (d.Email == "")
                {
                    Poruka.prikaziPoruku("Niste uneli email adresu dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                bool proveraEmail = false;

                foreach (char c in d.Email)
                {
                    if (c.ToString() == "@")
                    {
                        proveraEmail = true;
                        break;
                    }
                }

                if (!proveraEmail)
                {
                    Poruka.prikaziPoruku("Email mora da sadrži @!", Poruka.TipPoruke.neuspesno);
                    return false;
                }


                object o = kal.izmeniDobavljaca(d);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je zapamtio izmenjenog dobavljača.", Poruka.TipPoruke.uspesno);
                    
                    return true;
                }
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem ne može da zapamti dobavljača.", Poruka.TipPoruke.neuspesno);
                return false;
            }

        }

        public bool prijaviSeNaSistem(global::MetroFramework.Controls.MetroTextBox txtKorisnickoIme, global::MetroFramework.Controls.MetroTextBox txtKorisnickaSifra)
        {
             zaposleni = new Zaposleni();
            zaposleni.KorisnickoIme = txtKorisnickoIme.Text;
            zaposleni.KorisnickaSifra = txtKorisnickaSifra.Text;

            zaposleni = kal.prijaviZaposlenogNaSistem(zaposleni);

            if(zaposleni == null)
            {
                Poruka.prikaziPoruku("Sistem ne može da nađe zaposlenog \n na osnovu unetih vrednosti.", Poruka.TipPoruke.neuspesno);
                txtKorisnickoIme.Clear();
                txtKorisnickaSifra.Clear();
                txtKorisnickoIme.Focus();
                return false;
            }

            else
            {
                Poruka.prikaziPoruku("Zaposleni je uspešno prijavljen na sistem.", Poruka.TipPoruke.uspesno);
                return true;
              
            }
        }

        public bool ucitajDobavljaca(DataGridView dgvDobavljaci)
        {
            try
            {
                dobavljac = dgvDobavljaci.CurrentRow.DataBoundItem as Dobavljac;
                dobavljac = kal.ucitajDobavljaca(dobavljac);

                if (dobavljac == null)
                {
                    Poruka.prikaziPoruku("Sistem ne može da prikaže podatke o \n izabranom dobavljaču.",Poruka.TipPoruke.neuspesno);
                    return false;
                }

                else
                {
                    Poruka.prikaziPoruku("Odabrani dobavljač je prikazan.",Poruka.TipPoruke.uspesno);
                    return true;
                }
            }
            catch (Exception)
            {
                Poruka.prikaziPoruku("Niste odabrali dobavljača za prikaz.",Poruka.TipPoruke.neuspesno);
                return false;
               
            }
        }

        

        public void pretraziDobavljace(TextBox txtNazivDobavljaca, DataGridView dgvDobavljaci)
        {
            dobavljac = new Dobavljac();
            dobavljac.NazivDobavljaca = txtNazivDobavljaca.Text;

            List<Dobavljac> lista = kal.pretraziDobavljace(dobavljac);

            if(lista == null || lista.Count == 0)
            {
                Poruka.prikaziPoruku("Sistem ne može da nađe dobavljače \n po zadatoj vrednosti.",Poruka.TipPoruke.neuspesno);
                return;
            }
            else
            {
                Poruka.prikaziPoruku("Sistem je našao dobavljače \n po zadatoj vrednosti.",Poruka.TipPoruke.uspesno);
                listaDobavljaca = new BindingList<Dobavljac>(lista);
                dgvDobavljaci.DataSource = listaDobavljaca;
            }
        }

        public void osveziGrid(TextBox txtNazivDobavljaca,DataGridView dgvDobavljaci)
        {
            dobavljac = new Dobavljac();
            dobavljac.NazivDobavljaca = txtNazivDobavljaca.Text;

            List<Dobavljac> lista = kal.pretraziDobavljace(dobavljac);
            listaDobavljaca = new BindingList<Dobavljac>(lista);
            dgvDobavljaci.DataSource = listaDobavljaca;


        }



        public bool zapamtiDobavljaca(TextBox txtDobavljacID, TextBox txtNazivDobavljaca, TextBox txtTelefon, TextBox txtEmail, TextBox txtAdresa)
        {
            try
            {
                Dobavljac d = new Dobavljac();

                d.DobavljacID = Convert.ToInt32(txtDobavljacID.Text);

                d.NazivDobavljaca = txtNazivDobavljaca.Text;
                if (d.NazivDobavljaca == "")
                {
                    Poruka.prikaziPoruku("Niste uneli naziv dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Telefon = txtTelefon.Text;
                if (d.Telefon == "")
                {
                    Poruka.prikaziPoruku("Niste uneli telefon dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                bool proveraTelefona = false;

                foreach (Char c in d.Telefon)
                {
                    if (char.IsLetter(c))
                    {
                        proveraTelefona = true;
                        break;
                    }
                }

                if (proveraTelefona)
                {
                    Poruka.prikaziPoruku("Broj telefona ne sme sadržati slova!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Adresa = txtAdresa.Text;
                if (d.Adresa == "")
                {
                    Poruka.prikaziPoruku("Niste uneli adresu dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                d.Email = txtEmail.Text;
                if (d.Email == "")
                {
                    Poruka.prikaziPoruku("Niste uneli email adresu dobavljača!", Poruka.TipPoruke.neuspesno);
                    return false;
                }

                bool proveraEmail = false;

                foreach (char c in d.Email)
                {
                    if (c.ToString() == "@")
                    {
                        proveraEmail = true;
                        break;
                    }
                }

                if (!proveraEmail)
                {
                    Poruka.prikaziPoruku("Email mora da sadrži @!", Poruka.TipPoruke.neuspesno);
                    return false;
                }


                object o = kal.zapamtiDobavljaca(d);
                if (o == null || (int)o == 0)
                {
                    throw new Exception();
                }
                else
                {
                    Poruka.prikaziPoruku("Sistem je zapamtio novog dobavljača.", Poruka.TipPoruke.uspesno);
                    return true;
                }
            }
            catch (Exception)
            {

                Poruka.prikaziPoruku("Sistem nije zapamtio novog dobavljača.", Poruka.TipPoruke.neuspesno);
                return false;
            }


        }

        public void kreirajNovogDobavljaca(TextBox txtDobavljacID, Button btnKreirajDobavljaca, Button btnZapamtiDobavljaca, GroupBox groupBox1)
        {
            try
            {
                Object o = kal.kreirajDobavljaca();
                if (o == null)
                {
                    throw new Exception();
                }
                else
                {
                    txtDobavljacID.Text = o.ToString();
                    Poruka.prikaziPoruku("Sistem je kreirao novog dobavljača.",Poruka.TipPoruke.uspesno);
                    groupBox1.Enabled = true;
                    btnZapamtiDobavljaca.Enabled = true;
                    btnKreirajDobavljaca.Enabled = false;
                }
            }
            catch (Exception)
            {
                Poruka.prikaziPoruku("Sistem ne može da kreira novog dobavljača.", Poruka.TipPoruke.neuspesno);
                
            }
        }

        public string ulogovani()
        {
            return "Ulogovano zaposleno lice: " + zaposleni.ToString();
        }
    }
}
