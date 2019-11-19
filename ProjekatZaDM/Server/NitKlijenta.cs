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
using SistemskeOperacije;
using System.Windows.Forms;

namespace Server
{
    class NitKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = obradi;
            new Thread(ts).Start();
        }

        private void obradi()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {

                       
                        case Operacije.prijavaNaSistem:
                            PronadjiZaposlenog pz = new PronadjiZaposlenog();
                            transfer.Rezultat = pz.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.kreirajDobavljaca:
                            KreirajDobavljaca knd = new KreirajDobavljaca();
                            transfer.Rezultat = knd.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.zapamtiDobavljaca:
                            ZapamtiDobavljaca zd = new ZapamtiDobavljaca();
                            transfer.Rezultat = zd.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.pretraziDobavljace:
                            PronadjiDobavljace pd = new PronadjiDobavljace();
                            transfer.Rezultat = pd.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ucitajDobavljaca:
                            UcitajDobavljaca ud = new UcitajDobavljaca();
                            transfer.Rezultat = ud.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.izmeniDobavljaca:
                            ZapamtiDobavljaca zd2 = new ZapamtiDobavljaca();
                            transfer.Rezultat = zd2.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.obrisiDobavljaca:
                            ObrisiDobavljaca od = new ObrisiDobavljaca();
                            transfer.Rezultat = od.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.kreirajNarudzbenicu:
                            KreirajNarudzbenicu kn = new KreirajNarudzbenicu();
                            transfer.Rezultat = kn.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ucitajListuDobavljaca:
                            UcitajListuDobavljaca uld = new UcitajListuDobavljaca();
                            transfer.Rezultat = uld.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ucitajListuProizvoda:
                            UcitajListuProizvoda ulp = new UcitajListuProizvoda();
                            transfer.Rezultat = ulp.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.zapamtiNarudzbenicu:
                            ZapamtiNarudzbenicu zn = new ZapamtiNarudzbenicu();
                            transfer.Rezultat = zn.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.pronadjiNarudzbenice:
                            PronadjiNarudzbenice pn = new PronadjiNarudzbenice();
                            transfer.Rezultat = pn.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ucitajNarudzbenicu:
                           UcitajNarudzbenicu un = new UcitajNarudzbenicu();
                            transfer.Rezultat = un.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.izmeniNarudzbenicu:
                            ZapamtiNarudzbenicu izmn = new ZapamtiNarudzbenicu();
                            transfer.Rezultat = izmn.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.obrisiNarudzbenicu:
                            ObrisiNarudzbenicu on = new ObrisiNarudzbenicu();
                            transfer.Rezultat = on.izvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;


                        case Operacije.kraj: operacija = 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
