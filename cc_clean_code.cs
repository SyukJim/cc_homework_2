using System;

namespace cc_clean_code_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This code will compare two value and return the greater out of the two.
            Initiate variables*/
            char charX = 'X';
            char charY = 'Y';
            int x, y;


            //This function ask for the input from the user
            x = askForInput(charX);
            y = askForInput(charY);

            //This function compare the two value that was given by the user.
            compareInput(x, y);
   
        }

        static int askForInput(char alphabet)
        {

            String s;
            char alpha = alphabet;
            int value;

            Console.WriteLine("Please enter value for {0}: ", alpha);
            s = Console.ReadLine();

            value = convertToInt(s);
            return value;

            
        }

        static int convertToInt(String inputValue)
        {
            //This class convert from string to integer.

            String input = inputValue;
            int result = Convert.ToInt32(input);

            return result;
        
        }

        static void compareInput(int x, int y)
        {

            //This class compare the value that was given by the user.

            int inputX = x;
            int inputY = y;

            if (inputX > inputY)
            {

                Console.WriteLine("Larger value is X: {0}", inputX);

            }
            else if (inputY > inputX)
            {

                Console.WriteLine("Larger value is Y: {0}", inputY);

            }
            else if (inputX == inputY)
            {

                Console.WriteLine("They are equal, X: {0}, Y: {1}", inputX, inputY);

            }
        
        }
    }
}
