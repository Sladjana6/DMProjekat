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
    public partial class UnosDobavljaca : Form
    {
        KontrolerKI kki = new KontrolerKI();


        public UnosDobavljaca()
        {
            InitializeComponent();
        }

        

        

        private void btnKreirajDobavljaca_Click_1(object sender, EventArgs e)
        {
            kki.kreirajNovogDobavljaca(txtDobavljacID, btnKreirajDobavljaca, btnZapamtiDobavljaca, groupBox1);
        }

        private void UnosDobavljaca_Load(object sender, EventArgs e)
        {

        }

        private void btnZapamtiDobavljaca_Click_1(object sender, EventArgs e)
        {
            if (kki.zapamtiDobavljaca(txtDobavljacID, txtNazivDobavljaca, txtTelefon, txtEmail, txtAdresa)) this.Close();
        }
    }
}
