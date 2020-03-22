using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_SequenceEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SequenceEqual() anahtar sözcüğü iki koleksiyonda bulunan öğelerin bir birine eşit olup olmamasını döner.
            Birinci koleksiyonun öğeleri, ikinci koleksiyonunu öğelerine eşit ise true değilse false döner.
            */
            string[] words1 = { "February", "March", "May" };
            string[] words2 = { "February", "May", "March" };
            string[] words3 = { "MARCH", "February", "May" };
            string[] words4 = { "February", "March", "May" };
            string[] words5 = { "February", "MARCH", "May" };

            var result1 = words1.OrderBy(x=>x).SequenceEqual(words2.OrderBy(x=>x)); //Sıralama sorununu ortadan kaldırmak için kullanılabilir.
            var result2 = words1.SequenceEqual(words3);
            var result3 = words1.SequenceEqual(words4);
            var result4 = words1.SequenceEqual(words5, StringComparer.OrdinalIgnoreCase); // Büyük küçük duyarlılını kapatmak.



            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadLine();
        }
    }
}
