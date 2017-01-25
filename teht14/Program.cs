using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht14
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask number
            int number=0, arv0=0, arv1=0, arv2=0, arv3=0, arv4=0, arv5=0;
            while (number != 6)
            {

                Console.Write("Syota arvosanat 0-5, painamalla 6 jakauma tulostetaan ja ohjelma loppuu > ");
                string line = Console.ReadLine();
                bool result = Int32.TryParse(line, out number);
                if (result == true)
                {                                            //show number "text"

                    switch (number)
                    {
                        case 0:
                            arv0++;
                            break;
                        case 1:
                            arv1++;
                            break;
                        case 2:
                            arv2++;
                            break;
                        case 3:
                            arv3++;
                            break;
                        case 4:
                            arv4++;
                            break;
                        case 5:
                            arv5++;
                            break;
                        case 6:
                            //PIIRTAA TAHDET ja lopettaa

                            Console.Write("\narvosana ja lukumaara:\n0: " + arv0 + " ");
                                for(int i0 =0; i0 < arv0; i0++)
                                    { Console.Write("*"); }
                                
                            Console.Write("\narvosana ja lukumaara:\n1: " + arv1 + " ");
                            for (int i1 = 0; i1 < arv1; i1++)
                            { Console.Write("*"); }

                            Console.Write("\narvosana ja lukumaara:\n2: " + arv2 + " ");
                            for (int i2 = 0; i2 < arv2; i2++)
                            { Console.Write("*"); }

                            Console.Write("\narvosana ja lukumaara:\n3: " + arv3 + " ");
                            for (int i3 = 0; i3 < arv3; i3++)
                            { Console.Write("*"); }

                            Console.Write("\narvosana ja lukumaara:\n4: " + arv4 + " ");
                            for (int i4 = 0; i4 < arv4; i4++)
                            { Console.Write("*"); }

                            Console.Write("\narvosana ja lukumaara:\n5: " + arv5 + " ");
                            for (int i5 = 0; i5 < arv5; i5++)
                            { Console.Write("*"); }

                            /*   for (int i = 0; i < 5; i++)
                               {
                                   Console.Write(i + ": ");
                                   for (int j = 0; j < )
                               }*/
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
            }
            Console.ReadLine();
        }
    }
}
