using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class LogIn
    {
        public void Main()
        {
            
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



            if (userName != admin)
            {
                do 
                {
                    Console.WriteLine("Incorrect Username");
                    Console.Write("Try Again: ");
                    userName = Console.ReadLine().ToUpper();
                    attempts++;

                    if (attempts == 3 && userName!= admin)
                    {
                        Console.WriteLine("You have exceeded the maximum number of attempts.");
                        Console.WriteLine("Your access has been denied");
                    }
                } while (userName != admin && attempts<3) ;


                
            }

            if (userName == admin)
            {

               
                string adminPassword = "ALFREDO";
                int tries = 1;
                Console.Write("Enter your password: ");
                string password = Console.ReadLine().ToUpper();

                while (password != adminPassword && tries < 4)
                {


                    Console.WriteLine("Incorrect Password");
                    Console.Write("Try Again: ");
                    password = Console.ReadLine().ToUpper();
                    tries++;


                    if (tries == 3 && password!=adminPassword)
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
