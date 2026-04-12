using System;
using System.Drawing;
using System.Security.Policy;

namespace greeting_and_prompting
{//start of namespace
    public class logo
    {//start of class

        //get the path of where the project is and logo
        string path_logo = AppDomain.CurrentDomain.BaseDirectory;



        //constructor
        public logo()
        {//start of constructor


            //calling the ascii method
            asci();


        }//end of contructor

        //ascii method

        private void asci()
        {
            //replace bin and debug -> bin\Debug
            string full_path = path_logo.Replace(@"\bin\Debug\", @"\logo.png");
            Console.WriteLine(full_path);


            //path of the logo [ where the logo is ]
            string path = full_path;

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 150;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#$%&?!+=-:,.'`";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }
    }//end of class
}//end of namespace