namespace KorisnickiInterfejs
{
    partial class PretragaDobavljaca
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
            this.txtNazivDobavljaca = new System.Windows.Forms.TextBox();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.btnPretragaDobavljaca = new System.Windows.Forms.Button();
            this.btnPrikazDobavljaca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite naziv dobavljača:";
            // 
            // txtNazivDobavljaca
            // 
            this.txtNazivDobavljaca.Location = new System.Drawing.Point(172, 19);
            this.txtNazivDobavljaca.Name = "txtNazivDobavljaca";
            this.txtNazivDobavljaca.Size = new System.Drawing.Size(163, 20);
            this.txtNazivDobavljaca.TabIndex = 1;
            this.txtNazivDobavljaca.TextChanged += new System.EventHandler(this.txtNazivDobavljaca_TextChanged);
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Location = new System.Drawing.Point(25, 83);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.Size = new System.Drawing.Size(535, 150);
            this.dgvDobavljaci.TabIndex = 8;
            this.dgvDobavljaci.SelectionChanged += new System.EventHandler(this.dgvDobavljaci_SelectionChanged);
            // 
            // btnPretragaDobavljaca
            // 
            this.btnPretragaDobavljaca.Location = new System.Drawing.Point(375, 12);
            this.btnPretragaDobavljaca.Name = "btnPretragaDobavljaca";
            this.btnPretragaDobavljaca.Size = new System.Drawing.Size(126, 36);
            this.btnPretragaDobavljaca.TabIndex = 9;
            this.btnPretragaDobavljaca.Text = "Pretraži dobavljače";
            this.btnPretragaDobavljaca.UseVisualStyleBackColor = true;
            this.btnPretragaDobavljaca.Click += new System.EventHandler(this.btnPretragaDobavljaca_Click);
            // 
            // btnPrikazDobavljaca
            // 
            this.btnPrikazDobavljaca.Location = new System.Drawing.Point(198, 278);
            this.btnPrikazDobavljaca.Name = "btnPrikazDobavljaca";
            this.btnPrikazDobavljaca.Size = new System.Drawing.Size(137, 40);
            this.btnPrikazDobavljaca.TabIndex = 10;
            this.btnPrikazDobavljaca.Text = "Prikaži dobavljača";
            this.btnPrikazDobavljaca.UseVisualStyleBackColor = true;
            this.btnPrikazDobavljaca.Click += new System.EventHandler(this.btnPrikazDobavljaca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(539, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PretragaDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(651, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrikazDobavljaca);
            this.Controls.Add(this.btnPretragaDobavljaca);
            this.Controls.Add(this.dgvDobavljaci);
            this.Controls.Add(this.txtNazivDobavljaca);
            this.Controls.Add(this.label1);
            this.Name = "PretragaDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Pretraga dobavljača";
            this.Load += new System.EventHandler(this.PretragaDobavljaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivDobavljaca;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private System.Windows.Forms.Button btnPretragaDobavljaca;
        private System.Windows.Forms.Button btnPrikazDobavljaca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}