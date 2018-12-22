using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            do
            {
                Console.WriteLine("Unesite željeni broj (između 6 i 10): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 6 || n > 10);

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", i);
            }
            Console.ReadLine();
        }
    }
}
