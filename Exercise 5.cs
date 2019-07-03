using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        public static int Prime(int num)
        {
            int check = 0;
            int limit = num / 2;
            for (int i = 2; i <= limit; i++)
            {

                if (num % i == 0)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 0 & num > 1)
            {
                return 1;
            }
            else
            { 
                return 0;
            }
        }
        static int gcd(int a, int b)
        {
            if (b==0)
            {
                return a;
            }
            else
            {
                return gcd(b, a % b);
            }
        }
        static void RSA()
        {
            int check = 0;
            int p = 0;
            while (check == 0) //Reading p and checking if it is a prime number
            {
                Console.WriteLine("Enter random big prime number p");
                p = int.Parse(Console.ReadLine());
                if (Prime(p) == 1)
                {
                    check = 1;
                }
            }
            check = 0;
            int q = 0;
            while (check == 0)//Reading q and checking if it is a prime number
            {
                Console.WriteLine("Enter random big prime number q");
                q = int.Parse(Console.ReadLine());
                if (Prime(q) == 1)
                {
                    check = 1;
                }
            }
            check = 0;
            int e = 0;
            while (check == 0)
            {
                Console.WriteLine("Enter natural e such that e and ({0}-1)({1}-1) were coprime", p, q);
                e = int.Parse(Console.ReadLine());
                if (gcd((p - 1) * (q - 1), e) == 1)
                {
                    check = 1;
                }
            }
            float d = 1/e;
            //check = 0;
            //while (check ==0)
            //{
                //Console.WriteLine("Enter such d that d * {0} = 1 mod ({1}-1)({2}-1)", e, p, q);
               // d = double.Parse(Console.ReadLine());
                //if (1/e * e == 1 % ((p - 1) * (q - 1)))
                //{
                   // check = 1;
                //}
            //}
            int n = p * q;
            Console.WriteLine("Pair ({0},{1}) is your public key", n, e);
            Console.WriteLine("Pair ("+ n + " 1/" + e + ") is your private key");
        }
        static void Main(string[] args)
        {
            RSA();
            Console.ReadKey();
        }
    }
}
