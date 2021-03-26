using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            int grades;
            do
            {
                Console.Write("Enter your test scores: ");
                string a = Console.ReadLine();
                grades = int.Parse(a);
                Console.WriteLine();
                Console.WriteLine("Your scores:");
                Console.WriteLine(grades);
                



            } while (grades > 0);
            
                

                
        }
    }
}
