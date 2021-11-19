using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kutuphane
    {

        public List<Kitap> Kitaps { get; set; } = new List<Kitap>();

        public void KitapEkle(Kitap kitap)
        {
            Kitaps.Add(kitap);
        }

        public void KitapSil()
        {
            Kitaps.Clear();
        }

        public string KitapListele()
        {
            string bilgi = " ";
            foreach (Kitap kitap in Kitaps)
            {
                bilgi += "Kitap ISBN: " + kitap.kitapOzellik.ISBN  +
                "Kitap Adı: " + kitap.kitapOzellik.KitapAdi + "Kitap Yazarı: " + kitap.kitapOzellik.Yazar;
                    
            }
            return bilgi;
        }


        //LİSTEYİ FORSUZ DÖNDÜRME DENEMESİ.(Hoca böyle yapmıştı ama bu çalışmıyor. Forla yapmak gerekiyor.)
        public List<Kitap> KitapListele2()
        {
            return Kitaps;
        }

    }
}
