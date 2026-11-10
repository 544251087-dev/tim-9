using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Bcpg;
using Project_Klp_9.Models;
using Project_Klp_9.Presenter;

namespace Project_Klp_9.Views
{
    public partial class dashboardsiswa : Form
    {
        private Model CurrentUser;
        public dashboardsiswa()
        {
            InitializeComponent();        }

        private void dashboardsiswa_Load(Model user)
        {
            if (user.role == "siswa")
            {
                label11.Text = user.poinjiwa.ToString(); // Menampilkan poin jiwa
                label12.Text = user.poinpelanggaran.ToString(); // Menampilkan poin pelanggaran
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Label untuk poin jiwa
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Label untuk poin pelanggaran
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Hasil Poin Pelanggaran
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Hasil Poin Jiwa
            
        }
    }
}
