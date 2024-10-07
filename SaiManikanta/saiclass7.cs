using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass7
    {
        static void Main()
        {
            char grade = 'c';

            switch (grade)
            {
                case 'a':
                    Console.WriteLine("excellent");
                    break;
                case'b':
                        Console.WriteLine("welldone");
                    break;
                case 'c':
                        Console.WriteLine("good");
                    break;
                case'd':
                        Console.WriteLine("passed");
                    break;
                case'e':
                        Console.WriteLine("failed");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;
            }
            Console.ReadLine();
        }
    }
}

                            

            

