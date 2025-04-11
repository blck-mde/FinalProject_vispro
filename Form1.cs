using System;
using System.Collections;
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
    public partial class Form1: Form
    {
        public static string loggedInUsername;
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_GG; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            formSignUp formsignup = new formSignUp();
            formsignup.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_user where username = '{0}'", txtUsername.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["password"].ToString();
                        if (sandi == txtPassword.Text)
                        {
                            loggedInUsername = kolom["username"].ToString(); // Menyimpan username yang login
                            FormRegist formregist = new FormRegist();
                            formregist.Show();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
