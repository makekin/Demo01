using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht20
{
    class Program
    {
        static void Main(string[] args)
        {
            //THE MOST AMAZING MAKEN NOPPASIMULAATTORI LAUTAPELEIHIN TAI KOLIKONHEITTOON!
            int count, dice;
            Random random = new Random();
            Console.Write("Select the number for dices > ");
            count = int.Parse(Console.ReadLine());

            Console.Write("Select how many sided dice you want to use > ");
            dice = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (dice == 2 && count == 1)
                {
                    Console.WriteLine("So you decided to toss a coin.");
                    int randomNumber2 = random.Next(0, 1);
                    if (randomNumber2 == 0)
                    { Console.WriteLine("The coin fell tails!"); }

                    else
                    {
                        { Console.WriteLine("The coin fell heads!"); }
                    }
                }
                else {
                int randomNumber = random.Next(1, dice);
                Console.WriteLine(randomNumber);
            }
            }


        }
    }
}
