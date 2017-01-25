using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht13
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            int[] lista = new int[5];
            Console.WriteLine("Insert five numbers to give points to sky jumper (max points is 999)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give points  > ");
                x = int.Parse(Console.ReadLine());
                lista[i] = x;
            }
            int min=1000, max=0;
            for (int j = 0; j < 5; j++)
            {
                if (lista[j] < min)
                { min = lista[j]; }
            }

            for (int k = 0; k < 5; k++)
            {
                if (lista[k] > max)
                { max = lista[k]; }
            }

            int pisteet=0;
            for (int ii = 0; ii < 5; ii++)
            {
                pisteet = pisteet + lista[ii];
            }
            pisteet = pisteet - min - max;

            Console.Write("You got " + pisteet + " when highest and lowest points are removed \n");
            



        }
    }
}
