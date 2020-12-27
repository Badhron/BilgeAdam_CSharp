using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        string OrnekMetin; // global değişken

        private void btnCONTAINS_Click(object sender, EventArgs e)
        {
            //Contains => Aradıgınz char ya da string deger, arama yaptiginiz metinsel ifade icerisinde gecmekte mi gecmemekte mi cevabini size "bool" olarak dondurur..
            OrnekMetin = txtGirisAlani.Text;
            bool varMi = OrnekMetin.Contains("ada m"); // bilgeadam

            //if (varMi == true)
            //{
            //    MessageBox.Show("Aradığınız değer bulunmaktadır!");
            //}
            //else
            //{
            //    MessageBox.Show("Aradığınız değer bulunmamaktadır!");
            //}

            MessageBox.Show(varMi ? "Aradığınız değer bulunmaktadır!" : "Aradığınız değer bulunmamaktadır!");
        }

        private void btnSTARTSWITH_Click(object sender, EventArgs e)
        {
            //StartsWith => Kelimenizin parametrede gonderdiginiz degerle baslayip baslamadigini size "bool" olarak dondurur...
            OrnekMetin = txtGirisAlani.Text.ToUpper();
            bool sonuc = OrnekMetin.StartsWith("bil");
            MessageBox.Show(sonuc ? "Kelime \"bil\" ile başlamaktadır." : "Kelime \"bil\" ile başlamamaktadır!");

            //bool sonuc = OrnekMetin.StartsWith("TR");
            //MessageBox.Show(sonuc ? "Doğru" : "Yanlış");
        }

        private void btnENDSWITH_Click(object sender, EventArgs e)
        {
            //EndsWith => Kelimenizin parametrede gonderdiginiz degerle bitip bitmedigini size "bool" olarak dondurur...
            OrnekMetin = txtGirisAlani.Text;
            MessageBox.Show(OrnekMetin.EndsWith("dam dan dak") ? "Kelime \"dam\" ile bitmektedir." : "Kelime \"dam\" ile bitmemektedir!");

            //if (OrnekMetin.EndsWith("adam") || OrnekMetin.EndsWith("bilge"))
            //{
            //    MessageBox.Show("Doğru");
            //}
            //else
            //{
            //    MessageBox.Show("Yanlş");
            //}
        }

        private void btnINDEXOF_Click(object sender, EventArgs e)
        {
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...


            // indeks numarasını soldan sağa doğru sayar.

            // belirttiğiniz ifadeyi bulurken soldan sağa doğru bir bakma işlemi yapar


            OrnekMetin = txtGirisAlani.Text;
            int index = OrnekMetin.IndexOf('g'); // bilgeadam -> Bunun için g harfi geçiyor mu ?
            MessageBox.Show(index.ToString());
        }

        private void btnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            //LastIndexOf => Dizilerde gordugumuz metodun ayni prensibiyle calisir. Eger harf varsa harfin indexini, yoksa - 1 degerini, harf birden fazla varsa son harfin indexini dondurur...

            // indeks numarasını soldan sağa doğru sayar.

            // belirttiğiniz ifadeyi bulurken sağdan sola doğru bir bakma işlemi yapar

            OrnekMetin = txtGirisAlani.Text;
            int index = OrnekMetin.LastIndexOf('t');
            MessageBox.Show(index.ToString());
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            //NOT => Bir string uzerinde yaptiginiz degisiklikler o string'i degistirmez, size yeni bir kopyasini teslim eder...

            //Remove (1.Kullanım) => Verdiginiz index numarasi dahil, o indexteki ve sonraki tum karakterleri ortadan kaldirir...

            //Remove (2.Kullanım) => Verdiginiz index numarasi dahil, o indexteki elemandan baslayarak, ikinci parametrede gonderdiginiz deger kadar eleman siler...

            OrnekMetin = txtGirisAlani.Text;
            //OrnekMetin = OrnekMetin.Remove(5); ;//=> BİRİNCİ KULLANIM
            OrnekMetin = OrnekMetin.Remove(3, 5);         // => İKİNCİ KULLANIM
            MessageBox.Show(OrnekMetin);
        }


        private void btnREPLACE_Click(object sender, EventArgs e)
        {
            //Replace => Metniniz icerisindeki bir karakteri ya da bir bolumu yeni bir karakter - bolum - ile degistirmenize olanak saglar..
            OrnekMetin = txtGirisAlani.Text;
            OrnekMetin = OrnekMetin.Replace("adam", "kadın");
            MessageBox.Show(OrnekMetin);
        }

        private void btnSPLIT_Click(object sender, EventArgs e)
        {
            //Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza olanak saglayan metottur. Ayni anda birden fazla ozel karakter de verebilirsiniz...
            string mailAdresleri = txtGirisAlani.Text;
            string[] adresler = mailAdresleri.Split('/');
            //string[] adresler = mailAdresleri.Split(';', ',');
            foreach (string st in adresler) // { "deneme", "test", "sonuc" }
            {
                MessageBox.Show(st);
            }
        }


        private void btnINSERT_Click(object sender, EventArgs e)
        {
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten önce ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...
            OrnekMetin = txtGirisAlani.Text;
            OrnekMetin = OrnekMetin.Insert(5, "lik");
            MessageBox.Show(OrnekMetin);
        }


        private void btnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            //ToLower => İlgili metnin tamamını küçük harfe çevirmenize olanak saglar.. Bilgeadam -> bilgeadam
            //ToUpper => İlgili metnin tamamini buyuk harfe cevirmenize olanak saglar.. BİLGEADAM
            OrnekMetin = txtGirisAlani.Text;
            MessageBox.Show("Küçük Harfe Dönüştü " + OrnekMetin.ToLower());
            MessageBox.Show("Büyük Harfe Dönüştü " + OrnekMetin.ToUpper());
        }


        private void btnSUBSTRING_Click(object sender, EventArgs e)
        {
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..

            OrnekMetin = txtGirisAlani.Text;
            //OrnekMetin = OrnekMetin.Substring(3);         // => 1.KULLANIM
            OrnekMetin = OrnekMetin.Substring(3, 2);       //=> 2.KULLANIM
            MessageBox.Show(OrnekMetin);
        }

        private void btnTOCHARARRAY_Click(object sender, EventArgs e)
        {
            //ToCharArray => Stringinizi charlarina ayirarak size char[] olarak teslim eder...
            OrnekMetin = txtGirisAlani.Text;
            char[] karakterler = OrnekMetin.ToCharArray();

            //ORNEK: disaridan girilen metindeki her bir karakterin ASCII degerleri toplami kactir?
            int havuz = 0;
            for (int index = 0; index < karakterler.Length; index++)
            {
                havuz += karakterler[index];
            }
            MessageBox.Show(havuz.ToString());
        }

        private void btnTRIM_Click(object sender, EventArgs e)
        {
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur...
            OrnekMetin = txtGirisAlani.Text;
            string YeniDeger = OrnekMetin.Trim();
            //MessageBox.Show(YeniDeger);
            MessageBox.Show(string.Format("Boşluklarla Hesaplanan Karakter Sayısı: {0}\nBoşluklar Temizlenip Hesaplanan Karakter Sayısı: {1}", OrnekMetin.Length, YeniDeger.Length));
            // MessageBox.Show($"Boşluklarla Hesaplanan Karakter Sayısı : {OrnekMetin}\nBoşluklar Temizlenip Hesaplanan Karakter Sayısı : {YeniDeger.Length}");
        }

        private void txtGirisAlani_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
