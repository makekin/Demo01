using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Give the year to check > ");
            year = int.Parse(Console.ReadLine());

            if (year % 400 == 0) 
            {
                //jaollinen 400
                Console.WriteLine("vuosi " + year + " on karkausvuosi");
            }
            else if (year % 100 == 0)
            {
                //jaollinen 100
                Console.WriteLine("vuosi " + year + " ei ole karkausvuosi");
            }
            else if (year % 4 == 0)
            {
                //jaollinen 4
                Console.WriteLine("vuosi " + year + " on karkausvuosi");
            }
            else
            {
                Console.WriteLine("vuosi " + year + " ei ole karkausvuosi");
            }

       
       

        }
    }
}
