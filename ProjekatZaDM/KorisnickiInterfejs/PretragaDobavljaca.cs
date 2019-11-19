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
    public partial class PretragaDobavljaca : Form
    {

        KontrolerKI kki = new KontrolerKI();

        public PretragaDobavljaca()
        {
            InitializeComponent();
        }

        

        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            dgvDobavljaci.Update();
        }

        private void txtNazivDobavljaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void PretragaDobavljaca_Load(object sender, EventArgs e)
        {

        }

        private void btnPretragaDobavljaca_Click(object sender, EventArgs e)
        {
            kki.pretraziDobavljace(txtNazivDobavljaca, dgvDobavljaci);
        }

        private void btnPrikazDobavljaca_Click(object sender, EventArgs e)
        {
            if (kki.ucitajDobavljaca(dgvDobavljaci)) new PrikazDobavljaca().ShowDialog();
            kki.osveziGrid(txtNazivDobavljaca, dgvDobavljaci);

        }
    }
}
