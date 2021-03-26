using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Main_Homework
    {
        static void Main()
        {
            ATM atmMachine = new ATM();
            TemperatureConverter temp = new TemperatureConverter();
            MadLib mad = new MadLib();
            FruitLoops1 fl1 = new FruitLoops1();
            FruitLoops2 fl2 = new FruitLoops2();
            LogIn log = new LogIn();

            Console.WriteLine("Homework Packet\n");
            Console.WriteLine("1) Fruit Loops");
            Console.WriteLine("2) Fruit Loops 2");
            Console.WriteLine("3) Temp Converter");
            Console.WriteLine("4) Mad Lib");
            Console.WriteLine("5) Login");
            Console.WriteLine("6) ATM");
            Console.WriteLine("7) Exit");
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1":
                    Console.Clear();
                    fl1.Main();

                    break;
                case "2":
                    Console.Clear();
                    fl2.Main();

                    break;
                case "3":
                    Console.Clear();
                    temp.Main();

                    break;
                case "4":
                    Console.Clear();
                    mad.Main();

                    break;
                    
                case "5":
                    Console.Clear();
                    log.Main();

                    break;
                case "6":
                    Console.Clear();
                    atmMachine.Main();
                    break;
                case "7":

                    break;


              
               
            }
        }
    }
}
