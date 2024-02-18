using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{

    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 255;
            short number2 = 32767;
            int number3 = 2147483647;
            long number4 = 9223372036854775807;

            double number5 = 92.8;
            decimal number6 = 92.8m;

            bool isCustomerLogin = false;

            char character = 'A';
            string city = "Angara";

            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);



            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);




            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday = 10, Saturday, Sunday
    }
}
