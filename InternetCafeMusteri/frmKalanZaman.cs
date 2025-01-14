using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace InternetCafe
{
    public partial class frmKalanZaman : Form
    {
        private Timer timer;
        private int kalanSaniye;

        public frmKalanZaman()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Load += new EventHandler(frmKalanZaman_Load);
            LoadUserData(frmLogin.hesapAdi);
        }

        private void frmKalanZaman_Load(object sender, EventArgs e)
        {
            // Ekranın boyutlarını al
            Rectangle workingArea = Screen.GetWorkingArea(this);

            // Formun konumunu ayarla (sağ alt köşe)
            this.Location = new Point(workingArea.Right - this.Width, workingArea.Bottom - this.Height);

            // MasaId 1 olan masanın durumunu DOLU olarak güncelleme
            try
            {
                string query = "UPDATE tblBilgisayar SET masadurumu = 'DOLU' WHERE masaId = 1";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void LoadUserData(string hesapAdi)
        {
            try
            {
                if (frmLogin.con.State == System.Data.ConnectionState.Closed)
                {
                    frmLogin.con.Open();
                }

                string query = "SELECT kalanSaniye, kullanilanSure, sonGiris FROM tblMusteri WHERE hesapAdi = @hesapAdi";
                SqlCommand cmd = new SqlCommand(query, frmLogin.con);
                cmd.Parameters.AddWithValue("@hesapAdi", hesapAdi);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblKullaniciAdi.Text = $"Kullanıcı Adı: {hesapAdi}";
                    kalanSaniye = Convert.ToInt32(reader["kalanSaniye"]);
                    lblKullanilanSure.Text = $"Kullanılan Süre: {reader["kullanilanSure"]}";
                    lblSonGiris.Text = $"Son Giriş: {reader["sonGiris"]}";

                    UpdateKalanSure();
                    InitializeTimer();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void UpdateKalanSure()
        {
            int dakika = kalanSaniye / 60;
            int saniye = kalanSaniye % 60;
            lblKalanSure.Text = $"Kalan Süre: {dakika} dk {saniye} sn";
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (kalanSaniye > 0)
            {
                kalanSaniye--;
                UpdateKalanSure();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Süreniz doldu.");

                // Veritabanındaki kalanDakika değerini 0 olarak ayarlama
                try
                {
                    string query = "UPDATE tblMusteri SET kalanDakika = 0 WHERE hesapAdi = @hesapAdi";
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@hesapAdi", frmLogin.hesapAdi); // Kullanıcının hesap adını buraya ekleyin
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            frmSifreDegistir sifreDegistirFormu = new frmSifreDegistir();
            sifreDegistirFormu.ShowDialog();
        }

        private void frmKalanZaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer?.Stop();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Kalan dakikayı hesaplamak için kalan saniyeyi dakika cinsine çevirin
                    int kalanDakika = kalanSaniye / 60;

                    // Veritabanına kalan dakika ve masanın durumunu güncelleyin
                    string updateKalanDakikaQuery = "UPDATE tblMusteri SET kalanDakika = @kalanDakika WHERE hesapAdi = @hesapAdi";
                    string updateMasaDurumQuery = "UPDATE tblBilgisayar SET masadurumu = 'BOŞ' WHERE masaId = 1";

                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(updateKalanDakikaQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@kalanDakika", kalanDakika);
                            cmd.Parameters.AddWithValue("@hesapAdi", frmLogin.hesapAdi); // Kullanıcının hesap adını buraya ekleyin
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand(updateMasaDurumQuery, con))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kalan dakika ve masa durumu başarıyla güncellendi.");
                    }

                    // Formu kapatın
                    this.Close();
                    frmLogin login = new frmLogin();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void lblKullanilanSure_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
