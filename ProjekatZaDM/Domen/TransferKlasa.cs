using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { kraj = 1,
        prijavaNaSistem = 2,
        kreirajDobavljaca = 3,
        zapamtiDobavljaca = 4,
        pretraziDobavljace = 5,
        ucitajDobavljaca = 6,
        izmeniDobavljaca = 7,
        obrisiDobavljaca = 8,
        kreirajNarudzbenicu = 9,
        ucitajListuDobavljaca = 10,
        ucitajListuProizvoda = 11,
        zapamtiNarudzbenicu = 12,
        pronadjiNarudzbenice = 13,
        ucitajNarudzbenicu = 14,
        izmeniNarudzbenicu = 15,
        obrisiNarudzbenicu = 16,
    }
    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;
        Object transferObjekat;
        Object rezultat;

        public Operacije Operacija { get => operacija; set => operacija = value; }
        public object TransferObjekat { get => transferObjekat; set => transferObjekat = value; }
        public object Rezultat { get => rezultat; set => rezultat = value; }

    }
}
