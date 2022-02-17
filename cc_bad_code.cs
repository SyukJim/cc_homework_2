using System;

namespace cc_bad_code_assignmnet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            int x, y;
            //this code will compare two value and show the greater one.
            Console.WriteLine("Please Enter for value for X: ");
            s = Console.ReadLine();
            x = Convert.ToInt32(s);

            Console.WriteLine("Please Enter for value for Y: ");
            s = Console.ReadLine();
            y = Convert.ToInt32(s);

            int greaterValue = checkGreaterValue(x, y);

            Console.WriteLine(greaterValue);
        }

        static int checkGreaterValue(int userX, int userY)
        {

            int x = userX;
            int y = userY;

            if (x > y)
                return x;
            else
                return y;

        
        }
    }
}
