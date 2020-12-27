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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Name = "Ahmet";
            accounting.Surname = "Yener";
            accounting.Age = 30;
            accounting.City = "Istanbul";
            accounting.Gender = "Male";

            accounting.Show();
            accounting.ShowAccounting();

            accounting.DisplaySalary = true;
            accounting.ArrangeSalary = true;

            listBox1.Items.Add(accounting.Name);
            listBox1.Items.Add(accounting.Surname);
            listBox1.Items.Add(accounting.Gender);
            listBox1.Items.Add(accounting.City);
            listBox1.Items.Add(accounting.Age);
            listBox1.Items.Add(accounting.DisplaySalary);
            listBox1.Items.Add(accounting.ArrangeSalary);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            HumanResource human = new HumanResource();

            human.Name = "Sıla";
            human.Surname = "Demirkol";
            human.Age = 25;
            human.City = "İzmir";
            human.Gender = "Female";

            human.Show();
            human.ShowAccounting();

            human.CanHirePerson = true;
            human.CanSetAFee = true;

            listBox2.Items.Add(human.Name);
            listBox2.Items.Add(human.Surname);
            listBox2.Items.Add(human.Gender);
            listBox2.Items.Add(human.City);
            listBox2.Items.Add(human.Age);
            listBox2.Items.Add(human.CanHirePerson);
            listBox2.Items.Add(human.CanSetAFee);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TechnicalService technical = new TechnicalService();

            technical.Name = "Atilla";
            technical.Surname = "Gülsuyu";
            technical.Age = 30;
            technical.City = "Istanbul";
            technical.Gender = "Male";

            technical.Show();

            technical.TechnicalSupport = true;

            listBox3.Items.Add(technical.Name);
            listBox3.Items.Add(technical.Surname);
            listBox3.Items.Add(technical.Gender);
            listBox3.Items.Add(technical.City);
            listBox3.Items.Add(technical.Age);
            listBox3.Items.Add(technical.TechnicalSupport);
        }
    }
}
