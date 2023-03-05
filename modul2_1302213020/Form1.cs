using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302213020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int hasilKalkulator = 0;
        private string kalkulatorLabel = "";
        private void nol_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 0;
            hasil.Text = kalkulatorLabel;
        }

        private void satu_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 1;
            hasil.Text = kalkulatorLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (this.kalkulatorLabel != "") {
                this.hasilKalkulator += int.Parse(hasil.Text);
            }
            this.kalkulatorLabel = "";
            hasil.Text = "0";
        }

        private void sama_dengan_Click(object sender, EventArgs e)
        {
            if (this.kalkulatorLabel != "")
            {
                this.hasilKalkulator += int.Parse(this.kalkulatorLabel);
            }
            this.kalkulatorLabel = "";
            hasil.Text = this.hasilKalkulator.ToString();
        }

        private void dua_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 2;
            hasil.Text = kalkulatorLabel;
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 3;
            hasil.Text = kalkulatorLabel;
        }

        private void empat_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 4;
            hasil.Text = kalkulatorLabel;
        }

        private void lima_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 5;
            hasil.Text = kalkulatorLabel;
        }

        private void enam_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 6;
            hasil.Text = kalkulatorLabel;
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 7;
            hasil.Text = kalkulatorLabel;
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 8;
            hasil.Text = kalkulatorLabel;
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            this.kalkulatorLabel += 9;
            hasil.Text = kalkulatorLabel;
        }
    }
}
