using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass8
    {
        public static void Main()
        {


            int age = 20;
            string health = "good";
            bool value = false;
            {
                if (age==20)
                {



                    if (health=="good")
                    {
                        if (value)
                        {
                            Console.WriteLine("Your totally welcome to cult gym");

                        }
                        else
                        {
                            Console.WriteLine("sorry your fitness not good");
                        }
                    }
                    else
                    {
                        Console.WriteLine("sorry sir your health is not good");
                    }
                }
                else
                {
                    Console.WriteLine("sorry sir your age not elgible ");
                }
            }
            Console.ReadLine();
           
            
            
            
        }
    }
}

   

