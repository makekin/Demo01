using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.Write("Give the first number > ");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("Give the second number > ");
            b = int.Parse(Console.ReadLine());

            int c;
            Console.Write("Give the third number > ");
            c = int.Parse(Console.ReadLine());

            if(a > b && a > c)
            { Console.WriteLine("the biggest number is " + a); }

            else if(b > a && b > c)
            { Console.WriteLine("The biggest number is " + b); }

            else if (c > a && c > b) 
            { Console.WriteLine("The biggest number is " + c); }

        }
    }
}
