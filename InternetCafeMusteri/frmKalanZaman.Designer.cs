namespace InternetCafe
{
    partial class frmKalanZaman
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblKalanSure;
        private DevExpress.XtraEditors.LabelControl lblKullanilanSure;
        private DevExpress.XtraEditors.LabelControl lblSonGiris;
        private DevExpress.XtraEditors.SimpleButton btnSifreDegistir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblKalanSure = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanilanSure = new DevExpress.XtraEditors.LabelControl();
            this.lblSonGiris = new DevExpress.XtraEditors.LabelControl();
            this.btnSifreDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(13, 261);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(138, 25);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanSure.Appearance.Options.UseFont = true;
            this.lblKalanSure.Location = new System.Drawing.Point(13, 294);
            this.lblKalanSure.Margin = new System.Windows.Forms.Padding(4);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(121, 25);
            this.lblKalanSure.TabIndex = 1;
            this.lblKalanSure.Text = "Kalan Süre:";
            // 
            // lblKullanilanSure
            // 
            this.lblKullanilanSure.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanilanSure.Appearance.Options.UseFont = true;
            this.lblKullanilanSure.Location = new System.Drawing.Point(13, 327);
            this.lblKullanilanSure.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullanilanSure.Name = "lblKullanilanSure";
            this.lblKullanilanSure.Size = new System.Drawing.Size(163, 25);
            this.lblKullanilanSure.TabIndex = 2;
            this.lblKullanilanSure.Text = "Kullanılan Süre:";
            this.lblKullanilanSure.Click += new System.EventHandler(this.lblKullanilanSure_Click);
            // 
            // lblSonGiris
            // 
            this.lblSonGiris.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonGiris.Appearance.Options.UseFont = true;
            this.lblSonGiris.Location = new System.Drawing.Point(13, 360);
            this.lblSonGiris.Margin = new System.Windows.Forms.Padding(4);
            this.lblSonGiris.Name = "lblSonGiris";
            this.lblSonGiris.Size = new System.Drawing.Size(99, 25);
            this.lblSonGiris.TabIndex = 3;
            this.lblSonGiris.Text = "Son Giriş:";
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Appearance.BackColor = System.Drawing.Color.Blue;
            this.btnSifreDegistir.Appearance.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifreDegistir.Appearance.Options.UseBackColor = true;
            this.btnSifreDegistir.Appearance.Options.UseFont = true;
            this.btnSifreDegistir.Location = new System.Drawing.Point(5, 403);
            this.btnSifreDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(133, 37);
            this.btnSifreDegistir.TabIndex = 4;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternetCafeMusteri.Properties.Resources.kullanici_resim;
            this.pictureBox1.Location = new System.Drawing.Point(79, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::InternetCafeMusteri.Properties.Resources.powerbutton;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(301, 388);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 59);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmKalanZaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 453);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.lblSonGiris);
            this.Controls.Add(this.lblKullanilanSure);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.lblKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKalanZaman";
            this.Opacity = 0.7D;
            this.Text = "Kullanıcı Bilgileri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKalanZaman_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCikis;
    }
}