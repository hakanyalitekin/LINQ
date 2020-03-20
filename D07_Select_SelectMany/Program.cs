using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07_Select_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {

            /********************** Select() ************************/

            /*Select() anahtar sözcüğü ile koleksiyonda bulunan elementler kullanılarak yeni bir koleksiyon oluşturulur. */


            string[] ulkeler = { "Turkey", "France", "Russian", "India" };

            int[] sayilar = { 0, 1, 2, 3 };

            var sonuc1 = sayilar.Select(x => x * 10);

            var sonuc2 = from s in sayilar select (s * 10);
            Console.WriteLine("-----------------Select Çıktısı------------");

            foreach (var item in sonuc2)
            {
                Console.WriteLine(item);
            }




            /********************** SelectMany() ************************/

            //Örnek 1 
            var sonuc3 = ulkeler.SelectMany(x => sayilar, (x, n) => new
            {
                ulke = x,
                sayi = n
            });

            Console.WriteLine("-----------------SelectMany Örnek 1  Çıktısı------------");

            foreach (var item in sonuc3)
            {
                Console.WriteLine("Ülke: " + item.ulke + " - Sayi: " + item.sayi);
            }

            //Örnek 2

            //Using Method Syntax
            List<string> MethodSyntax = Ogrenci.GetirOgrenciler().SelectMany(std => std.Programlama).ToList();

            //Query Syntax
            IEnumerable<string> QuerySyntax = from ogr in Ogrenci.GetirOgrenciler()
                                              from program in ogr.Programlama
                                              select program;

            Console.WriteLine("-----------------SelectMany Örnek 2  Çıktısı------------");
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }


            Console.ReadLine();




        }


        public class Ogrenci
        {
            public int ID { get; set; }
            public string Isim { get; set; }
            public List<string> Programlama { get; set; }

            public static List<Ogrenci> GetirOgrenciler()
            {
                return new List<Ogrenci>()
            {
                new Ogrenci(){ID = 1,Isim = "James",Programlama = new List<string>(){"C#", "Jave", "C++"}},
                new Ogrenci(){ID = 2, Isim = "Sam",  Programlama = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Ogrenci(){ID = 3, Isim = "Patrik", Programlama = new List<string>() { "MVC", "Jave", "LINQ"}},
                new Ogrenci(){ID = 4, Isim = "Sara", Programlama = new List<string>() { "ADO.NET", "C#", "LINQ" }}
            };
            }
        }
    }
}
