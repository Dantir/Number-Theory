using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static double Itera(int n, int p)
        {
            n = n % p;
            for (double x = 1; x < p; x++)
            {
                if ((n * x) % p == 1)
                    return x;
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Itera(11, 15));
            Console.ReadKey();
        }
    }
}
