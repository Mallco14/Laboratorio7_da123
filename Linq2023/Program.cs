using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            ShowPares(numbers);
            ShowParesLambda(numbers);

            Console.ReadLine();

        }

        private static void ShowPares(int[] numbers)
        {
            Console.WriteLine("ShowPares");
            var pares = (from c in numbers
                         where c % 2 == 0
                         select c).ToList();


            foreach (var par in pares) { Console.WriteLine(par); }
        }
        private static void ShowParesLambda(int[] numbers)
        {
            Console.WriteLine("ShowParesLambda");
            var pares =  numbers.Where(x=>x%2==0).ToList();
            foreach (var par in pares) { Console.WriteLine(par); }
        }



    }
}
