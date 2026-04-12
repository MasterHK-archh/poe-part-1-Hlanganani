using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greeting_and_prompting
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for the greeting_voice class 
            //class with contructor 

            new greet_voice() { };

            

            //creating an instance for the class greet_and_name
            //with an object name greeting_and_name

            greet_and_name greeting_and_name = new greet_and_name();

            //calling the welcome method
            greeting_and_name.welcome();

            //calling the ask_name method
            greeting_and_name.ask_name();


            string name = greeting_and_name.GetUsername();
            //create an instance for ai response
            AwareBot bot = new AwareBot();

            //calling the ai_chat method
            bot.ai_chat(name);




        }//end of main method
    }//end of class
}//end of namespace
