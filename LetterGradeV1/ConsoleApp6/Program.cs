using System;

namespace ConsoleApp6
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("Hello and welcome to LetterGradeV1!  Please input the number grade that you would like converted to a letter grade.");
            Console.WriteLine("From there let the program do the rest!");
            Console.WriteLine("Here is a rubric for the grading scale:");
            Console.WriteLine("90-100=A");
            Console.WriteLine("80-89=B");
            Console.WriteLine("70-79=C");
            Console.WriteLine("60-69=D");
            Console.WriteLine("60 or below=F");

        }

        public static int getInt()
        {
            int numberGrade = 0; 
            string input = "";
            Console.WriteLine("Please enter an integer between 0-100: ");
            input = Console.ReadLine();
            numberGrade = Convert.ToInt32(input);
            return numberGrade;
        }

        public static char calculateChar(int numericalGrade)
        {
            char letterGrade = 'E';
            if ( (numericalGrade <= 100) &&  (numericalGrade >= 90) )
            {
                letterGrade = 'A';
            }

            else if ((numericalGrade<=90)  && (numericalGrade>=89))
            {
                letterGrade = 'B';
            }

            else if ((numericalGrade<=89) && (numericalGrade>=70))
            {
                letterGrade = 'C';
            }

            else if ((numericalGrade<=70) && (numericalGrade>=69))
            {
                letterGrade = 'D';
            }

            else
            {
                letterGrade = 'F';
            }

            return letterGrade;
        }

        public static void printResults(int num, char let)
            {
              Console.WriteLine("Here is the numerical grade you entered " + num);
              Console.WriteLine("Here is the letter grade that corresponds to that numerical value " + let);
            }

        

          

        public static void LettergradeV1()
        {
            int numGrade = 0;
            char letGrade = 'E';

            printDirections();
            numGrade = getInt();
            letGrade = calculateChar(numGrade);
            printResults(numGrade, letGrade);
        }
        static void Main(string[] args)
        {
            LettergradeV1();
        }
    }
}
