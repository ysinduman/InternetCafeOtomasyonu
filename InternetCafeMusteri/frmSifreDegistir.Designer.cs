namespace InternetCafe
{
    partial class frmSifreDegistir
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtEskiSifre;
        private DevExpress.XtraEditors.TextEdit txtYeniSifre;
        private DevExpress.XtraEditors.TextEdit txtYeniSifreOnay;
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
            this.btnSifreDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYeniSifreOnay = new DevExpress.XtraEditors.TextEdit();
            this.txtYeniSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtEskiSifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Location = new System.Drawing.Point(13, 144);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(53, 16);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Eski Şifre";
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSifreDegistir.Appearance.Options.UseBackColor = true;
            this.btnSifreDegistir.Location = new System.Drawing.Point(42, 342);
            this.btnSifreDegistir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(239, 28);
            this.btnSifreDegistir.TabIndex = 4;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 206);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Yeni Şifre";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 268);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Yeni Şifreyi Onaylayın";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternetCafeMusteri.Properties.Resources.changepwd;
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtYeniSifreOnay
            // 
            this.txtYeniSifreOnay.Location = new System.Drawing.Point(13, 292);
            this.txtYeniSifreOnay.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniSifreOnay.Name = "txtYeniSifreOnay";
            this.txtYeniSifreOnay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifreOnay.Properties.Appearance.Options.UseFont = true;
            this.txtYeniSifreOnay.Properties.UseSystemPasswordChar = true;
            this.txtYeniSifreOnay.Size = new System.Drawing.Size(304, 30);
            this.txtYeniSifreOnay.TabIndex = 3;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(13, 230);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniSifre.Properties.Appearance.Options.UseFont = true;
            this.txtYeniSifre.Properties.UseSystemPasswordChar = true;
            this.txtYeniSifre.Size = new System.Drawing.Size(304, 30);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(13, 168);
            this.txtEskiSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEskiSifre.Properties.Appearance.Options.UseFont = true;
            this.txtEskiSifre.Properties.UseSystemPasswordChar = true;
            this.txtEskiSifre.Size = new System.Drawing.Size(304, 30);
            this.txtEskiSifre.TabIndex = 1;
            // 
            // frmSifreDegistir
            // 
            this.Appearance.BackColor = System.Drawing.Color.Red;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 383);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.txtYeniSifreOnay);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtEskiSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSifreDegistir";
            this.Text = "Şifre Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifreOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeniSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEskiSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
