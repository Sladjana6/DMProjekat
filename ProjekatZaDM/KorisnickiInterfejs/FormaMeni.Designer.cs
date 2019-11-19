namespace KorisnickiInterfejs
{
    partial class FormaMeni
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaMeni));
            this.panelMeni = new System.Windows.Forms.Panel();
            this.btnNarudzbenica = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDobavljac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPomeranje = new System.Windows.Forms.Panel();
            this.btnPretragaNarudzbenice = new System.Windows.Forms.Button();
            this.btnUnosNarudzbenice = new System.Windows.Forms.Button();
            this.btnPretragaDobavljaca = new System.Windows.Forms.Button();
            this.btnUnosDobavljaca = new System.Windows.Forms.Button();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lblPoruka = new System.Windows.Forms.Label();
            this.panelMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelPomeranje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeni
            // 
            this.panelMeni.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMeni.Controls.Add(this.btnNarudzbenica);
            this.panelMeni.Controls.Add(this.btnDobavljac);
            this.panelMeni.Controls.Add(this.bunifuImageButton1);
            this.panelAnimator.SetDecoration(this.panelMeni, BunifuAnimatorNS.DecorationType.None);
            this.panelMeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeni.Location = new System.Drawing.Point(0, 0);
            this.panelMeni.Name = "panelMeni";
            this.panelMeni.Size = new System.Drawing.Size(173, 334);
            this.panelMeni.TabIndex = 11;
            // 
            // btnNarudzbenica
            // 
            this.btnNarudzbenica.Activecolor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNarudzbenica.BackColor = System.Drawing.Color.Transparent;
            this.btnNarudzbenica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNarudzbenica.BorderRadius = 5;
            this.btnNarudzbenica.ButtonText = "   Narudžbenica";
            this.btnNarudzbenica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnNarudzbenica, BunifuAnimatorNS.DecorationType.None);
            this.btnNarudzbenica.DisabledColor = System.Drawing.Color.Gray;
            this.btnNarudzbenica.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNarudzbenica.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNarudzbenica.Iconimage = global::KorisnickiInterfejs.Properties.Resources.icons8_purchase_order_50;
            this.btnNarudzbenica.Iconimage_right = null;
            this.btnNarudzbenica.Iconimage_right_Selected = null;
            this.btnNarudzbenica.Iconimage_Selected = null;
            this.btnNarudzbenica.IconMarginLeft = 0;
            this.btnNarudzbenica.IconMarginRight = 0;
            this.btnNarudzbenica.IconRightVisible = true;
            this.btnNarudzbenica.IconRightZoom = 0D;
            this.btnNarudzbenica.IconVisible = true;
            this.btnNarudzbenica.IconZoom = 65D;
            this.btnNarudzbenica.IsTab = false;
            this.btnNarudzbenica.Location = new System.Drawing.Point(0, 164);
            this.btnNarudzbenica.Name = "btnNarudzbenica";
            this.btnNarudzbenica.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNarudzbenica.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnNarudzbenica.OnHoverTextColor = System.Drawing.Color.MidnightBlue;
            this.btnNarudzbenica.selected = false;
            this.btnNarudzbenica.Size = new System.Drawing.Size(173, 56);
            this.btnNarudzbenica.TabIndex = 6;
            this.btnNarudzbenica.Text = "   Narudžbenica";
            this.btnNarudzbenica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNarudzbenica.Textcolor = System.Drawing.Color.Black;
            this.btnNarudzbenica.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarudzbenica.Click += new System.EventHandler(this.btnNarudzbenica_Click);
            // 
            // btnDobavljac
            // 
            this.btnDobavljac.Activecolor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDobavljac.BackColor = System.Drawing.Color.Transparent;
            this.btnDobavljac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDobavljac.BorderRadius = 5;
            this.btnDobavljac.ButtonText = "   Dobavljač";
            this.btnDobavljac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.btnDobavljac, BunifuAnimatorNS.DecorationType.None);
            this.btnDobavljac.DisabledColor = System.Drawing.Color.Gray;
            this.btnDobavljac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDobavljac.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDobavljac.Iconimage = global::KorisnickiInterfejs.Properties.Resources.icons8_supplier_50;
            this.btnDobavljac.Iconimage_right = null;
            this.btnDobavljac.Iconimage_right_Selected = null;
            this.btnDobavljac.Iconimage_Selected = null;
            this.btnDobavljac.IconMarginLeft = 0;
            this.btnDobavljac.IconMarginRight = 0;
            this.btnDobavljac.IconRightVisible = true;
            this.btnDobavljac.IconRightZoom = 0D;
            this.btnDobavljac.IconVisible = true;
            this.btnDobavljac.IconZoom = 65D;
            this.btnDobavljac.IsTab = false;
            this.btnDobavljac.Location = new System.Drawing.Point(0, 111);
            this.btnDobavljac.Name = "btnDobavljac";
            this.btnDobavljac.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDobavljac.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDobavljac.OnHoverTextColor = System.Drawing.Color.MidnightBlue;
            this.btnDobavljac.selected = false;
            this.btnDobavljac.Size = new System.Drawing.Size(173, 56);
            this.btnDobavljac.TabIndex = 5;
            this.btnDobavljac.Text = "   Dobavljač";
            this.btnDobavljac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDobavljac.Textcolor = System.Drawing.Color.Black;
            this.btnDobavljac.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobavljac.Click += new System.EventHandler(this.btnDobavljac_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::KorisnickiInterfejs.Properties.Resources.icons8_menu_24;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(128, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(32, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(616, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 334);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::KorisnickiInterfejs.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(6, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.panel2.Controls.Add(this.panelPomeranje);
            this.panelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 334);
            this.panel2.TabIndex = 13;
            // 
            // panelPomeranje
            // 
            this.panelPomeranje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPomeranje.BackColor = System.Drawing.Color.Transparent;
            this.panelPomeranje.Controls.Add(this.lblPoruka);
            this.panelPomeranje.Controls.Add(this.btnPretragaNarudzbenice);
            this.panelPomeranje.Controls.Add(this.btnUnosNarudzbenice);
            this.panelPomeranje.Controls.Add(this.btnPretragaDobavljaca);
            this.panelPomeranje.Controls.Add(this.btnUnosDobavljaca);
            this.panelAnimator.SetDecoration(this.panelPomeranje, BunifuAnimatorNS.DecorationType.None);
            this.panelPomeranje.Location = new System.Drawing.Point(31, 74);
            this.panelPomeranje.Name = "panelPomeranje";
            this.panelPomeranje.Size = new System.Drawing.Size(397, 213);
            this.panelPomeranje.TabIndex = 1;
            // 
            // btnPretragaNarudzbenice
            // 
            this.panelAnimator.SetDecoration(this.btnPretragaNarudzbenice, BunifuAnimatorNS.DecorationType.None);
            this.btnPretragaNarudzbenice.Location = new System.Drawing.Point(231, 139);
            this.btnPretragaNarudzbenice.Name = "btnPretragaNarudzbenice";
            this.btnPretragaNarudzbenice.Size = new System.Drawing.Size(147, 59);
            this.btnPretragaNarudzbenice.TabIndex = 16;
            this.btnPretragaNarudzbenice.Text = "Pretraga narudžbenice";
            this.btnPretragaNarudzbenice.UseVisualStyleBackColor = true;
            this.btnPretragaNarudzbenice.Visible = false;
            this.btnPretragaNarudzbenice.Click += new System.EventHandler(this.btnPretragaNarudzbenice_Click);
            // 
            // btnUnosNarudzbenice
            // 
            this.panelAnimator.SetDecoration(this.btnUnosNarudzbenice, BunifuAnimatorNS.DecorationType.None);
            this.btnUnosNarudzbenice.Location = new System.Drawing.Point(32, 139);
            this.btnUnosNarudzbenice.Name = "btnUnosNarudzbenice";
            this.btnUnosNarudzbenice.Size = new System.Drawing.Size(147, 59);
            this.btnUnosNarudzbenice.TabIndex = 15;
            this.btnUnosNarudzbenice.Text = "Unos narudžbenice";
            this.btnUnosNarudzbenice.UseVisualStyleBackColor = true;
            this.btnUnosNarudzbenice.Visible = false;
            this.btnUnosNarudzbenice.Click += new System.EventHandler(this.btnUnosNarudzbenice_Click_1);
            // 
            // btnPretragaDobavljaca
            // 
            this.panelAnimator.SetDecoration(this.btnPretragaDobavljaca, BunifuAnimatorNS.DecorationType.None);
            this.btnPretragaDobavljaca.Location = new System.Drawing.Point(216, 15);
            this.btnPretragaDobavljaca.Name = "btnPretragaDobavljaca";
            this.btnPretragaDobavljaca.Size = new System.Drawing.Size(147, 59);
            this.btnPretragaDobavljaca.TabIndex = 14;
            this.btnPretragaDobavljaca.Text = "Pretraga dobavljača";
            this.btnPretragaDobavljaca.UseVisualStyleBackColor = true;
            this.btnPretragaDobavljaca.Visible = false;
            this.btnPretragaDobavljaca.Click += new System.EventHandler(this.btnPretragaDobavljaca_Click);
            // 
            // btnUnosDobavljaca
            // 
            this.panelAnimator.SetDecoration(this.btnUnosDobavljaca, BunifuAnimatorNS.DecorationType.None);
            this.btnUnosDobavljaca.Location = new System.Drawing.Point(32, 15);
            this.btnUnosDobavljaca.Name = "btnUnosDobavljaca";
            this.btnUnosDobavljaca.Size = new System.Drawing.Size(147, 59);
            this.btnUnosDobavljaca.TabIndex = 13;
            this.btnUnosDobavljaca.Text = "Unos dobavljača";
            this.btnUnosDobavljaca.UseVisualStyleBackColor = true;
            this.btnUnosDobavljaca.Visible = false;
            this.btnUnosDobavljaca.Click += new System.EventHandler(this.btnUnosDobavljaca_Click);
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.panelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation4;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.panelAnimator.SetDecoration(this.lblPoruka, BunifuAnimatorNS.DecorationType.None);
            this.lblPoruka.Font = new System.Drawing.Font("Georgia", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.Location = new System.Drawing.Point(45, 68);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(318, 43);
            this.lblPoruka.TabIndex = 17;
            this.lblPoruka.Text = "DOBRO DOŠLI!";
            // 
            // FormaMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 334);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMeni);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "FormaMeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[DM] Glavni meni";
            this.Load += new System.EventHandler(this.FormaMeni_Load);
            this.panelMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelPomeranje.ResumeLayout(false);
            this.panelPomeranje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeni;
        private Bunifu.Framework.UI.BunifuFlatButton btnNarudzbenica;
        private Bunifu.Framework.UI.BunifuFlatButton btnDobavljac;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.Panel panelPomeranje;
        private System.Windows.Forms.Button btnUnosDobavljaca;
        private System.Windows.Forms.Button btnPretragaDobavljaca;
        private System.Windows.Forms.Button btnUnosNarudzbenice;
        private System.Windows.Forms.Button btnPretragaNarudzbenice;
        private System.Windows.Forms.Label lblPoruka;
    }
}