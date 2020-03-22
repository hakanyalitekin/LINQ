using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13_DefaultIfEmpty_Range_Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            // DefaultIfEmpty
            List<int> sayilar = new List<int>() { };
            IEnumerable<int> sonuc = sayilar.DefaultIfEmpty(3); //Liste boşya default değer olarak normalde 0 dönen fakat 3 dönsün isteniyorsa.
            foreach (int num in sonuc)
            {
                Console.WriteLine(num);
            }



            // Repeat
            /*
             * Repeat() anahtar sözcüğü, Yenilenen değerleri belirtilen adette bir koleksiyonda listelenmesini sağlar.
             * Bu değerler tekrarlananacak olan kayıtlardır. Repeat() anahtar sözcüğünde birinci argüman tekrarlanacak olan kelime,
             * ikinci argüman ise kaç defa tekrarlanacağı sayısını ifade eder.
             */
            string ay = "Ocak";
            var sonuc2 = Enumerable.Repeat(ay, 2);
            foreach (var item in sonuc2)
            {
                Console.WriteLine(item);
            }



            //Range yöntemi, LINQ ile kullanılabilecek bir tamsayı aralığı sağlar.
            var Sayilar = from TamSayi in Enumerable.Range(100, 11) select new { Sayi = TamSayi, TekMi = TamSayi % 2 == 1 };

            Console.WriteLine("100 ile 110 arasındaki sayıların tek / çift olma durumları :");

            foreach (var BirSayi in Sayilar)
            {
                Console.WriteLine("Sayı {0} {1}tir.", BirSayi.Sayi, BirSayi.TekMi ? "tek" : "çift");
            }

            Console.ReadLine();

        }
    }
}
