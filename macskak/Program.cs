using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macskak
{
    class Program
    {
        enum animals {cat, dog, tiger, wolf };
        static void Main(string[] args)
        {
            

            animals a = animals.cat;
                animals b = animals.dog;
                    animals c = animals.tiger;
                        animals d = animals.wolf;

            if (a==animals.cat)
            {
                Console.WriteLine("cat");
            }
            if (b==animals.dog)
            {
                Console.WriteLine("dog");
            }

            Console.ReadKey();
        }
    }
}
