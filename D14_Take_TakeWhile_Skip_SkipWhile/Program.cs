using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_Take_TakeWhile_Skip_SkipWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Take
             * Take() anahtar sözcüğü koleksiyon içerisinden listelenecek olan veri adedini belirtir.
             * Sql Sorgu cümleciğinde Top() anahtar sözcüğüne eş değerdir.
             */

            var sayilar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sonuc1 = sayilar.Take(5);
            foreach (var item in sonuc1)
            {
                Console.WriteLine("Take() -> " + item);
            }

            /*  TakeWhile   
             *TakeWhile() anahtar sözcüğü Koleksiyon da bulunan verilerin, belirlenen koşul neticesinde listelenmesini sağlar.
            */
            var sonuc2 = sayilar.TakeWhile(x => x < 4);
            foreach (var item in sonuc2)
            {
                Console.WriteLine("TakeWhile() -> " + item);
            }

            /*
             * Skip
             * Skip() anahtar sözcüğü koleksiyon içerisinde bulunan verilerin başlangıç index'ini belirler. Belirlenen index numarasından sonraki verileri getirir.
             */
            var sonuc3 = sayilar.Skip(5);
            foreach (var item in sonuc3)
            {
                Console.WriteLine("Skip() -> " + item);
            }

            /* SkipWhile()
             * Koleksiyonda bulunan verilerin ekrana getirilme index'inin belirlenen koşula göre çalıştıran metotdur.
             */
            var sonuc4 = sayilar.SkipWhile(x=>x < 1);
            foreach (var item in sonuc4)
            {
                Console.WriteLine("SkipWhile() -> " + item);
            }

                                //******************* SAYFALAMA ÖRNEĞİ ******************
            int SayfaBasinaKayitSayisi = 4;
            int SayfaNumarasi = 0;
            do
            {
                Console.WriteLine("1 - 4 arası sayfa numarası giriniz.");
                if (int.TryParse(Console.ReadLine(), out SayfaNumarasi))
                {
                    if (SayfaNumarasi > 0 && SayfaNumarasi < 5)
                    {
                        var calisanlar = Calisan.GetAllEmployees().Skip((SayfaNumarasi - 1) * SayfaBasinaKayitSayisi).Take(SayfaBasinaKayitSayisi).ToList();
                        Console.WriteLine();
                        Console.WriteLine("Sayfa Numarası: " + SayfaNumarasi);
                        foreach (var emp in calisanlar)
                        {
                            Console.WriteLine($"ID : {emp.ID}, İsim : {emp.Ad}, Departman : {emp.Departman}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir sayfa numarası giriniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir sayfa numarası giriniz.");
                }
            } while (true);
        

        }
    }
}
