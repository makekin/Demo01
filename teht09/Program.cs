using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int sum = 0;
            do 
            {
                Console.Write("Give a number (enter 0 to sum previous numbers) > ");
                a = int.Parse(Console.ReadLine());
                sum = sum + a;

            } while (a != 0);
            Console.WriteLine("The sum of the number is " + sum);
        }
    }
}
