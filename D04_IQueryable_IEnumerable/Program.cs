using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_IQueryable_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           * İlk bakışta bize aynı gibi görünseler de IEnumerable ve IQueryable arasında büyük farklar var.
           * IEnumerable ve IQueryable arasındaki en büyük fark IEnumerable tipinin datayı önce belleğe atıp ardından koşulları bellekteki dataya uygulamasıdır.
           * IQueryable tipinde ise sorgular direkt olarak Sql serverda yapılır.
           * Yani IEnumerable ile tüm kayıtları bir kere alırız. IQueryable'da ise yalnızca istediğimiz kayıtları alırız.
           * Bir veritabanı veya uzak veri kaynakları üzerinde işlem yapacaksak IQueryable en iyi çözümdür.
           */
            List<int> intList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            IEnumerable<int> QuerySyntax1 = from i in intList
                                            where i > 5
                                            select i;


            IQueryable<int> QuerySyntax = from i in intList.AsQueryable()
                                          where i > 5
                                          select i;

            IQueryable<int> MethodSyntax = intList.AsQueryable().Where(x => x > 5);

            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
