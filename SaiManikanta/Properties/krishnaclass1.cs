using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta.Properties
{
    internal class krishnaclass1
    {
        public static void Main()
        {
            Console.WriteLine("Start your Program");
            int a = 10, b = 20, c = 30;

            if (a > b && a>c)
            {
                Console.WriteLine("a is greatest");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine("b is a greatest");
            }
            else if (c>a && c>b)
            {
                Console.WriteLine("c is a greatest");
            }
            else
            {
                Console.WriteLine("All are Equal");
                Console.ReadLine();
            }

        }

    }
}

        

    

