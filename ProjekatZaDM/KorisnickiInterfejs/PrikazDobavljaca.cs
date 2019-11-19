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
    public partial class PrikazDobavljaca : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public PrikazDobavljaca()
        {
            InitializeComponent();
        }

        private void PrikazDobavljaca_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaZaClana(txtNazivDobavljaca,txtTelefon,txtEmail,txtAdresa);
        }

       
       
        private void btnIzmeniDobavljaca_Click_1(object sender, EventArgs e)
        {
            if (kki.izmeniDobavljaca(txtNazivDobavljaca, txtTelefon, txtEmail, txtAdresa)) this.Close();
        }

        private void btnObrisiDobavljaca_Click_1(object sender, EventArgs e)
        {
            if (kki.obrisiDobavljaca()) this.Close();
        }
    }
}
