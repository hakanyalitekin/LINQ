using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06_Any_All_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Linq ile Koleksiyonlarda veri var mı kontrolü All, Any, Contains metotları ile yapılır ve bool olarak geriye döner.
             * Kayıt var ise True, yok ise False döner.
             * 
             * Any() -> Liste içerisinde birtane bile var mı?
             * All() -> Liste içerisinde tümünde var mı?
             * Contains() -> İçeriyor mu?
             * 
             * Any-Contains farkı https://www.hikmetokumus.com/makale/155/linq-ile-contains-ve-any-metodlarini-kullanarak-in-sorgusu-olusturmak
             */


            /********************** Any() ************************/

            /*
             * Any() anahtar sözcüğü koleksiyonda bulunan verilerin olup olmadığını kontrol eder.
             * System.Linq namespace kütüphanesinde bulunur.
             * Any() anahtar sözcüğü ile yazılan lambda sorgusunda koşul ifadeleri yazılabilir. Geriye dönen değerler true yada false dir.
             */

            int[] sayilar = { 15, 21, 58, 44, 12, 14 };
            var sonuc1 = sayilar.Any();
            var sonuc2 = sayilar.Any(x => x == 10);
            var sonuc3 = sayilar.Any(x => x == 21);
            var sonuc4 = sayilar.Any(x => x == 44 || x == 78);
            var sonuc5 = sayilar.Any(x => x > 55);

            Console.WriteLine("-----------------Any Çıktısı------------");

            Console.WriteLine("Koleksiyonda en az bir kayıt var) " + sonuc1);
            Console.WriteLine("Koleksiyonda koşulu sağlayan değer yok -> " + sonuc2);
            Console.WriteLine("Koleksiyonda koşulu sağlayan değer var -> " + sonuc3);
            Console.WriteLine("Koleksiyonda koşulu sağlayan en az bir değer var -> " + sonuc4);
            Console.WriteLine("Koleksiyonda koşulu sağlayan değer var -> " + sonuc5);






            /********************** Contains() ************************/

            /*
             * Contains() anahtar sözcüğü koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.
             * System.Linq namespace kütüphanesinde bulunur.
             * Dönen değer tipi boolean'dır(true, false). 
             */
            bool sonuc6 = sayilar.Contains(25);
            Console.WriteLine("-----------------Contains Çıktısı------------");

            Console.WriteLine("Koleksiyonda 25 rakamı var -> " + sonuc6);




            /********************** All() ************************/

            /*All() anahtar sözcüğü ile koleksiyonda bulunan tüm veriler içerisinde belirlenen koşullara göre kayıt olup olmadığını döner.
             * Geriye dönen değer true ise kayıt var, false ise kayıt yok anlamındadır.*/


            string[] languages = { "French", "English", "Russian", "Chinese" };

            var sonuc7 = languages.All(x => x == "French");
            var sonuc8 = languages.All(x => x.StartsWith("R"));
            var sonuc9 = languages.All(x => x.Contains("n"));
            Console.WriteLine("-----------------All Çıktısı------------");

            Console.WriteLine("Koleksiyonun tümü elemanları French mi? -> " + sonuc7);
            Console.WriteLine("Koleksiyonun tümü elemanları R ile mi başlıyor? -> " + sonuc8);
            Console.WriteLine("Koleksiyonun tümü elemanları n içeriyor mu? -> " + sonuc9);
            Console.ReadLine();


        }
    }
}
