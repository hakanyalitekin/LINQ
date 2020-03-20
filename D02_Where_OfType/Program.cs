using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Where_OfType
{
    class Program
    {

        static void Main(string[] args)
        {

            /**************************************************** Where ****************************************************/

            //ÖRNEK DATA
            List<Kurs> kurslar1 = new List<Kurs>();
            kurslar1.Add(new Kurs { ID = 1, Konu = "LINQ Konuları", Sira = 5 });
            kurslar1.Add(new Kurs { ID = 2, Konu = ".Net Konuları", Sira = 4 });
            kurslar1.Add(new Kurs { ID = 3, Konu = "MVC Konuları", Sira = 3 });

            //QUERY YÖNTEMİ
            var sonuc = from k in kurslar1
                        where k.Sira > 3
                        select k;

            //METHOD YÖNTEMİ
            var sonuc2 = kurslar1.Where(x => x.Sira > 3);


            //KULLANIM
            foreach (var kurs in sonuc2)
            {
                Console.WriteLine(kurs.Konu);
            }

            //Console.ReadLine();


            /**************************************************** OfType ****************************************************
            /*
              * OfType() anahtar sözcüğü özel tipler ile dolu olan koleksiyondaki verilerin belirtilen tipte listelenmesi sağlar.
              * OfType anahtar sözcüğü ile dizi içerisinde bulunan object değerlerden sadece belirtilen tipteki değerleri alıp yeni koleksiyonda oluşturur.
              * Dizide bulunan string, int ve Decimal türündeki verilerden sadece int türündeki verilerin yeni bir koleksiyon olarak verilmesi örneği aşağıdaki gibidir.

            */

            /*----------------------ÖRNEK 1------------------------*/
            object[] values = { "Turkey", "India", 5, 75, "China", 5.25 };

            var result = values.OfType<int>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            /*----------------------ÖRNEK 2------------------------*/
            //ÖRNEK DATA
            List<Kurs> kurslar = new List<Kurs>();
            kurslar.Add(new UcretliKurs { ID = 1, Konu = "LINQ Konuları", Sira = 5 });
            kurslar.Add(new UcretliKurs { ID = 2, Konu = ".Net Konuları", Sira = 4 });


            kurslar.Add(new UcretsizKurs { ID = 1, Konu = "MVC Konuları", Sira = 3 });
            kurslar.Add(new UcretsizKurs { ID = 2, Konu = "API Konuları", Sira = 2 });



            //QUERY YÖNTEMİ
            var ucretliKurslar = from k in kurslar.OfType<UcretliKurs>()
                                 select k;

            //METHOD YÖNTEMİ
            var ucrestizKurslar = kurslar.OfType<UcretsizKurs>();


            //KULLANIM
            foreach (var kurs in ucrestizKurslar)
            {
                Console.WriteLine(kurs.Konu);
            }


            Console.ReadLine();
        }
    }


    class Kurs
    {
        public int ID { get; set; }
        public string Konu { get; set; }
        public int Sira { get; set; }
    }
    class UcretliKurs : Kurs
    {

    }
    class UcretsizKurs : Kurs
    {
        public decimal Fiyat { get; set; }
    }
}






