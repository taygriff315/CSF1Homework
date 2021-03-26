using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Power
    {
        static void Main()
        {
            long power = 1;
            long number = 2;
            

            for (power =1; power<50 ; power++)
            {
                Console.WriteLine((long)Math.Pow(number, power));
                
            }
            
           
        }
    }
}
