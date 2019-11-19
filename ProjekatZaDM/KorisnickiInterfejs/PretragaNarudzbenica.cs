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
    public partial class PretragaNarudzbenica : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public PretragaNarudzbenica()
        {
            InitializeComponent();
        }

        private void PretragaNarudzbenica_Load(object sender, EventArgs e)
        {
            kki.popuniComboDobavljac(cmbDobavljac);
        }

        

        private void cmbDobavljac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kki.pronadjiNarudzbenice(cmbDobavljac, dgvStavke);
        }

        

        private void dgvNarudzbenice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPretraziNarudzbenice_Click(object sender, EventArgs e)
        {
            kki.pronadjiNarudzbenice(cmbDobavljac, dgvNarudzbenice);
        }

        private void btnPrikazNarudzbenice_Click_1(object sender, EventArgs e)
        {
            if (kki.ucitajNarudzbenicu(dgvNarudzbenice)) new PrikazNarudzbenice().ShowDialog();
            kki.osveziGridNarudzbenice(cmbDobavljac, dgvNarudzbenice);

        }
    }
}
