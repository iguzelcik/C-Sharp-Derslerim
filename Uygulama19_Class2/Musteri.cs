using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3_14122021
{
    internal class Musteri
    {
        public string Ad;
        public string Soyad;
        private string kimlikNo;
        private string vize1;

        public string Vize1Puan
        {
            get
            {
                return vize1;
            }
            set
            { //value.ToString() --> Convert.toString(value)
                if (Convert.ToDouble(value)>=0 && Convert.ToDouble(value) <= 100)
                {
                    vize1 = value;
                }
                else
                {
                    vize1 = "Vize Puanı uygun değil";
                }
            }

        }

        public string KimlikNumarasi { 
            get
            { 
                return kimlikNo; 
            } 
            set
            { //value.ToString() --> Convert.toString(value)
                if (value.ToString().Length != 11)
                {
                    kimlikNo = "Kimlik Numarası Uygun değil";
                }
                else
                {
                     kimlikNo=value;
                }
            } 
        
        }

    }
}
