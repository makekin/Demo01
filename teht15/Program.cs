using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Give the tree height in number > ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i < x + 1; i++)
            {
                for (int k = i; k < x; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < (i * 2); j++)
                {
                    Console.Write("*");
                }



                Console.WriteLine();
            }
            for (int j2 = 0; j2 < 2; j2++)
            {
                for (int i2 = 0; i2 < x - 1; i2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");

            }
        }
    }
}
