using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15_Zip
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //index'e göre ayarlar yani 40'a kadar eşler 50 için birşey yapmaz.
            int[] numbersSequence = { 10, 20, 30, 40, 50 };
            string[] wordsSequence = { "Ten", "Twenty", "Thirty", "Fourty" };
            var resultSequence = numbersSequence.Zip(wordsSequence, (first, second) => first + " - " + second);
            foreach (var item in resultSequence)
            {
                Console.WriteLine(item);
            }


            //Örnek 2

            var personnels = new List<Personnel>
            {
                new Personnel{Id = 1,FirstName = "Hüseyin",LastName = "AKKAYA",Age = 32},
                new Personnel{Id = 2,FirstName = "Orhan",LastName = "Gül",Age = 27},
                new Personnel{Id = 5,FirstName = "Yıldırım",LastName = "Beyazıd",Age = 29}
            };
            var departments = new List<Department>
            {
                new Department{Id = 1,Name = "Muhasebe",Address = "İstanbul"},
                new Department{Id = 2,Name = "Bilgi İşlem",Address = "İstanbul"},
                new Department{Id = 5,Name = "Hukuk",Address = "İstanbul"}
            };

            var personelDepartments = personnels.Zip(departments, (p, d) => p.FirstName + " " + p.LastName + " - " + d.Name);

            foreach (var item in personelDepartments)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

    public class Personnel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

