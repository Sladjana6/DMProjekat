namespace KorisnickiInterfejs
{
    partial class PretragaNarudzbenica
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
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPretraziNarudzbenice = new System.Windows.Forms.Button();
            this.btnPrikazNarudzbenice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(104, 25);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(142, 21);
            this.cmbDobavljac.TabIndex = 1;
            this.cmbDobavljac.SelectedIndexChanged += new System.EventHandler(this.cmbDobavljac_SelectedIndexChanged);
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.AllowUserToAddRows = false;
            this.dgvNarudzbenice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(27, 36);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.RowHeadersVisible = false;
            this.dgvNarudzbenice.Size = new System.Drawing.Size(626, 184);
            this.dgvNarudzbenice.TabIndex = 2;
            this.dgvNarudzbenice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbenice_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNarudzbenice);
            this.groupBox1.Location = new System.Drawing.Point(29, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narudžbenice odabranog dobavljača";
            // 
            // btnPretraziNarudzbenice
            // 
            this.btnPretraziNarudzbenice.Location = new System.Drawing.Point(295, 15);
            this.btnPretraziNarudzbenice.Name = "btnPretraziNarudzbenice";
            this.btnPretraziNarudzbenice.Size = new System.Drawing.Size(138, 38);
            this.btnPretraziNarudzbenice.TabIndex = 5;
            this.btnPretraziNarudzbenice.Text = "Pretraži narudžbenice";
            this.btnPretraziNarudzbenice.UseVisualStyleBackColor = true;
            this.btnPretraziNarudzbenice.Click += new System.EventHandler(this.btnPretraziNarudzbenice_Click);
            // 
            // btnPrikazNarudzbenice
            // 
            this.btnPrikazNarudzbenice.Location = new System.Drawing.Point(295, 334);
            this.btnPrikazNarudzbenice.Name = "btnPrikazNarudzbenice";
            this.btnPrikazNarudzbenice.Size = new System.Drawing.Size(138, 38);
            this.btnPrikazNarudzbenice.TabIndex = 6;
            this.btnPrikazNarudzbenice.Text = "Prikaži narudžbenicu";
            this.btnPrikazNarudzbenice.UseVisualStyleBackColor = true;
            this.btnPrikazNarudzbenice.Click += new System.EventHandler(this.btnPrikazNarudzbenice_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(759, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // PretragaNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(871, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrikazNarudzbenice);
            this.Controls.Add(this.btnPretraziNarudzbenice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "PretragaNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Pretraga narudžbenica";
            this.Load += new System.EventHandler(this.PretragaNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraziNarudzbenice;
        private System.Windows.Forms.Button btnPrikazNarudzbenice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}