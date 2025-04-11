using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FinalProject_vispro
{
    public partial class Form6 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string query;
        public Form6()
        {
            koneksi = new MySqlConnection("server=localhost; database=db_GG; username=root; password=;");
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Mengambil username yang login dari Form1
            string loggedInUsername = Form1.loggedInUsername; 

            // Ambil data profil user dari database
            query = string.Format("SELECT * FROM tbl_user WHERE username = '{0}'", loggedInUsername);
            ds.Clear();
            
            koneksi.Open();
            perintah = new MySqlCommand(query, koneksi);
            adapter = new MySqlDataAdapter(perintah);
            perintah.ExecuteNonQuery();
            adapter.Fill(ds);
            koneksi.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string username = row["username"].ToString();
                string namaLengkap = row["nama_lengkap"].ToString(); // Kolom yang sesuai dengan nama lengkap

                // Menampilkan nama lengkap dan username pengguna di label atau kontrol lain
                lblUsername.Text = username;
                lblNama.Text = namaLengkap;
            }
            else
            {
                MessageBox.Show("Profil tidak ditemukan.");
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
