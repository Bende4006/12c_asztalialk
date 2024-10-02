using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haág
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if (true) Console.WriteLine("Ez az igaz ág");
            else Console.WriteLine("ez a hamis ág");

            b = false;
            if (b) Console.WriteLine("ಠ_ಠ Ez az igaz ág");
            else Console.WriteLine("ez a hamis ág");

            Console.ReadKey();
        }
    }
}
