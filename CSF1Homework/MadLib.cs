using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a noun");
            string noun = Console.ReadLine();
            Console.WriteLine("Please, enter a verb");
            string verb = Console.ReadLine();
            Console.WriteLine("Please, enter an adjective");
            string adj = Console.ReadLine();
            Console.WriteLine("Please, enter a noun");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("Please, enter a verb");
            string verbTwo = Console.ReadLine();
            Console.WriteLine("Please, enter a noun");
            string nounThree = Console.ReadLine();
            Console.Clear();


            Console.WriteLine($"There once was a {noun}. They {verb} everyday and dreamed that they would one day be {adj}. Things don't always go the way they seem tho and one day " +
                $"a {nounTwo} came and took everthing they had {verbTwo} for. This is why you should never trust a {nounThree}....") ;
        }
    }
}
