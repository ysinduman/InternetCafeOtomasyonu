using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetCafe
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            // Sorguda sütun adlarını doğru kullanalım
            string query = "SELECT COUNT(1) FROM tblAdmin WHERE adminAdi=@adminAdi AND sifre=@sifre";
            SqlCommand cmd = new SqlCommand(query, frmLogin.con);
            cmd.Parameters.AddWithValue("@adminAdi", txtAdminAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtAdminSifre.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 1)
            {
                frmAdminPanel adminPanelFormu = new frmAdminPanel();
                adminPanelFormu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Admin adı veya şifre yanlış.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
