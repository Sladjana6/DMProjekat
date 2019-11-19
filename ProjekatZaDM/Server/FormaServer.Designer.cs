namespace Server
{
    partial class FormaServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaServer));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnZaustavi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPokreni = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(98)))), ((int)(((byte)(135)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(116)))), ((int)(((byte)(145)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(155)))), ((int)(((byte)(196)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(572, 292);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btnZaustavi);
            this.bunifuGradientPanel2.Controls.Add(this.btnPokreni);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(161)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(572, 292);
            this.bunifuGradientPanel2.TabIndex = 5;
            this.bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.Activecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZaustavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(46)))), ((int)(((byte)(32)))));
            this.btnZaustavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZaustavi.BorderRadius = 5;
            this.btnZaustavi.ButtonText = "   Zaustavi server";
            this.btnZaustavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaustavi.DisabledColor = System.Drawing.Color.Gray;
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnZaustavi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnZaustavi.Iconimage = global::Server.Properties.Resources.iconfinder_button_stop_85593;
            this.btnZaustavi.Iconimage_right = null;
            this.btnZaustavi.Iconimage_right_Selected = null;
            this.btnZaustavi.Iconimage_Selected = null;
            this.btnZaustavi.IconMarginLeft = 0;
            this.btnZaustavi.IconMarginRight = 0;
            this.btnZaustavi.IconRightVisible = true;
            this.btnZaustavi.IconRightZoom = 0D;
            this.btnZaustavi.IconVisible = true;
            this.btnZaustavi.IconZoom = 65D;
            this.btnZaustavi.IsTab = false;
            this.btnZaustavi.Location = new System.Drawing.Point(300, 101);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(46)))), ((int)(((byte)(32)))));
            this.btnZaustavi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(36)))), ((int)(((byte)(22)))));
            this.btnZaustavi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnZaustavi.selected = false;
            this.btnZaustavi.Size = new System.Drawing.Size(171, 56);
            this.btnZaustavi.TabIndex = 5;
            this.btnZaustavi.Text = "   Zaustavi server";
            this.btnZaustavi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaustavi.Textcolor = System.Drawing.Color.Black;
            this.btnZaustavi.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click_1);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Activecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPokreni.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPokreni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPokreni.BorderRadius = 5;
            this.btnPokreni.ButtonText = "   Pokreni server";
            this.btnPokreni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPokreni.DisabledColor = System.Drawing.Color.Gray;
            this.btnPokreni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPokreni.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPokreni.Iconimage = global::Server.Properties.Resources.icons8_start_50__2_;
            this.btnPokreni.Iconimage_right = null;
            this.btnPokreni.Iconimage_right_Selected = null;
            this.btnPokreni.Iconimage_Selected = null;
            this.btnPokreni.IconMarginLeft = 0;
            this.btnPokreni.IconMarginRight = 0;
            this.btnPokreni.IconRightVisible = true;
            this.btnPokreni.IconRightZoom = 0D;
            this.btnPokreni.IconVisible = true;
            this.btnPokreni.IconZoom = 65D;
            this.btnPokreni.IsTab = false;
            this.btnPokreni.Location = new System.Drawing.Point(78, 101);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnPokreni.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPokreni.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPokreni.selected = false;
            this.btnPokreni.Size = new System.Drawing.Size(168, 56);
            this.btnPokreni.TabIndex = 4;
            this.btnPokreni.Text = "   Pokreni server";
            this.btnPokreni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPokreni.Textcolor = System.Drawing.Color.Black;
            this.btnPokreni.TextFont = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Server.Properties.Resources._1280px_Dm_drogerie_Logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(460, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormaServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(214)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(572, 292);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "FormaServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " [DM] Server";
            this.Load += new System.EventHandler(this.FormaServer_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnZaustavi;
        private Bunifu.Framework.UI.BunifuFlatButton btnPokreni;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

