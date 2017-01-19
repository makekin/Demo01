using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double kulutus = 0.0702;
            double hinta = 1.595;

            Console.Write("Give the distance > ");
            matka = int.Parse(Console.ReadLine());

            Console.WriteLine("The consumption is 7,02 l/100km and cost for gas is 1,595€/l");
            double endcost = matka * kulutus * hinta;
            Console.WriteLine("Your end cost is " + endcost + " euros");                   
        }
    }
}
