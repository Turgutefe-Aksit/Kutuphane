using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap
    {

        public KitapOzellik kitapOzellik { get; set; }  //bu aggracation tanımlama 
        //eğer  = new KitapOzellik olarak tanımlasaydık composition olurdu. ve buttonun içinde tekrardan
        // bir kitap özellik tanımlamamıza gerek kalmazdı.
        public DateTime AlisTarih { get; set; }
        public DateTime IadeTarihi { get; set; }

    }
}
