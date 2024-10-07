using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass1
    {
        public static void Main()
        {

            string input;
            Console.WriteLine("exit or quit");

           while (true)
            {
                Console.WriteLine("if your enter any statemnt");


                input=Console.ReadLine();

                if (input=="exit")
                {
                    break;
                }
                Console.WriteLine("your enter"+input);
            }
        }
    }
}































