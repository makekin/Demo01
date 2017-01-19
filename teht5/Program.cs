using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.Write("Give your time in seconds > ");
            time = int.Parse(Console.ReadLine());

            //syotetyt sekunnit
            int hours = time / 3600;
            int min = time / 60 - hours * 60;
            int sek = time % 60;

            Console.WriteLine("Seconds you gave is "+ hours + " hours " + min +" minutes "+ sek + " seconds");
        }
    }
}
