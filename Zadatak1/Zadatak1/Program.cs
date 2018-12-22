using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Unesite zeljenu godinu: ");
            year = Convert.ToInt16(Console.ReadLine());

            if ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0)))
            {
                Console.WriteLine("Godina {0} je prestupna godina.", year);
            }
            else
            {
                Console.WriteLine("Godina {0} nije prestupna godina.", year);
            }
            Console.ReadLine();
        }
    }
}
