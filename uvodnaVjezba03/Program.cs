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

            Console.Write("Molim vas unesite prvu katetu pravokutnog trokuta:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Molim vas unesite drugu katetu pravokutnog trokuta:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Molim vas unesite hipotenuzu pravokutnog trokuta:");
            c = Convert.ToInt32(Console.ReadLine());

            if(a > 0 && b > 0 && c > 0)
            {
                if((a*a) + (b*b) == c)
                {
                    Console.WriteLine("Trokut je pravokutan!");
                }
                if (a * a + b * b != c)
                {
                    Console.WriteLine("Trokut je nije pravokutan!");
                }


            }
            else
            {

                Console.ReadKey();

            }



            Console.ReadKey();





        }
    }
}
