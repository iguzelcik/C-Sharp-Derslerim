using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5_16122021_FormUygulamasi
{
    class Sinema
    {
        int toplamKoltukSayisi;
        int bosKoltukSayisi;
        double bakiye;
        string salonNo;

        const double TAM = 15.0;
        const double INDIRIMLI = 10.0;

        public Sinema(string salon, int koltuksayi) //Yapıcı-Kurucu Metot Constructor
        {
            toplamKoltukSayisi = koltuksayi;
            salonNo = salon;
            bosKoltukSayisi = toplamKoltukSayisi;
            bakiye = 0;

        }

        ~Sinema() //Deconstructor: Classsın işi bitmeden önce çalışan metod
        {

        }

        public void BiletSat(bool indirimli) //Bilet Satış
        {
            bosKoltukSayisi--; //bosKoltukSayisi=bosKoltukSayisi-1
            if (indirimli)
                bakiye += INDIRIMLI; //bakiye=bakiye+INDIRIMLI
            else
                bakiye += TAM;
        }

        public void BiletIptal(bool indirimli) //Bilet İade
        {
            bosKoltukSayisi++;
            if (indirimli)
                bakiye -= INDIRIMLI;
            else
                bakiye -= TAM;
        }

        public int BosKoltukOgren() //Boş koltuk Sayısı
        {
            return bosKoltukSayisi;
        }

        public double BakiyeOgren() //Bakiye Öğren
        {
            return bakiye;
        }

    }
}
