using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05_Except_Union_Concat_Intersect_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************** Except ************************/
            /*
            * Except() Anahtar sözcüğü, iki koleksiyonda bulunan verilerin sadece ilk koleksiyonda olup ikinci koleksiyonda olmayan kayıtları listeler. 
            * Except anahtar sözcüğü ile iki koleksiyon birleştirilir ve bu birleştirme sonucunda sadece ilk koleksiyonda bulunan ve ikinci koleksiyonda bulunmayan değerler listesini ekrana verir.
            */


            string[] kume1 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            string[] kume2 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };


            //DİKKAT: kume1'de olup kume2'de olmayanları verir. Yani -> a ve b'yi verir. e ve f'yi vermez!
            var sonuc1 = kume1.Except(kume2);


            Console.WriteLine("-----------------Except Çıktısı------------");

            foreach (var item in sonuc1)
            {
                Console.WriteLine(item);
            }




            /********************** Union ************************/
            /*
           * Union() anahtar sözcüğü iki koleksiyonda bulunan verilerin tekrarlayanları olmadan, koleksiyon verilerini geri döner.
           * Farklı iki koleksiyonda bulunan verilerin tekrarlayanlarını dahil etmeden yeni bir koleksiyon oluşturur.
           * Örnekte bulunan iki koleksiyonda da aynı değerler mevcuttur.
           * Union ile bu koleksiyonlar birleştirilir ve tekrarlayan değerler yeni oluşan koleksiyonda bulunmaz.
           */
            Console.WriteLine("-----------------Union Çıktısı------------");

            var sonuc2 = kume1.Union(kume2);

            foreach (var item in sonuc2)
            {
                Console.WriteLine(item);
            }





            /********************** Concat() ************************/

            /*
                Concatenation - Birbirine bağlama
                * Concat() anahtar sözcüğü ile iki koleksiyondaeki elemanların sırası ile birleştirilmesi sağlar.
                * İlk koleksiyonun elemanlarından sonra ikinci koleksiyonun elemanları listelenecek şekilde yeni bir koleksiyon oluşur.
            */
            //DİKKAT: Union'dan farklı olarak yinelenenleri silmez!

            Console.WriteLine("-----------------Concat Çıktısı------------");

            var sonuc3 = kume1.Concat(kume2);
            foreach (var item in sonuc3)
            {
                Console.WriteLine(item);
            }




            /********************** Intersect() ************************/
            /*
            * 
            * Intersect() anahtar sözcüğü iki koleksiyonda bulunan tekrarlayan kayıtların listelenmesini sağlar.
            * Intersect anahtar sözcüğü ile iki koleksiyonda bulunan ve tekrarlayan kayıt var ise sadece tekrarlayan kayıtları yeni bir koleksiyon olarak döner.
            * Aşağıdaki örnekte bulunan koleksiyonlarda Intersect anahtar sözcüğü ile tekrarlayan değerlerin listesini verir.
            */

            var result = kume1.Intersect(kume2);
            Console.WriteLine("-----------------Intersect Çıktısı------------");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }




            /********************** Distinct() ************************/

            /*
              * Distinct() anahtar sözcüğü koleksiyon içerisinde bulunan tekrarlayan kayıtların gösterilmesini engeller.
              * Koleksiyonda bulunan verilerin tekrarlayan kayıtların tekrarlanmamasını sağlar.
              * Koleksiyonda bulunan günlerde tekrarlayan günler mevcut ve aşağıdaki örnekte tekrarlayan kayıtların ekrana yazılması engellenir.
           */

            string[] gunler = { "Pazartesi", "Pazartesi", "Salı", "Salı", "Çarşamba", "Çarşamba", "Perşembe", "Perşembe", "Cuma", "Cuma", "Cumartesi", "Cumartesi", "Pazar", "Pazar" };

            var sonuc = gunler.Distinct();

            Console.WriteLine("-----------------Distinct Çıktısı------------");

            foreach (var item in sonuc)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
