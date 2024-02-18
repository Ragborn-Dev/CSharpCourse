using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Faruk", "Ahmet", "Ferhat" };
            //students[0] = "Faruk";
            //students[1] = "Ahmet";
            //students[2] = "Ferhat";



            string[] students2 = { "Faruk", "Ahmet", "Ferhat" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("--------------");

            string[,] regions = new string[5, 3]
            {
                {"istanbul", "kocaeli", "balıkesir" },
                { "ankara", "konya", "kırıkkale"},
                { "antalya", "adana", "mersin"},
                { "rize", "trabzon", "samsun" },
                { "izmir", "muğla", "manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**************");
            }

            Console.ReadLine();
        }
    }
}
