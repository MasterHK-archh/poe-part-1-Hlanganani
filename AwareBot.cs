using System;
using System.Collections;
using System.Drawing.Imaging;

namespace greeting_and_prompting
{// start of namespace
    public class AwareBot
    {//start of class

        //array 
        ArrayList reply = new ArrayList();
        ArrayList ignoring = new ArrayList();

        public void ai_chat(string name)
        {
            //add replies
            Console.ForegroundColor = ConsoleColor.White;
            reply.Add("The password must be at least 8 characters long.");
            reply.Add("phishing is when someone tries to trick you into giving them sensitive information");
            reply.Add("it is important to use safe websites");
            reply.Add("Protect your informmation");
            reply.Add("Avoid suspicious links");

            //add some ignoring words to the array list.
            Console.ForegroundColor = ConsoleColor.Blue;
            ignoring.Add("What");
            ignoring.Add("This");
            ignoring.Add("is");
            ignoring.Add("about");
            ignoring.Add("do");

            string asking = string.Empty;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("NANI_CYBERSECURITY: " + "Hey " + name + ", How can I assist you today?");
            Console.WriteLine("AwarenessBot:Type 'exit' to stop.\n");

            //DO WHILE LOOP
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(name + ": ");
                asking = Console.ReadLine().ToLower();

            } while (end_chat(asking, name));
        }

        //Now also recive the user input and check if it contains any of the ignoring words
        private Boolean end_chat(string asking, string name)
        {
            //Handle empty input
            if (string.IsNullOrWhiteSpace(asking))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("AwarenessBot: " + name + ", Please enter a valid message or 'exit' to leave");
                return true;
            }
            //Exit chat
            if (asking == "exit")
            {
                Console.WriteLine("AwarenessBot: Goodbye " + name + "! Stay safe online.");
                return false; // End the chat
            }
            else
            {
                string[] find_words = asking.Split(' ');

                bool found = false; 

                foreach (string word in find_words)
                {
                    //Skip ingnored words
                    if (ignoring.Contains(word))
                        continue;

                    foreach (string find_reply in reply)
                    {
                        if (find_reply.ToLower().Contains(word))
                        {
                            //Personalised resply based on the user's input
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("AwarenessBot:" + name + "," + find_reply);

                            found = true;
                            break; //This breaks the inner loop
                        }
                    }
                    if (found)
                        break; //break the outer loop if a reply was found
                }
                //Default response if no reply was found
                if (!found)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("AwarenessBot: Sorry, I don't understand that. Can you please rephrase?");
                }
                return true;
            }//end of else statement
        }//end of method



    }//end of class
}//end of namespace