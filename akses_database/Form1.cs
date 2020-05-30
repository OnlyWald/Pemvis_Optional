using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akses_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"SERVER=localhost; Port=1433;Userid=postgres; Password=widiant0; Database=DVDRental";
            NpgsqlConnection koneksi = new NpgsqlConnection(constring);
            try
            {
                koneksi.Open();
                MessageBox.Show("Koneksi Berhasil");
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show("Koneksi Gagal"+ex.Message);
            }
        }

    }
}
