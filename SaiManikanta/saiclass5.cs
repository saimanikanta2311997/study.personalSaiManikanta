using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass5
    {
        public static void Main()
        {

            double num1 = 50, num2 = 10;
            char operation = '/';

            switch (operation)
            {
                case '+':
                    Console.WriteLine("result"+(num1+num2));
                    break;

                case '-':
                    Console.WriteLine("result"+(num1-num2));
                    break;

                case '/':
                    if (num2 !=0)
                    {
                        Console.WriteLine ("result"+(num1/num2));
                    }
                    else
                    {
                        Console.WriteLine("cannot devided by zero");
                    }
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}



    

