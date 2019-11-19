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
using Bunifu;
using MetroFramework;
using Obavestenje;

namespace KorisnickiInterfejs
{
    public partial class PrijavaNaSistem : Form
    {

        KontrolerKI kki;

        public PrijavaNaSistem()
        {
            InitializeComponent();
            KontrolerKI.poveziSeNaServer();
            kki = new KontrolerKI();
            
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PrijavaNaSistem_Load(object sender, EventArgs e)
        {

            
        }

        private void txtKorisnickoIme_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUlogujSe_Click(object sender, EventArgs e)
        {
            if (kki.prijaviSeNaSistem(txtKorisnickoIme, txtKorisnickaSifra))
            {
                this.Hide();
                new FormaMeni().ShowDialog();
            }
        }

        


    }
}
