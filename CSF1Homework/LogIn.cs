using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class LogIn
    {
        static void Main()
        {
            bool isAdmin = false;
            int attempts = 1;
            string admin = "TAYLOR GRIFFIN";
            Console.Write("Enter you username: ");
            string userName = Console.ReadLine().ToUpper();

            //IF NOT USER
            //{
            //  Make sure its user - 3 times
            //}
            //else you are your user
            //proceed to passowrd time
            //do same thing



            if (userName != admin && attempts < 3)
            {
                do 
                {
                    Console.WriteLine("Incorrect Username");
                    Console.WriteLine("Try Again");
                    userName = Console.ReadLine().ToUpper();
                    attempts++;

                    if (!isAdmin && attempts == 3)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts.");
                        Console.WriteLine("Your access has been denied");
                    }
                } while (userName != admin && attempts<3) ;


                
            }

            if (userName == admin)
            {

                bool isPassword = false;
                string adminPassword = "ALFREDO";
                int tries = 1;
                Console.Write("Enter your password: ");
                string password = Console.ReadLine().ToUpper();

                while (password != adminPassword && tries < 3)
                {


                    Console.WriteLine("Incorrect Password");
                    Console.WriteLine("Try Again");
                    password = Console.ReadLine().ToUpper();
                    tries++;


                    if (!isPassword && tries == 3)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts.");
                        Console.WriteLine("Your access has been denied");
                    }





                }

                if (password == adminPassword)
                {
                    Console.WriteLine("Access Granted");

                }    





            }  
         } 

      







        
    }
}
