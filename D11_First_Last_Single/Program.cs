using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_First_Last_Single
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = { "Hüseyin", "Ahmet", "Onur", "Tolgahan" };

            var first = isimler.First();
            Console.WriteLine($"First() İLK KAYDI alır. Kayıt olmaz ise hata veririr.-> {first}");


            var firstOrDefault = isimler.FirstOrDefault();
            Console.WriteLine($"FirstOrDefault() İLK KAYDI alır. Kayıt olmaz ise hata vermez, default değeri döner.-> {firstOrDefault}");

            var last = isimler.Last();
            Console.WriteLine($"Last() SON KAYDI alır. Kayıt olmaz ise hata veririr.-> {last}");


            var lastOrDefault = isimler.LastOrDefault();
            Console.WriteLine($"LastOrDefault() SON KAYDI alır.  Kayıt olmaz ise hata vermez, default değeri döner.-> {lastOrDefault}");


            var single = isimler.Single(x => x.EndsWith("r"));
            Console.WriteLine($"Single() anahtar sözcüğü koleksiyonda bulunan bir öğeyi alır. Birden çok değer gelirse hata alırız. -> {single}");


            var singleOrDefault = isimler.SingleOrDefault(x => x.EndsWith("z"));
            Console.WriteLine($"SingleOrDefault() Kayıt olmaz ise hata vermez, default değeri döner. Birden çok kayıt gelirse hata alırız.-> {singleOrDefault}");


            var elementAt = isimler.ElementAt(1);
            Console.WriteLine($"ElementAt() anahtar sözcüğü bir koleksiyonda bulunan verilerin index değerine göre alınmasını sağlanır..-> {elementAt}");

            var elementAtOrDefault = isimler.ElementAtOrDefault(4);
            Console.WriteLine($"ElementAtOrDefault() anahtar sözcüğü eğer index yok ise sonucun hata vermemesiniz sağlar...-> {elementAtOrDefault}");



            Console.ReadLine();

        }
    }
}
