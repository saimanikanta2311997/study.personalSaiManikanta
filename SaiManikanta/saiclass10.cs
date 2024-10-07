using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass10
    {
        public static void Main()
        {
            int amount = 1000;
            string area = "hyderabad";
            {
                if (amount<1000)
                {
                    if (area=="hyderabad")
                    {
                        Console.WriteLine("free delivery avilable");
                    }
                    else
                    {
                        Console.WriteLine("sorry,this offer hyd people");
                    }
                }
                else
                {
                    Console.WriteLine("sory sir you have purchase minimum $1000");
                }
            }
            Console.ReadLine(); 
        }
    }
}




                  
            
            

            
            



















