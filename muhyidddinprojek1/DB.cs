using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace muhyidddinprojek1
{
    class DB
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username=root; password=; database=db_muhyiddin");
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;
        public static DataSet ds = new DataSet();

        public static void crud(string kueri)
        {
            Console.WriteLine(kueri);
            ds.Tables.Clear();
            perintah = new MySqlCommand(kueri, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
        public static void form21(Form f1, Panel p1)
        {
            p1.Controls.Clear();
            f1.TopLevel = false;
            p1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            f1.Show();
        }
    }
}