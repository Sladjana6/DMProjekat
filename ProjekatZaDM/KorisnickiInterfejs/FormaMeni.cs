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
    public partial class FormaMeni : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public FormaMeni()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panelMeni.Width == 56)
            {
                panelMeni.Visible = false;
                panelMeni.Width = 173;
                panelAnimator.ShowSync(panelMeni);
                
            }
            else
            {

                panelMeni.Visible = false;
                panelMeni.Width = 56;
                panelAnimator.ShowSync(panelMeni);
                

            }
        }

        private void btnDobavljac_Click(object sender, EventArgs e)
        {

            if (btnUnosNarudzbenice.Visible == true && btnPretragaNarudzbenice.Visible == true)
            {
                btnUnosNarudzbenice.Visible = false;
                btnPretragaNarudzbenice.Visible = false;
                
                btnUnosDobavljaca.Visible = true;
                btnUnosDobavljaca.Location = new Point(44,60);
               
                btnPretragaDobavljaca.Visible = true;
                btnPretragaDobavljaca.Location = new Point(231, 60);
            }
            else
            {
                lblPoruka.Visible = false;
                btnUnosDobavljaca.Visible = true;
                btnUnosDobavljaca.Location = new Point(44, 60);

                btnPretragaDobavljaca.Visible = true;
                btnPretragaDobavljaca.Location = new Point(231, 60);
            }
        }

        private void btnNarudzbenica_Click(object sender, EventArgs e)
        {
            if (btnUnosDobavljaca.Visible == true && btnPretragaDobavljaca.Visible == true)
            {
                btnUnosDobavljaca.Visible = false;
                btnPretragaDobavljaca.Visible = false;
                btnUnosNarudzbenice.Location = new Point(44, 60);
                btnPretragaNarudzbenice.Location = new Point(231, 60);
               
                btnUnosNarudzbenice.Visible = true;
             
                btnPretragaNarudzbenice.Visible = true;


            }
            else
            {
                lblPoruka.Visible = false;
               
                btnUnosNarudzbenice.Visible = true;
                btnUnosNarudzbenice.Location = new Point(44, 60);
               
                btnPretragaNarudzbenice.Visible = true;
                btnPretragaNarudzbenice.Location = new Point(231, 60);

                

            }
        }

        private void FormaMeni_Load(object sender, EventArgs e)
        {
            this.Text = kki.ulogovani();
        }

        


        private void btnUnosDobavljaca_Click(object sender, EventArgs e)
        {
            new UnosDobavljaca().ShowDialog();
        }

       
        private void btnPretragaDobavljaca_Click(object sender, EventArgs e)
        {
            new PretragaDobavljaca().ShowDialog();
        }

        private void btnUnosNarudzbenice_Click_1(object sender, EventArgs e)
        {
            new UnosNarudzbenice().ShowDialog();
        }

        private void btnPretragaNarudzbenice_Click(object sender, EventArgs e)
        {
            new PretragaNarudzbenica().ShowDialog();
        }
    }
}
