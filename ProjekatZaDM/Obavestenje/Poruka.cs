using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obavestenje
{
    public partial class Poruka : Form
    {
        public enum TipPoruke { uspesno, neuspesno }
        public Poruka(string poruka, TipPoruke tip)
        {
            InitializeComponent();
            lblPoruka.Text = poruka;
            //lblPoruka.Text = poruka;
            switch (tip)
            {
                case TipPoruke.uspesno:
                    this.BackColor = Color.SeaGreen;
                    pictureBox1.Image = imageList1.Images[0];
        
                    break;
                case TipPoruke.neuspesno:
                    this.BackColor = Color.FromArgb(201, 46, 32);
                    pictureBox1.Image = imageList1.Images[1];
                    
                    break;
                default:
                    break;
            }
        }

        public static string prikaziPoruku(string poruka, TipPoruke tip)
        {
           return new Poruka(poruka, tip).ShowDialog().ToString();
        }

        private void Poruka_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
