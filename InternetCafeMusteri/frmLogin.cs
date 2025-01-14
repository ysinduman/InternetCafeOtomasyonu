using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace InternetCafe
{
    public partial class frmLogin : Form
    {
        public static string hesapAdi;
        public static SqlConnection con;

        public frmLogin()
        {
            InitializeComponent();
            if (con == null)
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30");
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(1) FROM tblMusteri WHERE hesapAdi=@hesapAdi AND sifre=@sifre";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@hesapAdi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                hesapAdi = txtKullaniciAdi.Text;
                frmKalanZaman kalanZamanFormu = new frmKalanZaman();
                kalanZamanFormu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            frmAdminLogin adminLoginFormu = new frmAdminLogin();
            adminLoginFormu.ShowDialog();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bilgisayarı kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Bilgisayarı kapatmak için shutdown komutunu çağırın
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}
