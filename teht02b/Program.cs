using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02b
{
    class Program
    {
        static void Main(string[] args)
        {
               // ask number
                int number;
                Console.Write("Syota pisteesi > ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out number);
            if (result == true)
            {                                            //show number "text"
                switch (number)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Koulunumerosi on 0");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Koulunumerosi on 1");
                        break;
                    case 4:
                    case 5:
                        Console.WriteLine("Koulunumerosi on 2");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("Koulunumerosi on 3");
                        break;
                    case 8:
                    case 9:
                        Console.WriteLine("Koulunumerosi on 4");
                        break;
                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("Koulunumerosi on 5");
                        break;
                    default:
                        Console.WriteLine("Ei arvosteluasteikolla");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Et syottanyt numeroa!");
            }
                Console.ReadLine();
        }
    }
}
