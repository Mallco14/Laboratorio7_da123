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

            var pares = (from c in numbers
                        where c % 2 == 0
                        select c).ToList();

            
            foreach (var par in pares) { Console.Write(par); }
            
            
            Console.ReadLine();

        }
    }
}
