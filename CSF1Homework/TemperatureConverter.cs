using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TemperatureConverter
    {
        public void Main()
        {
            bool repeat = true;

            do
            {
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("---------------------\n");
                Console.WriteLine("1) Convert from F to C");
                Console.WriteLine("2) Convert from C to F");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.Write("Enter the F temperature you would like to convert into C ");
                        string userInput = Console.ReadLine();
                        decimal userFah = decimal.Parse(userInput);
                        Console.WriteLine(" That would = " + (userFah - 32) / (9 / 5) + " degrees in celsius");
                        Console.WriteLine("\nWould you like to make another conversion? Y/N");
                        ConsoleKey userDecision = Console.ReadKey(true).Key;
                        switch (userDecision)
                        {
                            case ConsoleKey.Y:

                                Console.Clear();
                                Main();
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("Have a good day");
                                repeat = false;
                                break;
                        }
                        break;
                    case "2":
                        Console.Write("Enter the C temperature you would like to convert into F ");
                        string userTemp = Console.ReadLine();
                        decimal userCel = decimal.Parse(userTemp);
                        decimal cel = (9 / 5) * userCel + 32;
                        Console.WriteLine("That would = "+ cel+ " degrees in Fahrenheight");
                        Console.WriteLine("\n Would you like to make another conversion? Y/N");
                        ConsoleKey userAction = Console.ReadKey(true).Key;
                        switch (userAction)
                        {
                            case ConsoleKey.Y:

                                Console.Clear();
                                Main();
                                break;
                            case ConsoleKey.N:
                                Console.WriteLine("Have a good day");
                                repeat = false;
                                break;

                        }
                        break;

                    default:
                        Console.WriteLine("That is not a valid option");
                        break;

                }

                } while (repeat) ;

            


        }
    }
}

    