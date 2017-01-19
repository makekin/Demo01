using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask number
            int age;
            Console.Write("Give your age > ");
            age = int.Parse(Console.ReadLine());
            //"10" -> 10
            //show number "text"

            if (age <= 18)
            {
                Console.WriteLine("Alaikainen!");
            }
            else
            {
                Console.WriteLine("Seniori.");
            }
                    
         
            Console.ReadLine();
        }
    }
}
