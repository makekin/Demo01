using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int x;
            int[] lista = new int[5];
            Console.WriteLine("Insert five numbers to reverse their order");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a number  > ");
                x = int.Parse(Console.ReadLine());
                lista[i] = x;
            }
            Console.Write(lista[4]);
            for (int i = 3; i >= 0; i--)
            {
                Console.Write(", " + lista[i]);
            }
            Console.WriteLine();
           
                    
                 

        }
    }
}
