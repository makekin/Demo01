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
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give a number > ");
                x = int.Parse(Console.ReadLine());
                lista[i] = x;
            }
            for (int i = 4; i > 0; i--)
            {
                Console.Write(lista[i] + ", ");
            }
           
                    
                 

        }
    }
}
