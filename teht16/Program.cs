using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            int x=101;
            int counter = 1;
            Console.WriteLine("randomnumber on " + randomNumber);

            
          

            while (x != randomNumber)
            {
                Console.Write("Try to guess the random number! > ");

                x = int.Parse(Console.ReadLine());

                if (x > randomNumber)
                {
                    Console.WriteLine("The random number is smaller than your guess");
                    counter++;
                }
                else if (x < randomNumber)
                {
                    Console.WriteLine("The random number is larger that your guess");
                    counter++;
                }
                
                else
                {
                    
                    Console.WriteLine("You guessed right! jei. It took "+ counter + " tries.");
                }

            } 
            

        }
    }
}
