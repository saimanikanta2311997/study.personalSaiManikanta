using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SaiManikanta
{
    internal class saiclass2
    {
        static void Main()
        {
            int sum = 0,number;
            do
            {
                Console.WriteLine("enter positve number(0 to 10):");
                number=Convert.ToInt32(Console.ReadLine());
                sum+=number;
            }

            while(number !=0);   
            Console.WriteLine("the total valuse="+sum);


            
            

        }
    }
}
            



































