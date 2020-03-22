using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_Take_TakeWhile_Skip_SkipWhile
{
    public class Calisan
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Departman { get; set; }
        public static List<Calisan> GetAllEmployees()
        {
            return new List<Calisan>()
            {
                new Calisan() {ID = 1, Ad = "Pranaya", Departman = "IT" },
                new Calisan() {ID = 2, Ad = "Priyanka", Departman = "IT" },
                new Calisan() {ID = 3, Ad = "Preety", Departman = "IT" },
                new Calisan() {ID = 4, Ad = "Sambit", Departman = "IT" },
                new Calisan() {ID = 5, Ad = "Sudhanshu", Departman = "HR" },
                new Calisan() {ID = 6, Ad = "santosh", Departman = "HR" },
                new Calisan() {ID = 7, Ad = "Happy", Departman = "HR" },
                new Calisan() {ID = 8, Ad = "Raja", Departman = "IT" },
                new Calisan() {ID = 9, Ad = "Tarun", Departman = "IT" },
                new Calisan() {ID = 10, Ad = "Bablu", Departman = "IT" },
                new Calisan() {ID = 11, Ad = "Hina", Departman = "HR" },
                new Calisan() {ID = 12, Ad = "Anurag", Departman = "HR" },
                new Calisan() {ID = 13, Ad = "Dillip", Departman = "HR" },
                new Calisan() {ID = 14, Ad = "Manoj", Departman = "HR" },
                new Calisan() {ID = 15, Ad = "Lima", Departman = "IT" },
                new Calisan() {ID = 16, Ad = "Sona", Departman = "IT" },
            };
        }
    }

}
