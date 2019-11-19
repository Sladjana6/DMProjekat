using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace KontolerAplikacioneLogike
{
    public class KontrolerAL
    {

        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool diskonektujSeSaServera()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.kraj;
                formater.Serialize(tok, transfer);

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Zaposleni prijaviZaposlenogNaSistem(Zaposleni z)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.prijavaNaSistem;
            transfer.TransferObjekat = z;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Zaposleni;
        }

        public object kreirajDobavljaca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.kreirajDobavljaca;
            transfer.TransferObjekat = new Dobavljac();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Dobavljac> pretraziDobavljace(Dobavljac dobavljac)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.pretraziDobavljace;
            transfer.TransferObjekat = dobavljac;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Dobavljac>;
        }

        public object zapamtiDobavljaca(Dobavljac d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.zapamtiDobavljaca;
            d.Status = Status.Ubaci;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }


        public Dobavljac ucitajDobavljaca(Dobavljac d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ucitajDobavljaca;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Dobavljac; ;
        }

        public object izmeniDobavljaca(Dobavljac d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.izmeniDobavljaca;
            d.Status = Status.Izmeni;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object obrisiDobavljaca(Dobavljac d)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.obrisiDobavljaca;
            transfer.TransferObjekat = d;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public object kreirajNarudzbenicu()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.kreirajNarudzbenicu;
            transfer.TransferObjekat = new Narudzbenica();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Dobavljac> ucitajListuDobavljaca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ucitajListuDobavljaca;
            transfer.TransferObjekat = new Dobavljac();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Dobavljac>;
        }

        public List<Proizvod> ucitajListuProizvoda(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ucitajListuProizvoda;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Proizvod>;
        }

        public object zapamtiNarudzbenicu(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.zapamtiNarudzbenicu;
            n.Status = Status.Ubaci;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Narudzbenica> pronadjiNarudzbenice(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.pronadjiNarudzbenice;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Narudzbenica>;
        }

        public Narudzbenica ucitajNarudzbenicu(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ucitajNarudzbenicu;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Narudzbenica; 
        }

        public object izmeniNarudzbenicu(Narudzbenica n)
        {
            
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.izmeniNarudzbenicu;
                n.Status = Status.Izmeni;
                transfer.TransferObjekat = n;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.Rezultat;
           
        }

        public object obrisiNarudzbenicu(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.obrisiNarudzbenicu;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
