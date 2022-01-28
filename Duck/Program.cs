using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            RedheadDuck duck2 = new RedheadDuck();

            Duck[] ducks = new Duck[] { duck1, duck2 };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Quack());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].Display());
            }

            Console.ReadKey();
        }

    }
}
