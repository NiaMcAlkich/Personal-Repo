using System;

namespace ConsoleApp4
{
    class Program
    {

        public static int getInt()
        {
            string input = "";
            int num = 0;
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            num = Convert.ToInt32(input);
            return num;
        }

        public static void printDirections()
        {
            Console.WriteLine("Hello! Welcome to the temp. converter!");
            Console.WriteLine("This program will convert a temperature from farenheight to celcius for you.");
            Console.WriteLine("Please start by typing a valid number; if you enter anything other than a number the program will crash.");
            Console.WriteLine("Then this program will do the math to convert it to celcius for you");
            Console.WriteLine("Enjoy and have fun!");
        }

        public static double convertFtoC(int f)
        {
            double resultC = 0.0;
            resultC = (f - 32) * 5.0 / 9.0;

            return resultC;
        }
        
        public static void printResults(int f, double c)
        {
            Console.WriteLine("Here's what you entered for farenheit, and here is that temp. in celcius");
            Console.WriteLine("f is " + f);
            Console.WriteLine("c is " + c);
        }

        public static void convertTemp()
        {
            int tempFar = 0;
            double tempCel = 0.0;
            printDirections();
            tempFar = getInt();
            tempCel = convertFtoC(tempFar);
            printResults(tempFar, tempCel);
        }
        static void Main(string[] args)
        {
            convertTemp();
        }
    }
}
