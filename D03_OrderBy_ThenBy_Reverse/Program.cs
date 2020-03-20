using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_OrderBy_ThenBy_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciler = OgrenciListesi();

            var sonuc1 = from s in ogrenciler
                         orderby s.Yas, s.Ad descending
                         select s;

            var sonuc2 = ogrenciler.OrderBy(x => x.Ad.Length & x.Yas);


            var sonuc3 = ogrenciler.OrderByDescending(x => x.Ad.Length);


            var sonuc5 = ogrenciler.OrderBy(x => x.Ad).ThenBy(s => s.Yas); // ikinci sıralama için ThenBy kullanılabilir.


            var sonuc6 = ogrenciler.OrderByDescending(x => x.Ad).ThenByDescending(s => s.Yas); // ikinci sıralama için ThenBy kullanılabilir.

            /*Listeyi ters çevirme Reverse*/
            var sonuc7 = (from s in ogrenciler
                          orderby s.Yas
                          select s).Reverse();

            var sonuc8 = ogrenciler.OrderBy(x => x.Yas).Reverse();


            foreach (var product in sonuc8)
            {
                Console.WriteLine("Adı: " + product.Ad + " - Soyadı: " + product.Soyad + " - Yaşı: " + product.Yas);
            }

            Console.ReadLine();
        }

        private static IList<Ogrenci> OgrenciListesi()
        {
            IList<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci { Id = 1, Ad = "Yıldırım", Soyad = "BEYAZID", Yas = 20 },
                new Ogrenci { Id = 2, Ad = "Orhan", Soyad = "KAYA", Yas = 19 },
                new Ogrenci { Id = 2, Ad = "MAHMUT", Soyad = "GÜNAY", Yas = 22 },
                new Ogrenci { Id = 2, Ad = "Hüseyin", Soyad = "ER", Yas = 25 }
            };
            return ogrenciler;
        }

        public class Ogrenci
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }
        }
    }
}
