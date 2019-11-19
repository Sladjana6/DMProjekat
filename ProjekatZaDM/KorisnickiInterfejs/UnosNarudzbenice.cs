using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Bunifu;
using KontrolerKorisnickogInterfejsa;

namespace KorisnickiInterfejs
{
    public partial class UnosNarudzbenice : Form
    {

        KontrolerKI kki = new KontrolerKI();

        public UnosNarudzbenice()
        {
            InitializeComponent();
        }

        private void UnosNarudzbenice_Load(object sender, EventArgs e)
        {
            kki.popuniComboDobavljac(cmbDobavljac);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
  
      
        private void btnKreirajNarudzbenicu_Click(object sender, EventArgs e)
        {
            kki.kreirajNovuNarudzbenicu(txtNarudzbenicaID, groupBox1, cmbDobavljac, dgvStavke, btnKreirajNarudzbenicu, cmbProizvod);
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
            if (kki.sacuvajNarudzbenicu(dtpDatum)) this.Close();
        }
    }
}
