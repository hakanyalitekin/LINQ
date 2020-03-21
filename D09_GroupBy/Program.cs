using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {


            #region GroupBy
            //Using Method Syntax
            IEnumerable<IGrouping<string, Ogrenci>> GroupByMS = Ogrenci.GetirOgrenciler().GroupBy(s => s.Brans);

            //Using Query Syntax
            var GroupByQS = (from std in Ogrenci.GetirOgrenciler() group std by std.Brans);

            //Her bir grup içerisinde dönecek.
            Console.WriteLine("-----------------GroupBy Çıktısı------------");

            foreach (var grup in GroupByMS)
            {
                Console.WriteLine(grup.Key + " : " + grup.Count());
                //Her bir grubun içerisinde ki öğrenciler arasında dönecek.
                foreach (var ogrenci in grup)
                {
                    Console.WriteLine("  İsim :" + ogrenci.Isim + ", Yaş: " + ogrenci.Yas + ", Cinsiyet :" + ogrenci.Cinsiyet);
                }
            }
            #endregion


            #region MyRegion

            //Örnek: Branşa ve cinsiyete göre gruplanıp, isme göre sıralanmak isteniyor.

            //Method Syntax
            var gbMultiple = Ogrenci.GetirOgrenciler()
                                    .GroupBy(x => new { x.Brans, x.Cinsiyet })
                                    .OrderByDescending(g => g.Key.Brans).ThenBy(g => g.Key.Cinsiyet)
                                    .Select(g => new
                                    {
                                        Branch = g.Key.Brans,
                                        Gender = g.Key.Cinsiyet,
                                        Students = g.OrderBy(x => x.Isim)
                                    });


            //Query Syntax
            var GroupByMultipleKeysQS = from ogrenci in Ogrenci.GetirOgrenciler()
                                        group ogrenci by new
                                        {
                                            ogrenci.Brans,
                                            ogrenci.Cinsiyet

                                        } into grupOgrenci
                                        orderby grupOgrenci.Key.Brans descending,
                                                grupOgrenci.Key.Cinsiyet ascending

                                        select new
                                        {
                                            Branch = grupOgrenci.Key.Brans,
                                            Gender = grupOgrenci.Key.Cinsiyet,
                                            Students = grupOgrenci.OrderBy(x => x.Isim)
                                        };



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------GroupBy Multiple Çıktısı------------");


            foreach (var group in gbMultiple)
            {
                Console.WriteLine($"Branş : {group.Branch} Cinsiyet: {group.Gender} Öğrenci Sayısı = {group.Students.Count()}");
                //Her bir grubun içerisinde ki öğrenciler arasında dönecek.
                foreach (var ogrenci in group.Students)
                {
                    Console.WriteLine("  İsim :" + ogrenci.Isim + ", Yaş: " + ogrenci.Yas + ", Cinsiyet :" + ogrenci.Cinsiyet);
                }
                Console.WriteLine();
            }

            #endregion

            Console.Read();

        }
        public class Ogrenci
        {

            public int ID { get; set; }
            public string Isim { get; set; }
            public string Cinsiyet { get; set; }
            public string Brans { get; set; }
            public int Yas { get; set; }
            public static List<Ogrenci> GetirOgrenciler()
            {
                return new List<Ogrenci>()
        {
            new Ogrenci { ID = 1001, Isim = "Preety", Cinsiyet = "Kadın", Brans = "CSE", Yas = 20 },
            new Ogrenci { ID = 1002, Isim = "Snurag", Cinsiyet = "Erkek", Brans = "ETC", Yas = 21  },
            new Ogrenci { ID = 1003, Isim = "Pranaya", Cinsiyet = "Erkek", Brans = "CSE", Yas = 21  },
            new Ogrenci { ID = 1004, Isim = "Anurag", Cinsiyet = "Erkek", Brans = "CSE", Yas = 20  },
            new Ogrenci { ID = 1005, Isim = "Hina", Cinsiyet = "Kadın", Brans = "ETC", Yas = 20 },
            new Ogrenci { ID = 1006, Isim = "Priyanka", Cinsiyet = "Kadın", Brans = "CSE", Yas = 21 },
            new Ogrenci { ID = 1007, Isim = "santosh", Cinsiyet = "Erkek", Brans = "CSE", Yas = 22  },
            new Ogrenci { ID = 1008, Isim = "Tina", Cinsiyet = "Kadın", Brans = "CSE", Yas = 20  },
            new Ogrenci { ID = 1009, Isim = "Celina", Cinsiyet = "Kadın", Brans = "ETC", Yas = 22 },
            new Ogrenci { ID = 1010, Isim = "Sambit", Cinsiyet = "Erkek", Brans = "ETC", Yas = 21 }
        };
            }
        }
    }
}
