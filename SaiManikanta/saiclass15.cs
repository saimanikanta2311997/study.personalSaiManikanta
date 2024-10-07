using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass15
    {
        public static void Main()
        {
            int avilabilitystock = 200;
            int requeststock = 150;
            {
                if (avilabilitystock ==200) 
                {
                    if (requeststock==100)
                    {
                        Console.WriteLine("Your purchase is approved, please store your stock");
                    }
                    else
                    {
                        Console.WriteLine("Sorrry, Your requst stock is very huge quantity");

                    }
                }
                else
                {
                    Console.WriteLine("sorry storage is not avilable");


                }
            }
            Console.ReadLine();
        }
    }
}


                    











