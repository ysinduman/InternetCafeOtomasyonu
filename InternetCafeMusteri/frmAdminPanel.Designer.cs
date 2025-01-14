namespace InternetCafe
{
    partial class frmAdminPanel
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPanel));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.txtEklenenSure = new System.Windows.Forms.TextBox();
            this.btnMasayiAc = new System.Windows.Forms.Button();
            this.btnSureEkle = new System.Windows.Forms.Button();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalanDakika = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanilanSure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSaatlikUcret = new System.Windows.Forms.TextBox();
            this.btnSaatlikUcretGuncelle = new System.Windows.Forms.Button();
            this.btnKarRaporu = new System.Windows.Forms.Button();
            this.txtKullaniciSil = new DevExpress.XtraEditors.TextEdit();
            this.btnKullaniciSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblcontsure = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSil.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.CadetBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1078, 87);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesapAdi.Location = new System.Drawing.Point(837, 200);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(217, 34);
            this.txtHesapAdi.TabIndex = 1;
            // 
            // txtEklenenSure
            // 
            this.txtEklenenSure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenenSure.Location = new System.Drawing.Point(837, 267);
            this.txtEklenenSure.Name = "txtEklenenSure";
            this.txtEklenenSure.Size = new System.Drawing.Size(217, 34);
            this.txtEklenenSure.TabIndex = 2;
            // 
            // btnMasayiAc
            // 
            this.btnMasayiAc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMasayiAc.FlatAppearance.BorderSize = 0;
            this.btnMasayiAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasayiAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasayiAc.Location = new System.Drawing.Point(837, 307);
            this.btnMasayiAc.Name = "btnMasayiAc";
            this.btnMasayiAc.Size = new System.Drawing.Size(103, 47);
            this.btnMasayiAc.TabIndex = 3;
            this.btnMasayiAc.Text = "Masayı Aç";
            this.btnMasayiAc.UseVisualStyleBackColor = false;
            this.btnMasayiAc.Click += new System.EventHandler(this.btnMasayiAc_Click);
            // 
            // btnSureEkle
            // 
            this.btnSureEkle.BackColor = System.Drawing.Color.Aqua;
            this.btnSureEkle.FlatAppearance.BorderSize = 0;
            this.btnSureEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSureEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSureEkle.Location = new System.Drawing.Point(946, 307);
            this.btnSureEkle.Name = "btnSureEkle";
            this.btnSureEkle.Size = new System.Drawing.Size(108, 47);
            this.btnSureEkle.TabIndex = 4;
            this.btnSureEkle.Text = "Süre Ekle";
            this.btnSureEkle.UseVisualStyleBackColor = false;
            this.btnSureEkle.Click += new System.EventHandler(this.btnSureEkle_Click);
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridControl.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridControl.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.gridControl.Location = new System.Drawing.Point(12, 200);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(776, 200);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.ColumnFilterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridView.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHesapAdi,
            this.colKalanDakika,
            this.colSonGiris,
            this.colKullanilanSure,
            this.colEmail});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_CellValueChanged);
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.Caption = "Hesap Adı";
            this.colHesapAdi.FieldName = "hesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 0;
            // 
            // colKalanDakika
            // 
            this.colKalanDakika.Caption = "Kalan Dakika";
            this.colKalanDakika.FieldName = "kalanDakika";
            this.colKalanDakika.Name = "colKalanDakika";
            this.colKalanDakika.Visible = true;
            this.colKalanDakika.VisibleIndex = 1;
            // 
            // colSonGiris
            // 
            this.colSonGiris.Caption = "Son Giriş";
            this.colSonGiris.FieldName = "sonGiris";
            this.colSonGiris.Name = "colSonGiris";
            this.colSonGiris.Visible = true;
            this.colSonGiris.VisibleIndex = 2;
            // 
            // colKullanilanSure
            // 
            this.colKullanilanSure.Caption = "Kullanılan Süre";
            this.colKullanilanSure.FieldName = "kullanilanSure";
            this.colKullanilanSure.Name = "colKullanilanSure";
            this.colKullanilanSure.Visible = true;
            this.colKullanilanSure.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // txtSaatlikUcret
            // 
            this.txtSaatlikUcret.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaatlikUcret.Location = new System.Drawing.Point(308, 145);
            this.txtSaatlikUcret.Name = "txtSaatlikUcret";
            this.txtSaatlikUcret.Size = new System.Drawing.Size(100, 34);
            this.txtSaatlikUcret.TabIndex = 6;
            // 
            // btnSaatlikUcretGuncelle
            // 
            this.btnSaatlikUcretGuncelle.BackColor = System.Drawing.Color.Maroon;
            this.btnSaatlikUcretGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaatlikUcretGuncelle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaatlikUcretGuncelle.Location = new System.Drawing.Point(414, 141);
            this.btnSaatlikUcretGuncelle.Name = "btnSaatlikUcretGuncelle";
            this.btnSaatlikUcretGuncelle.Size = new System.Drawing.Size(217, 40);
            this.btnSaatlikUcretGuncelle.TabIndex = 7;
            this.btnSaatlikUcretGuncelle.Text = "Saatlik Ücreti Güncelle";
            this.btnSaatlikUcretGuncelle.UseVisualStyleBackColor = false;
            this.btnSaatlikUcretGuncelle.Click += new System.EventHandler(this.btnSaatlikUcretGuncelle_Click);
            // 
            // btnKarRaporu
            // 
            this.btnKarRaporu.BackColor = System.Drawing.Color.Green;
            this.btnKarRaporu.FlatAppearance.BorderSize = 0;
            this.btnKarRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarRaporu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarRaporu.Location = new System.Drawing.Point(12, 141);
            this.btnKarRaporu.Name = "btnKarRaporu";
            this.btnKarRaporu.Size = new System.Drawing.Size(210, 40);
            this.btnKarRaporu.TabIndex = 8;
            this.btnKarRaporu.Text = "Kâr Raporu";
            this.btnKarRaporu.UseVisualStyleBackColor = false;
            this.btnKarRaporu.Click += new System.EventHandler(this.btnKarRaporu_Click);
            // 
            // txtKullaniciSil
            // 
            this.txtKullaniciSil.Location = new System.Drawing.Point(12, 414);
            this.txtKullaniciSil.Name = "txtKullaniciSil";
            this.txtKullaniciSil.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSil.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciSil.Size = new System.Drawing.Size(328, 26);
            this.txtKullaniciSil.TabIndex = 10;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnKullaniciSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSil.Appearance.Options.UseBackColor = true;
            this.btnKullaniciSil.Appearance.Options.UseFont = true;
            this.btnKullaniciSil.Location = new System.Drawing.Point(357, 412);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(191, 29);
            this.btnKullaniciSil.TabIndex = 11;
            this.btnKullaniciSil.Text = "Kullanıcıyı Sil";
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYeniKullanici.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKullanici.Appearance.Options.UseBackColor = true;
            this.btnYeniKullanici.Appearance.Options.UseFont = true;
            this.btnYeniKullanici.Location = new System.Drawing.Point(866, 388);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(150, 43);
            this.btnYeniKullanici.TabIndex = 9;
            this.btnYeniKullanici.Text = "Yeni Kullanıcı Ekle";
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "backgrounds1.jpg");
            this.ımageList1.Images.SetKeyName(1, "pc.png");
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(836, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 20);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Kullanıcı Adı";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // lblcontsure
            // 
            this.lblcontsure.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcontsure.Appearance.Options.UseFont = true;
            this.lblcontsure.Location = new System.Drawing.Point(837, 241);
            this.lblcontsure.Name = "lblcontsure";
            this.lblcontsure.Size = new System.Drawing.Size(79, 20);
            this.lblcontsure.TabIndex = 12;
            this.lblcontsure.Text = "Süre (DK)";
            // 
            // frmAdminPanel
            // 
            this.BackgroundImage = global::InternetCafeMusteri.Properties.Resources.backgrounds1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 464);
            this.Controls.Add(this.lblcontsure);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtKullaniciSil);
            this.Controls.Add(this.btnKullaniciSil);
            this.Controls.Add(this.btnYeniKullanici);
            this.Controls.Add(this.btnKarRaporu);
            this.Controls.Add(this.btnSaatlikUcretGuncelle);
            this.Controls.Add(this.txtSaatlikUcret);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnSureEkle);
            this.Controls.Add(this.btnMasayiAc);
            this.Controls.Add(this.txtEklenenSure);
            this.Controls.Add(this.txtHesapAdi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmAdminPanel";
            this.Text = "Admin Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciSil.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DevExpress.XtraEditors.SimpleButton btnKullaniciSil;
        private DevExpress.XtraEditors.TextEdit txtKullaniciSil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.TextBox txtEklenenSure;
        private System.Windows.Forms.Button btnMasayiAc;
        private System.Windows.Forms.Button btnSureEkle;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.TextBox txtSaatlikUcret;
        private System.Windows.Forms.Button btnSaatlikUcretGuncelle;
        private System.Windows.Forms.Button btnKarRaporu;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullanici;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanDakika;
        private DevExpress.XtraGrid.Columns.GridColumn colSonGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanilanSure;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblcontsure;
    }
}
