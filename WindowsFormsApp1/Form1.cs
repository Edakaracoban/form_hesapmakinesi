using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txt_1.Text);
            sayi2 = Convert.ToDouble(txt_2.Text);
            sonuc=sayi1 + sayi2;
            lbl_4.Text=sonuc.ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txt_1.Text);
            sayi2 = Convert.ToDouble(txt_2.Text);
            sonuc = sayi1 - sayi2;
            lbl_4.Text = sonuc.ToString();

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txt_1.Text);
            sayi2 = Convert.ToDouble(txt_2.Text);
            if (sayi2!=0)
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                MessageBox.Show("0'a bölüm işlemi tanımsızdır.");
            }
         
            lbl_4.Text = sonuc.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            sayi1 = Convert.ToDouble(txt_1.Text);
            sayi2 = Convert.ToDouble(txt_2.Text);
            sonuc = sayi1 *sayi2;
            lbl_4.Text = sonuc.ToString();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
