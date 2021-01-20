using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baklavaDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 1; k <sayi1; k++)
                {
                    Console.Write(" ");
                }
                sayi1+=2;
                if (i > 0)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(" *");
                for (int j = 0; j < sayi2; j++)
                {
                    Console.Write(" ");
                }
                sayi2 -= 2;
                if(i<3)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
            
    }
}
