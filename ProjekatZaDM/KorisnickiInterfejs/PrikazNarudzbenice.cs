using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontrolerKorisnickogInterfejsa;

namespace KorisnickiInterfejs
{
    public partial class PrikazNarudzbenice : Form
    {

        KontrolerKI kki = new KontrolerKI();

        public PrikazNarudzbenice()
        {
            InitializeComponent();
        }

        private void PrikazNarudzbenice_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaNarudzbenice(lblDobavljac, dtpDatum, cmbProizvod, dgvStavke, txtUkupnoBezPDV, txtUkupanPDV, txtUkupanIznosSaPDV);
        }

        private void btnDodajStavku_Click_1(object sender, EventArgs e)
        {
            kki.dodajStavku(cmbProizvod, txtKolicina, txtUkupnoBezPDV, txtUkupanPDV, txtUkupanIznosSaPDV);
        }

        private void btnObrisiStavku_Click_1(object sender, EventArgs e)
        {
            kki.obrisiStavku(dgvStavke, txtUkupnoBezPDV, txtUkupanPDV, txtUkupanIznosSaPDV);
        }

        private void btnZapamtiNarudzbenicu_Click_1(object sender, EventArgs e)
        {
            if (kki.izmeniNarudzbenicu(dtpDatum)) this.Close();
        }

        private void btnObrisiNarudzbenicu_Click_1(object sender, EventArgs e)
        {
            if (kki.obrisiNarudzbenicu()) this.Close();
        }
    }
}
