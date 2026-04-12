using System;
using System.Media;

namespace greeting_and_prompting
{//start of namespace
    public class greet_voice
    {//start of class
        //auto path
        string path = AppDomain.CurrentDomain.BaseDirectory;

        public greet_voice()
        {//start of constructor
         //call the voice method 
            voice();
        }//end of constructor

        //method to voice greet the user
        private void voice()
        {//start of method

            //get the full path replace of Debug\bin\
            string fullpath = path.Replace(@"bin\Debug\", "");

            //play the sound
            string joined_path = fullpath + "greet_voice.wav";

            //create an instance for the soundPlayer class
            SoundPlayer voice_play = new SoundPlayer(joined_path);

            //Load the audio
            voice_play.Load();

            //play till the end
            voice_play.PlaySync();
        }//end of method
    }//end of class
}//end of namespace
