using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Data;

namespace InternetCafe
{
    public partial class frmSifreDegistir : DevExpress.XtraEditors.XtraForm
    {
        public frmSifreDegistir()
        {
            InitializeComponent();
            string hesapAdi = frmLogin.hesapAdi.ToUpper();
            this.Text = hesapAdi;
            lblKullaniciAdi.Text = hesapAdi;
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            // Bağlantı nesnesinin başlatıldığından ve açıldığından emin olun
            if (frmAdminPanel.con == null)
            {
                frmAdminPanel.con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30");
            }

            if (frmAdminPanel.con.State == ConnectionState.Closed)
            {
                frmAdminPanel.con.Open();
            }

            if (txtYeniSifre.Text == txtYeniSifreOnay.Text)
            {
                string query = "UPDATE tblMusteri SET sifre=@yeniSifre WHERE hesapAdi=@hesapAdi AND sifre=@eskiSifre";
                SqlCommand cmd = new SqlCommand(query, frmAdminPanel.con);
                cmd.Parameters.AddWithValue("@yeniSifre", txtYeniSifre.Text);
                cmd.Parameters.AddWithValue("@eskiSifre", txtEskiSifre.Text);
                cmd.Parameters.AddWithValue("@hesapAdi", frmLogin.hesapAdi);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eski şifre yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Yeni şifreler eşleşmiyor.");
            }
        }
    }
}
