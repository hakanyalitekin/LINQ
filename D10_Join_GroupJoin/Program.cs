using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10_Join_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>()
            {
                new Kisi { ID =1, Ad="Ali", SehirID=34, DepartmanID = 1},
                new Kisi { ID =2, Ad="Veli", SehirID = 35, DepartmanID = 1},
                new Kisi { ID =3, Ad="Mehmet", SehirID = 36, DepartmanID = 2},
                new Kisi { ID =4, Ad="İsmet", SehirID = 36, DepartmanID = 3 },
            };
            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir { ID =34, SehirAdi ="İstanbul"},
                new Sehir { ID =35, SehirAdi ="Izmir"},
                new Sehir { ID =36, SehirAdi ="Kars"},
                new Sehir { ID =06, SehirAdi ="Ankara"},
            };
            List<Departman> departmanlar = new List<Departman>()
            {
                new Departman { ID =1, DepartmanAdi = "İnsan Kaynakları"},
                new Departman { ID =2, DepartmanAdi = "Bilgi İşlem"},
                new Departman { ID =3, DepartmanAdi = "Pazarlama"},

            };


            //************************************** Join **************************************
            #region Join
            var sonucMethot = kisiler.Join(sehirler, k => k.SehirID, s => s.ID, (k, s) => new { KisiAdi = k.Ad, SehirAdi = s.SehirAdi });

            var sonucQuery = (from k in kisiler
                              join s in sehirler on k.SehirID equals s.ID
                              select new
                              {
                                  KisiAdi = k.Ad,
                                  SehirAdi = s.SehirAdi
                              }).ToList();

            Console.WriteLine("-----------------Join Çıktısı------------");

            foreach (var item in sonucMethot)
            {
                Console.WriteLine($" Kisi:{item.KisiAdi}, Şehri:{item.SehirAdi}");
            }

            #endregion


            //************************************** 2 Join Multiple Data **********************
            #region 2 Join Multiple Data
            Console.WriteLine();
            Console.WriteLine("----------------- METHOD SYNTAX 2 Join / Multiple Data Çıktısı ------------");

            var cokluDataMethod = kisiler.Join(sehirler, kisi => kisi.SehirID, sehir => sehir.ID, (kisi, sehir) => new { kisi, sehir })
                .Join(departmanlar, kisi_LVL2 => kisi_LVL2.kisi.DepartmanID, dep => dep.ID, (kisiSeviye2, dep) => new { kisiSeviye2, dep });//.Select(e=>e.kisiSeviye2.sehir.SehirAdi).ToList();

            foreach (var item in cokluDataMethod)
            {
                Console.WriteLine($" Kisi:{item.kisiSeviye2.kisi.Ad}, Şehri:{item.kisiSeviye2.sehir.SehirAdi}, Departmanı: {item.dep.DepartmanAdi}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------- QUERY SYNTAX 2 Join / Multiple Data Çıktısı ------------");

            var cokluDataQuery = (from k in kisiler
                                  join s in sehirler on k.SehirID equals s.ID
                                  join d in departmanlar on k.DepartmanID equals d.ID
                                  select new
                                  {
                                      KisiAdi = k.Ad,
                                      SehirAdi = s.SehirAdi,
                                      Departman = d.DepartmanAdi
                                  }).ToList();
            foreach (var item in cokluDataQuery)
            {
                Console.WriteLine($" Kisi:{item.KisiAdi}, Şehri:{item.SehirAdi}, Departmanı: {item.Departman}");
            }

            #endregion



            //************************************** GroupJoin *********************************
            #region GroupJoin

            var groupJoinSonuc = sehirler.GroupJoin(kisiler, sehir => sehir.ID, kisi => kisi.SehirID, (sehir, kisi) => new { sehir, kisi });

            Console.WriteLine();
            Console.WriteLine("----------------- GroupJoin ------------");

            // şehre göre grupladığımız result set'imizde dönüyoruz..
            foreach (var s in groupJoinSonuc)
            {
                Console.WriteLine("Sehir :" + s.sehir.SehirAdi + "Şehirde bulunan kişi:"+ s.kisi.Count()); ;

                //ilgili şehirde bulunan kişiler arasında dönüyoruz.
                foreach (var k in s.kisi)
                {
                    Console.WriteLine("  EmployeeID : " + k.ID + " , Name : " + k.Ad);
                }
            }

            #endregion


            Console.ReadLine();
        }
    }


    class Kisi
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int SehirID { get; set; }
        public int DepartmanID { get; set; }
    }
    class Sehir
    {
        public int ID { get; set; }
        public string SehirAdi { get; set; }
    }
    class Departman
    {
        public int ID { get; set; }
        public string DepartmanAdi { get; set; }
    }
}
