using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Soru2 : Form
    {
        public Soru2()
        {
            InitializeComponent();
        }

        private void Soru2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sayılar();
        }

        void Sayılar()
        {
            int numberOfRandom = 10;
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < numberOfRandom; i++)
            {
                randomNumbers.Add(rnd.Next());
            }
            foreach (int i in randomNumbers)
            {
                listBox1.Items.Add(i.ToString());
            }
        }
        void inceleme()
        {
            String path = "C:/Users/User/Desktop/Sınav.txt";
            if(File.Exists(@path)){                    
                Console.WriteLine("That path exists already.");
                return;
            }
            else
            {
                FileStream yaz = new FileStream(@path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(yaz);
                foreach (var listBoxItem in listBox1.Items)
                {
                    if (Convert.ToInt32(listBoxItem) % 5 == 0 || Convert.ToInt32(listBoxItem) % 4 == 0)
                    {
                        sw.WriteLine(listBoxItem.ToString());
                    }
                }
                sw.Close();
                yaz.Close();
            }      
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            inceleme();
        }
    }
}
