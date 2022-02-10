using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            //if (userValue == "1")
            //{
            //    //string message = "You won a new car!";
            //    //Console.WriteLine(message);
            //    message = "You won a new car!";
            //}
            //else if (userValue == "2")
            //{
            //    //string message = "You won a new boat!";
            //    //Console.WriteLine(message);
            //    message = "You won a new boat!";
            //}
            //else if (userValue == "3")
            //{
            //    //string message = "You won a new cat!";
            //    //Console.WriteLine(message);
            //    message = "You won a new cat!";
            //}
            //else
            //{
            //    //string message = "Sorry, we didn't understand.";
            //    //Console.WriteLine(message);
            //    message = "Sorry, we didn't understand. ";
            //    message = message + "You lose.";
            //}

            if (userValue == "1")
                message = "You won a new car!";
            else if (userValue == "2")
                message = "You won a new boat!";
            else if (userValue == "3")
                message = "You won a new cat!";
            else
            {
                message = "Sorry, we didn't understand. ";
                //message = message + "You lose.";
                message += "You lose.";
            }

            Console.WriteLine(message);
            //Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            //Console.WriteLine("You won a {0}.", message);

            Console.WriteLine("You entered: {0} therefor you won a {1}.",userValue, message);

            //Console.ReadLine();

        }
    }
}
