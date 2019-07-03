using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exersice1
{
    class Program
    {
        public static double exp4(int a, int b)
        {
            double result = 1;
            while (b!=0)
            {
                if (b % 2 == 1)
                {
                    result *= a;
                }
                b /= 2;
                a *= a;
            }
            return result;
        }
        public static double exp5(int a, int b)
        {
            double result = 1;
            while (b!=0)
            {
                if (b%2==1)
                {
                    result *= a;
                }
                b >>= 1;
                a *= a;
            }
            return result;
        }
        static double Naive(int n, int p)
        {
            double sum=n;
            for(int i = 1;i<p;i++)
            {
                sum = sum*n;
            }
            return sum;
        }
        static double Recur(int n,int p)
        {
            if (p <= 1) return n;
            return n * Recur(n,p-1);
        }

        static double Itera(int n, int p)
        {
            double result=1;
            while (p > 0)
            {
                result *= n;
                p--;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(exp4(5,5));//exp4mod
            Console.WriteLine(exp5(5,5));//exp5mod
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(Itera(1000021, 50));//iterative
            watch1.Stop();
            Console.WriteLine(watch1.ElapsedTicks);
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(Recur(1000021, 50));//recursive
            watch2.Stop();
            Console.WriteLine(watch2.ElapsedTicks);
            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine(Naive(1000021, 50));//naive
            watch3.Stop();
            Console.WriteLine(watch3.ElapsedTicks);
            Console.ReadKey();
            //Judging by the analysis - Iterative algorythm worked the longest, while Naive was the fastest.
        }
    }
}
