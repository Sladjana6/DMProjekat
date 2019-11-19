namespace KorisnickiInterfejs
{
    partial class UnosDobavljaca
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDobavljacID = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtNazivDobavljaca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKreirajDobavljaca = new System.Windows.Forms.Button();
            this.btnZapamtiDobavljaca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Naziv dobavljača:";
            // 
            // txtDobavljacID
            // 
            this.txtDobavljacID.Location = new System.Drawing.Point(130, 22);
            this.txtDobavljacID.Name = "txtDobavljacID";
            this.txtDobavljacID.ReadOnly = true;
            this.txtDobavljacID.Size = new System.Drawing.Size(127, 20);
            this.txtDobavljacID.TabIndex = 5;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(118, 142);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(127, 20);
            this.txtAdresa.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(127, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(118, 67);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(127, 20);
            this.txtTelefon.TabIndex = 9;
            // 
            // txtNazivDobavljaca
            // 
            this.txtNazivDobavljaca.Location = new System.Drawing.Point(118, 32);
            this.txtNazivDobavljaca.Name = "txtNazivDobavljaca";
            this.txtNazivDobavljaca.Size = new System.Drawing.Size(127, 20);
            this.txtNazivDobavljaca.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(348, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNazivDobavljaca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 187);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos podataka o dobavljaču";
            // 
            // btnKreirajDobavljaca
            // 
            this.btnKreirajDobavljaca.Location = new System.Drawing.Point(289, 17);
            this.btnKreirajDobavljaca.Name = "btnKreirajDobavljaca";
            this.btnKreirajDobavljaca.Size = new System.Drawing.Size(114, 29);
            this.btnKreirajDobavljaca.TabIndex = 15;
            this.btnKreirajDobavljaca.Text = "Kreiraj dobavljača";
            this.btnKreirajDobavljaca.UseVisualStyleBackColor = true;
            this.btnKreirajDobavljaca.Click += new System.EventHandler(this.btnKreirajDobavljaca_Click_1);
            // 
            // btnZapamtiDobavljaca
            // 
            this.btnZapamtiDobavljaca.Location = new System.Drawing.Point(95, 254);
            this.btnZapamtiDobavljaca.Name = "btnZapamtiDobavljaca";
            this.btnZapamtiDobavljaca.Size = new System.Drawing.Size(114, 48);
            this.btnZapamtiDobavljaca.TabIndex = 16;
            this.btnZapamtiDobavljaca.Text = "Zapamti dobavljača";
            this.btnZapamtiDobavljaca.UseVisualStyleBackColor = true;
            this.btnZapamtiDobavljaca.Click += new System.EventHandler(this.btnZapamtiDobavljaca_Click_1);
            // 
            // UnosDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(452, 316);
            this.Controls.Add(this.btnZapamtiDobavljaca);
            this.Controls.Add(this.btnKreirajDobavljaca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDobavljacID);
            this.Controls.Add(this.label1);
            this.Name = "UnosDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Unos novog dobavljača";
            this.Load += new System.EventHandler(this.UnosDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDobavljacID;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtNazivDobavljaca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKreirajDobavljaca;
        private System.Windows.Forms.Button btnZapamtiDobavljaca;
    }
}