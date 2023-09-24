using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;

            unosA: Console.Write("Molim vas unesite prvu katetu pravokutnog trokuta:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Prva kateta je manja od nule. ");
                goto unosA;
            }

            unosB: Console.Write("Molim vas unesite drugu katetu pravokutnog trokuta:");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Druga kateta je manja od nule. ");
                goto unosB;
            }

            unosC: Console.Write("Molim vas unesite hipotenuzu pravokutnog trokuta:");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("Hipotenuza je manja od nule. ");
                goto unosC;
            }





            if (a * a + b * b == c * c)
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }
                if (a * a + b * b != c * c)
                {
                    Console.WriteLine("Trokut je nije pravokutan!");
                }


            
           



            Console.ReadKey();





        }
    }
}
