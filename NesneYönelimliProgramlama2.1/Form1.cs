using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneYönelimliProgramlama2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("Mühendis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal prs2 = new Personal(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text), comboBox1.Text);

            if (comboBox1.Text == "İşçi")
            {
                MessageBox.Show(prs2.ucretHesapla().ToString());
            }
            else
            {
                prs2.ucretHesapla(1000);
            }
         


           /* Personal prs1 = new Personal();
            prs1.Ad = adTxt.Text;
            prs1.Adres = adresTxt.Text;
            prs1.Yas = Convert.ToInt32(yasTxt.Text);
            MessageBox.Show("Ad =" + prs1.Ad + "\nAdres =" + prs1.Adres + "\nYaş =" + prs1.Yas);
           */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
        

        }

     
    

