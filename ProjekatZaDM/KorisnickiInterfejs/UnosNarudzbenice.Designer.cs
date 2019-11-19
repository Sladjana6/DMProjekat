namespace KorisnickiInterfejs
{
    partial class UnosNarudzbenice
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
            this.txtNarudzbenicaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnZapamtiNarudzbenicu = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.txtUkupanIznosSaPDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUkupanPDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUkupnoBezPDV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKreirajNarudzbenicu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narudžbenica ID:";
            // 
            // txtNarudzbenicaID
            // 
            this.txtNarudzbenicaID.Location = new System.Drawing.Point(136, 53);
            this.txtNarudzbenicaID.Name = "txtNarudzbenicaID";
            this.txtNarudzbenicaID.ReadOnly = true;
            this.txtNarudzbenicaID.Size = new System.Drawing.Size(139, 20);
            this.txtNarudzbenicaID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dobavljač:";
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(136, 20);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(139, 21);
            this.cmbDobavljac.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(89, 31);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(192, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZapamtiNarudzbenicu);
            this.groupBox1.Controls.Add(this.btnObrisiStavku);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.txtUkupanIznosSaPDV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUkupanPDV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUkupnoBezPDV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProizvod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(26, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 445);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos podataka o narudžbenici";
            // 
            // btnZapamtiNarudzbenicu
            // 
            this.btnZapamtiNarudzbenicu.Location = new System.Drawing.Point(278, 390);
            this.btnZapamtiNarudzbenicu.Name = "btnZapamtiNarudzbenicu";
            this.btnZapamtiNarudzbenicu.Size = new System.Drawing.Size(147, 45);
            this.btnZapamtiNarudzbenicu.TabIndex = 28;
            this.btnZapamtiNarudzbenicu.Text = "Zapamti narudžbenicu";
            this.btnZapamtiNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnZapamtiNarudzbenicu.Click += new System.EventHandler(this.btnZapamtiNarudzbenicu_Click_1);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(213, 136);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(135, 45);
            this.btnObrisiStavku.TabIndex = 27;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click_1);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(25, 136);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(135, 45);
            this.btnDodajStavku.TabIndex = 26;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click_1);
            // 
            // txtUkupanIznosSaPDV
            // 
            this.txtUkupanIznosSaPDV.Location = new System.Drawing.Point(596, 349);
            this.txtUkupanIznosSaPDV.Name = "txtUkupanIznosSaPDV";
            this.txtUkupanIznosSaPDV.ReadOnly = true;
            this.txtUkupanIznosSaPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupanIznosSaPDV.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ukupan iznos sa PDV:";
            // 
            // txtUkupanPDV
            // 
            this.txtUkupanPDV.Location = new System.Drawing.Point(354, 349);
            this.txtUkupanPDV.Name = "txtUkupanPDV";
            this.txtUkupanPDV.ReadOnly = true;
            this.txtUkupanPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupanPDV.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ukupan PDV:";
            // 
            // txtUkupnoBezPDV
            // 
            this.txtUkupnoBezPDV.Location = new System.Drawing.Point(160, 349);
            this.txtUkupnoBezPDV.Name = "txtUkupnoBezPDV";
            this.txtUkupnoBezPDV.ReadOnly = true;
            this.txtUkupnoBezPDV.Size = new System.Drawing.Size(89, 20);
            this.txtUkupnoBezPDV.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ukupan iznos bez PDV:";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(25, 193);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(692, 150);
            this.dgvStavke.TabIndex = 17;
            this.dgvStavke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(89, 100);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtKolicina.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Količina:";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(89, 67);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(192, 21);
            this.cmbProizvod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proizvod:";
            // 
            // btnKreirajNarudzbenicu
            // 
            this.btnKreirajNarudzbenicu.Location = new System.Drawing.Point(304, 23);
            this.btnKreirajNarudzbenicu.Name = "btnKreirajNarudzbenicu";
            this.btnKreirajNarudzbenicu.Size = new System.Drawing.Size(168, 46);
            this.btnKreirajNarudzbenicu.TabIndex = 15;
            this.btnKreirajNarudzbenicu.Text = "Kreiraj narudžbenicu";
            this.btnKreirajNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnKreirajNarudzbenicu.Click += new System.EventHandler(this.btnKreirajNarudzbenicu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(780, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // UnosNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(892, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKreirajNarudzbenicu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNarudzbenicaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDobavljac);
            this.Name = "UnosNarudzbenice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Unos narudžbenice";
            this.Load += new System.EventHandler(this.UnosNarudzbenice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNarudzbenicaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUkupanIznosSaPDV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUkupanPDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUkupnoBezPDV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKreirajNarudzbenicu;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnZapamtiNarudzbenicu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}