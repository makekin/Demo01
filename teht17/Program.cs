using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 10, 20, 30, 40, 50 };
            int[] taulukko2 = { 5, 15, 25, 35, 45 };
            int[] taulukko3 = new int[taulukko1.Length+taulukko2.Length];
            int temp =0;




            for (int i = 0; i < taulukko1.Length; i++)
            {
                taulukko3[i] = taulukko1[i];
            }

            for (int j = 0; j < taulukko2.Length; j++)
            {
                taulukko3[j + taulukko1.Length] = taulukko2[j];
            }

            Console.WriteLine("Original list: ");
            for (int k = 0; k < taulukko3.Length; k++)
            {
                Console.WriteLine(taulukko3[k]);
            }
            Console.WriteLine("Organized list: ");
            //Kierrokset
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < taulukko3.Length-1; y++)
                {
                    //Alkioiden paikanvaihto
                    if (taulukko3[y] > taulukko3[y + 1])
                    {
                        temp = taulukko3[y];
                        taulukko3[y] = taulukko3[y + 1];
                        taulukko3[y + 1] = temp;
                    }
                }
            }

            for (int k = 0; k < taulukko3.Length; k++)
            {
                Console.WriteLine(taulukko3[k]);
            }
        }
    }
}