namespace KorisnickiInterfejs
{
    partial class PrikazNarudzbenice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUkupanIznosSaPDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUkupanPDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUkupnoBezPDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnZapamtiNarudzbenicu = new System.Windows.Forms.Button();
            this.btnObrisiNarudzbenicu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobavljac.Location = new System.Drawing.Point(101, 23);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(57, 15);
            this.lblDobavljac.TabIndex = 1;
            this.lblDobavljac.Text = "LABELA";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(17, 181);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersVisible = false;
            this.dgvStavke.Size = new System.Drawing.Size(684, 161);
            this.dgvStavke.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiNarudzbenicu);
            this.groupBox1.Controls.Add(this.btnZapamtiNarudzbenicu);
            this.groupBox1.Controls.Add(this.btnObrisiStavku);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.txtUkupanIznosSaPDV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUkupanPDV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUkupnoBezPDV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProizvod);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Location = new System.Drawing.Point(30, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 468);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena/brisanje podataka o narudžbenici";
            // 
            // txtUkupanIznosSaPDV
            // 
            this.txtUkupanIznosSaPDV.Location = new System.Drawing.Point(612, 351);
            this.txtUkupanIznosSaPDV.Name = "txtUkupanIznosSaPDV";
            this.txtUkupanIznosSaPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupanIznosSaPDV.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Ukupan iznos sa PDV:";
            // 
            // txtUkupanPDV
            // 
            this.txtUkupanPDV.Location = new System.Drawing.Point(363, 351);
            this.txtUkupanPDV.Name = "txtUkupanPDV";
            this.txtUkupanPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupanPDV.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ukupan PDV:";
            // 
            // txtUkupnoBezPDV
            // 
            this.txtUkupnoBezPDV.Location = new System.Drawing.Point(155, 351);
            this.txtUkupnoBezPDV.Name = "txtUkupnoBezPDV";
            this.txtUkupnoBezPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupnoBezPDV.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ukupan iznos bez PDV:";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(64, 60);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(146, 21);
            this.cmbProizvod.TabIndex = 12;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(64, 90);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(146, 20);
            this.txtKolicina.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proizvod:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(64, 24);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(771, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(37, 125);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(135, 45);
            this.btnDodajStavku.TabIndex = 35;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click_1);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(220, 125);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(135, 45);
            this.btnObrisiStavku.TabIndex = 36;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click_1);
            // 
            // btnZapamtiNarudzbenicu
            // 
            this.btnZapamtiNarudzbenicu.Location = new System.Drawing.Point(155, 400);
            this.btnZapamtiNarudzbenicu.Name = "btnZapamtiNarudzbenicu";
            this.btnZapamtiNarudzbenicu.Size = new System.Drawing.Size(147, 45);
            this.btnZapamtiNarudzbenicu.TabIndex = 37;
            this.btnZapamtiNarudzbenicu.Text = "Zapamti narudžbenicu";
            this.btnZapamtiNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnZapamtiNarudzbenicu.Click += new System.EventHandler(this.btnZapamtiNarudzbenicu_Click_1);
            // 
            // btnObrisiNarudzbenicu
            // 
            this.btnObrisiNarudzbenicu.Location = new System.Drawing.Point(363, 400);
            this.btnObrisiNarudzbenicu.Name = "btnObrisiNarudzbenicu";
            this.btnObrisiNarudzbenicu.Size = new System.Drawing.Size(147, 45);
            this.btnObrisiNarudzbenicu.TabIndex = 38;
            this.btnObrisiNarudzbenicu.Text = "Obriši narudžbenicu";
            this.btnObrisiNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnObrisiNarudzbenicu.Click += new System.EventHandler(this.btnObrisiNarudzbenicu_Click_1);
            // 
            // PrikazNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(883, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "PrikazNarudzbenice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Prikaz narudžbenice";
            this.Load += new System.EventHandler(this.PrikazNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUkupanIznosSaPDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUkupanPDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUkupnoBezPDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnObrisiNarudzbenicu;
        private System.Windows.Forms.Button btnZapamtiNarudzbenicu;
    }
}