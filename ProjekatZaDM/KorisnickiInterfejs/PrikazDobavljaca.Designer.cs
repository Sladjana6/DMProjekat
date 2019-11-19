namespace KorisnickiInterfejs
{
    partial class PrikazDobavljaca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazivDobavljaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzmeniDobavljaca = new System.Windows.Forms.Button();
            this.btnObrisiDobavljaca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiDobavljaca);
            this.groupBox1.Controls.Add(this.btnIzmeniDobavljaca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNazivDobavljaca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 265);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena/brisanje podataka o dobavljaču";
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
            // txtNazivDobavljaca
            // 
            this.txtNazivDobavljaca.Location = new System.Drawing.Point(118, 32);
            this.txtNazivDobavljaca.Name = "txtNazivDobavljaca";
            this.txtNazivDobavljaca.Size = new System.Drawing.Size(127, 20);
            this.txtNazivDobavljaca.TabIndex = 10;
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
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(118, 67);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(127, 20);
            this.txtTelefon.TabIndex = 9;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email adresa:";
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
            // btnIzmeniDobavljaca
            // 
            this.btnIzmeniDobavljaca.Location = new System.Drawing.Point(12, 193);
            this.btnIzmeniDobavljaca.Name = "btnIzmeniDobavljaca";
            this.btnIzmeniDobavljaca.Size = new System.Drawing.Size(111, 38);
            this.btnIzmeniDobavljaca.TabIndex = 11;
            this.btnIzmeniDobavljaca.Text = "Izmeni dobavljača";
            this.btnIzmeniDobavljaca.UseVisualStyleBackColor = true;
            this.btnIzmeniDobavljaca.Click += new System.EventHandler(this.btnIzmeniDobavljaca_Click_1);
            // 
            // btnObrisiDobavljaca
            // 
            this.btnObrisiDobavljaca.Location = new System.Drawing.Point(152, 193);
            this.btnObrisiDobavljaca.Name = "btnObrisiDobavljaca";
            this.btnObrisiDobavljaca.Size = new System.Drawing.Size(111, 38);
            this.btnObrisiDobavljaca.TabIndex = 12;
            this.btnObrisiDobavljaca.Text = "Obriši dobavljača";
            this.btnObrisiDobavljaca.UseVisualStyleBackColor = true;
            this.btnObrisiDobavljaca.Click += new System.EventHandler(this.btnObrisiDobavljaca_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(372, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PrikazDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(484, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrikazDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Prikaz dobavljača";
            this.Load += new System.EventHandler(this.PrikazDobavljaca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazivDobavljaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiDobavljaca;
        private System.Windows.Forms.Button btnIzmeniDobavljaca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}