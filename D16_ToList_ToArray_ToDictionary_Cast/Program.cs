using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16_ToList_ToArray_ToDictionary_Cast
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to Array
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var list = numbers.ToArray();


            // Array to List
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sonuc = array.ToList();

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // List to Dictionary
            var result = numbers.ToDictionary(x => x, y => (y % 2) == 1);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            //  Cast() anahtar sözcüğü özel tipler ile dolu olan koleksiyondaki verileri belirtilen tipe atayarak, tek tipte yeni bir koleksiyon olarak sunar.
            var months = new List<string> { "February", "March", "May", "June", "July", "August", "September", "October", "November", "December" };
            var result2 = months.Cast<string>(); 
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();



        }


    }
}
