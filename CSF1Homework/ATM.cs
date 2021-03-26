using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        public void Main()
        {
            bool repeat = false;


            //// account number code below

            //IF NOT USER
            //{
            //  Make sure its user - 3 times
            //}
            //else you are your user
            //proceed to passowrd time
            //do same thing

            int accAtt = 1;
            string acctNumber = "1234567";
            Console.Write("Enter your account number: ");
            string userAcct = Console.ReadLine();


            if (userAcct != acctNumber)
            {
                do
                {
                    Console.WriteLine("Account doesn't exist");
                    Console.Write("Try Again: ");
                    userAcct = Console.ReadLine().ToUpper();
                    accAtt++;

                    if (accAtt == 3 && userAcct != acctNumber)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts.");
                        Console.WriteLine("Your access has been denied");
                    }
                } while (userAcct != acctNumber && accAtt < 3);

            }

            ////////////////////////// account number Code above


            //// pin and bank app below

            if (userAcct == acctNumber)
            {

                string userPin = "1234";
                Console.WriteLine("Enter your pin number");
                string pin = Console.ReadLine();
                int attempts = 1;

                string userChoice;

                if (pin != userPin)
                {
                    do
                    {
                        Console.WriteLine("That is not the correct pin");
                        Console.WriteLine("Please Try Again");
                        pin = Console.ReadLine();
                        attempts++;

                        if (attempts == 3)
                        {
                            Console.WriteLine("You have attempted the maximum amount");
                            Console.WriteLine("Access Denied");
                        }

                    } while (pin != userPin && attempts < 3);
                }

                else if (pin == userPin)
                {
                    decimal money = 5467.89m;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Welcome\n");
                        Console.WriteLine("1) Check Balance");
                        Console.WriteLine("2) Withdraw");
                        Console.WriteLine("3) Make Deposit");
                        Console.WriteLine("4) Exit");
                        userChoice = Console.ReadLine();
                       

                        switch (userChoice)
                        {
                            case "1":
                                Console.WriteLine("$" + money);
                                Console.WriteLine("Would you like to make another transaction? Y/N");
                                string b = Console.ReadLine().ToUpper();
                                if (b == "Y")
                                {
                                    repeat = true;
                                }
                                else if (b == "N")
                                    repeat=false;
                                else
                                {
                                    Console.WriteLine("Please enter a valid answer");
                                }

                                break;

                            case "2":
                                Console.Write("How much would you like to withdrawl $");
                                string withdraw = Console.ReadLine();
                                decimal wd = decimal.Parse(withdraw);
                                money = money - wd;
                                Console.WriteLine($"You have withdrawn ${withdraw}\n\n" +
                                    $"your new balance is ${money}");
                                Console.WriteLine("Would you like to make another transaction? Y/N");
                                string a = Console.ReadLine().ToUpper();
                                if (a == "Y")
                                {
                                    repeat = true;
                                }
                                else if (a == "N")
                                    repeat = false;
                                else
                                {
                                    Console.WriteLine("Please enter a valid answer");
                                }
                                break;


                            case "3":
                                Console.Write("How much would you like to deposit? $");
                                string deposit = Console.ReadLine();
                                decimal dp = decimal.Parse(deposit);
                                money = money + dp;


                                Console.WriteLine($"You have deposited ${dp}." +
                                    $"Your new balance is ${money}");
                                Console.WriteLine("Would you like to make another transaction? Y/N");
                                string c = Console.ReadLine().ToUpper();

                                if (c == "Y")
                                {
                                    repeat = true;
                                }
                                else if (c == "N")
                                    repeat = false;
                                else
                                {
                                    Console.WriteLine("Please enter a valid answer");
                                }

                                break;

                            case "4":

                                
                                repeat = false;
                                break;
                        }


                    } while (repeat);

                    Console.WriteLine("Thank you for your business");
                }

            }
        }
     }
  }





