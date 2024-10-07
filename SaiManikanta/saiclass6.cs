using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass6
    {
        public static void Main()
        {
            string trafficsignal = "green and yellow";

            switch (trafficsignal)
            {
                case "red":
                    Console.WriteLine("stop");
                    break;
                case "green":
                    Console.WriteLine("Go");
                    break;
                case "yellow":
                    Console.WriteLine("ready to move");
                    break;
                default:
                    Console.WriteLine("invalid light");
                    break;
            }
            Console.ReadLine();
        }
    }

        
}
