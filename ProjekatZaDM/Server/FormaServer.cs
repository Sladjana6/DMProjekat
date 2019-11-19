using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu;
using Obavestenje;
using MetroFramework;



namespace Server
{
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void FormaServer_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnPokreni_Click_1(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                btnPokreni.Textcolor = Color.Black;
                Poruka.prikaziPoruku("Server je uspešno pokrenut!", Poruka.TipPoruke.uspesno);

            }
        }

        private void btnZaustavi_Click_1(object sender, EventArgs e)
        {
            if (s.zaustaviServer())
            {
                btnZaustavi.Enabled = false;
                btnPokreni.Enabled = true;
                btnZaustavi.Textcolor = Color.Black;
                Poruka.prikaziPoruku("Server je zaustavljen!", Poruka.TipPoruke.neuspesno);
            }
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

       

        

        
    }
}
