using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice3
{
    class Program
    {
        static double Fermat(int a, int p)
        {
            double sum = 1;
            int buf = p-2;
           while (buf!=0)
            {
                sum = sum * a;
                buf--;
            }
            Console.WriteLine("If the sum " + sum + " contains E - the solution is wrong!(It's too big)");
            sum = sum%p;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The solution is " + Fermat(12, 21));
            Console.ReadKey();
        }
    }
}
