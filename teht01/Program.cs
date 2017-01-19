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
            int number;
            Console.Write("Give number > ");
            number = int.Parse(Console.ReadLine()); 
            //"10" -> 10
            //show number "text"
            switch (number)
            {
                case 1: Console.WriteLine("yksi");
                    break;
                case 2: Console.WriteLine("kaksi");
                    break;
                case 3: Console.WriteLine("kolme");
                    break;
                default: Console.WriteLine("joku muu luku");
                    break;
            }
            Console.ReadLine();
        }
    }
}
