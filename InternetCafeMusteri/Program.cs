using System;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace InternetCafe
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin.con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yasin\Documents\InternetCafeDB.mdf;Integrated Security=True;Connect Timeout=30");
            frmLogin.con.Open();
            Application.Run(new frmLogin());
        }
    }
}
