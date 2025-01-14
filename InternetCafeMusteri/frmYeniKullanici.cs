using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetCafe
{
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    string query = "INSERT INTO tblMusteri (hesapAdi, sifre, email, kalanDakika, sonGiris, kullanilanSure) VALUES (@hesapAdi, @sifre, @Email, @kalanDakika, @sonGiris, @kullanilanSure)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@hesapAdi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@kalanDakika", 120); // 120 dakika başlangıç süresi 
                    cmd.Parameters.AddWithValue("@sonGiris", DateTime.Now); // Şu anki zamanı alıyor
                    cmd.Parameters.AddWithValue("@kullanilanSure", 0); // Başlangıçta kullanılan süre 0
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yeni kullanıcı başarıyla eklendi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
