using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i=0;i<taulukko.Length;i++)
            {
                Console.Write(taulukko[i]);
                if(taulukko[i] % 2 == 0)
                { Console.WriteLine(" HEP!"); }
                else
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
