using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine($"Az x eredeti értéke: {x}");
            Console.WriteLine($"Az x értéke: '++x' {++x}");

            Console.WriteLine($"Az x értéke a kiiratás után{x}");

            Console.WriteLine($"\n Az y eredeti értéke: {y}");
            Console.WriteLine($"Az y értéke: '++x' {++y}");

            Console.WriteLine($"Az y értéke a kiiratás után{y}");

            Console.ReadKey();
        }
    }
}
