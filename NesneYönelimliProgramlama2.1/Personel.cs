using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesneYönelimliProgramlama2._1
{
    internal class Personal
    {
       
        public Personal(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;
            
        }

        string unvan;
        public string Unvan
          { get { return unvan; }
            set { unvan = value; }
        }
        int mesai;
        public int Mesai
        {
            get { return mesai; }
            set { mesai = value; }
        }

        public int ucretHesapla()
        {
            return this.mesai * 100;
        }

        public void ucretHesapla(int ekUcret)
        {
            int odenecek = this.mesai * 100 + ekUcret;
            MessageBox.Show(odenecek.ToString());
        }
            
            string ad;
            public string Ad
        {
            get { return ad; }
            set { ad = value; }
        
        }


            string adres;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        int yas;

        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }
            

    }
}
