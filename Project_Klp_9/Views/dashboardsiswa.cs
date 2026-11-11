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
        private Model currentUser;
        private void DisplayUser(Model user)
        {
            if (user != null)
            {
                label4.Text = user.users;
                label12.Text = user.poinpelanggaran.ToString();
                label11.Text = user.poinjiwa.ToString();
            }
            else
            {
                label4.Text = "Anda Gagal Login";
                label12.Text = "0";
                label11.Text = "0";
            }

        }
        public dashboardsiswa()
        {
            InitializeComponent();
            currentUser = Program.currentUser;
            DisplayUser(currentUser);
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //nama siswa
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
