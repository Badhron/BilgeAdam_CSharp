using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void btnPI_Click(object sender, EventArgs e)
        {
            string pi = Math.PI.ToString();
            MessageBox.Show(pi);
        }

        private void btnABS_Click(object sender, EventArgs e)
        {
            int MutlakDeger = Math.Abs(-45);
            MessageBox.Show(MutlakDeger.ToString());
        }

        private void btnFLOOR_Click(object sender, EventArgs e)
        {
            //Floor => Verilen ondalikli degeri, bir alt tam degere tamamlar...
            double deger = Math.Floor(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnCEILING_Click(object sender, EventArgs e)
        {
            //Ceiling => Verilen ondalikli degeri, bir ust tam degere tamamlar...
            double deger = Math.Ceiling(12.98);
            MessageBox.Show(deger.ToString());
        }

        private void btnROUND_Click(object sender, EventArgs e)
        {
            //Round => Sayinin yarisindan fazlasini bir uste, yarisindan azini ise bir alttaki tam sayiya yuvarlar...

            //NOT : .'dan önceki sayı çift ise bir alt değere, tek ise bir üst değere tamamlar. (NOT: .'dan sonraki değer 50 ise)


            double deger = Math.Round(13.50);

            MessageBox.Show(deger.ToString());
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Truncate => Sayının ondalikli kismina bakmaz, yalnizca tam kismini size teslim eder...
            double deger = Math.Truncate(13.98);
            MessageBox.Show(deger.ToString());
        }


        private void btnMAX_Click(object sender, EventArgs e)
        {
            int maksimumdeger = Math.Max(66, 65);
            MessageBox.Show(maksimumdeger.ToString());
        }

        private void btnMIN_Click(object sender, EventArgs e)
        {
            int minimumDeger = Math.Min(45, 65);
            MessageBox.Show(minimumDeger.ToString());
        }

        private void btnPOW_Click(object sender, EventArgs e)
        {
            //Pow => Kuvvet alma islemlerini gerceklestirir. Ilk parametrede hangi sayinin kuvveti alinacak, ikinci parametrede ise o sayinin kacinci kuvveti alinacak diye sorar...
            double kuvvet = Math.Pow(5, 2);
            MessageBox.Show(kuvvet.ToString());
        }

        private void btnSQRT_Click(object sender, EventArgs e)
        {
            //Sqrt => Bir sayının karekokunu hesaplamak icin kullanilir...
            double deger = Math.Sqrt(16);
            MessageBox.Show(deger.ToString());
        }


        private void btnSIGN_Click(object sender, EventArgs e)
        {
            //SIGN => Bir sayinin negatif, pozitif ya da 0'a esit olup olmadigiyla ilgili bildirim doner...
            //Eger sayi negatifse -1, pozitifse +1, 0 ise size 0 degerini doner...
            int sonuc = Math.Sign(-25);
            MessageBox.Show(sonuc.ToString());
        }

        private void btnMinimumDeger_Click(object sender, EventArgs e)
        {
            //Disaridan girilen 3 sayidan en kucugunu tek satirda gosteriniz...

            int birinciDeger = Convert.ToInt32(txtBirinci.Text);
            int ikinciDeger = Convert.ToInt32(txtIkinci.Text);
            int ucuncuDeger = Convert.ToInt32(txtUcuncu.Text);

            int minDeger = Math.Min(Math.Min(birinciDeger, ikinciDeger), ucuncuDeger);

            //Math.Max(ucuncuDeger, Math.Max(birinciDeger, ikinciDeger));

            MessageBox.Show("En küçük değer; " + minDeger);
        }
    }
}
