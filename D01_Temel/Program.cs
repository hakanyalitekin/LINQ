using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_Temel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             LINQ; açılımı Language Integrated Query (Dile Entegre Edilmiş Sorgu) olan,Microsoft tarafından geliştirilen ve
             C# 3.0 ile hayatımıza giren farklı veri kaynaklarından sorgulama yapabilmemize olanak sağlayan bir söz dizimidir.

             LINQ, koleksiyonlar, ADO.Net DataSet, XML , SQL Server, Entity Framework ve diğer veritabanları gibi farklı veri kaynağı türlerinden veri almak için oluşturulmuş bir sorgu söz dizimidir.
             
             
             LINQ’da iki farklı söz dizimi mevcuttur.
                   -> Query Syntax (Sorgu söz dizimş ) -> from ile başlar.
                   -> Method Syntax (Metot söz dizimi)
            
            Eğer daha önce SQL komutları yazdıysak, Query Syntax yordamı bize hiç de yabancı gelmeyecektir. Küçük bir örnek ile iki söz dizimini inceleyelim.

             */


            // Veri Kaynağı (Bu veri yukarıda basettiğim gibi her hangi bir yerden sağlanıyor olabilir.)
            int[] sayilar = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // LINQ sorgusu QUERY SÖZ DİZİMİ
            var kucukSayilar1 = from sayi in sayilar
                                where sayi < 5
                                select sayi;

            //LINQ sorgusu METHOD SÖZ DİZİMİ
            var kucukSayilar2 = sayilar.Where(x => x < 5);


            // Sorguyu kullanma
            foreach (int sayi in kucukSayilar2)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();
        }
    }
}
