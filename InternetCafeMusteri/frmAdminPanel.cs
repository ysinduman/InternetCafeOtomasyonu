using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Drawing;
using InternetCafe;
using DevExpress.Data;
using InternetCafeMusteri.Properties;

namespace InternetCafe
{
    public partial class frmAdminPanel : Form
    {
        public static SqlConnection con;
        private int selectedComputerId = -1;

        public frmAdminPanel()
        {
            InitializeComponent();
            if (frmAdminPanel.con == null)
            {
                frmAdminPanel.con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
            if (frmAdminPanel.con.State == ConnectionState.Closed)
            {
                frmAdminPanel.con.Open();
            }
            InitializeComputerButtons();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT hesapAdi, kalanSaniye / 60 as kalanDakika, sonGiris, kullanilanSure, email FROM tblMusteri";
                using (SqlCommand cmd = new SqlCommand(query, frmAdminPanel.con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    gridControl.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void InitializeComputerButtons()
        {
            for (int i = 1; i <= 10; i++)
            {
                Button btn = new Button
                {
                    Text = "Bilgisayar " + i,
                    Name = "btnComputer" + i,
                    Width = 100,
                    Height = 80,
                    BackColor = Color.Green // Varsayılan arka plan rengini yeşil yapıyoruz
                };

                // Arka plan resmini ayarlama
                btn.BackgroundImage = global::InternetCafeMusteri.Properties.Resources.pc;
                btn.BackgroundImageLayout = ImageLayout.Stretch; // Resmi butonun tamamına yaymak için

                btn.Click += new EventHandler(ComputerButton_Click);
                flowLayoutPanel1.Controls.Add(btn); // flowLayoutPanel1, butonların ekleneceği panel
            }
            LoadComputerStatus();
        }



        private void LoadComputerStatus()
        {
            try
            {
                string query = "SELECT masaId, masaDurumu, masaKullanicisi FROM tblBilgisayar";
                using (SqlCommand cmd = new SqlCommand(query, frmAdminPanel.con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        int masaId = (int)row["masaId"];
                        string masaDurumu = (string)row["masaDurumu"];
                        string masaKullanicisi = row["masaKullanicisi"].ToString();
                        Button btn = flowLayoutPanel1.Controls["btnComputer" + masaId] as Button;
                        if (btn != null)
                        {
                            btn.Text = "Bilgisayar " + masaId + " - " + masaKullanicisi;
                            btn.BackColor = masaDurumu == "Boş" ? Color.Green : Color.Red;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void ComputerButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                selectedComputerId = int.Parse(btn.Text.Split(' ')[1]);
            }
        }

        private void btnSureEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(txtHesapAdi.Text) && !string.IsNullOrEmpty(txtEklenenSure.Text))
                {
                    string hesapAdi = txtHesapAdi.Text;
                    int eklenenSure = int.Parse(txtEklenenSure.Text);

                    // Hesap adının `tblMusteri` tablosunda mevcut olup olmadığını kontrol edelim
                    string checkQuery = "SELECT COUNT(1) FROM tblMusteri WHERE hesapAdi = @hesapAdi";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, frmAdminPanel.con))
                    {
                        checkCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                        int userExists = (int)checkCmd.ExecuteScalar();

                        if (userExists == 1)
                        {
                            // Saatlik fiyatı veritabanından çekelim
                            string fiyatQuery = "SELECT TOP 1 birimFiyat FROM tblSaatlikFiyat ORDER BY gecerliTarih DESC";
                            decimal saatlikFiyat;
                            using (SqlCommand fiyatCmd = new SqlCommand(fiyatQuery, frmAdminPanel.con))
                            {
                                saatlikFiyat = (decimal)fiyatCmd.ExecuteScalar();
                            }

                            // Odeme kaydını ekleyelim
                            string odemeQuery = "INSERT INTO tblOdeme (hesapAdi, eklenenSure, toplamTutar) VALUES (@hesapAdi, @eklenenSure, @toplamTutar)";
                            using (SqlCommand odemeCmd = new SqlCommand(odemeQuery, frmAdminPanel.con))
                            {
                                odemeCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                                odemeCmd.Parameters.AddWithValue("@eklenenSure", eklenenSure);
                                odemeCmd.Parameters.AddWithValue("@toplamTutar", eklenenSure * saatlikFiyat);
                                odemeCmd.ExecuteNonQuery();
                            }

                            // Kârı hesaplayıp `tblKarRaporu` tablosuna kaydedelim
                            decimal kar = eklenenSure * saatlikFiyat;
                            string karRaporuQuery = "INSERT INTO tblKarRaporu (hesapAdi, eklenenSure, kar, tarihSaat) VALUES (@hesapAdi, @eklenenSure, @kar, @tarihSaat)";
                            using (SqlCommand karRaporuCmd = new SqlCommand(karRaporuQuery, frmAdminPanel.con))
                            {
                                karRaporuCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                                karRaporuCmd.Parameters.AddWithValue("@eklenenSure", eklenenSure);
                                karRaporuCmd.Parameters.AddWithValue("@kar", kar);
                                karRaporuCmd.Parameters.AddWithValue("@tarihSaat", DateTime.Now);
                                karRaporuCmd.ExecuteNonQuery();
                            }

                            // `tblMusteri` tablosunda kalanDakika güncelleme
                            string updateQuery = "UPDATE tblMusteri SET kalanSaniye = kalanSaniye + @eklenenSure * 60 WHERE hesapAdi = @hesapAdi";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, frmAdminPanel.con))
                            {
                                updateCmd.Parameters.AddWithValue("@eklenenSure", eklenenSure); // Dakika cinsinden hesaplama
                                updateCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                                updateCmd.ExecuteNonQuery();
                            }

                            LoadComputerStatus();
                            MessageBox.Show("Süre başarıyla eklendi.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz hesap adı.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hesap adı ve eklenen süre boş olmamalıdır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnMasayiAc_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedComputerId == -1)
                {
                    MessageBox.Show("Lütfen bir bilgisayar seçin.");
                    return;
                }

                Button selectedButton = flowLayoutPanel1.Controls["btnComputer" + selectedComputerId] as Button;
                if (selectedButton != null && selectedButton.BackColor == Color.Red)
                {
                    MessageBox.Show("Masa dolu.");
                    return;
                }

                if (!string.IsNullOrEmpty(txtEklenenSure.Text))
                {
                    string hesapAdi = string.IsNullOrEmpty(txtHesapAdi.Text) ? "Geçici" : txtHesapAdi.Text;
                    int acilanSure = int.Parse(txtEklenenSure.Text);

                    // Saatlik fiyatı veritabanından çekelim
                    string fiyatQuery = "SELECT TOP 1 birimFiyat FROM tblSaatlikFiyat ORDER BY gecerliTarih DESC";
                    decimal saatlikFiyat;
                    using (SqlCommand fiyatCmd = new SqlCommand(fiyatQuery, frmAdminPanel.con))
                    {
                        saatlikFiyat = (decimal)fiyatCmd.ExecuteScalar();
                    }

                    // Geçici müşteri olarak kaydedelim
                    string insertQuery = "INSERT INTO tblGeciciMusteri (girisSaati, kalanSure) VALUES (@girisSaati, @kalanSure)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, frmAdminPanel.con))
                    {
                        insertCmd.Parameters.AddWithValue("@girisSaati", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@kalanSure", acilanSure * 60); // Süreyi saniyeye çeviriyoruz
                        insertCmd.ExecuteNonQuery();
                    }

                    // Odeme kaydını ekleyelim
                    string odemeQuery = "INSERT INTO tblOdeme (hesapAdi, eklenenSure, toplamTutar) VALUES (@hesapAdi, @eklenenSure, @toplamTutar)";
                    using (SqlCommand odemeCmd = new SqlCommand(odemeQuery, frmAdminPanel.con))
                    {
                        odemeCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                        odemeCmd.Parameters.AddWithValue("@eklenenSure", acilanSure);
                        odemeCmd.Parameters.AddWithValue("@toplamTutar", acilanSure * saatlikFiyat);
                        odemeCmd.ExecuteNonQuery();
                    }

                    // Kârı hesaplayıp `tblKarRaporu` tablosuna kaydedelim
                    decimal kar = acilanSure * saatlikFiyat;
                    string karRaporuQuery = "INSERT INTO tblKarRaporu (hesapAdi, eklenenSure, kar, tarihSaat) VALUES (@hesapAdi, @eklenenSure, @kar, @tarihSaat)";
                    using (SqlCommand karRaporuCmd = new SqlCommand(karRaporuQuery, frmAdminPanel.con))
                    {
                        karRaporuCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                        karRaporuCmd.Parameters.AddWithValue("@eklenenSure", acilanSure);
                        karRaporuCmd.Parameters.AddWithValue("@kar", kar);
                        karRaporuCmd.Parameters.AddWithValue("@tarihSaat", DateTime.Now);
                        karRaporuCmd.ExecuteNonQuery();
                    }

                    // Bilgisayar durumunu güncelle ve buton arka plan rengini kırmızı yap
                    string updateComputerQuery = "UPDATE tblBilgisayar SET masaDurumu = 'Dolu', masaKullanicisi = @hesapAdi WHERE masaId = @masaId";
                    using (SqlCommand updateComputerCmd = new SqlCommand(updateComputerQuery, frmAdminPanel.con))
                    {
                        updateComputerCmd.Parameters.AddWithValue("@masaId", selectedComputerId);
                        updateComputerCmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                        updateComputerCmd.ExecuteNonQuery();

                        // Seçilen bilgisayar butonunun arka plan rengini kırmızı yap
                        selectedButton.BackColor = Color.Red;

                        // Belirtilen süre boyunca arka plan renginin kırmızı kalmasını sağlamak için bir timer kullanıyoruz
                        Timer timer = new Timer();
                        timer.Interval = acilanSure * 60000; // Süreyi milisaniye cinsinden ayarlıyoruz
                        timer.Tick += (s, args) =>
                        {
                            selectedButton.BackColor = Color.Green; // Süre dolduktan sonra rengi yeşil yap
                            timer.Stop(); // Timer'ı durduruyoruz
                        };
                        timer.Start();
                    }

                    LoadComputerStatus();
                    MessageBox.Show("Masa başarıyla açıldı.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Açılan süre boş olmamalıdır.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }




        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeniKullaniciFormu = new frmYeniKullanici();
            yeniKullaniciFormu.Show();
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = (GridView)sender;

            // Seçili satırdaki hesapAdi değerini alalım
            var hesapAdiValue = view.GetFocusedRowCellValue("hesapAdi");

            // hesapAdiValue null ise bir işlem yapalım
            if (hesapAdiValue != null)
            {
                string hesapAdi = hesapAdiValue.ToString();

                // txtHesapAdi TextEdit kontrolüne yazalım
                txtHesapAdi.Text = hesapAdi;
            }
            else
            {
                // hesapAdiValue null ise, uygun bir işlem yapalım (örneğin, uyarı mesajı gösterme)
                MessageBox.Show("Geçersiz hesap adı. Lütfen listede bulunan bir kullanıcı adı seçin.");
                txtHesapAdi.Text = string.Empty; // TextEdit'i temizleyelim
            }
        }


        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "kalanDakika")
            {
                GridView view = (GridView)sender;
                string hesapAdi = view.GetRowCellValue(e.RowHandle, "hesapAdi").ToString();
                int kalanDakika = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "kalanDakika"));

                string updateQuery = "UPDATE tblMusteri SET kalanSaniye = @kalanSaniye WHERE hesapAdi = @hesapAdi";
                using (SqlCommand cmd = new SqlCommand(updateQuery, frmAdminPanel.con))
                {
                    cmd.Parameters.AddWithValue("@kalanSaniye", kalanDakika * 60); // Dakika cinsinden saniyeye çeviriyoruz
                    cmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnKarRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT girisSaati, kalanSure FROM tblGeciciMusteri";
                SqlDataAdapter da = new SqlDataAdapter(query, frmAdminPanel.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                using (FileStream fs = new FileStream("KarRaporu.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    Paragraph title = new Paragraph("Kâr Raporu");
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);

                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("Giriş Saati");
                    table.AddCell("Kalan Süre (dk)");

                    foreach (DataRow row in dt.Rows)
                    {
                        table.AddCell(row["girisSaati"].ToString());
                        table.AddCell((Convert.ToInt32(row["kalanSure"]) / 60).ToString()); // Saniyeden dakikaya çeviriyoruz
                    }

                    doc.Add(table);
                    doc.Close();
                    writer.Close();
                }

                MessageBox.Show("Kâr raporu başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSaatlikUcretGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSaatlikUcret.Text))
                {
                    MessageBox.Show("Lütfen saatlik ücreti girin.");
                    return;
                }

                decimal yeniUcret = decimal.Parse(txtSaatlikUcret.Text);
                string updateQuery = "INSERT INTO tblSaatlikFiyat (birimFiyat, gecerliTarih) VALUES (@birimFiyat, @gecerliTarih)";
                using (SqlCommand cmd = new SqlCommand(updateQuery, frmAdminPanel.con))
                {
                    cmd.Parameters.AddWithValue("@birimFiyat", yeniUcret);
                    cmd.Parameters.AddWithValue("@gecerliTarih", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Saatlik ücret başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeniKullaniciFormu = new frmYeniKullanici();
            yeniKullaniciFormu.Show();
        }
        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            try
            {
                string hesapAdi = txtKullaniciSil.Text;

                if (!string.IsNullOrEmpty(hesapAdi))
                {
                    // Kullanıcıyı silme işlemi
                    string deleteQuery = "DELETE FROM tblMusteri WHERE hesapAdi = @hesapAdi";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, frmAdminPanel.con))
                    {
                        cmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kullanıcı başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı bulunamadı.");
                        }
                    }

                    // TextEdit kontrolünü temizleyelim
                    txtKullaniciSil.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcı adını girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
