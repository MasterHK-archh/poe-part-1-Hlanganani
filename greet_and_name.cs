using System;
using System.Threading;

namespace greeting_and_prompting
{//start of namespace
    public class greet_and_name
    {//start of class

        //global variable
        private string username = string.Empty;

        // typing animation method
        private void TypeText(string message, int delay = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay); // delay in milliseconds
            }
            Console.WriteLine();
        }

        //void method to welcome the user
        public void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================");
            Console.ForegroundColor = ConsoleColor.White;
            TypeText("[Welcome to NANI_CYBERSECURITY CHATBOT ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================");

            Console.ResetColor();
        }

        // prompt the user for the username
        public void ask_name()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("NANI_CYBERSECURITY: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            TypeText("Hey, Enter your name.");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("User :");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();
                Console.ResetColor();

            } while (!isValidName());

        }

        // method to validate the username
        private Boolean isValidName()
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("NANI_CYBERSECURITY: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                TypeText("Please enter your name");
                Console.ResetColor();
                return false;
            }
            // check if the name contains only letters
            foreach (char c in username)
            {
                if (!char.IsLetter(c))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("NANI_CYBERSECURITY: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    TypeText("Name must contain letters only (no numbers or symbols)");
                    Console.ResetColor();
                    return false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("NANI_CYBERSECURITY: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            TypeText("Hey " + username);
            Console.ResetColor();

            return true;
        }

        public string GetUsername()
        {
            return username;
        }

    }//end of class
}//end of namespace