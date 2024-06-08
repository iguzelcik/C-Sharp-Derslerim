using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama11_15122021_Interface_arayuz_cokluKalitim
{
    internal interface IKisiBilgileri
    {
        string AdSoyad { get; set; }
        string EPosta { get; set; }
        string Telefon { get; set; }
    }
}
