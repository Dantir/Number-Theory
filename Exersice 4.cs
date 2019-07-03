using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4
{
    class Program
    {
        public static int Prime(int num)
        {
            int check=0;
            int limit = num / 2;
            for (int i=2;i<=limit;i++)
            {
                
                if (num%i==0)
                {
                    check = 1;
                    break;
                }
            }
            if (check==0 & num>1)
            { 
            Console.WriteLine("Number " + num + " is Prime!");
                return 1;
            }
            else
            {
                Console.WriteLine("Number " + num + " is not Prime!");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Prime(999983);
            Console.ReadKey();
        }
    }
}
