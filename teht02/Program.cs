using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask number
            int numberX, numberY, numberZ;
            Console.Write("Give the first number > ");
            string lineX = Console.ReadLine();
            bool resultX = Int32.TryParse(lineX, out numberX);


            if (resultX == true)
            {
                Console.Write("Give the second number > ");
                string lineY = Console.ReadLine();
                bool resultY = Int32.TryParse(lineY, out numberY);

                if (resultY == true)
                {
                    Console.Write("Give the third number > ");
                    string lineZ = Console.ReadLine();
                    bool resultZ = Int32.TryParse(lineZ, out numberZ);
                }

                else
                {
                    Console.WriteLine("Not an integer value!");
                }

                else
                {
                    Console.WriteLine("Not an integer value!");
                }


            
            }
            else
            {
                Console.WriteLine("Not an integer value!");
            }
            Console.ReadLine();
        }
    }
}
