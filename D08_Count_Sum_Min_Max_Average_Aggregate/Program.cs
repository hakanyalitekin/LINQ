using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08_Count_Sum_Min_Max_Average_Aggregate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, };

            var sonucSUM = sayilar.Sum();
            Console.WriteLine("Dizinin toplamı SUM-> " + sonucSUM);



            var sonucCOUNT = sayilar.Count();
            Console.WriteLine("Dizinin eleman adedi -> " + sonucCOUNT);


            var sonucMIN = sayilar.Min();
            Console.WriteLine("Dizinin en küçük elemanı -> " + sonucMIN);


            var sonucMAX = sayilar.Max();
            Console.WriteLine("Dizinin en büyük elemanı -> " + sonucMAX);

            var sonucAVERAGE = sayilar.Average();
            Console.WriteLine("Dizinin elemanlarının ortalaması -> " + sonucAVERAGE);


            //Aggregate() 1
            var sonucAGGREGATE1 = sayilar.Aggregate((x, y) => x * y);
            Console.WriteLine("Aggregate ile matematiksel işlem -> " + sonucAGGREGATE1);



            //Aggregate() 2
            string[] yetenekler = { "C#", "LINQ", "Ado.Net", "SQL" };
            var sonucAGGREGATE2 = yetenekler.Aggregate((x, y) => x + "," + y);
            Console.WriteLine("Aggregate ile string birleştirme işlemi-> " + sonucAGGREGATE2);

            //Aggregate() 3
            int maas = Calisan.GetirTumCalisanlari().Aggregate<Calisan, int>(0, (topMaas, calisan) => topMaas += calisan.Maas);
            Console.WriteLine("Aggregate ile çalışanların toplam maaşını hesaplama -> " + maas);


            //Aggregate() 4
            string dizCalisanIsimleri = Calisan.GetirTumCalisanlari().Aggregate<Calisan, string>("Çalışan İsimleri: " , (calisanIsimleri, calisan) => calisanIsimleri = calisanIsimleri + calisan.Ad + ", ");
            int LastIndex = dizCalisanIsimleri.LastIndexOf(",");
            dizCalisanIsimleri = dizCalisanIsimleri.Remove(LastIndex);
            Console.WriteLine(dizCalisanIsimleri);

            //Aggregate() 5
            string dizCalisanIsimleri2 = Calisan.GetirTumCalisanlari().Aggregate<Calisan, string, string>("Çalışan İsimleri: ", (calisanIsimleri, calisan) => calisanIsimleri = calisanIsimleri + calisan.Ad + ", ",x => x.Substring(0, x.Length - 2));
            Console.WriteLine(dizCalisanIsimleri2);


            Console.ReadLine();
        }

        public class Calisan
        {
            public int ID { get; set; }
            public string Ad { get; set; }
            public int Maas { get; set; }
            public string Departman { get; set; }
            public static List<Calisan> GetirTumCalisanlari()
            {
                List<Calisan> calisanlar = new List<Calisan>()
            {
                new Calisan{ID= 101,Ad = "Preety", Maas = 10000, Departman = "IT"},
                new Calisan{ID= 102,Ad = "Priyanka", Maas = 15000, Departman = "Sales"},
                new Calisan{ID= 103,Ad = "James", Maas = 50000, Departman = "Sales"},
                new Calisan{ID= 104,Ad = "Hina", Maas = 20000, Departman = "IT"},
                new Calisan{ID= 105,Ad = "Anurag", Maas = 30000, Departman = "IT"},

            };
                return calisanlar;
            }

        }
    }
}
